using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class TbPersonal
    {
        public TbPersonal()
        {
            ThHistMos = new HashSet<ThHistMo>();
        }

        public int IdPerso { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int? IdTipoProd { get; set; }
        public decimal? ValMinHora { get; set; }
        public decimal? ValMaxHora { get; set; }
        public int? IdTipoDocum { get; set; }
        public string NumDocumento { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public virtual TbTipoDocum IdTipoDocumNavigation { get; set; }
        public virtual TbTipoProd IdTipoProdNavigation { get; set; }
        public virtual ICollection<ThHistMo> ThHistMos { get; set; }
    }
}
