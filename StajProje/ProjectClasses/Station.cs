using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StajProje.ProjectClasses
{
    public class Station
    {
        [Key]
        public string IstasyonAdi { get; set; }        
        public string Sube { get; set; }
        public decimal Enlem { get; set; }
        public decimal Boylam { get; set; }
        public string Tip { get; set; }
        public int parentID { get; set; }
    }
}