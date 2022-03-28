using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int ilkSayi;
        int ikinciSayi;
        int sonuc;
        private void btnTopla_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt16(txtFirst.Text);
            ikinciSayi = Convert.ToInt16(txtSecond.Text);
            sonuc = ilkSayi + ikinciSayi;
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt16(txtFirst.Text);
            ikinciSayi = Convert.ToInt16(txtSecond.Text);
            sonuc = ilkSayi - ikinciSayi;
            lblSonuc.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt16(txtFirst.Text);
            ikinciSayi = Convert.ToInt16(txtSecond.Text);
            sonuc = ilkSayi * ikinciSayi;
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToInt16(txtFirst.Text);
            ikinciSayi = Convert.ToInt16(txtSecond.Text);
            sonuc = ilkSayi / ikinciSayi;
            lblSonuc.Text = sonuc.ToString();
        }
    }
}
