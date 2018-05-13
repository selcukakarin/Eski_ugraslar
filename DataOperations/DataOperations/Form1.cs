using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DataOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            writeToFile(text);
        }

        private static void writeToFile(string x)
        {
            string dosya_yolu = "textfile.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(x);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("textfile.txt");
            textBox1.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxID.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxFirstName.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxLastName.Text;
            textBoxID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();

        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("CustomerInformation");
            DataTable dt = new DataTable("CustomerDetail");
            dt.Columns.Add("ID");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            ds.Tables.Add(dt);


            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["CustomerDetail"].NewRow();
                row["ID"] = r.Cells[0].Value.ToString();
                row["FirstName"] = r.Cells[1].Value.ToString();
                row["LastName"] = r.Cells[2].Value.ToString();
                ds.Tables["CustomerDetail"].Rows.Add(row);
            }
            ds.WriteXml("Veri1.xml");
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            string DosyaYolu = "Veri1" + ".xml";
            if (System.IO.File.Exists(DosyaYolu))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Veri1.xml");

                foreach (DataRow item in ds.Tables["CustomerDetail"].Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                }
            }
            else
            {
                MessageBox.Show("Veri1.XML Bulunamadı.XML Dosyasını Oluşturun.");
                
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = textBoxID.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = textBoxFirstName.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = textBoxLastName.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

    }
}
