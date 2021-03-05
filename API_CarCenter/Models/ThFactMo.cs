using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThFactMo
    {
        public int IdFactMo { get; set; }
        public int? IdFactura { get; set; }
        public int? IdHistMo { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? ValBruto { get; set; }
        public decimal? ValDescto { get; set; }
        public decimal? PorIva { get; set; }
        public decimal? ValIva { get; set; }
        public decimal? PorReteiva { get; set; }
        public decimal? ValReteiva { get; set; }
        public decimal? PorRetefte { get; set; }
        public decimal? ValRetefte { get; set; }
        public decimal? ValNeto { get; set; }

        public virtual ThFactCab IdFacturaNavigation { get; set; }
        public virtual ThHistMo IdHistMoNavigation { get; set; }
    }
}
