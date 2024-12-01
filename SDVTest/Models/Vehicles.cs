using System.ComponentModel.DataAnnotations;

namespace SDVTest.Models
{
    public class Vehicles
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? vehicleType { get; set; }
        public string? color { get; set; }
        public string? MaxVelocity { get; set; }
        public string? capacity { get; set; }
    }
}
