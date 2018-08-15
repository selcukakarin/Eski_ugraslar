using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double DerivationMethod(double firstx, double secondx, double thirdx, double startvalue, double finishvalue, int checkvalue)
        {
            if (checkvalue == 1)
            {
                return (2 * firstx * finishvalue + secondx) ;
            }
            else if (checkvalue == 2)
            {
                return (2 * firstx * finishvalue - secondx) ;
            }
            else if (checkvalue == 3)
            {
                return (2 * firstx * finishvalue + secondx);
            }

            else
            {
                return (2 * firstx * finishvalue - secondx);
            }
        }

        public double MultiplicationMethod(double firstx, double secondx, double thirdx, double startvalue, double finishvalue, int checkvalue)
        {
            double multiplication = 1;
            if (checkvalue == 1)
            {
                while (startvalue <= finishvalue)
                {
                    multiplication *= (firstx * startvalue * startvalue + secondx * startvalue + thirdx);
                    startvalue++;
                }
                return multiplication;
            }
            else if (checkvalue == 2)
            {
                while (startvalue <= finishvalue)
                {
                    multiplication *= (firstx * startvalue * startvalue - secondx * startvalue + thirdx);
                    startvalue++;
                }
                return multiplication;
            }
            else if (checkvalue == 3)
            {
                while (startvalue <= finishvalue)
                {
                    multiplication *= (firstx * startvalue * startvalue + secondx * startvalue - thirdx);
                    startvalue++;
                }
                return multiplication;
            }
            else if (checkvalue == 4)
            {
                while (startvalue <= finishvalue)
                {
                    multiplication *= (firstx * startvalue * startvalue - secondx * startvalue - thirdx);
                    startvalue++;
                }
                return multiplication;
            }
            return multiplication;

        }
        public double SummationMethod(double firstx, double secondx, double thirdx, double startvalue, double finishvalue, int checkvalue)
        {
            double sum = 0;
            if (checkvalue == 1)
            {
                while (startvalue <= finishvalue)
                {
                    sum += (firstx * startvalue * startvalue + secondx * startvalue + thirdx);
                    startvalue++;
                }
                return sum;
            }
            else if (checkvalue == 2)
            {
                while (startvalue <= finishvalue)
                {
                    sum += (firstx * startvalue * startvalue - secondx * startvalue + thirdx);
                    startvalue++;
                }
                return sum;
            }
            else if (checkvalue == 3)
            {
                while (startvalue <= finishvalue)
                {
                    sum += (firstx * startvalue * startvalue + secondx * startvalue - thirdx);
                    startvalue++;
                }
                return sum;
            }
            else if (checkvalue == 4)
            {
                while (startvalue <= finishvalue)
                {
                    sum += (firstx * startvalue * startvalue - secondx * startvalue - thirdx);
                    startvalue++;
                }
                return sum;
            }
            return sum;

        }

        public double IntegrationMethod(double firstx, double secondx, double thirdx, double startvalue, double finishvalue, int checkvalue)
        {
            if (checkvalue == 1)
            {
                return ((firstx * finishvalue * finishvalue * finishvalue) / 3 + (secondx * finishvalue * finishvalue) / 2 + thirdx * finishvalue) - ((firstx * startvalue * startvalue * startvalue) / 3 + (secondx * startvalue * startvalue) / 2 + thirdx * startvalue);
            }
            else if (checkvalue == 2)
            {
                return ((firstx * finishvalue * finishvalue * finishvalue) / 3 - (secondx * finishvalue * finishvalue) / 2 + thirdx * finishvalue) - ((firstx * startvalue * startvalue * startvalue) / 3 - (secondx * startvalue * startvalue) / 2 + thirdx * startvalue);
            }
            else if (checkvalue == 3)
            {
                return ((firstx * finishvalue * finishvalue * finishvalue) / 3 + (secondx * finishvalue * finishvalue) / 2 - thirdx * finishvalue) - ((firstx * startvalue * startvalue * startvalue) / 3 + (secondx * startvalue * startvalue) / 2 - thirdx * startvalue);
            }

            else
            {
                return ((firstx * finishvalue * finishvalue * finishvalue) / 3 - (secondx * finishvalue * finishvalue) / 2 - thirdx * finishvalue) - ((firstx * startvalue * startvalue * startvalue) / 3 - (secondx * startvalue * startvalue) / 2 - thirdx * startvalue);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstxder, secondxder, thirdxder, startvalueder, finishvalueder;
            firstxder = Convert.ToDouble(numericUpDown1.Text);
            secondxder = Convert.ToDouble(numericUpDown2.Text);
            thirdxder = Convert.ToDouble(numericUpDown3.Text);
            startvalueder = Convert.ToDouble(numericUpDown4.Text);
            finishvalueder = Convert.ToDouble(numericUpDown5.Text);


            if (chck1.Checked == true && chck2.Checked == true)
            {
                double derivationResult = DerivationMethod(firstxder, secondxder, thirdxder, startvalueder, finishvalueder, 1);
                int queue1 = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue1].Cells[0].Value = derivationResult.ToString();
            }

            else if (chck1.Checked == false && chck2.Checked == true)
            {
                double derivationResult = DerivationMethod(firstxder, secondxder, thirdxder, startvalueder, finishvalueder, 2);
                int queue = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue].Cells[0].Value = derivationResult.ToString();

            }

            else if (chck1.Checked == true && chck2.Checked == false)
            {
                double derivationResult = DerivationMethod(firstxder, secondxder, thirdxder, startvalueder, finishvalueder, 3);
                int queue = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue].Cells[0].Value = derivationResult.ToString();


            }

            else if (chck1.Checked == false && chck2.Checked == false)
            {
                double derivationResult = DerivationMethod(firstxder, secondxder, thirdxder, startvalueder, finishvalueder, 4);
                int queue = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue].Cells[0].Value = derivationResult.ToString();

            }

            DataSet dtSet = new DataSet("Derivation");
            DataTable dtTable = new DataTable("Derivation of Result");
            dtTable.Columns.Add("DerivationResult");
            dtSet.Tables.Add(dtTable);
            foreach (DataGridViewRow myrow in mydatagrid.Rows)
            {
                DataRow row = dtSet.Tables["Derivation of Result"].NewRow();
                row["DerivationResult"] = myrow.Cells[0].Value.ToString();
                dtSet.Tables["Derivation of Result"].Rows.Add(row);
            }
            dtSet.WriteXml("derivation.xml");
            this.mydatagrid.Rows.Clear();
            string FilePath = "derivation" + ".xml";
            if (System.IO.File.Exists(FilePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("derivation.xml");

                foreach (DataRow item in ds.Tables["Derivation of Result"].Rows)
                {
                    int n = mydatagrid.Rows.Add();
                    mydatagrid.Rows[n].Cells[0].Value = item[0].ToString();
                }
            }
            else
            {
                MessageBox.Show("derivation.xml Not found");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstxmul, secondxmul, thirdxmul, startvaluemul, finishvaluemul;

            firstxmul = Convert.ToDouble(numericUpDown10.Text);
            secondxmul = Convert.ToDouble(numericUpDown9.Text);
            thirdxmul = Convert.ToDouble(numericUpDown8.Text);
            startvaluemul = Convert.ToDouble(numericUpDown7.Text);
            finishvaluemul = Convert.ToDouble(numericUpDown6.Text);
            if (chck1.Checked == true && chck2.Checked == true)
            {
                
                int queue4 = mydatagrid2.Rows.Add();
                double multiplicationResult = MultiplicationMethod(firstxmul, secondxmul, thirdxmul, startvaluemul, finishvaluemul, 1);
                mydatagrid2.Rows[queue4].Cells[0].Value = multiplicationResult.ToString();

            }

            else if (chck1.Checked == false && chck2.Checked == true)
            {
                int queue4 = mydatagrid2.Rows.Add();
                double multiplicationResult = MultiplicationMethod(firstxmul, secondxmul, thirdxmul, startvaluemul, finishvaluemul, 1);
                mydatagrid2.Rows[queue4].Cells[0].Value = multiplicationResult.ToString();

            }

            else if (chck1.Checked == true && chck2.Checked == false)
            {
                int queue4 = mydatagrid2.Rows.Add();
                double multiplicationResult = MultiplicationMethod(firstxmul, secondxmul, thirdxmul, startvaluemul, finishvaluemul, 1);
                mydatagrid2.Rows[queue4].Cells[0].Value = multiplicationResult.ToString();
            }

            else if (chck1.Checked == false && chck2.Checked == false)
            {
                int queue4 = mydatagrid2.Rows.Add();
                double multiplicationResult =MultiplicationMethod(firstxmul, secondxmul, thirdxmul, startvaluemul, finishvaluemul, 1);
                mydatagrid2.Rows[queue4].Cells[0].Value = multiplicationResult.ToString();
            }
            DataSet dtSet2 = new DataSet("Multiplication");
            DataTable dtTable2 = new DataTable("Multiplication of Result");
            dtTable2.Columns.Add("MultiplicationResult");
            dtSet2.Tables.Add(dtTable2);
            foreach (DataGridViewRow myrow in mydatagrid2.Rows)
            {
                DataRow row = dtSet2.Tables["Multiplication of Result"].NewRow();
                row["MultiplicationResult"] = myrow.Cells[0].Value.ToString();
                dtSet2.Tables["Multiplication of Result"].Rows.Add(row);
            }
            dtSet2.WriteXml("Multiplication.xml");
            this.mydatagrid2.Rows.Clear();
            string FilePath = "Multiplication.xml";
            if (System.IO.File.Exists(FilePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Multiplication.xml");

                foreach (DataRow item in ds.Tables["Multiplication of Result"].Rows)
                {
                    int n = mydatagrid2.Rows.Add();
                    mydatagrid2.Rows[n].Cells[0].Value = item[0].ToString();
                }
            }
            else
            {
                MessageBox.Show("Multiplication.xml Not found");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstxsum, secondxsum, thirdxsum, startvaluesum, finishvaluesum;
            firstxsum = Convert.ToDouble(numericUpDown15.Text);
            secondxsum = Convert.ToDouble(numericUpDown14.Text);
            thirdxsum = Convert.ToDouble(numericUpDown13.Text);
            startvaluesum = Convert.ToDouble(numericUpDown12.Text);
            finishvaluesum = Convert.ToDouble(numericUpDown11.Text);


            if (chck1.Checked == true && chck2.Checked == true)
            {
                double summationResult = SummationMethod(firstxsum, secondxsum, thirdxsum, startvaluesum, finishvaluesum, 1);
                int queue1 = mydatagrid3.Rows.Add();
                mydatagrid3.Rows[queue1].Cells[0].Value = summationResult.ToString();
            }

            else if (chck1.Checked == false && chck2.Checked == true)
            {
                double summationResult = SummationMethod(firstxsum, secondxsum, thirdxsum, startvaluesum, finishvaluesum, 2);
                int queue = mydatagrid3.Rows.Add();
                mydatagrid3.Rows[queue].Cells[0].Value = summationResult.ToString();

            }

            else if (chck1.Checked == true && chck2.Checked == false)
            {
                double summationResult = SummationMethod(firstxsum, secondxsum, thirdxsum, startvaluesum, finishvaluesum, 3);
                int queue = mydatagrid3.Rows.Add();
                mydatagrid3.Rows[queue].Cells[0].Value = summationResult.ToString();


            }

            else if (chck1.Checked == false && chck2.Checked == false)
            {
                double summationResult = SummationMethod(firstxsum, secondxsum, thirdxsum, startvaluesum, finishvaluesum, 4);
                int queue = mydatagrid3.Rows.Add();
                mydatagrid3.Rows[queue].Cells[0].Value = summationResult.ToString();

            }
            DataSet dtSet3 = new DataSet("Summation");
            DataTable dtTable3 = new DataTable("Summation of Result");
            dtTable3.Columns.Add("SummationResult");
            dtSet3.Tables.Add(dtTable3);
            foreach (DataGridViewRow myrow in mydatagrid3.Rows)
            {
                DataRow row = dtSet3.Tables["Summation of Result"].NewRow();
                row["SummationResult"] = myrow.Cells[0].Value.ToString();
                dtSet3.Tables["Summation of Result"].Rows.Add(row);
            }
            dtSet3.WriteXml("Summation.xml");
            this.mydatagrid3.Rows.Clear();
            string FilePath = "Summation.xml";
            if (System.IO.File.Exists(FilePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Summation.xml");

                foreach (DataRow item in ds.Tables["Summation of Result"].Rows)
                {
                    int n = mydatagrid3.Rows.Add();
                    mydatagrid3.Rows[n].Cells[0].Value = item[0].ToString();
                }
            }
            else
            {
                MessageBox.Show("Summation.xml Not found");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstxint, secondxint, thirdxint, startvalueint, finishvalueint;
           
            firstxint = Convert.ToDouble(numericUpDown20.Text);
            secondxint = Convert.ToDouble(numericUpDown19.Text);
            thirdxint = Convert.ToDouble(numericUpDown18.Text);
            startvalueint = Convert.ToDouble(numericUpDown17.Text);
            finishvalueint = Convert.ToDouble(numericUpDown16.Text);

            if (chck1.Checked == true && chck2.Checked == true)
            {
                double integrationResult = IntegrationMethod(firstxint, secondxint, thirdxint, startvalueint, finishvalueint, 1);
                int queue1 =dataGridView4.Rows.Add();
                dataGridView4.Rows[queue1].Cells[0].Value = integrationResult.ToString();
            }

            else if (chck1.Checked == false && chck2.Checked == true)
            {
                double integrationResult = IntegrationMethod(firstxint, secondxint, thirdxint, startvalueint, finishvalueint, 2);
                int queue = dataGridView4.Rows.Add();
                dataGridView4.Rows[queue].Cells[0].Value = integrationResult.ToString();

            }

            else if (chck1.Checked == true && chck2.Checked == false)
            {
                double integrationResult = IntegrationMethod(firstxint, secondxint, thirdxint, startvalueint, finishvalueint, 3);
                int queue = dataGridView4.Rows.Add();
                dataGridView4.Rows[queue].Cells[0].Value = integrationResult.ToString();


            }

            else if (chck1.Checked == false && chck2.Checked == false)
            {
                double integrationResult = IntegrationMethod(firstxint, secondxint, thirdxint, startvalueint, finishvalueint, 4);
                int queue = dataGridView4.Rows.Add();
                dataGridView4.Rows[queue].Cells[0].Value = integrationResult.ToString();

            }
            DataSet dtSet4 = new DataSet("Integration");
            DataTable dtTable4 = new DataTable("Integration of Result");
            dtTable4.Columns.Add("IntegrationResult");
            dtSet4.Tables.Add(dtTable4);
            foreach (DataGridViewRow myrow in dataGridView4.Rows)
            {
                DataRow row = dtSet4.Tables["Integration of Result"].NewRow();
                row["IntegrationResult"] = myrow.Cells[0].Value.ToString();
                dtSet4.Tables["Integration of Result"].Rows.Add(row);
            }
            dtSet4.WriteXml("Integration.xml");
            this.dataGridView4.Rows.Clear();
            string FilePath = "Integration.xml";
            if (System.IO.File.Exists(FilePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Integration.xml");

                foreach (DataRow item in ds.Tables["Integration of Result"].Rows)
                {
                    int n = dataGridView4.Rows.Add();
                    dataGridView4.Rows[n].Cells[0].Value = item[0].ToString();
                }
            }
            else
            {
                MessageBox.Show("Integration.xml Not found");

            }
        }
    }
}
