using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StajProje.ProjectClasses
{
    public class StationFailure
    {
        public string IstasyonAdi { get; set; }

        public string Sube { get; set; }
        public decimal Enlem { get; set; }
        public decimal Boylam { get; set; }

        public int parentID { get; set; }
        public string Tip { get; set; }


        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
        public string Quality { get; set; }
        public DateTime Time_Stamp { get; set; }

        public int TypeIID { get; set; }
        public string ObjectID { get; set; }

        public int IID { get; set; }
    }
}