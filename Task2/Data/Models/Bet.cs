using System;
using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Bet
    {
        [Key]
        public int BetId { get; set; }

        public int Amount { get; set; }
        public int GameId { get; set; }
        public int Prediction { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }
    }
}