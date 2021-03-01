using System;
using ThingsWeNeed.DataLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace ThingsWeNeed.DataLogic
{
    public class ThingsWeNeedContext : DbContext
    {
        public ThingsWeNeedContext(DbContextOptions<ThingsWeNeedContext> opt) : base(opt) 
        {

        }

        public DbSet<Thing> Things { get; set; }
    }
}
