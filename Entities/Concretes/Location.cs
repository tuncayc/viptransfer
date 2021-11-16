namespace Entities.Concretes
{
    public class Location
    {
        public byte Id { get; set; }
        public Departure DepartureId { get; set; }
        public Arrival ArrivalId { get; set; }
        public decimal Price { get; set; }
    }
}