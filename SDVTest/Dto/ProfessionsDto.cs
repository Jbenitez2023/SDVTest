using System.ComponentModel.DataAnnotations;

namespace SDVTest.Dto
{
    public class ProfessionsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StrBoost { get; set; }
        public int DefBoost { get; set; }
        public int HPBoost { get; set; }
        public int SpeedBoost { get; set; }
    }
}
