using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using restful_api.Data;
using restful_api.Dtos;
using restful_api.Modals;

namespace restful_api.Controllers{
    [Route("sports/cricket")]
    [ApiController]
    public class CricketController : Controller{
        private readonly ICricketRepo _repo;
        private readonly IMapper _mapper;

        public CricketController(ICricketRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<CricketReadDto>> GetAllVals(){
            var item = _repo.GetAllCricketers();
            return Ok(_mapper.Map<IEnumerable<CricketReadDto>>(item));
        }
        [HttpGet("{id}")]
        public ActionResult <CricketReadDto> GetValsById(int id){
            var valById = _repo.GetCricketerById(id);
            if(valById != null){
                return Ok(_mapper.Map<CricketReadDto>(valById));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult <CricketReadDto> CreateVals(CrickInsDto insDto){
            var modal =  _mapper.Map<CricketModal>(insDto);
            _repo.InsertPlayer(modal);
            _repo.SaveChanges();
            return Ok(modal);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateCick(int id, CrickUpdateDto updateDto){
            var modal = _repo.GetCricketerById(id);
            if(modal ==  null){
                return NotFound();
            }
            _mapper.Map(updateDto, modal);
            _repo.UpdatePlayer(modal);
            _repo.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DelCric(int id){
            var modal = _repo.GetCricketerById(id);
            if(modal == null){
                return NotFound();
            }
            _repo.RemovePlayer(modal);
            _repo.SaveChanges();
            return NoContent();
        }
    }
}