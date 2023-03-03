using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    public class Articulo
    {
        protected string[] codigo = new string[5];
        protected string[] nombre = new string[5];
        protected double[] precio = new double[5];
        protected int contador = 0;

        public Articulo()
        {
        }

        public Articulo(string cod, string nom, double pre)
        {
            codigo[contador] = cod;
            nombre[contador] = nom;
            precio[contador] = pre;
            contador++;
        }

        public void AgregarArticulo(string cod, string nom, double pre)
        {
            if (contador < 5)
            {
                codigo[contador] = cod;
                nombre[contador] = nom;
                precio[contador] = pre;
                contador++;
                Console.WriteLine("Articulo agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más artículos.");
            }
        }

        public void ConsultarArticulo(string cod)
        {
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (codigo[i] == cod)
                {
                    Console.WriteLine($"Código: {codigo[i]}");
                    Console.WriteLine($"Nombre: {nombre[i]}");
                    Console.WriteLine($"Precio: {precio[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Artículo no encontrado.");
            }
        }

        public void BorrarArticulo(string cod)
        {
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (codigo[i] == cod)
                {
                    for (int j = i; j < contador - 1; j++)
                    {
                        codigo[j] = codigo[j + 1];
                        nombre[j] = nombre[j + 1];
                        precio[j] = precio[j + 1];
                    }
                    contador--;
                    encontrado = true;
                    Console.WriteLine("Artículo borrado exitosamente.");
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Artículo no encontrado.");
            }
        }
    }
}
