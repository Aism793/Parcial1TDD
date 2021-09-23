using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoDomain
{
    public class ProductoCompuesto
    {
        
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

        public string Vender(int cantidadProducto, decimal precio, List<ProductoSimple> productoSimples)
        {
            if (cantidadProducto < 0)
            {
                return "La cantidad a vender es incorrecta";
            }
            if (cantidadProducto > 0)
            {
                decimal total = 0;
                foreach (ProductoSimple p in productoSimples)
                {
                    if(Nombre.Equals("Perro sencillo"))
                    {
                        foreach (ProductoSimple pro in ProductoSimple._movimientos)
                        {
                            if (pro.Nombre.Equals("Salchicha"))
                            {
                                ProductoSimple.Disminuir(pro.Nombre);
                                total = total + pro.Costo;
                            }
                            if (pro.Nombre.Equals("PanPerros"))
                            {
                                ProductoSimple.Disminuir(pro.Nombre);
                                total = total + pro.Costo;
                            }
                            if (pro.Nombre.Equals("LaminaQueso"))
                            {
                                ProductoSimple.Disminuir(pro.Nombre);
                                total = total + pro.Costo;
                            }
                        }
                        
                    }
                    
                }
                return $"El costo total es {total} pesos";
            }
            throw new NotImplementedException();
        }
    }
}
