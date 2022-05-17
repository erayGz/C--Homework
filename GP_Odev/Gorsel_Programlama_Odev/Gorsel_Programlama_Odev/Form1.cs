namespace Gorsel_Programlama_Odev
{
    public partial class Form1 : Form
    {
        //Random Dizimizi her yerde kullanacaðýmýz için burada tanýmlýyoruz
        int[] sayilar = new int[25];
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoru1_Click(object sender, EventArgs e)
        {
            //Her Butona Týkladýðýmýzda listeyi sýfýrlamasý için
            lblListe.Items.Clear();
            //Listemizdeki sayýlarýn toplamýný tutmak için toplam deðiþkeni tanýmlarýz
            int toplam = 0;
            //Her sayýyý yazdýrmak için döngü kullanmamýz lazým
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                toplam++;
            }
            lblSonuc.Text = "Toplam Sayý Boyutu :" + toplam.ToString();
        }

        private void btnSoru2_Click(object sender, EventArgs e)
        {
            //Her Butona Týkladýðýmýzda listeyi sýfýrlamasý için
            lblListe.Items.Clear();
            //Listemizdeki 50'nii altýnda kaç tane sayý olduðunu bulmak için deðiþkeni tanýmlarýz
            int EllininAltýndakilerinToplami = 0;
            //Her sayýyý yazdýrmak için döngü kullanmamýz lazým
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                //50'nin Altýný Almamýz için koþul belirtmemiz lazým
                if (sayilar[i] < 50)
                {
                    EllininAltýndakilerinToplami++;
                }

            }

            lblSonuc.Text = "50'nin Altýndakileri Sayýlarýn Boyutu : " + EllininAltýndakilerinToplami.ToString();
        }

        private void btnSoru3_Click(object sender, EventArgs e)
        {
            //Her Butona Týkladýðýmýzda listeyi sýfýrlamasý için
            lblListe.Items.Clear();
            //Listemizdeki sayýlarýn toplamýný tutmak için toplam deðiþkeni tanýmlarýz
            int toplam = 0;
            int ortalama;
            //Her sayýyý yazdýrmak için döngü kullanmamýz lazým
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                //Diziye Yazýlan Sayýlarý Toplama Ýþlemi
                toplam += sayilar[i];
            }
            //Dizimizin Boyutu 25 olduðu için 25e böldük
            ortalama = toplam / 25;
            lblSonuc.Text = "Ortalama : " + ortalama.ToString();
        }

        private void btnSoru4_Click(object sender, EventArgs e)
        {
            //Her Butona Týkladýðýmýzda listeyi sýfýrlamasý için
            lblListe.Items.Clear();
            //Listemizdeki En Büyük Sayýyý Bulmak için deðiþkenimizi tanýmlarýz
            int EnBuyuk = 0;
            //Her sayýyý yazdýrmak için döngü kullanmamýz lazým
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                //lblListe.Items.Add(sayilar[i]);
                //En Büyük Sayýyý Bulma Ýþlemi
                if (EnBuyuk < sayilar[i])
                {
                    EnBuyuk = sayilar[i];

                }

            }
            //En Büyük Sayýyý Ekrana Yazdýrma Ýþlemi         
            lblListe.Items.Add(EnBuyuk);
            lblSonuc.Text = "En Buyuk Sayý : " + EnBuyuk.ToString();
        }

        private void btnSoru5_Click(object sender, EventArgs e)
        {
            //Her Butona Týkladýðýmýzda listeyi sýfýrlamasý için
            lblListe.Items.Clear();
            //Listemizdeki Ne kadar asal sayý olduðunu bulmak için deðiþkenimizi tanýmlarýz

            int AsalSayi = 0;
            
            //Her sayýyý yazdýrmak için döngü kullanmamýz lazým

            for (int i = 0; i < 25; i++)
            {
                int divider = 0;
                sayilar[i] = random.Next(0,100);
                lblListe.Items.Add(sayilar[i]);
                //Asal Sayi Bulma Fonksiyonu
                for (int j = 1; j <= sayilar[i]; j++)
                {
                    if (sayilar[i] % j == 0)
                    {
                        divider++;
                    }
                    
                }
                //Asal Sayýlarýn 2 tane böleni olduðu için 2ye eþitleriz
                if (divider == 2)
                {
                   AsalSayi++;
                }
            }

            //En Büyük Sayýyý Ekrana Yazdýrma Ýþlemi
            lblSonuc.Text = "Asal Sayý : " + AsalSayi.ToString();
        }
    }
}