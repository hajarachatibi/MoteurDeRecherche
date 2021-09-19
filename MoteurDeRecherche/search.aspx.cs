using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoteurDeRecherche
{
    public partial class search : System.Web.UI.Page
    {
        public static string txt = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            txt = txtsearch.Text;
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            txt = txtsearch.Text;
            Response.Redirect("link.aspx");
        }
        public string value
        {
            get { return txt; }
        }
    }
}