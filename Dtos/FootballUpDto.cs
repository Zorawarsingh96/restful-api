using System.ComponentModel.DataAnnotations;

namespace restful_api.Dtos{
    public class FootballUpDto{
        [Required]
        public string FootballerName { get; set; }
        [Required]
        public int JerseyNumber { get; set; }
        [Required]
        public int Matches{ get; set; }
        [Required]
        public int Goals { get; set; }
        [Required]
        public int Assist { get; set; }
        [Required]
        public int YellowCard { get; set; }
        [Required]
        public int RedCard { get; set; }
    }
}