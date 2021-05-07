using System.Collections.Generic;
using restful_api.Modals;

namespace restful_api.Data{
    public interface ICricketRepo{
        IEnumerable<CricketModal> GetAllCricketers();
        CricketModal GetCricketerById(int id);
        void InsertPlayer(CricketModal cric);
        void RemovePlayer(CricketModal cric);
        void UpdatePlayer(CricketModal cric);
        bool SaveChanges();
    }
}