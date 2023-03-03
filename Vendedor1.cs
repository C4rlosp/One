using System;

namespace One
{
    public class IVendedor1 : Ivendedor1
    {
        public string Nombre { get; }

        public IVendedor1(string nombre)
        {
            Nombre = nombre;
        }

        public void VentasContado()
        {
            // Implementación del método VentasContado para el vendedor 1
            Console.WriteLine($"El vendedor {Nombre} ha registrado una venta al contado.");
        }
    }
}
