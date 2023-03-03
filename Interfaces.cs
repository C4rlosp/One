using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    public interface Ivendedor1
    {
        void VentasContado();
    }

    public interface Ivendedor2
    {
        string VentasCredito();
    }

    public class Interfaces : Ivendedor1, Ivendedor2
    {
        public void VentasContado()
        {
            // Código para la implementación de VentasContado
        }

        public string VentasCredito()
        {
            // Código para la implementación de VentasCredito
            return "Ventas a crédito";
        }
    }

}
