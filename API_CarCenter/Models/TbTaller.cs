using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class TbTaller
    {
        public TbTaller()
        {
            ThFactCabs = new HashSet<ThFactCab>();
            ThInventarios = new HashSet<ThInventario>();
        }

        public int IdTaller { get; set; }
        public string Nombre { get; set; }
        public int? IdCiudad { get; set; }

        public virtual TbCiudad IdCiudadNavigation { get; set; }
        public virtual ICollection<ThFactCab> ThFactCabs { get; set; }
        public virtual ICollection<ThInventario> ThInventarios { get; set; }
    }
}
