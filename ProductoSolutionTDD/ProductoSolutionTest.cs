using NUnit.Framework;
using ProductoDomain;
using System;

namespace ProductoSolutionTDD
{
    public class ProductoSolutionTest
    {
        /*
         HU1. ENTRADA DE PRODUCTO 
        (1.5) COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        CRITERIOS DE ACEPTACI�N    
        1. La cantidad de la entrada de debe ser mayor a 0    
        2. La cantidad de la entrada se le aumentar� a la cantidad existente del producto
         */
        /*
        Escenario: Valor de ingreso -1
        H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        Criterio de Aceptaci�n:
        1. La cantidad de la entrada de debe ser mayor a 0 
        //El ejemplo o escenario
        Dado El cliente tiene un producto 
        Id 1, Nombre �Gaseosa�, Categoria "VentaDirecta"
        Cuando Va a ingresar una cantidad -1
        Entonces El sistema presentar� el mensaje. �La cantidad a ingresar es incorrecta�
         */
        [Test]
        public void NoPuedeIngresarCantidadProductosDeMenosUno()
        {
            var productoSimple = new ProductoSimple(id: "1", nombre: "Gaseosa", categoria: "VENTADIRECTA", costo: 2000, precio: 5000);
            int cantidadProducto = -1;
            string respuesta = productoSimple.Ingresar(cantidadProducto: cantidadProducto);
            Assert.AreEqual("La cantidad a ingresar es incorrecta", respuesta);
        }

        /*
        Escenario: Valor de ingreso 50
        H1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS  
        Criterio de Aceptaci�n:
        1. La cantidad de la entrada de debe ser mayor a 0 
        2. La cantidad de la entrada se le aumentar� a la cantidad existente del producto
        //El ejemplo o escenario
        Dado El cliente tiene un producto 
        Id 1, Nombre �Salchicha�, Categoria "Preparacion", Cantidad 50
        Cuando Va a ingresar una cantidad 30
        Entonces El sistema la sumar� a la cantidad existente
        and presentar� el mensaje. �La cantidad actual del producto es 80�
         */
        [Test]
        public void PuedeIngresarCantidadProductosCincuentaCorrecta()
        {
            var productoSimple = new ProductoSimple(id: "1", nombre: "Gaseosa", categoria: "VENTADIRECTA", costo: 2000, precio: 5000);
            int cantidadProducto = 50;
             productoSimple.Ingresar(cantidadProducto: cantidadProducto);
            string respuesta = productoSimple.Ingresar(cantidadProducto: 30);
            Assert.AreEqual("La cantidad actual del producto es 80", respuesta);
        }

        //--------------------------------------------------------------------------------------------------

        //PRUEBAS PARA SALIDA DE PRODUCTOS
        /*
         HU1. SALIDA DE PRODUCTO 
        (3.5) COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS  
        CRITERIOS DE ACEPTACI�N 
        1. La cantidad de la salida de debe ser mayor a 0 
        2. En caso de un producto sencillo la cantidad de la salida se le disminuir� a la cantidad existente 
        del producto. 
        3. En caso de un producto compuesto la cantidad de la salida se le disminuir� a la cantidad existente 
        de cada uno de su ingrediente 
        4. Cada salida debe registrar el costo del producto y el precio de la 
        venta 
        5. El costo de los productos compuestos corresponden al costo de sus ingredientes por la cantidad de 
        estos. 
         */
        /*
        /*
        Escenario: Valor de ingreso -1
        H1: (3.5) COMO USUARIO QUIERO REGISTRAR LA SALIDA PRODUCTOS   
        Criterio de Aceptaci�n:
        1. La cantidad de la salida de debe ser mayor a 0 
        //El ejemplo o escenario
        Dado El cliente va a comprar un producto 
        Id 1, Nombre �Gaseosa�, Categoria "VentaDirecta"
        Cuando Va a ingresar una cantidad -1
        Entonces El sistema presentar� el mensaje. �La cantidad a ingresar es incorrecta�
         */
        [Test]
        public void NoPuedeVenderCantidadProductosDeMenosUno()
        {
            var productoCompuesto = new ProductoCompuesto(id: "1", nombre: "Gaseosa", categoria: "VENTADIRECTA", costo: 2000, precio: 5000);
            int cantidadProducto = -1;
            string respuesta = productoCompuesto.Vender(cantidadProducto: cantidadProducto);
            Assert.AreEqual("La cantidad a ingresar es incorrecta", respuesta);
        }
    }

    internal class ProductoCompuesto
    {
        private string id;
        private string nombre;
        private string categoria;
        private int costo;
        private int precio;

        public ProductoCompuesto(string id, string nombre, string categoria, int costo, int precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
            this.costo = costo;
            this.precio = precio;
        }

        internal string Vender(int cantidadProducto)
        {
            throw new NotImplementedException();
        }
    }
}