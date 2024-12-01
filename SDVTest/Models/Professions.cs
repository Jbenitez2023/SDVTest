using System.ComponentModel.DataAnnotations;

namespace SDVTest.Models
{
    public class Professions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? StrBoost { get; set; }
        public int? DefBoost { get; set; }
        public int? HPBoost { get; set; }
        public int? SpeedBoost { get; set; }

        public List<People> People { get; set; }
        public List<Weapons> Weapons { get; set; }
    }
}
