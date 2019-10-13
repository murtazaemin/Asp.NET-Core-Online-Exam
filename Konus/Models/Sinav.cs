using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Konus.Models
{
    public class Sinav
    {
        public int Id { get; set; }     
        public string Baslik { get; set; }     
        public string Yazi { get; set; }
        public string Tarih { get; set; }
    
    }
}
