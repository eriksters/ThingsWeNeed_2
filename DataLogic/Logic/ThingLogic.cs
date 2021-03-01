using System;
using ThingsWeNeed.DataLogic.Models;
using ThingsWeNeed.DataLogic.Repos;

namespace ThingsWeNeed.DataLogic.Logic
{
    public class ThingLogic : IThingLogic
    {
        private IThingRepo _repo;

        public ThingLogic(IThingRepo repo)
        {
            _repo = repo;
        }

        public void CreateThing(Thing thing)
        {
            _repo.CreateThing(thing);
        }
    }
}
