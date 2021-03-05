using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThVehiculo
    {
        public ThVehiculo()
        {
            ThHistVehics = new HashSet<ThHistVehic>();
        }

        public int IdVehic { get; set; }
        public string Placa { get; set; }

        public virtual ICollection<ThHistVehic> ThHistVehics { get; set; }
    }
}
