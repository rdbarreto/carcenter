using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class TbCiudad
    {
        public TbCiudad()
        {
            TbTallers = new HashSet<TbTaller>();
        }

        public int IdCiudad { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TbTaller> TbTallers { get; set; }
    }
}
