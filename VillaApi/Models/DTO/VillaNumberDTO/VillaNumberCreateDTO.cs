using System.ComponentModel.DataAnnotations;

namespace VillaApi.Models.DTO.VillaNumberDTO
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string? SpecialDetails { get; set; }
    }
}
