using System.ComponentModel.DataAnnotations;

namespace SDVTest.Dto
{
    public class WeaponsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdProfession { get; set; }
        public int? StrBoost { get; set; }
        public int? MgBoost { get; set; }
        public ProfessionsDto? Professions { get; set; }
    }
}
