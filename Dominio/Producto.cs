using AdministradorDeProductos.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public Producto()
        {
        }

        public Producto(int codigo, string name, string descripcion, int cantidad, decimal precio, DateTime caducidad)
        {
            this.Codigo = codigo;
            this.Nombre = name;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Caducidad = caducidad;
        }
        public int Codigo { get; set; }
        public int  ID {get ; set;}
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio{ get; set; }
        public DateTime Caducidad { get; set; }
        public UnidadDeMedida Unidaddemedida { get; set; }


    }
}
