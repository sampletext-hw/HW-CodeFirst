using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }
    }
}