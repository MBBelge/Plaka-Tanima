using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PlakaTanima
{
    public partial class KayitSil : Form
    {
        public KayitSil()
        {
            InitializeComponent();
        }

        OleDbDataAdapter da;
        OleDbConnection con;
        OleDbCommand cmd;

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Plaka alanının dolu olmasını kontrol eder
            if (tbPlaka.Text == "")
            {
                MessageBox.Show("Alanı Doldurun!");
            }
            else
            {
                //Plaka alanı doluysa silme işlemi yapar.
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PlakaTanima.accdb");
                    con.Open();
                    cmd = new OleDbCommand("Delete from Plakalar WHERE Plaka = @Plaka", con);
                    cmd.Parameters.Add("@Plaka", tbPlaka.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    con.Dispose();
                    MessageBox.Show("Kayıt Başarıyla Silindi");
            }
                catch
            {
                MessageBox.Show("Veritabanı hatası!");
            }
        }
        }
    }
}
