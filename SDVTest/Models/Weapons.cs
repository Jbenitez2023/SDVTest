using System.ComponentModel.DataAnnotations;

namespace SDVTest.Models
{
    public class Weapons
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int IdProfession { get; set; }
        public int? StrBoost { get; set; }
        public int? MgBoost { get; set; }
        public List<People> People { get; set; }
        public Professions Professions { get; set; }

    }
}
