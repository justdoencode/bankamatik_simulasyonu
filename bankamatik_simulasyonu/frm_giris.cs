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
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=bankamatik_simulasyonu;Uid=root;Pwd=root;");
        private void lbl_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_kayit frmkayit = new frm_kayit();
            frmkayit.Show();
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select * from tbl_müsteriler where müsteri_hesapno=@hesapno and müsteri_sifre=@sifre", baglanti);
            cmd.Parameters.AddWithValue("@hesapno", txt_hesapno.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_parola.Text);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                frm_kullanici frmkullanici = new frm_kullanici();
                frmkullanici.hesapnumarasi = txt_hesapno.Text;
                frmkullanici.Show();
            }
            baglanti.Close();
        }
    }
}
