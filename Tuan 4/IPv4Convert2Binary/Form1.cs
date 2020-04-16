using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPv4Convert2Binary
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
        string oct1, oct2, oct3, oct4;
        private void tachOctet()
        {
            int dem = 0,vt=0;
            string s = txtNhap.Text; 
            for(int i = 0; i<s.Length; i++)
            {
                if (s[i] == '.') 
                { 
                    dem++;
                    if (dem == 1)
                    {
                        oct1 = s.Substring(0, i);
                        vt = i;
                    }
                    if (dem == 2)
                    {
                        oct2 = s.Substring(vt + 1, i - vt - 1);
                        vt = i;
                    }
                    if (dem == 3)
                    {
                        oct3 = s.Substring(vt + 1, i - vt- 1);
                        oct4 = s.Substring(i + 1, s.Length - i -1);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
        }
        private string dec2Bin(int o)
        {
            if (o > 255||o<0)
            {
                MessageBox.Show("Error Found! Octet vượt quá 256 hoặc bị âm!");
                return "<Lỗi octet>";
            }
            else
            {
                o *= 2;
                string str1 = "", str = str1;
                while (o / 2 != 0)
                {
                    o /= 2;
                    str = str + (o % 2).ToString();
                }
                for (int i = str.Length - 1; i >= 0; i--) str1 += str[i];
                return str1;
            }
        }
        private string bin2Dec(string s)
        {
            int kq=0,g=1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1') kq += g;
                g *= 2;
            }
            if (kq > 255 || kq < 0)
            {
                MessageBox.Show("Error Found! Octet vượt quá 256!");
                return "<Lỗi octet>";
            }
            else return kq.ToString();
        }
        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtnBin2Normal.Checked)
            {
                if(e.KeyChar!='1'&&e.KeyChar!='0'&&e.KeyChar!='.'&&e.KeyChar!=8)
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai định dạng!","Thông báo");
                }
            }
        }
        private void normal2Bin()
        {
            tachOctet();
            oct1 = dec2Bin(Convert.ToInt32(oct1));
            oct2 = dec2Bin(Convert.ToInt32(oct2));
            oct3 = dec2Bin(Convert.ToInt32(oct3));
            oct4 = dec2Bin(Convert.ToInt32(oct4));
        }
        private void bin2Normal()
        {
            tachOctet();
            oct1 = bin2Dec(oct1);
            oct2 = bin2Dec(oct2);
            oct3 = bin2Dec(oct3);
            oct4 = bin2Dec(oct4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnNormal2Bin.Checked) normal2Bin();
            else bin2Normal();
            txtKQ.Text = oct1 + "." + oct2 + "." + oct3 + "." + oct4;
        }
    }
}
