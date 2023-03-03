using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public object Codigo { get; internal set; }

        public virtual void Promocion()
        {
            Console.WriteLine("Descuentos y promociones");
        }
    }
    public class Categorias
    {
        private List<Categoria> categorias;

        public Categorias()
        {
            categorias = new List<Categoria>();
            categorias.Add(new Categoria() { Id = 1, Nombre = "Categoría 1" });
            categorias.Add(new Categoria() { Id = 2, Nombre = "Categoría 2" });
            categorias.Add(new Categoria() { Id = 3, Nombre = "Categoría 3" });
        }

        public List<Categoria> ListadoCategorias()
        {
            return categorias;
        }

        public bool CategoriaExiste(int id)
        {
            return categorias.Any(c => c.Id == id);
        }
    }
    public class Categoria1 : Categoria
    {
        public void promocion()
        {
            Console.WriteLine("Descuento de 15%");
        }
    }
    public class Categoria2 : Categoria
    {
        public void promoción()
        {
            Console.WriteLine("Promoción dos por 1");
        }
    }
    public class Categoria3 : Categoria
    {
        public void promoción()
        {
            Console.WriteLine("Todo a mitad de precio");
        }
    }





}
