using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummationIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Integration(double a, double b, double c, double xa, double xb)
        {
            return ((a * xb * xb * xb) / 3 + (b * xb * xb) / 2 + c * xb) - ((a * xa * xa * xa) / 3 + (b * xa * xa) / 2 + c * xa);
        }
        public double Integration(double a, double b, double c, double xa, double xb, Boolean o)
        {
            return ((a * xb * xb * xb) / 3 - (b * xb * xb) / 2 + c * xb) - ((a * xa * xa * xa) / 3 - (b * xa * xa) / 2 + c * xa);
        }
        public double Integration(double a, double b, double c, double xa, double xb, Boolean o, Boolean u)
        {
            return ((a * xb * xb * xb) / 3 + (b * xb * xb) / 2 - c * xb) - ((a * xa * xa * xa) / 3 + (b * xa * xa) / 2 - c * xa);
        }
        public double Integration(double a, double b, double c, double xa, double xb, Boolean o, Boolean u, Boolean k)
        {
            return ((a * xb * xb * xb) / 3 - (b * xb * xb) / 2 - c * xb) - ((a * xa * xa * xa) / 3 - (b * xa * xa) / 2 - c * xa);
        }
        public double Summation(double a, double b, double c, double xa, double xb)
        {
            double result = 0;
            for (; xa <= xb; xa++)
            {
                result += (a * xa * xa + b * xa + c);
            }
            return result;
        }
        public double Summation(double a, double b, double c, double xa, double xb, Boolean o)
        {
            double result = 0;
            for (; xa <= xb; xa++)
            {
                result += (a * xa * xa - b * xb + c);
            }
            return result;
        }
        public double Summation(double a, double b, double c, double xa, double xb, Boolean o, Boolean u)
        {
            double result = 0;
            for (; xa <= xb; xa++)
            {
                result += (a * xa * xa + b * xa - c);
            }
            return result;
        }
        public double Summation(double a, double b, double c, double xa, double xb, Boolean o, Boolean u, Boolean k)
        {
            double result = 0;
            for (; xa <= xb; xa++)
            {
                result += (a * xa * xa - b * xa - c);
            }
            return result;
        }
        public double Multiplication(double a, double b, double c, double xa, double xb)
        {
            double result = 1;
            for (; xa <= xb; xa++)
            {
                result *= (a * xa * xa + b * xa + c);
            }
            return result;
        }
        public double Multiplication(double a, double b, double c, double xa, double xb, Boolean o)
        {
            double result = 1;
            for (; xa <= xb; xa++)
            {
                result *= (a * xa * xa - b * xa + c);
            }
            return result;
        }
        public double Multiplication(double a, double b, double c, double xa, double xb, Boolean o, Boolean u)
        {
            double result = 1;
            for (; xa <= xb; xa++)
            {
                result *= (a * xa * xa + b * xa - c);
            }
            return result;
        }
        public double Multiplication(double a, double b, double c, double xa, double xb, Boolean o, Boolean u, Boolean k)
        {
            double result = 1;
            for (; xa <= xb; xa++)
            {
                result *= (a * xa * xa - b * xb - c);
            }
            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            double a, b, c, xa, xb;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            xa = Convert.ToDouble(textBox4.Text);
            xb = Convert.ToDouble(textBox5.Text);
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                double result = Integration(a, b, c, xa, xb);
                label6.Text = result.ToString();
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = result.ToString();
                double resultSum = Summation(a, b, c, xa, xb);
                label7.Text = resultSum.ToString();
                dataGridView1.Rows[n].Cells[1].Value = resultSum.ToString();
                double resultMultiplication = Multiplication(a, b, c, xa, xb);
                label9.Text = resultMultiplication.ToString();
                dataGridView1.Rows[n].Cells[2].Value = resultMultiplication.ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                double result = Integration(a, b, c, xa, xb,true);
                label6.Text = result.ToString();
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = result.ToString();
                double resultSum = Summation(a, b, c, xa, xb, true);
                label7.Text = resultSum.ToString();
                dataGridView1.Rows[n].Cells[1].Value = resultSum.ToString();
                double resultMultiplication = Multiplication(a, b, c, xa, xb, true);
                label9.Text = resultMultiplication.ToString();
                dataGridView1.Rows[n].Cells[2].Value = resultMultiplication.ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                double result = Integration(a, b, c, xa, xb);
                label6.Text = result.ToString();
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = result.ToString();
                double resultSum = Summation(a, b, c, xa, xb, true, true);
                label7.Text = resultSum.ToString();
                dataGridView1.Rows[n].Cells[1].Value = resultSum.ToString();
                double resultMultiplication = Multiplication(a, b, c, xa, xb, true, true);
                label9.Text = resultMultiplication.ToString();
                dataGridView1.Rows[n].Cells[2].Value = resultMultiplication.ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                double result = Integration(a, b, c, xa, xb);
                label6.Text = result.ToString();
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = result.ToString();
                double resultSum = Summation(a, b, c, xa, xb, true, true, true);
                label7.Text = resultSum.ToString();
                dataGridView1.Rows[n].Cells[1].Value = resultSum.ToString();
                double resultMultiplication = Multiplication(a, b, c, xa, xb, true, true, true);
                label9.Text = resultMultiplication.ToString();
                dataGridView1.Rows[n].Cells[2].Value = resultMultiplication.ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            DataSet ds = new DataSet("Calculation");
            DataTable dt = new DataTable("Results");
            dt.Columns.Add("Integration");
            dt.Columns.Add("Summation");
            dt.Columns.Add("Multiplication");
            ds.Tables.Add(dt);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["Results"].NewRow();
                row["Integration"] = r.Cells[0].Value.ToString();
                row["Summation"] = r.Cells[1].Value.ToString();
                row["Multiplication"] = r.Cells[2].Value.ToString();
                ds.Tables["Results"].Rows.Add(row);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
