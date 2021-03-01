using System;
using Xunit;
using ThingsWeNeed.DataLogic.Repos;
using ThingsWeNeed.DataLogic.Models;
using ThingsWeNeed.DataLogic.Logic;
using ThingsWeNeed.Test.Mocks;

namespace ThingsWeNeed.Test
{
    public class ThingLogicTest
    {
        [Fact]
        public void CreateThingTest()
        {
            //  Assign
            IThingRepo repo = new ThingMockRepo();
            IThingLogic logic = new ThingLogic(repo);
            
            Random random = new Random();
            Thing thing = new Thing {
                Name = "Test Thing " + random.Next(),
                Needed = false
            };

            //  Act
            logic.CreateThing(thing);

            //  Assert
        }
    }
}