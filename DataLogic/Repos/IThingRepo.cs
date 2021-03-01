using System;
using ThingsWeNeed.DataLogic.Models;

namespace ThingsWeNeed.DataLogic.Repos
{
    public interface IThingRepo
    {
        bool ThingNameIsValid(string name);
        
        Thing GetThingByName(string name);

        void CreateThing(Thing thing);

        void SaveChanges();
    }
}
