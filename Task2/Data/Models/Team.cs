using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public int Budget { get; set; }
        public string Initials { get; set; }
        public string LogoUrl { get; set; }
        public string Name { get; set; }
        public int PrimaryKitColorId { get; set; }
        public int SecondaryKitColorId { get; set; }
        public int TownId { get; set; }
    }
}