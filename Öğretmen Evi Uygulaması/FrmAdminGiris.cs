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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=PC;Initial Catalog=ÖĞRETMENEVİ;Integrated Security=True");


        private void BtnGirisYap_Click(object sender, EventArgs e)
        {


            try
            {
                baglanti.Open();
                String Sql = "select*from AdminGiris where Kullanici=@Kullaniciadi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(Sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                    this.Hide();
                
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş.....");
            }
           
        }

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into AdminGiris(Kullanici,Sifre)values('" + TxtxKullaniciad.Text + "','" + TxtKullaniciSifre.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Kayıt İşlemi Gerçekleşmiştir, Giriş Yapınız.....");
            baglanti.Close();
            }
    }
}

