namespace One
{
    using System;
    using System.Collections.Generic;

    public class Vendedor
    {
        private Dictionary<int, string> _vendedores;

        public Vendedor()
        {
            _vendedores = new Dictionary<int, string>();
            _vendedores.Add(1, "Vendedor 1");
            _vendedores.Add(2, "Vendedor 2");
        }

        public Dictionary<int, string> ListadoVendedores(int codigoVendedor)
        {
            return _vendedores;
        }

        public string NombreVendedor(int codigo)
        {
            if (_vendedores.ContainsKey(codigo))
            {
                return _vendedores[codigo];
            }
            else
            {
                return "El vendedor no existe";
            }
        }
    }

    

}
