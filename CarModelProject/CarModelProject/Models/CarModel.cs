namespace CarModelProject.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Marka Marka { get; set; }
        public int MarkaId { get; set; }

        public List<Car> Cars { get; set; }




    }
}
