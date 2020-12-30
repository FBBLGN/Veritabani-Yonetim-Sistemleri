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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KargoSirketi; user ID=postgres ; password=1234");

        private void gkayitBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand ekleGonderen = new NpgsqlCommand("insert into gonderen (gonderen_id,ad,soyad,telefon,mail,adres) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            ekleGonderen.Parameters.AddWithValue("@p1", int.Parse(gidTxt.Text));
            ekleGonderen.Parameters.AddWithValue("@p2", gadTxt.Text);
            ekleGonderen.Parameters.AddWithValue("@p3", gsoyadTxt.Text);
            ekleGonderen.Parameters.AddWithValue("@p4", gtelTxt.Text);
            ekleGonderen.Parameters.AddWithValue("@p5", gmailTxt.Text);
            ekleGonderen.Parameters.AddWithValue("@p6", gadresTxt.Text);

            MessageBox.Show("Gönderici Eklendi.", "Ekle Gönderici", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ekleGonderen.ExecuteNonQuery();

            baglanti.Close();
        }

        private void ygirisBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from yonetici where mail='" + ymailTxt.Text+"' and sifre='" + ysifreTxt.Text+"'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Giriniz");
            }
        }

        private void Sorgula_Click(object sender, EventArgs e)
        {

                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Show();


        }

        private void uyeolBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand ekleAlici = new NpgsqlCommand("insert into alici (alici_id,ad,soyad,telefon,adres) values (@p1,@p2,@p3,@p4,@p5)", baglanti);

            ekleAlici.Parameters.AddWithValue("@p1", int.Parse(idTxt.Text));
            ekleAlici.Parameters.AddWithValue("@p2", adTxt.Text);
            ekleAlici.Parameters.AddWithValue("@p3", soyadTxt.Text);
            ekleAlici.Parameters.AddWithValue("@p4", telTxt.Text);
            ekleAlici.Parameters.AddWithValue("@p5", adresTxt.Text);


            MessageBox.Show("Alıcı Eklendi.", "Ekle Alıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ekleAlici.ExecuteNonQuery();

            baglanti.Close();
        }
    }
}
