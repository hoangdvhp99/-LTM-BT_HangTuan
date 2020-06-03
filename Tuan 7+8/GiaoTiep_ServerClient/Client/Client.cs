using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
namespace Client
{
    public partial class Client : Form
    {   
        public Client()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            try
            {
                client.Connect(txtHost.Text, int.Parse(txtPort.Text));
                client.WriteLine("Client connected!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                btnConnect.Enabled = true;
            } 
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
            
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            lbStatus.Invoke((MethodInvoker)delegate ()
            {
                lbStatus.Items.Add(e.MessageString);
                if (e.MessageString == "Good Bye!\u0013"||e.MessageString== "Server is closed!\u0013") btnConnect.Enabled = true;
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                lbStatus.Items.Add("You said: " + txtMessage.Text);
                client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(2));
            }
            txtMessage.Clear();
        }
    }
}
