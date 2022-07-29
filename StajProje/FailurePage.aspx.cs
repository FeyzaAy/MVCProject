using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using StajProje.ProjectClasses;
using StajProje.DataServices;

namespace StajProje
{
    public partial class FailurePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadGridDataArizalar();
        }
        protected void LoadGridDataArizalar()
        {
            ServiceReference1.WebServiceKatodikSoapClient client = new ServiceReference1.WebServiceKatodikSoapClient();


            ServiceReference1.AuthHeader ah = new ServiceReference1.AuthHeader();



            ah.UserName = "stajer";

            ah.Password = "Stajer2022$$";



            DataTable dtListe = new DataTable();

            dtListe = client.TumArizaGetir(ah);

            gvArizalar.DataSource = dtListe;
            gvArizalar.DataBind();

            dbClass dbClass = new dbClass();

            ArizaServices arizaServices = new ArizaServices();

            foreach(DataRow dr in dtListe.Rows)
            {
                Failure failure = new Failure();

                failure.IID = Convert.ToInt32(dr["IID"]);
                failure.Name = dr["Name"].ToString();
                failure.ParentIID = Convert.ToInt32(dr["ParentIID"]);
                failure.Type = dr["Type"].ToString();
                failure.Value = dr["Value"].ToString();

                if (dr["UNIT"]!= null)
                    failure.Unit = dr["UNIT"].ToString();
                else
                    failure.Unit = "";

                failure.Quality = dr["QUALITY"].ToString();
                failure.Time_Stamp = Convert.ToDateTime(dr["TIME_STAMP"]);
                failure.TypeIID = Convert.ToInt32(dr["TypeIID"]);
                failure.ObjectID = dr["ObjectID"].ToString();

                string mesaj = arizaServices.AddAriza(failure);
            }


        }
        protected void grdData_PageIndexChanging_Arizalar(object sender, GridViewPageEventArgs e)
        {
            gvArizalar.PageIndex = e.NewPageIndex;
            LoadGridDataArizalar();
        }
    }
}