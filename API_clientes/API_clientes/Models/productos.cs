//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_clientes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productos()
        {
            this.pedidosdeta = new HashSet<pedidosdeta>();
        }
    
        public int IdProducto { get; set; }
        public string NomProducto { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public string CantxUnidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short UnidadesEnExistencia { get; set; }
        public short UnidadesEnPedido { get; set; }
    
        public virtual categorias categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedidosdeta> pedidosdeta { get; set; }
        public virtual proveedores proveedores { get; set; }
    }
}
