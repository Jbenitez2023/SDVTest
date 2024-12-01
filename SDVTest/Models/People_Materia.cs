using System.ComponentModel.DataAnnotations;

namespace SDVTest.Models
{
    public class People_Materia
    {
        [Key]
        public int Id { get; set; }

        public int IdPeople { get; set; }

        public int IdMateria { get; set; }
        public People People { get; set; }
        public Materia Materia { get; set; }
    }
}
