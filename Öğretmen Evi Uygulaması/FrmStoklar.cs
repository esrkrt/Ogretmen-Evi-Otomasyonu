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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=PC;Initial Catalog=ÖĞRETMENEVİ;Integrated Security=True");

        private void veriler() {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from Faturalar ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read()){



                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektirik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2() {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Stoklar ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {



                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();


        }

       
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,İcecek,Cerezler)values('" + TxtGidalar.Text + "','" + Txtİcecekler.Text + "','" + TxtAtistirmalikler.Text+"')", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektirik,Su,İnternet)values('" + TxtElektirik.Text + "','" + TxtSu.Text + "','" + Txtİnternet.Text + "')", baglanti);

            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
