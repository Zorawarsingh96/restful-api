using System.Collections.Generic;
using restful_api.Modals;

namespace restful_api.Data{
    public interface IHockeyRepo{
        IEnumerable<FieldHockey> GetAllPlayer();
        FieldHockey GetPlayerById(int id);
        void InsertPlayer(FieldHockey cric);
        void RemovePlayer(FieldHockey cric);
        void UpdatePlayer(FieldHockey cric);
        bool SaveChanges();
    }
}