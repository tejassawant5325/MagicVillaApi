using System.ComponentModel.DataAnnotations;

namespace VillaApi.Models.DTO.VillaNumberDTO
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string? SpecialDetails { get; set; }
    }
}
