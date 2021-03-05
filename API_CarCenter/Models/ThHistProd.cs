using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThHistProd
    {
        public ThHistProd()
        {
            ThFactProds = new HashSet<ThFactProd>();
        }

        public int IdHistProd { get; set; }
        public int? IdHistVehic { get; set; }
        public int? IdProd { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ValMin { get; set; }
        public decimal? ValMax { get; set; }
        public decimal? PrecioAutoriz { get; set; }
        public decimal? PorDescto { get; set; }
        public decimal? ValDescto { get; set; }
        public int? AutorizaDescto { get; set; }
        public string Detalle { get; set; }

        public virtual TbProducto IdProdNavigation { get; set; }
        public virtual ICollection<ThFactProd> ThFactProds { get; set; }
    }
}
