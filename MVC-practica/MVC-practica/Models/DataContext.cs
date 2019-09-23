namespace MVC_practica.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_practica.Models.Book> Books { get; set; }
    }
}