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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=KargoSirketi; user ID=postgres ; password=1234");




        private void gonderisorgulaBtn_Click(object sender, EventArgs e)
        {
            if (gonderitakipidTxt.Text !="")
            {
                baglanti.Open();
                string sorgulagonderi = "select * from kargo where kargo_id='" + gonderitakipidTxt.Text + "'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgulagonderi, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                kargoData2.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Gönderi Takip Numaranızı Giriniz", "Gönderi Takip", MessageBoxButtons.OK);
            }
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
