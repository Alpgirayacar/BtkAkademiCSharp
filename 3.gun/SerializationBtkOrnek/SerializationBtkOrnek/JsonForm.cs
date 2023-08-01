using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializationBtkOrnek
{
    public partial class JsonForm : Form
    {
        public JsonForm()
        {
            InitializeComponent();
        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpireDate = new DateTime(2008, 12, 28);

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Documents\btkakademi\json.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
                MessageBox.Show("Serialize Edildİ");
            }
        }

        private void btnJsonOku_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(@"C:\Users\Administrator\Documents\btkakademi\json.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product product = (Product)serializer.Deserialize(reader, typeof(Product));
                MessageBox.Show(product.Name);

            }
        }
    }
}
