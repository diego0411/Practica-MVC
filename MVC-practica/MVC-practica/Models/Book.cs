namespace MVC_practica.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeContact
    {
        telefono,
        email,
        facebook,
        gmail,
    }
    public class Book
    {
        [key]
        public int bookID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public TypeContact type { get; set; }
        [Required]
        public string contact { get; set; }
    }
}