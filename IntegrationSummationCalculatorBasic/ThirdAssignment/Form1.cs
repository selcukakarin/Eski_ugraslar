using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        public double IntegrationMethod(double firstx, double secondx, double thirdx, double startvalue, double finishvalue, int checkvalue, int h)
        {
            if (checkvalue == 1)
            {
                double xtemp, a, b;
                double integration = 0;
                double g = (finishvalue - startvalue) / h;

                for (int i = 0; i < h; i++)
                {
                    xtemp = startvalue + g;
                    a = (firstx * Math.Pow(xtemp, 2)) + (secondx * xtemp) + thirdx;
                    b = g * a;
                    integration += b;
                }
                return integration;

            }
            else if (checkvalue == 2)
            {
                double xp, y, s;
                double integration = 0;
                double g = (finishvalue - startvalue) / h;

                for (int i = 0; i < h; i++)
                {
                    xp = startvalue + g;
                    y = (firstx * Math.Pow(xp, 2)) + (secondx * xp) - thirdx;
                    s = g * y;
                    integration += s;
                }
                return integration;
            }
            else if (checkvalue == 3)
            {
                double xp, y, s;
                double integration = 0;
                double g = (finishvalue - startvalue) / h;

                for (int i = 0; i < h; i++)
                {
                    xp = startvalue + g;
                    y = (firstx * Math.Pow(xp, 2)) - (secondx * xp) + thirdx;
                    s = g * y;
                    integration += s;
                }
                return integration;
            }
            else if (checkvalue == 4)
            {
                double xp, y, s;
                double integration = 0;
                double g = (finishvalue - startvalue) / h;

                for (int i = 0; i < h; i++)
                {
                    xp = startvalue + g;
                    y = (firstx * Math.Pow(xp, 2)) - (secondx * xp) - thirdx;
                    s = g * y;
                    integration += s;
                }
                return integration;
            }
            return 0;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double firstx, secondx, thirdx, startcalue, finishvalue;
            int h;


            firstx = Convert.ToDouble(txtx1.Text);
            secondx = Convert.ToDouble(txtx2.Text);
            thirdx = Convert.ToDouble(txtx3.Text);
            startcalue = Convert.ToDouble(txtx4.Text);
            finishvalue = Convert.ToDouble(txtx5.Text);
            h = Convert.ToInt32(txtx6.Text);

            if (chck1.Checked == true && chck2.Checked == true)
            {
                double integrationResult = IntegrationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 1, h);
                int queue = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue].Cells[0].Value = integrationResult.ToString();

                double sumResult = SummationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 1);
                mydatagrid.Rows[queue].Cells[1].Value = sumResult.ToString();

            }

            else if (chck1.Checked == false && chck2.Checked == true)
            {
                double integrationResult = IntegrationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 2, h);
                int queue = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue].Cells[0].Value = integrationResult.ToString();

                double sumResult = SummationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 2);
                mydatagrid.Rows[queue].Cells[1].Value = sumResult.ToString();


            }

            else if (chck1.Checked == true && chck2.Checked == false)
            {
                double integrationResult = IntegrationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 3, h);
                int queue = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue].Cells[0].Value = integrationResult.ToString();

                double sumResult = SummationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 3);
                mydatagrid.Rows[queue].Cells[1].Value = sumResult.ToString();


            }

            else if (chck1.Checked == false && chck2.Checked == false)
            {
                double integrationResult = IntegrationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 4, h);
                int queue = mydatagrid.Rows.Add();
                mydatagrid.Rows[queue].Cells[0].Value = integrationResult.ToString();

                double sumResult = SummationMethod(firstx, secondx, thirdx, startcalue, finishvalue, 4);
                mydatagrid.Rows[queue].Cells[1].Value = sumResult.ToString();


            }
            DataSet dtSet = new DataSet("Our calculations");
            DataTable dtTable = new DataTable("Calculations of Result");
            dtTable.Columns.Add("Integration of Result");
            dtTable.Columns.Add("Summation of Result");
            dtSet.Tables.Add(dtTable);
            foreach (DataGridViewRow myrow in mydatagrid.Rows)
            {
                DataRow row = dtSet.Tables["Calculations of Result"].NewRow();
                row["Integration of Result"] = myrow.Cells[0].Value.ToString();

                row["Summation of Result"] = myrow.Cells[1].Value.ToString();
                dtSet.Tables["Calculations of Result"].Rows.Add(row);
            }
        }
    }
}
