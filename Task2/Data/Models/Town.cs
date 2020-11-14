using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Town
    {
        [Key]
        public int TownId { get; set; }

        public int CountryId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }
    }
}