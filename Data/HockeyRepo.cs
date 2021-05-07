using System;
using System.Collections.Generic;
using System.Linq;
using restful_api.Modals;

namespace restful_api.Data{
    public class HockeyRepo : IHockeyRepo
    {
        private readonly MainDbContext _context;

        public HockeyRepo(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<FieldHockey> GetAllPlayer()
        {
            return _context.Hockey.ToList();
        }

        public FieldHockey GetPlayerById(int id)
        {
            return _context.Hockey.FirstOrDefault(p => p.Id == id);
        }

        public void InsertPlayer(FieldHockey cric)
        {
            if(cric == null){
                throw new ArgumentNullException(nameof(cric));
            }
            _context.Hockey.Add(cric);
        }

        public void RemovePlayer(FieldHockey cric)
        {
            if(cric == null){
                throw new ArgumentNullException(nameof(cric));
            }
            _context.Hockey.Remove(cric);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePlayer(FieldHockey cric)
        {
        }
    }
}