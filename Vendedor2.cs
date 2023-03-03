using System;

namespace One
{
    public class IVendedor2 : Ivendedor2
    {
        public string Nombre { get; }

        public IVendedor2(string nombre)
        {
            Nombre = nombre;
        }

        public string VentasCredito()
        {
            // Implementación del método VentasCredito para el vendedor 2
            Console.WriteLine($"El vendedor {Nombre} ha registrado una venta a crédito.");
            return "La venta se registró correctamente.";
        }
    }
}
