using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class ThCliente
    {
        public ThCliente()
        {
            ThFactCabs = new HashSet<ThFactCab>();
        }

        public int IdCliente { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string RazonSoc { get; set; }
        public int? IdTipoDocum { get; set; }
        public string NumDocum { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public virtual TbTipoDocum IdTipoDocumNavigation { get; set; }
        public virtual ICollection<ThFactCab> ThFactCabs { get; set; }
    }
}
