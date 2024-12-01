using System.ComponentModel.DataAnnotations;

namespace SDVTest.Models
{
    public class Enemies
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 99)]
        public int? Lvl { get; set; }
        public int? Def { get; set; }
        public int? HP { get; set; }
        public int? Str { get; set; }
        public string? ElementalWeakness { get; set; }
    }
}
