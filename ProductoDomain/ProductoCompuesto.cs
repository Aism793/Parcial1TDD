using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoDomain
{
    public class ProductoCompuesto
    {
        //protected List<MovimientoCuenta> _movimientos;
        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }
        public decimal Costo { get; private set; }
        public decimal Precio { get; private set; }
        public decimal Utilidad { get; private set; }
        public int Cantidad { get; protected set; }

        public ProductoCompuesto(string id, string nombre, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;

        }

        public string Vender(int cantidadProducto, decimal precio)
        {
            if (cantidadProducto < 0)
            {
                return "La cantidad a vender es incorrecta";
            }
            
            throw new NotImplementedException();
        }
    }
}
