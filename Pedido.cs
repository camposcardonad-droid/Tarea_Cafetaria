using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria
{
    public class Pedido
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public bool ParaLlevar { get; set; }
        public decimal Subtotal
        {
            get
            {
                decimal total = Producto.Precio * Cantidad;
                if (ParaLlevar)
                {
                    total += 5m;
                }
                return total;
            }
        }
        public Pedido(Producto producto, int cantidad, bool paraLlevar)
        {
            Producto = producto;
            Cantidad = cantidad;
            ParaLlevar = paraLlevar;
        }
    }
}
