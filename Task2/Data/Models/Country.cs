using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string Name { get; set; }
    }
}