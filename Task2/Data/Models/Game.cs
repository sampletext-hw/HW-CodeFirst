using System;
using System.ComponentModel.DataAnnotations;

namespace Task2.Data.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        public int AwayTeamBetRate { get; set; }
        public int AwayTeamGoals { get; set; }
        public int AwayTeamId { get; set; }
        public int DrawBetRate { get; set; }
        public int HomeTeamBetRate { get; set; }
        public int HomeTeamGoals { get; set; }
        public int HomeTeamId { get; set; }
        public int Result { get; set; }
        public DateTime DateTime { get; set; }
    }
}