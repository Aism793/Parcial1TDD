﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoDomain
{
    public class ProductoSimple
    {
        public static List<ProductoSimple> _movimientos;
        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }
        public decimal Costo { get; private set; }
        public decimal Precio { get; private set; }
        public decimal Utilidad { get; private set; }
        public int Cantidad { get; protected set; }

        public ProductoSimple(string id, string nombre, string categoria, decimal costo, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Costo = costo;
            Precio = precio;
            Utilidad = Precio - Costo;
            _movimientos = new List<ProductoSimple>();
        }
        public IReadOnlyCollection<ProductoSimple> Productos => _movimientos.AsReadOnly();

        public string Ingresar(int cantidadProducto, ProductoSimple producto)
        {
            if (cantidadProducto <= 0)
            {
                return "La cantidad a ingresar es incorrecta";
            }
            if (cantidadProducto > 0)
            {
                _movimientos.Add(producto);
                Cantidad += cantidadProducto;
                return $"La cantidad actual del producto es {Cantidad}";
            }
            throw new NotImplementedException();
        }

        public string Vender(int cantidadProducto)
        {
            if (cantidadProducto <= 0)
            {
                return "La cantidad a vender es incorrecta";
            }
            if (cantidadProducto > 0)
            {

                Cantidad -= cantidadProducto;
                return $"La cantidad actual del producto es {Cantidad}";
            }
                throw new NotImplementedException();
        }

        public static void Disminuir(string nombre)
        {
            foreach (ProductoSimple p in _movimientos)
            {
                if (p.Nombre.Equals(nombre))
                {
                    p.Cantidad -= 1;
                }
            }
        }
    }
}
