namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        bool durum = true;
        private void btnsayac_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int red = rnd.Next(0, 255);
            int green = rnd.Next(0, 255);
            int blue = rnd.Next(0, 255);
            lblsayac.ForeColor = Color.FromArgb(red, green, blue);

            if (sayac == 10)
                durum = false;
            else if (sayac == 0)
                durum = true;

            if (durum)
                sayac++;
            else
                sayac--;

            btnsayac.Text = durum ? "Arttýr" : "Azalt";
                lblsayac.Text = sayac.ToString();

        }

        bool gorunum = true;
        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            btnBut.Visible = gorunum;

            if (gorunum)
                gorunum = false;
            else
                gorunum = true;
            

        }
    }
}