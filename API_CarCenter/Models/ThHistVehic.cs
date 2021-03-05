using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThHistVehic
    {
        public ThHistVehic()
        {
            ThFactCabs = new HashSet<ThFactCab>();
            ThHistMos = new HashSet<ThHistMo>();
            ThHistVehicfotos = new HashSet<ThHistVehicfoto>();
        }

        public int IdHistVehic { get; set; }
        public int? IdVehic { get; set; }
        public DateTime? FecEntrada { get; set; }
        public DateTime? FecSalida { get; set; }
        public string DetalleEntrada { get; set; }
        public string DetalleValoracion { get; set; }
        public int? TecnicoValoracion { get; set; }
        public string DetalleSalida { get; set; }

        public virtual ThVehiculo IdVehicNavigation { get; set; }
        public virtual ICollection<ThFactCab> ThFactCabs { get; set; }
        public virtual ICollection<ThHistMo> ThHistMos { get; set; }
        public virtual ICollection<ThHistVehicfoto> ThHistVehicfotos { get; set; }
    }
}
