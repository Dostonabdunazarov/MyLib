using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLib.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано название книги")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Не указано дата издания книги")]
        public DateTime DatePublish { get; set; }

        public string FilePath { get; set; }
        public Genre? Genre { get; set; }
        public List<Author> Authors{ get; set; } = new List<Author>();
    }
}
