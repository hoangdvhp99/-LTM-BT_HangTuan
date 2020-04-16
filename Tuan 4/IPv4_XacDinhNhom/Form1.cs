using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPv4_XacDinhNhom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        int oct1, oct2, oct3, oct4;

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
        }

        bool check = true;
        private void tachOctet()
        {
            int dem = 0, vt = 0;
            string s = txtNhap.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    dem++;
                    if (dem == 1)
                    {
                        oct1 = Convert.ToInt32(s.Substring(0, i));
                        vt = i;
                    }
                    if (dem == 2)
                    {
                        oct2 = Convert.ToInt32(s.Substring(vt + 1, i - vt - 1));
                        vt = i;
                    }
                    if (dem == 3)
                    {
                        oct3 = Convert.ToInt32(s.Substring(vt + 1, i - vt - 1));
                        oct4 = Convert.ToInt32(s.Substring(i + 1, s.Length - i - 1));
                    }
                }
            }
            if (oct1 > 255 || oct2 > 255 || oct3 > 255 || oct4 > 255 || oct1 < 0 || oct2 < 0 || oct3 < 0 || oct4 < 0)
            {
                MessageBox.Show("Lỗi octet! Mời nhập lại");
                check = false;
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else check = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tachOctet();
            if (check)
            {
                // Private IP:
                if (oct1 == 10 || (oct1 == 172 && oct2 >= 16 && oct2 <= 31) || (oct1 == 192 && oct2 == 168))
                    MessageBox.Show("ĐỊA CHỈ THUỘC NHÓM 'PRIVATE IP'");
                // Loopback
                else if(oct1==127)
                    MessageBox.Show("ĐỊA CHỈ THUỘC NHÓM 'RESERVED IP - LOOPBACK'");
                // Public IP
                else if(oct1>=1&&oct1<=191) 
                    MessageBox.Show("ĐỊA CHỈ THUỘC NHÓM 'PUBLIC IP'");

            }
        }
    }
}
