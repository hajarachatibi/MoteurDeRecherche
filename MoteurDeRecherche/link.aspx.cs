using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MoteurDeRecherche;
using System.Web.UI.HtmlControls;
using System.Data.Entity;
using System.Windows.Documents;
using System.Data.Linq;
using System.Web.DynamicData;

namespace MoteurDeRecherche
{
    public partial class link : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["MydatabaseConnectionString"].ConnectionString + ";MultipleActiveResultSets=true";
        search sr = new search();
        String word = "";
        DCDataContext dc = new DCDataContext();
        List<LinkButton> myLinks;
        protected void Page_Load(object sender, EventArgs e)
        {
            word = sr.value;
            Affichage(word);
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            myLinks.Clear();
            Response.Redirect("search.aspx");
        }
        private void Affichage(String txt)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                myLinks = new List<LinkButton>();
                SqlDataAdapter da = new SqlDataAdapter("select mr.titre FROM (SELECT top 100 percent Lien.titre, COUNT(Recherche.IdLien) AS nb FROM Lien LEFT JOIN Recherche ON Lien.IdLien = Recherche.IdLien WHERE titre LIKE '%" + txt + "%' GROUP BY Lien.titre ) AS mr ORDER BY nb desc", con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlDataReader reader = da.SelectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Object[] values = new Object[reader.FieldCount];
                    int nb = reader.GetValues(values);
                    for (int i = 0; i < nb; i++)
                    {

                        SqlDataAdapter da1 = new SqlDataAdapter("select URL from Lien where titre = '" + (string)reader.GetValue(i) + "'", con);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);
                        SqlDataReader reader1 = da1.SelectCommand.ExecuteReader();
                        reader1.Read();
                        string url = (string)reader1.GetValue(i);
                        reader1.Close();
                        LinkButton link = new LinkButton();
                        string myword = (string)reader.GetValue(i);
                        link.Text = myword;
                        link.Visible = true;
                        myLinks.Add(link);
                        repLinks.DataSource = myLinks;
                        repLinks.DataBind();
                    }
                }
                reader.Close();
                if (myLinks.Count != 0)

                {
                    SqlDataAdapter da2 = new SqlDataAdapter("if not exists (select * From Mot where Text = '" + txt + "') insert into Mot (Text) VALUES ('" + txt + "') ", con);
                    da2.Fill(ds);
                    lblerror.Visible = false;
                    lblresult.Visible = true;


                }
                else
                {
                    lblerror.Visible = true;
                    lblresult.Visible = false;

                }
            }
        }

        protected void repLinks_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                switch (e.CommandName)
                {
                    case "Click":
                        string clickedlink = e.CommandArgument.ToString();
                        SqlDataAdapter da3 = new SqlDataAdapter("select URL from Lien where titre = '" + clickedlink + "'", conn);
                        conn.Open();
                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3);
                        SqlDataReader readertest = da3.SelectCommand.ExecuteReader();
                        readertest.Read();
                        string url = (string)readertest.GetValue(0);
                        readertest.Close();
                        SqlDataAdapter da4 = new SqlDataAdapter("if not exists (select top 1 IdMot, IdLien from Recherche where IdMot = (select top 1 IdMot from Mot where Text = '" + clickedlink + "') AND IdLien =  (select top 1 IdLien from Lien where URL LIKE '%" + url + "%')) insert into Recherche (IdMot, IdLien) values ((select top 1 IdMot from Mot where Text = '" + clickedlink + "'), (select top 1 IdLien from Lien where URL LIKE '%" + url + "%'))", conn);
                        da4.Fill(ds3);
                        SqlDataAdapter da5 = new SqlDataAdapter("insert into Historique (Date, IdSearch) values ('" + DateTime.UtcNow.Date.ToString("yyyy-MM-dd") + "', (select top 1 IdSearch from Recherche where IdMot = (select top 1 IdMot from Mot where Text = '" + clickedlink + "') AND IdLien =  (select top 1 IdLien from Lien where URL LIKE '%" + url + "%')))", conn);
                        da5.Fill(ds3);
                        Response.Redirect(url);
                    break;
                }

            }
        }
    }
}