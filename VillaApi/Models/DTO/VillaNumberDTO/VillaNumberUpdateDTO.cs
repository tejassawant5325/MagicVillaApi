using System.ComponentModel.DataAnnotations;

namespace VillaApi.Models.DTO.VillaNumberDTO
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string? SpecialDetails { get; set; }
    }
}
