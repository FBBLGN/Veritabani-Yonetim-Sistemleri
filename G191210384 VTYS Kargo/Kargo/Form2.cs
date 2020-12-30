using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KargoSirketi; user ID=postgres ; password=1234");

        private void kuryeListele()
        {
            baglanti.Open();

            string komut = "select * from kurye";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut,baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            kuryeData.DataSource = dt;
            baglanti.Close();
        }

        private void subeListele()
        {
            baglanti.Open();

            string komut = "select * from sube";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            subeData.DataSource = dt;
            baglanti.Close();
        }

        private void kargoListele()
        {
            baglanti.Open();

            string komut = "select * from kargo";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            kargoData.DataSource = dt;
            baglanti.Close();
        }

        private void gonderenListele()
        {
            baglanti.Open();

            string komut = "select * from gonderen";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            gonderenData.DataSource = dt;
            baglanti.Close();
        }

        private void aliciListele()
        {
            baglanti.Open();

            string komut = "select * from alici";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            aliciData.DataSource = dt;
            baglanti.Close();
        }

        private void faturaListele()
        {
            baglanti.Open();

            string komut = "select * from fatura";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            faturaData.DataSource = dt;
            baglanti.Close();
        }

        private void yksubeListele()
        {
            baglanti.Open();

            string komut = "select * from sube";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            yksubeData.DataSource = dt;
            baglanti.Close();
        }

        private void ykgonderenListele()
        {
            baglanti.Open();

            string komut = "select * from gonderen";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ykgonderenData.DataSource = dt;
            baglanti.Close();
        }

        private void ykaliciListele()
        {
            baglanti.Open();

            string komut = "select * from alici";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ykaliciData.DataSource = dt;
            baglanti.Close();
        }

        private void ykkuryeListele()
        {
            baglanti.Open();

            string komut = "select * from kurye";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ykkuryeData.DataSource = dt;
            baglanti.Close();
        }

        private void ykfiyatListele()
        {
            baglanti.Open();

            string komut = "select * from fiyat";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ykfiyatData.DataSource = dt;
            baglanti.Close();
        }

        private void ykodemeListele()
        {
            baglanti.Open();

            string komut = "select * from odeme";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut, baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ykodemeData.DataSource = dt;
            baglanti.Close();
        }





        private void Form2_Load(object sender, EventArgs e)
        {
            kuryeListele();
            subeListele();
            kargoListele();
            gonderenListele();
            aliciListele();
            faturaListele();

            yksubeListele();
            ykgonderenListele();
            ykaliciListele();
            ykkuryeListele();
            ykfiyatListele();
            ykodemeListele();

        }

        private void gonderenData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gonderenData.CurrentRow.Selected = true;
            gonderenidTxt.Text = gonderenData.CurrentRow.Cells[0].Value.ToString();
            gonderenadTxt.Text = gonderenData.CurrentRow.Cells[1].Value.ToString();
            gonderensoyadTxt.Text = gonderenData.CurrentRow.Cells[2].Value.ToString();
            gonderentelTxt.Text = gonderenData.CurrentRow.Cells[3].Value.ToString();
            gonderenadresTxt.Text = gonderenData.CurrentRow.Cells[4].Value.ToString();
            gonderenmailTxt.Text = gonderenData.CurrentRow.Cells[5].Value.ToString();
        }

        private void aliciData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aliciData.CurrentRow.Selected = true;
            aliciidTxt.Text = aliciData.CurrentRow.Cells[0].Value.ToString();
            aliciadTxt.Text = aliciData.CurrentRow.Cells[1].Value.ToString();
            alicisoyadTxt.Text = aliciData.CurrentRow.Cells[2].Value.ToString();
            alicitelTxt.Text = aliciData.CurrentRow.Cells[3].Value.ToString();
            aliciadresTxt.Text = aliciData.CurrentRow.Cells[4].Value.ToString();


        }

        private void yksubeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            yksubeData.CurrentRow.Selected = true;
            yksubeTxt.Text = yksubeData.CurrentRow.Cells[0].Value.ToString();
        }

        private void gonderenduzenlePic_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand guncelle = new NpgsqlCommand("update gonderen set ad=@p2,soyad=@p3,telefon=@p4,adres=@p5,mail=@p6 where gonderen_id=@p1", baglanti);

            guncelle.Parameters.AddWithValue("@p1", int.Parse(gonderenidTxt.Text));
            guncelle.Parameters.AddWithValue("@p2", gonderenadTxt.Text);
            guncelle.Parameters.AddWithValue("@p3", gonderensoyadTxt.Text);
            guncelle.Parameters.AddWithValue("@p4", gonderentelTxt.Text);
            guncelle.Parameters.AddWithValue("@p5", gonderenadresTxt.Text);
            guncelle.Parameters.AddWithValue("@p6", gonderenmailTxt.Text);
            guncelle.ExecuteNonQuery();

           

            baglanti.Close();

            gonderenListele();
        }

        private void aliciduzenlePic_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand guncelle = new NpgsqlCommand("update alici set ad=@p2,soyad=@p3,telefon=@p4,adres=@p5 where alici_id=@p1", baglanti);

            guncelle.Parameters.AddWithValue("@p1", int.Parse(aliciidTxt.Text));
            guncelle.Parameters.AddWithValue("@p2", aliciadTxt.Text);
            guncelle.Parameters.AddWithValue("@p3", alicisoyadTxt.Text);
            guncelle.Parameters.AddWithValue("@p4", alicitelTxt.Text);
            guncelle.Parameters.AddWithValue("@p5", aliciadresTxt.Text);

            guncelle.ExecuteNonQuery();



            baglanti.Close();

            aliciListele();
        }

        private void gonderesilPic_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand silme = new NpgsqlCommand("Delete from gonderen where gonderen_id=@p1", baglanti);
            silme.Parameters.AddWithValue("@p1", int.Parse(gonderenidTxt.Text));
            silme.ExecuteNonQuery();
            baglanti.Close();
            gonderenListele();
        }

        private void alicisilPic_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand silme = new NpgsqlCommand("Delete from alici where alici_id=@p1", baglanti);
            silme.Parameters.AddWithValue("@p1", int.Parse(aliciidTxt.Text));
            silme.ExecuteNonQuery();
            baglanti.Close();
            aliciListele();
        }

        private void ykKayit_Click(object sender, EventArgs e)
        {

            baglanti.Open();


            NpgsqlCommand ekle = new NpgsqlCommand("insert into kargo (kargo_id,gonderen_id,alici_id,kurye_id,sube_id,fiyat_id,odeme_id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);

            ekle.Parameters.AddWithValue("@p1", int.Parse(ykkargoidTxt.Text));
            ekle.Parameters.AddWithValue("@p2", int.Parse(ykgonderenTxt.Text));
            ekle.Parameters.AddWithValue("@p3", int.Parse(ykaliciTxt.Text));
            ekle.Parameters.AddWithValue("@p4", int.Parse(ykkuryeTxt.Text));
            ekle.Parameters.AddWithValue("@p5", int.Parse(yksubeTxt.Text));
            ekle.Parameters.AddWithValue("@p6", int.Parse(ykfiyatTxt.Text));
            ekle.Parameters.AddWithValue("@p7", int.Parse(ykodemeTxt.Text));

            ekle.ExecuteNonQuery();

            baglanti.Close();

            kargoListele();


        }

        private void ykgonderenData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ykgonderenData.CurrentRow.Selected = true;
            ykgonderenTxt.Text = ykgonderenData.CurrentRow.Cells[0].Value.ToString();
        }

        private void ykaliciData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ykaliciData.CurrentRow.Selected = true;
            ykaliciTxt.Text = ykaliciData.CurrentRow.Cells[0].Value.ToString();
        }

        private void ykkuryeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ykkuryeData.CurrentRow.Selected = true;
            ykkuryeTxt.Text = ykkuryeData.CurrentRow.Cells[0].Value.ToString();
        }

        private void ykfiyatData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ykfiyatData.CurrentRow.Selected = true;
            ykfiyatTxt.Text = ykfiyatData.CurrentRow.Cells[0].Value.ToString();
        }

        private void ykodemeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ykodemeData.CurrentRow.Selected = true;
            ykodemeTxt.Text = ykodemeData.CurrentRow.Cells[0].Value.ToString();
        }

        private void kargoData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kargoData.CurrentRow.Selected = true;
            kargoidTxt.Text = kargoData.CurrentRow.Cells[0].Value.ToString();
            kargoid2Txt.Text= kargoData.CurrentRow.Cells[0].Value.ToString();
            gonderenid2Txt.Text= kargoData.CurrentRow.Cells[5].Value.ToString();
        }

        private void kargoGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand guncellekargo = new NpgsqlCommand("update kargo set son_durum=@p2,islem_tarihi=@p3 where kargo_id=@p1", baglanti);

            guncellekargo.Parameters.AddWithValue("@p1", int.Parse(kargoidTxt.Text));
            guncellekargo.Parameters.AddWithValue("@p2", durumTxt.Text);
            guncellekargo.Parameters.AddWithValue("@p3", Convert.ToDateTime(islemtarihiTxt.Text));

            guncellekargo.ExecuteNonQuery();



            baglanti.Close();

            kargoListele();

        }

        private void faturaOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand eklefatura = new NpgsqlCommand("insert into fatura (fatura_id,kargo_id,gonderen_id,toplam_ucret) values (@p1,@p2,@p3,@p4)", baglanti);

            eklefatura.Parameters.AddWithValue("@p1", int.Parse(faturaidTxt.Text));
            eklefatura.Parameters.AddWithValue("@p2", int.Parse(kargoid2Txt.Text));
            eklefatura.Parameters.AddWithValue("@p3", int.Parse(gonderenid2Txt.Text));
            eklefatura.Parameters.AddWithValue("@p4", int.Parse(toplamfiyatTxt.Text));

            MessageBox.Show("Fatura Oluşturuldu.", "Fatura Oluştur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            eklefatura.ExecuteNonQuery();

            baglanti.Close();

            faturaListele();
        }
    }

    
}
