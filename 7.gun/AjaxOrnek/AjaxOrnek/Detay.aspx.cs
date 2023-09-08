using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxOrnek
{
    public partial class Detay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelenId = Convert.ToInt32(Request.QueryString["Id"]);
            string urunAdi = Request.QueryString["Adi"];
            string urunResimUrl = Request.QueryString["urunResim"];
            int urunFiyat = Convert.ToInt32(Request.QueryString["urunFiyati"]);
            lblUrunAdi.Text = urunAdi;
            imgUrun.ImageUrl = urunResimUrl;
            lblUrunFiyati.Text = "" + urunFiyat + " TL ";
        }
    }
}