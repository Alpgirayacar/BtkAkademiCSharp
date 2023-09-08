using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxOrnek
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string adi =  Request.QueryString["adi"].ToString();
            Label1.Text = "Hoşgeldiniz : " + adi;
        }
    }
}