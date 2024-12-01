using System.ComponentModel.DataAnnotations;

namespace SDVTest.Dto
{
    public class MateriaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int lvl { get; set; }
        public string Color { get; set; }
        public string Element { get; set; }
    }
}
