using StajProje.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StajProje.DataServices
{
    public class ArizaServices
    {
        #region Ariza
        public List<Station> GetAllIstasyon()
        {

            dbClass dbClass = new dbClass();
            return dbClass.Stations.ToList();


        }

        public List<Station> GetIstasyonByParentID(int ParentID)
        {

            dbClass dbClass = new dbClass();
            return dbClass.Stations.Where(x => x.parentID == ParentID).ToList();


        }

        public string AddIstasyon(Station station)
        {
            String ResultMessage = String.Empty;
            try
            {
                dbClass dbClass = new dbClass();
                dbClass.Stations.Add(station);
                dbClass.SaveChanges();

            }

            catch (Exception ex)
            {
                ResultMessage = ex.Message.ToString();

            }

            return ResultMessage;
        }
        public string AddAriza(Failure failure)
        {
            String ResultMessage = String.Empty;
            try
            {
                dbClass dbClass = new dbClass();
                dbClass.Failures.Add(failure);
                dbClass.SaveChanges();

            }

            catch (Exception ex)
            {
                ResultMessage = ex.Message.ToString();

            }

            return ResultMessage;
        }

        public string DeleteIstasyonAriza(Station station)
        {
            String ResultMessage = String.Empty;
            try
            {
                dbClass dbClass = new dbClass();
                dbClass.Stations.Remove(station);
                dbClass.SaveChanges();

            }

            catch (Exception ex)
            {
                ResultMessage = ex.Message.ToString();

            }

            return ResultMessage;
        }

        #endregion


        #region StationFailure

        //public List<StationFailure> GetStationFailures()
        //{

        //    dbClass dbClass = new dbClass();

        //    var stationfailures = (from station in dbClass.Stations
        //                           join failures in dbClass.Failures on station.parentID equals failures.ParentIID
        //                           select new StationFailure
        //                           {
        //                               IstasyonAdi = station.IstasyonAdi,
        //                               Sube = station.Sube,
        //                               Enlem = station.Enlem,
        //                               Boylam = station.Boylam,
        //                               Tip = station.Tip


        //                           }).ToList();

        //    return stationfailures;

        //}

        #endregion
    }
}