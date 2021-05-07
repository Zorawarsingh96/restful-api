using System.ComponentModel.DataAnnotations;

namespace restful_api.Dtos{
    public class HockeyUpDto{
        [Required]
        public string Name { get; set; }
        [Required]
        public int JerseyNumber { get; set; }
        [Required]
        public int Apperance{ get; set; }
        [Required]
        public int Goals { get; set; }
    }
}