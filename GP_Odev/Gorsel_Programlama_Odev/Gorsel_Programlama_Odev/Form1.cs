namespace Gorsel_Programlama_Odev
{
    public partial class Form1 : Form
    {
        //Random Dizimizi her yerde kullanaca��m�z i�in burada tan�ml�yoruz
        int[] sayilar = new int[25];
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoru1_Click(object sender, EventArgs e)
        {
            //Her Butona T�klad���m�zda listeyi s�f�rlamas� i�in
            lblListe.Items.Clear();
            //Listemizdeki say�lar�n toplam�n� tutmak i�in toplam de�i�keni tan�mlar�z
            int toplam = 0;
            //Her say�y� yazd�rmak i�in d�ng� kullanmam�z laz�m
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                toplam++;
            }
            lblSonuc.Text = "Toplam Say� Boyutu :" + toplam.ToString();
        }

        private void btnSoru2_Click(object sender, EventArgs e)
        {
            //Her Butona T�klad���m�zda listeyi s�f�rlamas� i�in
            lblListe.Items.Clear();
            //Listemizdeki 50'nii alt�nda ka� tane say� oldu�unu bulmak i�in de�i�keni tan�mlar�z
            int EllininAlt�ndakilerinToplami = 0;
            //Her say�y� yazd�rmak i�in d�ng� kullanmam�z laz�m
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                //50'nin Alt�n� Almam�z i�in ko�ul belirtmemiz laz�m
                if (sayilar[i] < 50)
                {
                    EllininAlt�ndakilerinToplami++;
                }

            }

            lblSonuc.Text = "50'nin Alt�ndakileri Say�lar�n Boyutu : " + EllininAlt�ndakilerinToplami.ToString();
        }

        private void btnSoru3_Click(object sender, EventArgs e)
        {
            //Her Butona T�klad���m�zda listeyi s�f�rlamas� i�in
            lblListe.Items.Clear();
            //Listemizdeki say�lar�n toplam�n� tutmak i�in toplam de�i�keni tan�mlar�z
            int toplam = 0;
            int ortalama;
            //Her say�y� yazd�rmak i�in d�ng� kullanmam�z laz�m
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                //Diziye Yaz�lan Say�lar� Toplama ��lemi
                toplam += sayilar[i];
            }
            //Dizimizin Boyutu 25 oldu�u i�in 25e b�ld�k
            ortalama = toplam / 25;
            lblSonuc.Text = "Ortalama : " + ortalama.ToString();
        }

        private void btnSoru4_Click(object sender, EventArgs e)
        {
            //Her Butona T�klad���m�zda listeyi s�f�rlamas� i�in
            lblListe.Items.Clear();
            //Listemizdeki En B�y�k Say�y� Bulmak i�in de�i�kenimizi tan�mlar�z
            int EnBuyuk = 0;
            //Her say�y� yazd�rmak i�in d�ng� kullanmam�z laz�m
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(0, 100);
                lblListe.Items.Add(sayilar[i]);
                //lblListe.Items.Add(sayilar[i]);
                //En B�y�k Say�y� Bulma ��lemi
                if (EnBuyuk < sayilar[i])
                {
                    EnBuyuk = sayilar[i];

                }

            }
            //En B�y�k Say�y� Ekrana Yazd�rma ��lemi         
            lblListe.Items.Add(EnBuyuk);
            lblSonuc.Text = "En Buyuk Say� : " + EnBuyuk.ToString();
        }

        private void btnSoru5_Click(object sender, EventArgs e)
        {
            //Her Butona T�klad���m�zda listeyi s�f�rlamas� i�in
            lblListe.Items.Clear();
            //Listemizdeki Ne kadar asal say� oldu�unu bulmak i�in de�i�kenimizi tan�mlar�z

            int AsalSayi = 0;
            
            //Her say�y� yazd�rmak i�in d�ng� kullanmam�z laz�m

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
                //Asal Say�lar�n 2 tane b�leni oldu�u i�in 2ye e�itleriz
                if (divider == 2)
                {
                   AsalSayi++;
                }
            }

            //En B�y�k Say�y� Ekrana Yazd�rma ��lemi
            lblSonuc.Text = "Asal Say� : " + AsalSayi.ToString();
        }
    }
}