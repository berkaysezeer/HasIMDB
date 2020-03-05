using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace HasIMDB
{
    public partial class Form1 : Form
    {
        private string dbName = "HasImdb";
        private SqlConnection con = new SqlConnection("server=.; database=master; uid=sa; pwd=123; Trusted_Connection=yes");
        private BindingList<Film> filmler;

        private bool guncellemeAktif = false;

        public Form1()
        {
            con.Open();
            VeritabaniOlustur();
            InitializeComponent();
            FilmlerListele();
        }

        private void FilmlerListele()
        {
            guncellemeAktif = false;

            var cmd = new SqlCommand("SELECT * FROM Filmler", con);
            var dr = cmd.ExecuteReader();

            filmler = new BindingList<Film>();

            while (dr.Read())
            {
                filmler.Add(new Film
                {
                    Id = (int)dr["Id"],
                    FilmAd = (string)dr["FilmAd"],
                    Puan = dr["Puan"] as int?,
                    Foto = ConvertToImage(dr["Foto"] as byte[])
                });
            }

            dr.Close();
            lstFilmler.DataSource = filmler;
            //pboPhoto.Image = filmler[0].Foto;
            guncellemeAktif = true;
        }

        private void VeritabaniOlustur()
        {
            //veritabani var mi kontrol
            var cmd = new SqlCommand($"SELECT DB_ID('{dbName}')", con);
            short? dbId = cmd.ExecuteScalar() as short?; //as ile donusturduk -- null ise de degiskene atar

            if (!dbId.HasValue)
            {
                cmd = new SqlCommand($"CREATE DATABASE {dbName};", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(
                    $"USE {dbName};" +
                    @"CREATE TABLE Filmler
                        (
                            Id INT PRIMARY KEY IDENTITY,
                            FilmAd NVARCHAR(200) NOT NULL,
                            Puan INT NULL,
                            Foto VARBINARY(MAX) NULL
                        );
                    ", con);

                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand($"USE {dbName}", con);
                cmd.ExecuteNonQuery();
            }
        }

        private Image ConvertToImage(byte[] data)
        {
            if (data == null) return null;

            return (Image)new ImageConverter().ConvertFrom(data);
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            int id = YeniFilmEkle();
            FilmlerListele();

            //foreach (var item in lstFilmler.Items)
            //{
            //    Film film = (Film)item;
            //    if (film.Id == id)
            //    {
            //        lstFilmler.SelectedItem = item;
            //        break;
            //    }
            //}

            lstFilmler.SelectedValue = id; //valuemember
        }

        private int YeniFilmEkle()
        {
            var cmd = new SqlCommand("INSERT INTO Filmler(FilmAd) VALUES(N'Yeni Film'); SELECT SCOPE_IDENTITY();", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void lstFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1) return;

            guncellemeAktif = false;

            Film film = (Film)lstFilmler.SelectedItem;

            txtFilmAd.Text = film.FilmAd;
            txtFilmId.Text = film.Id.ToString();
            pboPhoto.Image = film.Foto;

            #region Puanları Göster

            if (film.Puan == null)
                rbPuanYok.Checked = true;
            else
            {
                //foreach (Control control in gboPuan.Controls)
                //{
                //    if (control is RadioButton && control.Tag != null && control.Tag.ToString() == film.Puan.ToString())
                //    {
                //        ((RadioButton)control).Checked = true;
                //        break;
                //    }
                //}

                RadioButton[] rbDizi = { rbPuanYok, rbPuan1, rbPuan2, rbPuan3, rbPuan4, rbPuan5 };
                rbDizi[film.Puan.Value].Checked = true;
            }

            #endregion Puanları Göster
            guncellemeAktif = true;
        }

        private void txtFilmAd_TextChanged(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (guncellemeAktif && lstFilmler.SelectedIndex > -1)
            {
                Film film = (Film)lstFilmler.SelectedItem;
                film.FilmAd = txtFilmAd.Text;
                film.Puan = SeciliPuan();
                film.Foto = pboPhoto.Image;
                //puani ve resmi guncelle

                var cmd = new SqlCommand("UPDATE Filmler SET FilmAd=@p1, Puan=@p2, Foto=@p3 WHERE Id= @p4 ", con);
                cmd.Parameters.AddWithValue("@p1", film.FilmAd);
                cmd.Parameters.AddWithValue("@p2", (object)film.Puan ?? DBNull.Value); //Tag'a null degerini verebilmek icin
                cmd.Parameters.AddWithValue("@p3", (object)ConvertToByteArray(film.Foto) ?? SqlBinary.Null);
                cmd.Parameters.AddWithValue("@p4", film.Id);
                cmd.ExecuteNonQuery();

                filmler.ResetBindings();
            }

        }

        private int? SeciliPuan()
        {
            RadioButton rb = null;

            foreach (var control in gboPuan.Controls)
            {
                if (control is RadioButton)
                {
                    rb = (RadioButton)control;
                    if (rb.Checked) //secili radiobutton'i bulur ve cikar
                        break;
                }
            }

            return rb.Tag == null ? null as int? : Convert.ToInt32(rb.Tag);
        }

        private void rbPuanYok_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) Guncelle(); //radiobutondan secimi kalkan ve secilen dahil ikisi etkileniyor. 
            //Bu kodu yazdigimizde secimi kalkan etkilenmez ( cunku checked false )
        }

        private void pboPhoto_Click(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1) return;

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pboPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                Guncelle();
            }
        }

        public byte[] ConvertToByteArray(Image image)
        {
            if (image == null) return null;

            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(image, typeof(byte[]));
            return xByte;
        }

        private void lstFilmler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete == lstFilmler.SelectedIndex > -1) //??
            {
                int sid = lstFilmler.SelectedIndex;
                Film film = (Film)lstFilmler.SelectedItem;
                filmler.Remove(film);
                FilmSil(film.Id);

                if (sid == lstFilmler.SelectedIndex)
                {
                    lstFilmler.SelectedIndex = -1;
                    lstFilmler.SelectedIndex = sid;
                }
                else if (lstFilmler.SelectedIndex == -1)
                {
                    FormuTemizle();
                }
            }
        }

        private void FormuTemizle()
        {
            txtFilmAd.Clear();
            txtFilmId.Clear();
            rbPuanYok.Checked = true;
            pboPhoto.Image = null;
        }

        private void FilmSil(int id)
        {
            var cmd = new SqlCommand($"DELETE FROM Filmler WHERE Id = {id}", con);
            cmd.ExecuteNonQuery();
        }

        private void txtFilmAd_Leave(object sender, EventArgs e)
        {
            if (txtFilmAd.Text.Trim() == "")
            {
                MessageBox.Show("Film Adı Girmediniz");
                txtFilmAd.Focus();
            }
        }
    }
}