namespace Demo.Listings.Infrastructure.DataAccess.EF
{
    internal class ListingsRepository
    {
        private readonly ListingsDbContext _listingsDbContext;

        public ListingsRepository(ListingsDbContext listingsDbContext)
        {
            _listingsDbContext = listingsDbContext;
        }
    }
}