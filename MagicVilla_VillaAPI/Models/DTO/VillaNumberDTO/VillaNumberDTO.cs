using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO.VillaNumberDTO
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }
    }
}
