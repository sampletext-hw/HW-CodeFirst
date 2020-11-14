using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public int Balance { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}