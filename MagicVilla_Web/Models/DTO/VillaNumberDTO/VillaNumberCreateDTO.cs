using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.DTO.VillaNumberDTO
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }

        
    }
}
