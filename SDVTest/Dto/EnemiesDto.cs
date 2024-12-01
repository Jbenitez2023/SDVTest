using System.ComponentModel.DataAnnotations;

namespace SDVTest.Dto
{
    public class EnemiesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Lvl { get; set; }
        public int Def { get; set; }
        public int HP { get; set; }
        public int Str { get; set; }
        public string ElementalWeakness { get; set; }
    }
}
