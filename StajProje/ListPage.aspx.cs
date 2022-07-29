using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StajProje
{
    public partial class ListPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadGridDataListe();
        }
        void LoadGridDataListe()
        {
            ServiceReference1.WebServiceKatodikSoapClient client = new ServiceReference1.WebServiceKatodikSoapClient();



            ServiceReference1.AuthHeader ah = new ServiceReference1.AuthHeader();



            ah.UserName = "stajer";

            ah.Password = "Stajer2022$$";



            DataTable dtListe = new DataTable();

            dtListe = client.ListeGetir(ah);

            gvListe.DataSource = dtListe;
            gvListe.DataBind();


        }
        protected void grdData_PageIndexChanging_Liste(object sender, GridViewPageEventArgs e)
        {
            gvListe.PageIndex = e.NewPageIndex;
            LoadGridDataListe();
        }
    }
}