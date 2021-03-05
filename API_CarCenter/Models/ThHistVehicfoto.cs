using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThHistVehicfoto
    {
        public int IdHistVehicfoto { get; set; }
        public int? IdHistVehic { get; set; }
        public DateTime? FecEntrada { get; set; }
        public DateTime? FecSalida { get; set; }
        public string DetallesEntrada { get; set; }
        public string DetallesSalida { get; set; }
        public byte[] Imagen { get; set; }

        public virtual ThHistVehic IdHistVehicNavigation { get; set; }
    }
}
