using System;
using System.Collections.Generic;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class TbTipoProd
    {
        public TbTipoProd()
        {
            TbPersonals = new HashSet<TbPersonal>();
            TbProductos = new HashSet<TbProducto>();
        }

        public int IdTipoProd { get; set; }
        public string Nombre { get; set; }
        public string TipoProd { get; set; }
        public string Detalle { get; set; }

        public virtual ICollection<TbPersonal> TbPersonals { get; set; }
        public virtual ICollection<TbProducto> TbProductos { get; set; }
    }
}
