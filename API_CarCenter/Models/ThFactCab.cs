using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThFactCab
    {
        public ThFactCab()
        {
            ThFactMos = new HashSet<ThFactMo>();
            ThFactProds = new HashSet<ThFactProd>();
        }

        public int IdFactura { get; set; }
        public DateTime? FecFactura { get; set; }
        public DateTime? FecVencim { get; set; }
        public int? IdTaller { get; set; }
        public int? IdCliente { get; set; }
        public int? IdHistVehic { get; set; }
        public decimal? ValBrutoRep { get; set; }
        public decimal? ValBrutoMo { get; set; }
        public decimal? ValDesctoPrd { get; set; }
        public decimal? ValDesctoMo { get; set; }
        public decimal? ValNetoPrd { get; set; }
        public decimal? ValNetoMo { get; set; }
        public decimal? PorIva { get; set; }
        public decimal? ValIva { get; set; }
        public decimal? PorReteiva { get; set; }
        public decimal? ValReteiva { get; set; }
        public decimal? PorRetefte { get; set; }
        public decimal? ValRetefte { get; set; }
        public decimal? ValNeto { get; set; }

        public virtual ThCliente IdClienteNavigation { get; set; }
        public virtual ThHistVehic IdHistVehicNavigation { get; set; }
        public virtual TbTaller IdTallerNavigation { get; set; }
        public virtual ICollection<ThFactMo> ThFactMos { get; set; }
        public virtual ICollection<ThFactProd> ThFactProds { get; set; }
    }
}
