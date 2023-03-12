namespace CarModelProject.Models
{
    public class Car
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public string  FuelType { get; set; }

        public string BanType { get; set; }

        public int Year { get; set; }

        public CarModel CarModel { get; set; }

        public int CarModelId { get; set; }
    }
}
