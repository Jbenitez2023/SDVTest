using SDVTest.Models;
using System.ComponentModel.DataAnnotations;

namespace SDVTest.Dto
{
    public class PeopleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int IdProfession { get; set; }
        public int IdWeaponEquiped { get; set; }
        public int Lvl { get; set; }
        public WeaponsDto? Weapons { get; set; }
        public ProfessionsDto? Professions { get; set; }
        public List<PeopleMateriaDto>? People_materia { get; set; }

    }
}
