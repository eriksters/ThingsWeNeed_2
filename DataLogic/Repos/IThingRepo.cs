using System;
using ThingsWeNeed.DataLogic.Models;

namespace ThingsWeNeed.DataLogic.Repos
{
    public interface IThingRepo
    {
        void CreateThing(Thing thing);

        void SaveChanges();
    }
}
