using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vektorel.Web.KitapBankosuApp.Models
{
    //[Table("tblYazarlar")]
    public class Yazar
    {
        public int YazarId { get; set; }
        //[Column(TypeName ="varchar")]
        //[MaxLength(50)]
        //[Required]
        public string YazarAd { get; set; }
        //[Column(TypeName = "varchar")]
        //[MaxLength(50)]
        //[Required]
        public string YazarSoyad { get; set; }
        public DateTime DogumTarih { get; set; }
    }
}