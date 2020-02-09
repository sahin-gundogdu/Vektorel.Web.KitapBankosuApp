using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vektorel.Web.KitapBankosuApp.Models
{
    public class YazarViewModel
    {
        public IEnumerable<Yazar> Yazarlar { get; set; }
        public Yazar Yazar { get; set; }
    }
}