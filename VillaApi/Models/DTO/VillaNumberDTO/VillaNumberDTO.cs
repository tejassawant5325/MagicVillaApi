using System.ComponentModel.DataAnnotations;

namespace VillaApi.Models.DTO.VillaNumberDTO
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string? SpecialDetails { get; set; }
    }
}
