namespace OnionTemplate.Entities.Interfaces
{
    using TravelOnionTemplate.Entities;

    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
