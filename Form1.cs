using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int ilk_sayi ;
        public int ikinci_sayi ;
        public string islem_sayi = "";

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text +="1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text +="4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text +="5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text +="8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem_sayi =  "+";
            ilk_sayi = Convert.ToInt32(label1.Text);
            label1.Text = "";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ikinci_sayi = Convert.ToInt32(label1.Text);  
            if (islem_sayi == "+")
            {
                int sonuc = ilk_sayi + ikinci_sayi;
                label1.Text = sonuc.ToString();
            }
            else if (islem_sayi == "-")
            {
                int sonuc = ilk_sayi - ikinci_sayi;
                label1.Text = sonuc.ToString();
            }
            else if (islem_sayi == "*")
            {
                int sonuc = ilk_sayi * ikinci_sayi;
                label1.Text = sonuc.ToString();
            }
            else
            {
                int sonuc = ilk_sayi / ikinci_sayi;
                label1.Text = sonuc.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem_sayi =  "-" ; 
            ilk_sayi = Convert.ToInt32(label1.Text);
            label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            islem_sayi  = "*";
            ilk_sayi = Convert.ToInt32(label1.Text);
            label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem_sayi = "";
            ilk_sayi = Convert.ToInt32(label1.Text);
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string yazi = label1.Text;
            string sil = yazi.Substring(0, yazi.Length - 1);
            label1.Text = sil ;
        }
    }
}
