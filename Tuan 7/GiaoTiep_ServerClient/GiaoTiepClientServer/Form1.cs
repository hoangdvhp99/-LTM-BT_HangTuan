using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GiaoTiepClientServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        
        private string reply(string st)
        {
            string s="";
            for(int k=0;k<st.Length-1;k++)
            {
                if ((st[k] < '0') || (st[k] > '9')) return "Xin chao, " + txtHost.Text + ":" + txtPort.Text;
                switch (st[k])
                {
                    case '1': s+= "One "; break;
                    case '2': s+= "Two "; break;
                    case '3': s+= "Three "; break;
                    case '4': s+= "Four "; break;
                    case '5': s+= "Five "; break;
                    case '6': s+= "Six "; break;
                    case '7': s+= "Seven "; break;
                    case '8': s+= "Eight "; break;
                    case '9': s+= "Nine "; break;
                    case '0': s += "Zero "; break; 
                }
            }
            return s; 
        }
        bool done = false;
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            lbStatus.Invoke((MethodInvoker) delegate() 
            {
                lbStatus.Items.Add("+Client:" + e.MessageString);
                if (e.MessageString == "END\u0013")
                {
                    e.ReplyLine("Good Bye!"); 
                    done = true;
                   // server.Stop();
                }
                else
                    e.ReplyLine(string.Format("Server: {0}", reply(e.MessageString)));
            });
            if (done)
            {
                btnStop.Enabled = false;
                btnStart.Enabled = true;
                server.Stop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lbStatus.Items.Add("Server is starting...");
            IPAddress ip;
            ip = IPAddress.Parse(txtHost.Text);
            server.Start(ip,int.Parse(txtPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            if (server.IsStarted)
            {
                lbStatus.Items.Add("Server is closed!");
                server.BroadcastLine("Server is closed!");
                server.Stop();
            }
        }
    }
}
