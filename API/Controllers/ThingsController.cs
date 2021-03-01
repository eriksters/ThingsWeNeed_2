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

        [HttpGet("{name}")]
        public ActionResult<string> GetThingByName(string name) 
        {
            Thing thingModel = _repo.GetThingByName(name);

            if (thingModel == null) {
                return NotFound();
            }

            ThingGetDto thingDto = _mapper.Map<ThingGetDto>(thingModel);

            return Ok(thingDto);
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