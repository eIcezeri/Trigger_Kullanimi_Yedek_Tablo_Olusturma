using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trigger_Kullanimi_Yedek_Tablo_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SAMETYIGIT;Initial Catalog=TriggerKullanimi;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLKITAPLAR", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLSAYAC", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKitap.Text = dr[0].ToString();
            }
            baglanti.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();    
        }

        private void BtnEKLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKITAPLAR (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtAD.Text);
            komut.Parameters.AddWithValue("@P2", TxtYAZAR.Text);
            komut.Parameters.AddWithValue("@P3", TxtSAYFA.Text);
            komut.Parameters.AddWithValue("@P4", TxtYAYIN.Text);
            komut.Parameters.AddWithValue("@P5", TxtTUR.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Ekleme İslemi Basarili Bir Sekilde Gerceklesti");

            listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtYAZAR.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSAYFA.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtYAYIN.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtTUR.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BTNSIL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBLKITAPLAR where ID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Basarili Bir Sekilde Silindi");
            listele();
            sayac();
        }
    }
}
