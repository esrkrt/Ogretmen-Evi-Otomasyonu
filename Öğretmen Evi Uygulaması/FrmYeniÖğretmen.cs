using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Öğretmen_Evi_Uygulaması
{
    public partial class FrmYeniÖğretmen : Form
    {
        SqlCommand komut;


        public FrmYeniÖğretmen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=PC;Initial Catalog=ÖĞRETMENEVİ;Integrated Security=True");

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close(); 
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109(Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir...");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir...");
        }

       

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan Sonuc;
             Sonuc= BuyukTarih - KucukTarih;
            label10.Text = Sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label10.Text) * 50;
            TxtUcret.Text = ucret.ToString();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           String sorgu= "INSERT INTO MusteriEkle(Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi) VALUES (@Adi,@Soyadi, @cinsiyet, @Telefon,@Mail,@KimlikNo,@OdaNo,@Ucret,@GirisTarihi,@CikisTarihi)";
            komut = new SqlCommand(sorgu, baglanti);
            
            komut.Parameters.AddWithValue("@Adi",TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komut.Parameters.AddWithValue("@KimlikNo", TxtKimlikNo.Text);
            komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value);
            komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğretmen kaydı yapıldı...");
            baglanti.Close();
            
        }

        private void FrmYeniÖğretmen_Load(object sender, EventArgs e)
        {
            //ODA101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select*from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {

                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }
            //ODA102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select*from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {

                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }
            //ODA103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select*from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {

                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
            //ODA104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select*from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {

                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
            //ODA105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select*from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {

                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }
            //ODA106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select*from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {

                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }
            //ODA107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select*from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {

                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }
            //ODA108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select*from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {

                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }
            //ODA109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select*from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {

                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
        }
    }
}
//Data Source=PC;Initial Catalog=ÖĞRETMENEVİ;Integrated Security=True
/*SqlCommand cmd = new SqlCommand();
con.Open();
            cmd.Conne
            ction = con;
cmd.CommandText = "Select * From KISIADMIN where kadi='" + kadi.Text + "' and ksifre= '" + ksifre.Text + "'";
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI...");
                btnKitaplar.Visible = true;
                btnKişiler.Visible = true;
                btnEmanet.Visible = true;
                BTN_ADMINCIKIS.Visible = true;
               
            }
            else { MessageBox.Show("TEKRAR DENEYİNİZ...");


            }
           
            con.Close();
        }*/
/* baglanti.Open();
    SqlCommand cmd = new SqlCommand("INSERT INTO OgretmenEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CıkısTarihi)VALUES('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + cmbcinsiyet.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + dateTimePicker2.Value.ToString("yyyy-MM-dd")+ "')", baglanti);
    cmd.ExecuteNonQuery();

    MessageBox.Show("Öğretmen kaydı yapıldı...");


    baglanti.Close();*/
