using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GaussJordan(double[,] matris, double[] value, int dimension)
        {
            for (int i = 0; i < dimension; i++)
            {
                double firstTemp = matris[i, i];
                for (int k = 0; k < dimension; k++)
                {
                    matris[i, k] /= firstTemp;
                }
                value[i] /= firstTemp;


                for (int j = i + 1; j < dimension; j++)
                {
                    double multiplication = matris[j, i] / matris[i, i];

                    for (int l = 0; l < dimension; l++)
                    {
                        matris[j, l] = matris[j, l] - (multiplication * matris[i, l]);
                    }
                    value[j] = value[j] - (multiplication * value[i]);
                }
            }

            for (int i = dimension - 1; i > 0; i--)
            {

                for (int j = i - 1; j >= 0; j--)
                {
                    double multiplication = matris[j, i] / matris[i, i];
                    for (int k = 0; k < 3; k++)
                        matris[j, k] -= matris[i, k] * multiplication;
                    value[j] -= value[i] * multiplication;
                }
            }
            for (int i = 0; i < dimension; i++)
                listBox1.Items.Add("x(" + i + ") : " + value[i]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dimen = Interaction.InputBox("enter the dimension", "Dimension", "", 0, 0);
            int dimension = Convert.ToInt32(dimen);

            double[,] matris = new double[dimension, dimension];
            double[] value = new double[dimension];



            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    string matrisElement = Interaction.InputBox("Enter the element of "+ (i + 1) + "row" + (j + 1) + ".column ", "Matris", "", 0, 0);
                    matris[i, j] = Convert.ToDouble(matrisElement);
                }
            }


            for (int i = 0; i < dimension; i++)
            {
                string myValue = Interaction.InputBox( "enter the " + (i + 1) + ". value ", "Value", "", 0, 0);
                value[i] = Convert.ToDouble(myValue);

            }

            GaussJordan(matris, value, dimension);
        }

        public class NewtonRaphson
        {
            

            public double Solve(Func<double, double> f, Func<double, double> df, double initialGuess, int MaxIteration, double Epsilon)
            {
                var xn = initialGuess;

                for (var i = 0; i < MaxIteration; i++)
                {
                    var xn1 = xn - f.Invoke(xn) / df.Invoke(xn);

                    if (Math.Abs(xn - xn1) < Epsilon)
                    {
                        return xn1;
                    }

                    xn = xn1;
                }

                return xn;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string maxIt = Interaction.InputBox("Max iteration : ", "Max iteration", "Exp : 50", 0, 0);
            int maxIteration = Convert.ToInt32(maxIt);
            string eps = Interaction.InputBox("Epsilon : ", "Epsilon", "Exp : 0.000001", 0, 0);
            double Epsilon = Convert.ToDouble(eps);
            var solver = new NewtonRaphson();
            if (radioButton1.Checked)
            {
                double root = solver.Solve(x => x * x - 2, x => 2 * x, 1, maxIteration, Epsilon);
                listBox2.Items.Add(root);
            }
            else if (radioButton2.Checked)
            {
                double root2 = solver.Solve(x => x - Math.Cos(x), x => 1 + Math.Sin(x), 2, maxIteration,Epsilon);
                listBox2.Items.Add(root2);
            }
            else
            {
                MessageBox.Show("Choose a equation");
            }
            
        }
    }
}
