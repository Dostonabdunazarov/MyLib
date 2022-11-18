using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLib.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано название жанра!")]
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
