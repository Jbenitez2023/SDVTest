using SDVTest.Models;

namespace SDVTest.Dto
{
    public class PeopleMateriaDto
    {
        public int Id { get; set; }

        public int IdPeople { get; set; }

        public int IdMateria { get; set; }
        public string? namePeople { get; set; }

        public string? NameMateria { get; set; }
    }
}
