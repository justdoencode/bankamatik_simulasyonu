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
    public partial class frm_hesaphareketleri : Form
    {
        public frm_hesaphareketleri()
        {
            InitializeComponent();
        }
        public string hesapno;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=bankamatik_simulasyonu;Uid=root;Pwd=root;");
        private void frm_hesaphareketleri_Load(object sender, EventArgs e)
        {
            //GÖNDERİLEN HAREKETLER
            MySqlDataAdapter da = new MySqlDataAdapter("select concat(tbl_müsteriler.müsteri_ad,' ',tbl_müsteriler.müsteri_soyad) as 'ALICI',tbl_hareketler.tutar,tbl_hareketler.aciklama from bankamatik_simulasyonu.tbl_hareketler INNER JOIN bankamatik_simulasyonu.tbl_müsteriler ON (tbl_hareketler.alici=tbl_müsteriler.müsteri_hesapno) where tbl_hareketler.gonderen="+hesapno, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid_gonderilem.DataSource = dt;

            //ALINAN HAREKETLER
            MySqlDataAdapter da2 = new MySqlDataAdapter("select concat(tbl_müsteriler.müsteri_ad,' ',tbl_müsteriler.müsteri_soyad) as 'ALICI',tbl_hareketler.tutar,tbl_hareketler.aciklama from bankamatik_simulasyonu.tbl_hareketler INNER JOIN bankamatik_simulasyonu.tbl_müsteriler ON (tbl_hareketler.gonderen=tbl_müsteriler.müsteri_hesapno) where tbl_hareketler.alici=" + hesapno, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGrid_alinan.DataSource = dt2;
        }
    }
}
