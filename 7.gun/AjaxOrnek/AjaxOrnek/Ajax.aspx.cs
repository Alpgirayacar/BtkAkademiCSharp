using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxOrnek
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod]
        public static List<Product> YeniMetod(string abc)
        {
            List<Product> qDonus = new List<Product>();

            DataTable qTablo = new DataTable();
            string connectionString = "Data Source=(localdb)\\okul;Initial Catalog=BtkDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter qadap = new SqlDataAdapter(String.Format("SELECT * FROM TestTablo WHERE UrunAdi LIKE '%{0}%'", abc), connection.ConnectionString);
                    qadap.Fill(qTablo);
                    connection.Close();
                    foreach (DataRow dr in qTablo.Rows)
                    {
                        qDonus.Add(new Product
                        {
                            Id = Convert.ToInt32(dr["Id"].ToString()),
                            urunAdi = dr["UrunAdi"].ToString(),
                            resim = dr["Resim"].ToString(),
                            fiyat = Convert.ToInt32(dr["Fiyat"].ToString())
                        });
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
            return qDonus;
        }
    }
    
}