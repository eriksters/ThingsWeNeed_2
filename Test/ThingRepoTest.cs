using System;
using Xunit;
using ThingsWeNeed.DataLogic.Repos;
using ThingsWeNeed.DataLogic.Models;
using ThingsWeNeed.Test.Mocks;
using ThingsWeNeed.DataLogic;
using Microsoft.EntityFrameworkCore;

namespace ThingsWeNeed.Test
{
    public class ThingRepoTest
    {
        [Fact]
        public void CreateThingTest()
        {
            //  Assign
            var options = new DbContextOptionsBuilder<ThingsWeNeedContext>()
                .UseSqlServer("Server=localhost;Initial Catalog=ThingsWeNeedDB;User ID=ThingsWeNeed;Password=password;")
                .Options;

            Random random = new Random();
            Thing thing = new Thing {
                Name = "Test Thing " + random.Next(),
                Needed = false
            };

            //  Act
            using (var context = new ThingsWeNeedContext(options))
            {
                IThingRepo repo = new ThingRepo(context);
                
                repo.CreateThing(thing);

                repo.SaveChanges();
            };

            //  Assert

            
            

            
        }
    }
}
