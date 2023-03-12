namespace CarModelProject.Models
{
    public class Marka
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<CarModel> CarModels { get; set; }


    }
}
