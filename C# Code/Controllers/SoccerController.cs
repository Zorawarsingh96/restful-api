using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using restful_api.Data;
using restful_api.Dtos;
using restful_api.Modals;

namespace restful_api.Controllers{
    [Route("sports/soccer")]
    [ApiController]
    public class SoccerController : Controller{
        private readonly IFootballRepo _repository;
        private readonly IMapper _mapper;

        public SoccerController(IFootballRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<FootballReadDto>> GetAllVals(){
            var item = _repository.GetAllPlayer();
            return Ok(_mapper.Map<IEnumerable<FootballReadDto>>(item));
        }
        [HttpGet("{id}")]
        public ActionResult <FootballReadDto> GetValsById(int id){
            var valById = _repository.GetPlayerById(id);
            if(valById != null){
                return Ok(_mapper.Map<FootballReadDto>(valById));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult <FootballReadDto> CreateVals(FootballCreateDto insDto){
            var modal =  _mapper.Map<FootballModal>(insDto);
            _repository.InsertPlayer(modal);
            _repository.SaveChanges();
            return Ok(modal);
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id, FootballUpDto updateDto){
            var modal = _repository.GetPlayerById(id);
            if(modal ==  null){
                return NotFound();
            }
            _mapper.Map(updateDto, modal);
            _repository.UpdatePlayer(modal);
            _repository.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Deleted(int id){
            var modal = _repository.GetPlayerById(id);
            if(modal == null){
                return NotFound();
            }
            _repository.RemovePlayer(modal);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}