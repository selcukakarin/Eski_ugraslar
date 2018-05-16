using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int timer = 20;
        int correctanswer = 0, wronganswer = 0;

        public void sonuclar(RadioButton checkedAnswer)
        {
            if (checkedAnswer.Checked == true)
            {
                correctanswer++;
                checkedAnswer.BackColor = Color.Green;
            }
            else
            {

                wronganswer++;
            }
            label6.Text = correctanswer.ToString();
            label8.Text = wronganswer.ToString();

        }
        public void grupFalse()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }
        public void grupTrue()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            grupFalse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Please fill the blanks");
            }
            else if (textBox1.Text.Length != 8)
            {
                MessageBox.Show("Student number must be 8 digits");
            }
            else
            {
                timer1.Enabled = true;
                grupTrue();
                label9.Text = textBox1.Text; ;
                label10.Text = textBox2.Text;
                button2.Enabled = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer--;
            label2.Text = timer.ToString();
            if (timer == 0)
            {
                timer1.Enabled = false;
                grupFalse();
                MessageBox.Show("Time is over");
                button1.Enabled = false;
                button2.Enabled = false;
                sonuclar(radioButton2);
                sonuclar(radioButton8);
                sonuclar(radioButton12);
                sonuclar(radioButton16);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grupFalse();
            button1.Enabled = false;
            timer1.Enabled = false;
            sonuclar(radioButton2);
            sonuclar(radioButton8);
            sonuclar(radioButton12);
            sonuclar(radioButton16);
        }


    }
}
