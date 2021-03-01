using System;
using ThingsWeNeed.DataLogic.Models;

namespace ThingsWeNeed.DataLogic.Repos
{
    public class ThingRepo : IThingRepo
    {
        private readonly ThingsWeNeedContext _context;

        public ThingRepo(ThingsWeNeedContext context)
        {
            _context = context;
        }

        public void CreateThing(Thing thing)
        {
            _context.Things.Add(thing);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
