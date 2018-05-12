using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace veriCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adres = "http://www.tff.org/default.aspx";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenbilgiler.ReadToEnd();
            int baslikbaslangic = gelen.IndexOf("<title>") + 7;
            int baslikbitisi = gelen.Substring(baslikbaslangic).IndexOf("</title>");
            string baslik = gelen.Substring(baslikbaslangic, baslikbitisi);
            MessageBox.Show(baslik);


        }
    }
}
