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

namespace SaveToXML
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader StreamReader = new StreamReader("file.txt");
            textBox1.Text = StreamReader.ReadToEnd();
            StreamReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "file.txt";
            FileStream FileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter StreamWriter = new StreamWriter(FileStream);
            StreamWriter.WriteLine(textBox1.Text);
            StreamWriter.Flush();
            StreamWriter.Close();
            FileStream.Close();
        }
    }
}
