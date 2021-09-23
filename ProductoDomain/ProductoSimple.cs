using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoDomain
{
    public class ProductoSimple
    {
        //protected List<MovimientoCuenta> _movimientos;
        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }
        public decimal PrecioCompra { get; private set; }
        public decimal PrecioVenta { get; private set; }
        public decimal Utilidad { get; private set; }
        public int Cantidad { get; protected set; }

        public ProductoSimple(string id, string nombre, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
        }

        public string Ingresar(int cantidadProducto)
        {
            if (cantidadProducto <= 0)
            {
                return "La cantidad a ingresar es incorrecta";
            }
            if (cantidadProducto > 0)
            {
                Cantidad += cantidadProducto;
                return $"La cantidad actual del producto es {Cantidad}";
            }
            throw new NotImplementedException();
        }
    }
}
