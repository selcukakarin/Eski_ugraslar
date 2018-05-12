using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebChat.App.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        HubConnection con;
        HubProxy proxy; 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!txtServer.Text.StartsWith("http://"))
                txtServer.Text = "http://" + txtServer.Text;
            con = new HubConnection(txtServer.Text);
            proxy = (HubProxy)con.CreateHubProxy("ChatHub");
            proxy.On<string>("getMessage",DataRecieved);
            var t=new Task(() => con.Start());
            t.Start();
            Task.WhenAll(t);
            txtMessage.Enabled = btnSend.Enabled = true;
            txtServer.Enabled = txtName.Enabled = btnConnect.Enabled = false;
        }
        bool first=true;
        private void DataRecieved(string obj)
        {
            lbChat.Items.Add(obj);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (first)
                proxy.Invoke("SendMessage", string.Format("Kullanıcı > {0}, Ad > {1}", GetIP, txtName.Text));

            proxy.Invoke("SendMessage",txtName.Text+" > "+ txtMessage.Text);
            txtMessage.Clear();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend_Click(this, new EventArgs());
        }
        public string GetIP
        {
            get
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return "";
            }
        }
    }
}
