using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThInventario
    {
        public int IdInvent { get; set; }
        public int? IdTaller { get; set; }
        public int? IdProd { get; set; }
        public DateTime? FecMvto { get; set; }
        public decimal? CantEntra { get; set; }
        public decimal? CantSale { get; set; }
        public int? IdFactura { get; set; }
        public string Detalle { get; set; }

        public virtual TbProducto IdProdNavigation { get; set; }
        public virtual TbTaller IdTallerNavigation { get; set; }
    }
}
