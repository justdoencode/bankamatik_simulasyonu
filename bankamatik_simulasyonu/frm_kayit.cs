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
    public partial class frm_kayit : Form
    {
        public frm_kayit()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=bankamatik_simulasyonu;Uid=root;Pwd=root;");
        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int hesapno = rnd.Next(100000, 199999);
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("insert into tbl_müsteriler (müsteri_ad,müsteri_soyad,müsteri_tc,müsteri_telefon,müsteri_hesapno,müsteri_sifre) values (@ad,@soyad,@tc,@telefon,@hesapno,@sifre)", baglanti);

            cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            cmd.Parameters.AddWithValue("@hesapno", hesapno);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand("insert into tbl_hesaplar (hesap_no,bakiye) values (@hesapno,@bakiye)", baglanti);
            cmd2.Parameters.AddWithValue("@hesapno", hesapno);
            cmd2.Parameters.AddWithValue("@bakiye", decimal.Parse(txt_bakiye.Text));
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Kaydınız Başarıyla Gerçekleşti\nHesap Numaranız :" + hesapno);
        }
    }
}
