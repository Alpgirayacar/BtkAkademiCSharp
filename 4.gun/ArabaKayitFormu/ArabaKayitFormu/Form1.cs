using Microsoft.Data.SqlClient;
using System.Data;

namespace ArabaKayitFormu
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\okul;Initial Catalog=BtkDatabase;Integrated Security=SSPI;";
        int secilenMarkaTipi = 0;
        int secilenModelTipi = 0;
        int secilenKasaTipi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //sayfa yüklendiðin ilk çalýþmasýný istediðimiz 
        private void Form1_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            KasaGetir();
            ArabalariGetir();
        }

        public void MarkaGetir()
        {
            List<Marka> markaList = new List<Marka>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select * from Marka", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    Marka m = new Marka
                    {
                        Id = -1,
                        MarkaAdi = " Marka Seçiniz"
                    };
                    markaList.Add(m);
                    while (reader.Read())
                    {

                        markaList.Add(new Marka
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            MarkaAdi = reader["MarkaAdi"].ToString()
                        });
                    }
                    cmbMarka.DataSource = markaList;
                    cmbMarka.DisplayMember = "MarkaAdi";
                    cmbMarka.ValueMember = "Id";
                    conn.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {

                }

            }


        }

        public void ModelGetir(int markaId)
        {
            List<Model> modelList = new List<Model>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    cmbModel.Items.Clear();
                    SqlCommand command = new SqlCommand("select * from Model where MarkaId=" + markaId, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    Model m = new Model
                    {
                        Id = -1,
                        ModelAdi = " Model Seçiniz"
                    };
                    modelList.Add(m);
                    while (reader.Read())
                    {

                        modelList.Add(new Model
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            ModelAdi = reader["ModelAdi"].ToString()
                        });
                    }
                    cmbModel.DataSource = modelList;
                    cmbModel.DisplayMember = "ModelAdi";
                    cmbModel.ValueMember = "Id";
                    conn.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {

                }

            }

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            Marka marka = (Marka)cmbMarka.SelectedItem;
            secilenMarkaTipi = marka.Id;
            if (secilenMarkaTipi > 0)
            {
                ModelGetir(secilenMarkaTipi);
            }


        }

        public void KasaGetir()
        {
            List<Kasa> kasaList = new List<Kasa>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select * from Kasa", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    Kasa k = new Kasa
                    {
                        Id = -1,
                        KasaTipi = " Kasa Seçiniz"
                    };
                    kasaList.Add(k);
                    while (reader.Read())
                    {

                        kasaList.Add(new Kasa
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            KasaTipi = reader["KasaTipi"].ToString()
                        });
                    }
                    cmbKasa.DataSource = kasaList;
                    cmbKasa.DisplayMember = "KasaTipi";
                    cmbKasa.ValueMember = "Id";
                    conn.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {

                }

            }


        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("insert into Araba(MarkaId,ModelId,KasaId,KapiSayisi,PencereSayisi) values('" + secilenMarkaTipi + "','" + secilenModelTipi + "','" + secilenKasaTipi + "','" + txtKapiSayisi.Text + "','" + txtPencereSayisi.Text + "')", conn);
                   
                    //SqlCommand cmd = new SqlCommand($"insert into Araba(MarkaId,ModelId,KapiSayisi,PencereSayisi,KasaId) values('{MarkaID}','{ModelID}','{txtKapi.Text}','{txtPencere.Text}','{KasaID}')", connection);

                    int etkilenenKayitSayis = command.ExecuteNonQuery();
                    if (etkilenenKayitSayis > 0)
                    {
                        MessageBox.Show("Kayýt Eklenmiþtir");
                        ArabalariGetir();
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }


            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model model = (Model)cmbModel.SelectedItem;
            secilenModelTipi = model.Id;
        }

        private void cmbKasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kasa kasa = (Kasa)cmbKasa.SelectedItem;
            secilenKasaTipi = kasa.Id;
        }

        public void ArabalariGetir()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sorgu = "select Marka.MarkaAdi,MO.ModelAdi,K.KasaTipi,A.KapiSayisi,A.PencereSayisi from Araba as A\r\ninner join Marka \r\non Marka.Id= A.MarkaId\r\ninner join Model  MO\r\non MO.Id = A.ModelId\r\ninner join Kasa  K\r\non K.Id = A.KasaID";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu,conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Arabalar");
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();

            }
        }
    }
}