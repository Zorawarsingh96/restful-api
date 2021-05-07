using System.ComponentModel.DataAnnotations;

namespace restful_api.Modals{
    public class FieldHockey{
        [Key]
        public int Id { get; set; }
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