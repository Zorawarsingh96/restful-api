using System.Collections.Generic;
using restful_api.Modals;

namespace restful_api.Data{
    public interface IFootballRepo{
        IEnumerable<FootballModal> GetAllPlayer();
        FootballModal GetPlayerById(int id);
        void InsertPlayer(FootballModal cric);
        void RemovePlayer(FootballModal cric);
        void UpdatePlayer(FootballModal cric);
        bool SaveChanges();
    }
}