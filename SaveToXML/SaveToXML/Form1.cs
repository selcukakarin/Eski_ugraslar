using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveToXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = dgRegistiration.Rows.Add();
            dgRegistiration.Rows[count].Cells[0].Value = txtStudentNumber.Text;
            dgRegistiration.Rows[count].Cells[1].Value = txtDormID.Text;
            dgRegistiration.Rows[count].Cells[2].Value = txtFirstName.Text;
            dgRegistiration.Rows[count].Cells[3].Value = txtLastName.Text;
            dgRegistiration.Rows[count].Cells[4].Value = txtDormRoom.Text;
            dgRegistiration.Rows[count].Cells[5].Value = txtTel.Text;
            dgRegistiration.Rows[count].Cells[6].Value = txtMail.Text;
            dgRegistiration.Rows[count].Cells[7].Value = txtAge.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgRegistiration.Rows.RemoveAt(dgRegistiration.SelectedRows[0].Index);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgRegistiration.SelectedRows[0].Cells[0].Value = txtStudentNumber.Text;
            dgRegistiration.SelectedRows[0].Cells[1].Value = txtDormID.Text;
            dgRegistiration.SelectedRows[0].Cells[2].Value = txtFirstName.Text;
            dgRegistiration.SelectedRows[0].Cells[3].Value = txtLastName.Text;
            dgRegistiration.SelectedRows[0].Cells[4].Value = txtDormRoom.Text;
            dgRegistiration.SelectedRows[0].Cells[5].Value = txtTel.Text;
            dgRegistiration.SelectedRows[0].Cells[6].Value = txtMail.Text;
            dgRegistiration.SelectedRows[0].Cells[7].Value = txtAge.Text;
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet("DormRegistiration");
            DataTable datatable = new DataTable("StudentInformations");
            datatable.Columns.Add("StudentNumber");
            datatable.Columns.Add("DormID");
            datatable.Columns.Add("FirstName");
            datatable.Columns.Add("LastName");
            datatable.Columns.Add("Dorm Room");
            datatable.Columns.Add("Tel");
            datatable.Columns.Add("Mail");
            datatable.Columns.Add("Age");
            dataset.Tables.Add(datatable);


            foreach (DataGridViewRow item in dgRegistiration.Rows)
            {
                DataRow row = dataset.Tables["StudentInformations"].NewRow();
                row["StudentNumber"] = item.Cells[0].Value.ToString();
                row["DormID"] = item.Cells[1].Value.ToString();
                row["FirstName"] = item.Cells[2].Value.ToString();
                row["LastName"] = item.Cells[3].Value.ToString();
                row["Dorm Room"] = item.Cells[4].Value.ToString();
                row["Tel"] = item.Cells[5].Value.ToString();
                row["Mail"] = item.Cells[6].Value.ToString();
                row["Age"] = item.Cells[7].Value.ToString();
                dataset.Tables["StudentInformations"].Rows.Add(row);
            }
            dataset.WriteXml("StudentInfo.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnGetTheInformations_Click(object sender, EventArgs e)
        {
            this.dgRegistiration.Rows.Clear();
            string path = "StudentInfo.xml";
            if (System.IO.File.Exists(path))
            {
                DataSet dataset = new DataSet();
                dataset.ReadXml("StudentInfo.xml");

                foreach (DataRow item in dataset.Tables["StudentInformations"].Rows)
                {
                    int count = dgRegistiration.Rows.Add();
                    dgRegistiration.Rows[count].Cells[0].Value = item[0].ToString();
                    dgRegistiration.Rows[count].Cells[1].Value = item[1].ToString();
                    dgRegistiration.Rows[count].Cells[2].Value = item[2].ToString();
                    dgRegistiration.Rows[count].Cells[3].Value = item[3].ToString();
                    dgRegistiration.Rows[count].Cells[4].Value = item[4].ToString();
                    dgRegistiration.Rows[count].Cells[5].Value = item[5].ToString();
                    dgRegistiration.Rows[count].Cells[6].Value = item[6].ToString();
                    dgRegistiration.Rows[count].Cells[7].Value = item[7].ToString();
                }
            }
            else
            {
                MessageBox.Show("StudentInfo.XML Not found");

            }
        }

        private void dgRegistiration_MouseClick(object sender, MouseEventArgs e)
        {
            txtStudentNumber.Text = dgRegistiration.SelectedRows[0].Cells[0].Value.ToString();
            txtDormID.Text = dgRegistiration.SelectedRows[0].Cells[1].Value.ToString();
            txtFirstName.Text = dgRegistiration.SelectedRows[0].Cells[2].Value.ToString();
            txtLastName.Text = dgRegistiration.SelectedRows[0].Cells[3].Value.ToString();
            txtDormRoom.Text = dgRegistiration.SelectedRows[0].Cells[4].Value.ToString();
            txtTel.Text = dgRegistiration.SelectedRows[0].Cells[5].Value.ToString();
            txtMail.Text = dgRegistiration.SelectedRows[0].Cells[6].Value.ToString();
            txtAge.Text = dgRegistiration.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
