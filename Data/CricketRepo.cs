using System;
using System.Collections.Generic;
using System.Linq;
using restful_api.Modals;

namespace restful_api.Data{
    public class CricketRepo : ICricketRepo
    {
        private readonly MainDbContext _context;
        public CricketRepo(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<CricketModal> GetAllCricketers()
        {
            return _context.Cricket.ToList();
        }

        public CricketModal GetCricketerById(int id)
        {
           return _context.Cricket.FirstOrDefault(p => p.CricketerId == id);
        }

        public void InsertPlayer(CricketModal cric)
        {
            if(cric == null){
                throw new ArgumentNullException(nameof(cric));
            }
            _context.Cricket.Add(cric);
        }

        public void RemovePlayer(CricketModal cric)
        {
            if(cric ==  null){
                throw new ArgumentNullException(nameof(cric));
            }
            _context.Cricket.Remove(cric);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePlayer(CricketModal cric)
        {
        }
    }
}