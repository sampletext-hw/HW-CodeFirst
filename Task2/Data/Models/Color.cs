using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }
    }
}