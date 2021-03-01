using System;
using System.Linq;
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
        public bool ThingNameIsValid(string name)
        {
            return GetThingByName(name) == null;
        }

        public Thing GetThingByName(string name)
        {
            return _context.Things.FirstOrDefault(p => p.Name == name);
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
