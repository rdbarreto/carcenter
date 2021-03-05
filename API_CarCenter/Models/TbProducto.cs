using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class TbProducto
    {
        public TbProducto()
        {
            ThHistProds = new HashSet<ThHistProd>();
            ThInventarios = new HashSet<ThInventario>();
        }

        public int IdProd { get; set; }
        public int? IdTipoProd { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public decimal? ValMin { get; set; }
        public decimal? ValMax { get; set; }

        public virtual TbTipoProd IdTipoProdNavigation { get; set; }
        public virtual ICollection<ThHistProd> ThHistProds { get; set; }
        public virtual ICollection<ThInventario> ThInventarios { get; set; }
    }
}
