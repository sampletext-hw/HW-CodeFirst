using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}