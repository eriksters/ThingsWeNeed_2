using System.ComponentModel.DataAnnotations;

namespace ThingsWeNeed.API.Dtos
{
    public class ThingCreateDto
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}