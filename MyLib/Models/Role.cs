using MyLib.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLib.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public IEnumerable<User> Users { get; set; } = new List<User>();
    }
}
