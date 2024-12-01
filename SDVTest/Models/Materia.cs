using System.ComponentModel.DataAnnotations;

namespace SDVTest.Models
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(1, 5)]
        public int lvl { get; set; }

        public string? Color { get; set; }

        public string? Element { get; set; }

        public List<People_Materia> People_materia { get; set; }
    }
}
