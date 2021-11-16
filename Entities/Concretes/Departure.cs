namespace Entities.Concretes
{
    //Since we can need more properties in the future for the departure, we created a class for that.
    public class Departure
    {
        public byte Id { get; set; }
        public string Point { get; set; }
    }
}