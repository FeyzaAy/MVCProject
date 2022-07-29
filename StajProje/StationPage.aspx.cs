using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StajProje.ProjectClasses;
using StajProje.DataServices;


namespace StajProje
{
    public partial class StationPage : Page
    {
        DataTable dtListe = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadGridDataIstasyon();

        }
        protected void LoadGridDataIstasyon()
        {
            ServiceReference1.WebServiceKatodikSoapClient client = new ServiceReference1.WebServiceKatodikSoapClient();
            ServiceReference1.AuthHeader ah = new ServiceReference1.AuthHeader();

            ah.UserName = "stajer";

            ah.Password = "Stajer2022$$";

            dbClass dbClass = new dbClass();

            DataTable dtistasyon = client.istasyonGetir(ah);

            dtListe = client.ListeGetir(ah);

            ArizaServices arizaServices = new ArizaServices();

            List<Station> istasyonlar = arizaServices.GetAllIstasyon();

            foreach (DataRow dr in dtistasyon.Rows)
            {

               int count = istasyonlar.Where(obj => obj.IstasyonAdi.Trim() == dr["IstasyonAdi"].ToString().Trim()).ToList().Count;

                if(count== 0)
                {
                   int parentID = getParentID(dr["IstasyonAdi"].ToString());
               
                   if(parentID != -1)
                   {
                        Station station = new Station();

                        station.IstasyonAdi = dr["IstasyonAdi"].ToString();
                        station.Sube = dr["Sube"].ToString();
                        station.Enlem = Convert.ToDecimal(dr["Enlem"]);
                        station.Boylam = Convert.ToDecimal(dr["Boylam"]);
                        station.Tip = dr["Tip"].ToString();
                        station.parentID=parentID;


                        string mesaj =arizaServices.AddIstasyon(station);
                   }
                }
            }

            gvIstasyonlar.DataSource = dtistasyon;
            gvIstasyonlar.DataBind();

        }

        private int getParentID(string stationName)
        {
            foreach(DataRow dr in dtListe.Rows)
            {
                if (dr["SIGNAL"].ToString().IndexOf(stationName) > -1)
                {
                    return Convert.ToInt32(dr["Parent_ID"]);
                }
            }

            return -1;
        }
        protected void grdData_PageIndexChanging_Istasyon(object sender, GridViewPageEventArgs e)
        {
            gvIstasyonlar.PageIndex = e.NewPageIndex;
            LoadGridDataIstasyon();
        }
    }
}