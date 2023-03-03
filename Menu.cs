using System;
using System.Collections.Generic;

namespace One
{
    public class Menu
    {
        public static Dictionary<string, string> vendedores = new Dictionary<string, string>();
        public static List<string> categorias = new List<string>() { "Electronicos", "Ropas", "electrodomesticos" };
        private static List<Articulo> articulos = new List<Articulo>();
        private static string vcod;
        private static object vnom;
        private static double vpre;

        public static void MenuPrincipalTienda()
        {

            Console.WriteLine(" Hola bienvenido al sistema de venta de articulos." +
                                "\n" +
                                "Este trabajo fue desarrollado por:\n" +
                                "Carlos Ernesto Pérez Pérez\n");

            do
            {
                Console.WriteLine("Menú Princial de la tienda.");
                Console.WriteLine("a) Artículos.");
                Console.WriteLine("b) Facturación.");
                Console.WriteLine("c) Reporte.");
                Console.WriteLine("d) Salir.");
                Console.WriteLine("Elija una opción");

                char opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcion)
                {
                    case 'a':
                        MenuArticulos(string, string, double, vnom);
                        break;
                    case 'b':
                        Facturacion();
                        break;
                    case 'c':
                        Reporte();
                        break;
                    case 'd':
                        return;
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta, por favor elegir una opción de las que estan disponibles");
                        MenuPrincipalTienda();
                        break;
                }

            } while (true);


        }
        private static void MenuArticulos(string v, string v, double v, object vnom)
        {
            do
            {
                Console.WriteLine("Menu para agregar articulos");
                Console.WriteLine("A) Agregar");
                Console.WriteLine("B) Borrar");
                Console.WriteLine("C) Consultar");
                Console.WriteLine("D) Regresar al menu principal");
                Console.WriteLine("Digite una opcion");

                char opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Articulo articulo = new Articulo();
                

                switch (opcion)
                {
                    case 'A':
                        articulo.AgregarArticulo(vcod, (string)vnom, vpre);
                        break;
                    case 'B':
                        articulo.BorrarArticulo(vcod);
                        break;
                    case 'C':
                        articulo.BorrarArticulo(vcod);
                        break;
                    case 'D':
                        MenuPrincipalTienda();
                        break;
                    default:
                        Console.WriteLine("digite una opcion valida e intente de nuevo");
                        break;
                }

            } while (true);
        }

    }

    class Facturacion
    {
        private Dictionary<int, string[]> articulos;
        private List<string[]> categorias;
        private Vendedor vendedores;

        public Facturacion()
        {
            // Inicializar los atributos
            articulos = new Dictionary<int, string[]>();
            categorias = new List<string[]>();
            vendedores = new Vendedor();
        }

        public object Articulos { get; private set; }

        public void IniciarFacturacion(int codigoVendedor, object vendedor)
        {
            int codigoArticulo, codigoVendedores, categoria;
            string[] datosArticulo;
            string nombreArticulo;
            double precioArticulo, totalVenta;
            bool existeArticulo, existeVendedor, existeCategoria;

            // Pedir el código del artículo
            Console.Write("Ingrese el código del artículo: ");
            codigoArticulo = int.Parse(Console.ReadLine());

            // Validar si existe el artículo
            existeArticulo = articulos.ContainsKey(codigoArticulo);
            if (existeArticulo)
            {
                // Si existe el artículo, traer sus datos
                datosArticulo = articulos[codigoArticulo];
                nombreArticulo = datosArticulo[0];
                precioArticulo = double.Parse(datosArticulo[1]);

                // Pedir la categoría del artículo
                Console.Write("Ingrese la categoría del artículo: ");
                categoria = int.Parse(Console.ReadLine());

                // Validar si existe la categoría
                existeCategoria = false;
                foreach (string[] datosCategoria in categorias)
                {
                    if (int.Parse(datosCategoria[0]) == categoria)
                    {
                        existeCategoria = true;
                        break;
                    }
                }

                // Si existe la categoría, continuar con la facturación
                if (existeCategoria)
                {
                    // Pedir el código del vendedor
                    Console.Write("Ingrese el código del vendedor: ");
                    codigoVendedores = int.Parse(Console.ReadLine());

                    // Validar si existe el vendedor
                    existeVendedor = vendedores.ListadoVendedores(int codigoVendedores);

                    // Si existe el vendedor, calcular el total de la venta
                    if (existeVendedor)
                    {
                        totalVenta = precioArticulo * Math.PI * categoria / vendedor.ListadoVendedores();

                        Console.WriteLine("Nombre del artículo: {0}", nombreArticulo);
                        Console.WriteLine("Precio del artículo: {0}", precioArticulo);
                        Console.WriteLine("Categoría del artículo: {0}", categoria);
                        Console.WriteLine("Código del vendedor: {0}", codigoVendedores);
                        Console.WriteLine("Total de la venta: {0}", totalVenta);
                    }
                    else
                    {
                        Console.WriteLine("El código del vendedor no existe");
                    }
                }
                else
                {
                    Console.WriteLine("La categoría no existe");
                }
            }
            else
            {
                Console.WriteLine("El código del artículo no existe");
            }
        }

        public void Reporte()
        {
            Reporte(Articulos);
        }

        public void Reporte(object articulos)
        {
            Console.WriteLine("------Vendedores------");
            foreach (var vendedor in Vendedor.ListadoVendedores())
            {
                Console.WriteLine($"Código: {vendedor.Key} - Nombre: {vendedor.Value}");
            }

            Console.WriteLine("\n------Categorías------");
            System.Collections.IList list = categorias;
            for (int i = 0; i < list.Count; i++)
            {
                Categoria categoria = (Categoria)list[i];
                Console.WriteLine($"Código: {categoria.Codigo} - Nombre: {categoria.Nombre}");
            }

            Console.WriteLine("\n------Artículos------");
            for (int i = 0; i < articulos; i++)
            {
                if (Articulos[i] != null)
                {
                    Console.WriteLine($"Código: {Articulos[i].Codigo} - Nombre: {Articulo[i].Nombre} - Precio: {Articulos[i].Precio}");
                }
            }
        }

    }
}
