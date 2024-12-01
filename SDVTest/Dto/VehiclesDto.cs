using System.ComponentModel.DataAnnotations;

namespace SDVTest.Dto
{
    public class VehiclesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string vehicleType { get; set; }
        public string color { get; set; }
        public string MaxVelocity { get; set; }
        public string capacity { get; set; }
    }
}
