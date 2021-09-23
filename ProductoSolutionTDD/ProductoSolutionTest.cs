using NUnit.Framework;
using System;

namespace ProductoSolutionTDD
{
    public class ProductoSolutionTest
    {
        /*
         HU1. ENTRADA DE PRODUCTO 
        (1.5) COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        CRITERIOS DE ACEPTACIÓN    
        1. La cantidad de la entrada de debe ser mayor a 0    
        2. La cantidad de la entrada se le aumentará a la cantidad existente del producto
         */
        /*
        Escenario: Valor de ingreso -1
        H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        Criterio de Aceptación:
        1. La cantidad de la entrada de debe ser mayor a 0 
        //El ejemplo o escenario
        Dado El cliente tiene un producto 
        Id 1, Nombre “Salchicha”, Categoria "Preparacion"
        Cuando Va a ingresar una cantidad -1
        Entonces El sistema presentará el mensaje. “La cantidad a ingresar es incorrecta”
         */
        [Test]
        public void NoPuedeIngresarCantidadProductosDeMenosUno()
        {
            var productoSimple = new ProductoSimple(id: "1", nombre: "Salchicha", categoria: "PREPARACION");
            decimal cantidadProducto = -1;
            string respuesta = productoSimple.Ingresar(cantidadProducto: cantidadProducto);
            Assert.AreEqual("El valor a ingresar es incorrecta", respuesta);
        }
    }

    internal class ProductoSimple
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

        internal string Ingresar(decimal cantidadProducto)
        {
            if (cantidadProducto < 0)
            {
                return "El valor a ingresar es incorrecta";
            }
            throw new NotImplementedException();
        }
    }
}