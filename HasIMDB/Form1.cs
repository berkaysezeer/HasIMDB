using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HasIMDB
{
    public partial class Form1 : Form
    {
        private string dbName = "HasImdb";
        private SqlConnection con = new SqlConnection("server=.; database=master; uid=sa; pwd=123; Trusted_Connection=yes");
        private List<Film> filmler;

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

            filmler = new List<Film>();

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

            pboPhoto.Image = film.Foto;
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
                //puani ve resmi guncelle

                var cmd = new SqlCommand("UPDATE Filmler SET FilmAd=@p1 WHERE Id= @p4 ", con);
                cmd.Parameters.AddWithValue("@p1", film.FilmAd);
                cmd.Parameters.AddWithValue("@p4", film.Id);
                lstFilmler.Refresh();
                cmd.ExecuteNonQuery();
            }
        }
    }
}