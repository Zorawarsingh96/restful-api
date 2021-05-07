using System;
using System.Collections.Generic;
using System.Linq;
using restful_api.Modals;

namespace restful_api.Data{
    public class Footballrepo : IFootballRepo
    {
        private readonly MainDbContext _context;

        public Footballrepo(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<FootballModal> GetAllPlayer()
        {
            return _context.Soccer.ToList();
        }

        public FootballModal GetPlayerById(int id)
        {
            return _context.Soccer.FirstOrDefault(p => p.FootballerId == id);
        }

        public void InsertPlayer(FootballModal cric)
        {
            if(cric == null){
                throw new ArgumentNullException(nameof(cric));
            }
            _context.Soccer.Add(cric);
        }

        public void RemovePlayer(FootballModal cric)
        {
            if(cric == null){
                throw new ArgumentNullException(nameof(cric));
            }
            _context.Soccer.Remove(cric);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePlayer(FootballModal cric)
        {
        }
    }
}