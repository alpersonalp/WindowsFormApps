namespace App4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            kullanicilar = new Dictionary<string, string>();
            kullanicilar.Add("Recep","123");
            kullanicilar.Add("Emre","1234");
            kullanicilar.Add("Kaan","12345");

        }
        int h = 4;
        Dictionary<string, string> kullanicilar;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var list = (from a in kullanicilar
                        where a.Key == txtKullaniciAdi.Text && a.Value == txtSifre.Text
                        select a).ToList();

            if (list.Count >0)
            {
                MessageBox.Show("Hoþ Geldin Admin");
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();

            }
            else
            {
                h--;
                MessageBox.Show($"Hatalý bilgi. Kalan hakkýnýz : {h}");
            }
            if (h==0)
                btnGirisYap.Enabled = false;
        }
    }
}