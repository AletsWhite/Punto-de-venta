using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.POJOS
{
    class Producto
    {
        public Producto()
        {

        }
        public Producto(int codigo, string nombre, double precio)
        {
            this.id = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }

    }
}
