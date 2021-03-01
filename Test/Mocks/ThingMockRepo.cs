using System;
using System.Collections.Generic;
using ThingsWeNeed.DataLogic.Models;
using ThingsWeNeed.DataLogic.Repos;

namespace ThingsWeNeed.Test.Mocks
{
    public class ThingMockRepo : IThingRepo
    {
        public Thing GetThingByName(string name)
        {
            return new Thing{
                Name = name,
                Needed = true
            };
        }
        
        public void CreateThing(Thing thing)
        {
            return;
        }

        

        public void SaveChanges() 
        {
            return;
        }
    }
}
