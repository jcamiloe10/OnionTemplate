namespace OnionTemplate.RepositoryFake.Repositories
{
    using OnionTemplate.Entities.Interfaces;
    using System.Collections.Generic;
    using TravelOnionTemplate.Entities;

    public class ProductRepositoryFake : IProductRepository
    {
        private readonly ICollection<Product> products = new HashSet<Product>();

        public ProductRepositoryFake()
        {

        }

        public Task CreateProductAsync(Product product)
        {
            this.products.Add(product);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(this.PopulateProducts());
        }

        private IEnumerable<Product> PopulateProducts()
        {
            products.Add(new Product("Soup of Tomato"));
            products.Add(new Product("Luxurious Steel Hat"));
            products.Add(new Product("Handmade Granite Chicken"));
            products.Add(new Product("Handmade Cotton Chips"));
            products.Add(new Product("Tasty Steel Mouse"));
            products.Add(new Product("Intelligent Concrete Computer"));
            products.Add(new Product("Elegant Plastic Car"));

            return products;
        }
    }
}
