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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtID.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtLicensePlate.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtFirstName.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtLastName.Text;
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtLicensePlate.Clear();

        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("RentACar");
            DataTable dt = new DataTable("RentDetail");
            dt.Columns.Add("ID");
            dt.Columns.Add("LicensePlate");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            ds.Tables.Add(dt);


            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["RentDetail"].NewRow();
                row["ID"] = r.Cells[0].Value.ToString();
                row["LicensePlate"] = r.Cells[1].Value.ToString();
                row["FirstName"] = r.Cells[2].Value.ToString();
                row["LastName"] = r.Cells[3].Value.ToString();
                ds.Tables["RentDetail"].Rows.Add(row);
            }
            ds.WriteXml("Veri.xml");
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            string FilePath = "Veri" + ".xml";
            if (System.IO.File.Exists(FilePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Veri.xml");

                foreach (DataRow item in ds.Tables["RentDetail"].Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                }
            }
            else
            {
                MessageBox.Show("Veri.XML Not found.Create the xml file.");
                
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtLicensePlate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtLastName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = txtID.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = txtLicensePlate.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = txtFirstName.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = txtLastName.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
