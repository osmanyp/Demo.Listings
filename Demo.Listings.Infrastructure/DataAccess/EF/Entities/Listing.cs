namespace Demo.Listings.Infrastructure.DataAccess.EF.Entities
{
    internal class Listing
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Bathrooms { get; set; }
        public int HalfBathrooms { get; set; }
        public int Bedrooms { get; set; }
        public int YearBuilt { get; set; }
        public string? Address {get; set;}
        public string? PhotoUrl { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}