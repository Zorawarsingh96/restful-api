using System.ComponentModel.DataAnnotations;

namespace restful_api.Dtos{
    public class CricketReadDto{
        public string CrickterName { get; set; }
        
        public int JerseyNumber { get; set; }
        
        public int Matches{ get; set; }
        
        public int Runs { get; set; }
        
        public int Wickets { get; set; }
        
        public double BowlingAvg { get; set; }
        
        public double BattingAvg { get; set; }
    }
}