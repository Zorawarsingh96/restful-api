using AutoMapper;
using restful_api.Dtos;
using restful_api.Modals;

namespace restful_api.Profiles{
    public class RestSportProf : Profile{
       public RestSportProf(){
           CreateMap<CricketModal , CricketReadDto>();
           CreateMap<CrickInsDto, CricketModal>();
           CreateMap<CrickUpdateDto, CricketModal>();
           CreateMap<FootballModal, FootballReadDto>();
           CreateMap<FootballCreateDto, FootballModal>();
           CreateMap<FootballUpDto, FootballModal>();
           CreateMap<FieldHockey, HockeyReadDto>();
           CreateMap<HockeyCreateDto, FieldHockey>();
           CreateMap<HockeyUpDto, FieldHockey>();
       }
    }
}