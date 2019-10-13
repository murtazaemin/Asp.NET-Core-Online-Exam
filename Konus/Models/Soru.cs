using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Konus.Models
{
    public class Soru
    {
        public int Id { get; set; }
        public int SinavId { get; set; }

        
        public string Soru1 { get; set; }

        
        public string Soru2 { get; set; }

       
        public string Soru3 { get; set; }

        
        public string Soru4 { get; set; }

       
        public string Cevap1a { get; set; }

        
        public string Cevap1b { get; set; }

       
        public string Cevap1c { get; set; }

        
        public string Cevap1d { get; set; }

        public string Cevap1 { get; set; }

        
        public string Cevap2a { get; set; }

        
        public string Cevap2b { get; set; }

        
        public string Cevap2c { get; set; }

        
        public string Cevap2d { get; set; }

        public string Cevap2 { get; set; }

      
        public string Cevap3a { get; set; }

     
        public string Cevap3b { get; set; }


        public string Cevap3c { get; set; }

        
        public string Cevap3d { get; set; }

        public string Cevap3 { get; set; }

       
        public string Cevap4a { get; set; }

        
        public string Cevap4b { get; set; }

       
        public string Cevap4c { get; set; }

       
        public string Cevap4d { get; set; }

        public string Cevap4 { get; set; }
    }
}
