using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThHistMo
    {
        public ThHistMo()
        {
            ThFactMos = new HashSet<ThFactMo>();
        }

        public int IdHistMo { get; set; }
        public int? IdHistVehic { get; set; }
        public int? IdPerso { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ValMinHora { get; set; }
        public decimal? ValMaxHora { get; set; }
        public decimal? PrecioAutoriz { get; set; }
        public decimal? PorDescto { get; set; }
        public decimal? ValDescto { get; set; }
        public int? AutorizaDescto { get; set; }
        public string Detalle { get; set; }

        public virtual ThHistVehic IdHistVehicNavigation { get; set; }
        public virtual TbPersonal IdPersoNavigation { get; set; }
        public virtual ICollection<ThFactMo> ThFactMos { get; set; }
    }
}
