using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bankamatik_simulasyonu
{
    public partial class frm_kullanici : Form
    {
        public frm_kullanici()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=bankamatik_simulasyonu;Uid=root;Pwd=root;");
        public string hesapnumarasi;
        private void frm_kullanici_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select * from tbl_müsteriler where müsteri_hesapno=" + hesapnumarasi, baglanti);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_ad.Text = dr[1].ToString()+" "+dr[2];
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                txt_tc.Text = dr[3].ToString();
                txt_telefon.Text = dr[4].ToString();
                txt_parola.Text = dr[6].ToString();
            }
            dr.Close();
            MySqlCommand cmd2 = new MySqlCommand("select bakiye from tbl_hesaplar where hesap_no=" + hesapnumarasi, baglanti);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lbl_bakiye.Text = dr2[0].ToString();
            }
            dr2.Close();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand cmd3 = new MySqlCommand("delete from tbl_müsteriler where müsteri_hesapno=" + hesapnumarasi, baglanti);
            cmd3.ExecuteNonQuery();
            MySqlCommand cmd4 = new MySqlCommand("delete from tbl_hesaplar where hesap_no="+hesapnumarasi, baglanti);
            cmd4.ExecuteNonQuery();
            MySqlCommand cmd5 = new MySqlCommand("delete from tbl_hareketler where hesap_no=" + hesapnumarasi, baglanti);
            cmd5.ExecuteNonQuery();
            MessageBox.Show("Hesabınız silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand cmd4 = new MySqlCommand("update tbl_hesaplar set bakiye=bakiye+@tutar where hesap_no="+int.Parse(txt_hesapno.Text), baglanti);
            cmd4.Parameters.AddWithValue("@tutar", decimal.Parse(txt_tutar.Text));
            cmd4.ExecuteNonQuery();
            MySqlCommand cmd5 = new MySqlCommand("update tbl_hesaplar set bakiye=bakiye-@tutar where hesap_no=" + hesapnumarasi, baglanti);
            cmd5.Parameters.AddWithValue("@tutar", decimal.Parse(txt_tutar.Text));
            cmd5.ExecuteNonQuery();

            MySqlCommand cmd6 = new MySqlCommand("insert into tbl_hareketler (gonderen,alici,tutar,aciklama) values (@gonderen,@alici,@tutar,@aciklama)", baglanti);
            cmd6.Parameters.AddWithValue("@gonderen", hesapnumarasi);
            cmd6.Parameters.AddWithValue("@alici", txt_hesapno.Text);
            cmd6.Parameters.AddWithValue("@tutar", txt_tutar.Text);
            cmd6.Parameters.AddWithValue("@aciklama", rch_aciklama.Text);
            cmd6.ExecuteNonQuery();
            MessageBox.Show("Para Trasnferi Tamamlandı");
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand cmd5 = new MySqlCommand("update tbl_müsteriler set müsteri_ad=@ad,müsteri_soyad=@soyad,müsteri_tc=@tc,müsteri_telefon=@telefon,müsteri_sifre=@sifre where müsteri_hesapno=@hesapno", baglanti);
            cmd5.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd5.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd5.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd5.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            cmd5.Parameters.AddWithValue("@sifre", txt_parola.Text);
            cmd5.Parameters.AddWithValue("@hesapno", hesapnumarasi);
            cmd5.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz GÜncellendi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btn_hesaphareketleri_Click(object sender, EventArgs e)
        {
            frm_hesaphareketleri frmhesaphareketleri = new frm_hesaphareketleri();
            frmhesaphareketleri.hesapno = hesapnumarasi;
            frmhesaphareketleri.Show();
        }
    }
}
