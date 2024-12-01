using System.ComponentModel.DataAnnotations;

namespace SDVTest.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }

        [Required]  
        public string Name { get; set; }

        [Required]
        [Range(1, 90)]
        public int Age { get; set; }

        [Required]
        public int IdProfession { get; set; }

        [Required]
        public int IdWeaponEquiped { get; set; }

        [Required]
        [Range(1, 99)]
        public int Lvl { get; set; }
        public Weapons Weapons { get; set; }

        public Professions Professions { get; set; }

        public List<People_Materia> People_materia { get; set; }

    }

}
