namespace Task2.Data.Models
{
    public class PlayerStatistic
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int Assist { get; set; }
        public int MinutesPlayed { get; set; }
        public int ScoredGoals { get; set; }
    }
}