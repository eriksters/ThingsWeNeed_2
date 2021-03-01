using System.ComponentModel.DataAnnotations;
using ThingsWeNeed.API.Validation;

namespace ThingsWeNeed.API.Dtos
{
    public class ThingCreateDto
    {
        [Required]
        [ThingNameUnique]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}