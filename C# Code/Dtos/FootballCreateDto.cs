namespace restful_api.Dtos{
    public class FootballCreateDto{
        
        public string FootballerName { get; set; }
        
        public int JerseyNumber { get; set; }
        
        public int Matches{ get; set; }
        
        public int Goals { get; set; }
        
        public int Assist { get; set; }
        
        public int YellowCard { get; set; }
        
        public int RedCard { get; set; }
    }
}