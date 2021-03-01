using Microsoft.AspNetCore.Mvc;
using ThingsWeNeed.DataLogic.Repos;
using ThingsWeNeed.DataLogic.Models;
using ThingsWeNeed.API.Dtos;
using AutoMapper;

namespace ThingsWeNeed.API.Controllers
{
    [ApiController]
    [Route("things")]
    public class ThingsController : ControllerBase
    {
        private readonly IThingRepo _repo;
        private readonly IMapper _mapper;
        
        public ThingsController(IThingRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<string> GetThing() 
        {
            return Ok("All is good in the hood");
        }

        [HttpPost]
        public ActionResult CreateThing(ThingCreateDto thingDto) 
        {

            var thingModel =_mapper.Map<Thing>(thingDto);
            thingModel.Needed = false;

            _repo.CreateThing(thingModel);
            _repo.SaveChanges();

            return Ok();
        }

    }
}