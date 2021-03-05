using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class TbTipoDocum
    {
        public TbTipoDocum()
        {
            TbPersonals = new HashSet<TbPersonal>();
            ThClientes = new HashSet<ThCliente>();
        }

        public int IdTipoDocum { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TbPersonal> TbPersonals { get; set; }
        public virtual ICollection<ThCliente> ThClientes { get; set; }
    }
}
