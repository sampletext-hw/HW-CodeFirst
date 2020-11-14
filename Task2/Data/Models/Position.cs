using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        
        [MaxLength(32)]
        public string Name { get; set; }
    }
}