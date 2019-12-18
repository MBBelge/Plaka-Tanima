using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using openalprnet;
using System.Data;
using System.Data.OleDb;

namespace PlakaTanima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        //Dikdörtgen oluşturur
        public Rectangle boundingRectangle(List<Point> points)
        {

            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);

            return new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        //Fotoğrafı kırpar
        private static Image cropImage(Image img, Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        //Fotoğrafları birleştirir
        public static Bitmap combineImages(List<Image> images)
        {
            //Fotoğrafları belleğe yükle
            Bitmap finalImage = null;

            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }

                //Birleşik fotoğraf için bitmap oluştur
                finalImage = new Bitmap(width, height);

                using (var g = Graphics.FromImage(finalImage))
                {
                    //Arkaplan rengini ayarla
                    g.Clear(Color.Black);

                    //Bütün fotoğrafları tek resimde birleştir
                    var offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //Belleği boşalt
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }

        private void processImageFile(string fileName)
        {
            resetControls();

            //Bölge ayarı yap (Avrupa için "eu", Amerika için "us")
            var region = "eu";

            //OpenALPR ayar dosyalarını yükle
            String config_file = Path.Combine(AssemblyDirectory, "openalpr.conf");
            String runtime_data_dir = Path.Combine(AssemblyDirectory, "runtime_data");
            using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
            {
                if (!alpr.IsLoaded())
                {
                    MessageBox.Show("OpenALPR yüklenemedi!");
                    return;
                }

                //Fotoğraf yükleme
                fotoOrjinal.ImageLocation = fileName;
                fotoOrjinal.Load();

                //Resimleri klasöre kopyalama kodu. Erişim hatası veriyor.
                try
                {
                    var path = Path.Combine(
                    System.AppDomain.CurrentDomain.BaseDirectory,
                     "plakalar");
                    File.Copy(path, fileName);
                }
                catch
                {
                    MessageBox.Show("Erişim Hatası. Plaka fotoğrafı kaydedilemedi.");
                }
                
                //Fotoğraf ALPR kütüphanesi ile işlenir
                var results = alpr.Recognize(fileName);

                var images = new List<Image>(results.Plates.Count());

                foreach (var result in results.Plates)
                {
                    var rect = boundingRectangle(result.PlatePoints);
                    var img = Image.FromFile(fileName);
                    var cropped = cropImage(img, rect);
                    images.Add(cropped);

                    lblPlaka.Text = "";
                    lblSahibi.Text = "";
                    lblEklenme.Text = "";
                    lblSonKullanim.Text = "";
                    lblSonuc.Text = "Gecemez";

                    //En iyi tahmini gösterir
                    string plaka = result.BestPlate.Characters;
                    lblPlaka.Text = plaka;
                    
                    //Okunan plaka veritabanında aranır. Yoksa MessageBox ile hata mesajı verilir
                    try
                    {
                        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PlakaTanima.accdb"); con.Open();
                        OleDbCommand cmd = new OleDbCommand("Select Sahibi, Durum, Eklenme_Tarihi, Son_Kullanim from Plakalar where Plaka='" + lblPlaka.Text + "'", con);
                        OleDbDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lblSahibi.Text = dr["Sahibi"].ToString();
                            lblEklenme.Text = dr["Eklenme_Tarihi"].ToString();
                            lblSonKullanim.Text = dr["Son_Kullanim"].ToString();
                            lblSonuc.Text = dr["Durum"].ToString();
                            
                        };
                            con.Close();

                        //Plaka veritabanında yoksa hata mesajı verir
                        if(lblSahibi.Text == "")
                            {
                                MessageBox.Show("Plaka Bulunamadı!");
                                lblSonuc.Text = "Gecemez";
                            }
                        else
                        {
                            //Plaka veritabanında varsa en son okunduğu zaman güncellenir
                        con.Open();
                        cmd = new OleDbCommand("UPDATE Plakalar SET Son_Kullanim = @Son_Kullanim WHERE Plaka = @Plaka", con);
                        cmd.Parameters.Add("@Son_Kullanim", System.DateTime.Now.ToString());
                        cmd.Parameters.Add("@Plaka", lblPlaka.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        con.Dispose();
                    }
                        //Sonuc labelinin rengini kontrol eder
                        if (lblSonuc.Text == "Gecer")
                            {
                                lblSonuc.ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                lblSonuc.ForeColor = System.Drawing.Color.Red;
                            }

                        con.Close();
                }
                    catch
                {
                    MessageBox.Show("Veritabanı Hatası!");
                }

            }

                //Fotoğraf birleştrime
                if (images.Any())
                {
                    fotoPlaka.Image = combineImages(images);
                }
            }
        }

        private void resetControls()
        {
            fotoOrjinal.Image = null;
            fotoPlaka.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetControls();
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            if (dosyaSec.ShowDialog(this) == DialogResult.OK)
            {
                processImageFile(dosyaSec.FileName);
            }
            
        }

        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {
            var kayitekle = new KayitEkle();
            kayitekle.Show();
        }

        private void btnPlakaSil_Click(object sender, EventArgs e)
        {
            var kayitsil = new KayitSil();
            kayitsil.Show();
        }
    }
}