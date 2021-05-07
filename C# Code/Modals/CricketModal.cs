using System.ComponentModel.DataAnnotations;

namespace restful_api.Modals{
    public class CricketModal{
        [Key]
        public int CricketerId { get; set; }
        [Required]
        public string CrickterName { get; set; }
        [Required]
        public int JerseyNumber { get; set; }
        [Required]
        public int Matches{ get; set; }
        [Required]
        public int Runs { get; set; }
        [Required]
        public int Wickets { get; set; }
        [Required]
        public double BowlingAvg { get; set; }
        [Required]
        public double BattingAvg { get; set; }
    }
}