using Npgsql;
using System.Data;
using System.Data.Common;

namespace ArabaKiralamaSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost ; port = 5432; Database = ArabaKiralamaSistemi ;" +
           " user id = postgres ; password= 147258");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e) // silme btn
        {
            try
            {
                baglanti.Open();

                // Giriş değerlerini kontrol et
                int aracId = int.Parse(txtAracId.Text);

                // SQL komutunu oluştur ve parametreleri ekle
                // Delete from araclanidurumu
                string kayitAraclanidurumu = "DELETE FROM araclarindurumu WHERE aracid = @aracid";
                NpgsqlCommand komutAraclanidurumu = new NpgsqlCommand(kayitAraclanidurumu, baglanti);
                komutAraclanidurumu.Parameters.AddWithValue("@aracid", aracId);
                komutAraclanidurumu.ExecuteNonQuery();

                // string kayitrezervasyonler = "DELETE FROM araclarindurumu WHERE aracid = @aracid"

                // Delete from araclar
                string kayitAraclar = "DELETE FROM araclar WHERE aracid = @aracid";
                NpgsqlCommand komutAraclar = new NpgsqlCommand(kayitAraclar, baglanti);
                komutAraclar.Parameters.AddWithValue("@aracid", aracId);
                komutAraclar.ExecuteNonQuery();



                // Bağlantıyı kapat
                baglanti.Close();

                // Başarı mesajı göster
                MessageBox.Show("Silme başarıyla tamamlandı");
            }
            catch (FormatException)
            {
                // Hata durumunda uygun bir mesaj göster
                MessageBox.Show("Lütfen sayısal değerleri doğru formatta giriniz.");
            }
            catch (Exception ex)
            {
                // Diğer olası hata durumları için genel bir hata mesajı göster
                MessageBox.Show("Hata: " + ex.Message);
            }
        }




        private void button1_Click(object sender, EventArgs e)// listeleme btn
        {
            string sorgu = "select * from araclar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                // Giriş değerlerini kontrol et
                int aracId = int.Parse(txtAracId.Text);
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                int yil = int.Parse(txtYil.Text);
                int kilometre = int.Parse(txtKilometre.Text);
                decimal gunlukKira = decimal.Parse(txtGunlukKira.Text);
                int sirketId = int.Parse(txtSirketID.Text);
                string yakitAdi = txtYakitTipi.Text;
                int yakitId = int.Parse(txtYakiTipiId.Text);

                // SQL komutunu oluştur ve parametreleri ekle
                string kayit = "insert into araclar(aracid, marka, model, yil, kilometre, gunlukkirabedeli, sirketid, yakitadi, yakitid)" +
                               "values(@aracid,@marka,@model,@yil,@kilometre,@gunlukkirabedeli,@sirketid,@yakitadi,@yakitid)";
                NpgsqlCommand komut = new NpgsqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@aracid", aracId);
                komut.Parameters.AddWithValue("@marka", marka);
                komut.Parameters.AddWithValue("@model", model);
                komut.Parameters.AddWithValue("@yil", yil);
                komut.Parameters.AddWithValue("@kilometre", kilometre);
                komut.Parameters.AddWithValue("@gunlukkirabedeli", gunlukKira);
                komut.Parameters.AddWithValue("@sirketid", sirketId);
                komut.Parameters.AddWithValue("@yakitadi", yakitAdi);
                komut.Parameters.AddWithValue("@yakitid", yakitId);

                // SQL komutunu çalıştır
                komut.ExecuteNonQuery();

                // Bağlantıyı kapat
                baglanti.Close();

                // Başarı mesajı göster
                MessageBox.Show("Ekleme başarıyla tamamlandı");
            }
            catch (FormatException)
            {
                // Hata durumunda uygun bir mesaj göster
                MessageBox.Show("Lütfen sayısal değerleri doğru formatta giriniz.");
            }
            catch (Exception ex)
            {
                // Diğer olası hata durumları için genel bir hata mesajı göster
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void txtYakitTipi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Arama kriterlerini al
                int aracId = int.Parse(txtAracId.Text);

                // SQL komutunu oluştur ve parametreleri ekle
                string kayit = "SELECT * FROM araclar WHERE aracid=@aracid";
                NpgsqlCommand komut = new NpgsqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@aracid", aracId);

                // Veri okuyucu oluştur
                NpgsqlDataReader veriOkuyucu = komut.ExecuteReader();

                // Veriyi oku ve ekrana yaz
                if (veriOkuyucu.Read())
                {
                    txtMarka.Text = veriOkuyucu["marka"].ToString();
                    txtModel.Text = veriOkuyucu["model"].ToString();
                    txtYil.Text = veriOkuyucu["yil"].ToString();
                    txtKilometre.Text = veriOkuyucu["kilometre"].ToString();
                    txtGunlukKira.Text = veriOkuyucu["gunlukkirabedeli"].ToString();
                    txtSirketID.Text = veriOkuyucu["sirketid"].ToString();
                    txtYakitTipi.Text = veriOkuyucu["yakitadi"].ToString();
                    txtYakiTipiId.Text = veriOkuyucu["yakitid"].ToString();

                    // Diğer alanları da okuyabilirsiniz.
                }
                else
                {
                    MessageBox.Show("Belirtilen araç ID'sine sahip kayıt bulunamadı.");
                }

                // Veri okuyucuyu kapat
                veriOkuyucu.Close();

                // Bağlantıyı kapat
                baglanti.Close();
            }
            catch (FormatException)
            {
                // Hata durumunda uygun bir mesaj göster
                MessageBox.Show("Lütfen geçerli bir araç ID'si giriniz.");
            }
            catch (Exception ex)
            {
                // Diğer olası hata durumları için genel bir hata mesajı göster
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                // Giriş değerlerini kontrol et
                int aracId = int.Parse(txtAracId.Text);
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                int yil = int.Parse(txtYil.Text);
                int kilometre = int.Parse(txtKilometre.Text);
                decimal gunlukKira = decimal.Parse(txtGunlukKira.Text);
                int sirketId = int.Parse(txtSirketID.Text);
                string yakitAdi = txtYakitTipi.Text;
                int yakitId = int.Parse(txtYakiTipiId.Text);

                // SQL komutunu oluştur ve parametreleri ekle
                string kayit = "UPDATE araclar SET marka=@marka, model=@model, yil=@yil, " +
                       "kilometre=@kilometre, gunlukkirabedeli=@gunlukkirabedeli, " +
                       "sirketid=@sirketid, yakitadi=@yakitadi, yakitid=@yakitid " +
                       "WHERE aracid=@aracid";

                NpgsqlCommand komut = new NpgsqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@aracid", aracId);
                komut.Parameters.AddWithValue("@marka", marka);
                komut.Parameters.AddWithValue("@model", model);
                komut.Parameters.AddWithValue("@yil", yil);
                komut.Parameters.AddWithValue("@kilometre", kilometre);
                komut.Parameters.AddWithValue("@gunlukkirabedeli", gunlukKira);
                komut.Parameters.AddWithValue("@sirketid", sirketId);
                komut.Parameters.AddWithValue("@yakitadi", yakitAdi);
                komut.Parameters.AddWithValue("@yakitid", yakitId);

                // SQL komutunu çalıştır
                komut.ExecuteNonQuery();

                // Bağlantıyı kapat
                baglanti.Close();

                // Başarı mesajı göster
                MessageBox.Show("Gunceleme başarıyla tamamlandı");
            }
            catch (FormatException)
            {
                // Hata durumunda uygun bir mesaj göster
                MessageBox.Show("Lütfen sayısal değerleri doğru formatta giriniz.");
            }
            catch (Exception ex)
            {
                // Diğer olası hata durumları için genel bir hata mesajı göster
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapat
        }
    }
}