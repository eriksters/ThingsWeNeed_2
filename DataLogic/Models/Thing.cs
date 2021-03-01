using System;
using System.ComponentModel.DataAnnotations;

namespace ThingsWeNeed.DataLogic.Models
{
    public class Thing
    {
        [Key]
        [MaxLength(40)]
        public string Name { get; set; }
        public bool Needed { get; set; }
    }
}

