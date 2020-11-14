using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        public bool IsInjured { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public int PositionId { get; set; }
        public int SquadNumber { get; set; }
        public int TeamId { get; set; }
    }
}