using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PlakaTanima
{
    public partial class KayitEkle : Form
    {
        public KayitEkle()
        {
            InitializeComponent();
        }

        OleDbDataAdapter da;
        OleDbConnection con;
        OleDbCommand cmd;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Alanların hepsinin dolu olmasını kontrol eder
            if (tbPlaka.Text == "" || tbSahibi.Text == "" || cbDurum.Text == "")
            {
                MessageBox.Show("Alanların Hepsini Doldurun!");
            }
            else {
                try
                {
                    //Alanların hepsi doluysa ekleme işlemi yapar
                    con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PlakaTanima.accdb");
                    da = new OleDbDataAdapter("Select * from Plakalar", con);
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into Plakalar (Plaka,Sahibi,Durum,Eklenme_Tarihi) values ('" + tbPlaka.Text.ToString() + "','" + tbSahibi.Text.ToString() + "','" + cbDurum.Text.ToString() + "','" + System.DateTime.Now + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Başarıyla Eklendi!");
                }
                catch
                {
                    MessageBox.Show("HATA!");
                }
           }
        }
    }
}
