namespace OnionTemplate.RepositoryFake.Repositories
{
    using OnionTemplate.Entities.Interfaces;
    using System.Collections.Generic;
    using TravelOnionTemplate.Entities;

    public class ProductRepositoryFake: IProductRepository
    {
        private ICollection<Product> products;

        public ProductRepositoryFake()
        {

        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(this.PopulateProducts());
        }

        private IEnumerable<Product> PopulateProducts()
        {
            products = new List<Product>()
           {
               new Product { Id = 1, Name="Soup of Tomato"},
               new Product { Id = 2, Name="Luxurious Steel Hat"},
               new Product { Id = 3, Name="Handmade Granite Chicken"},
               new Product { Id = 4, Name="Handmade Cotton Chips"},
               new Product { Id = 5, Name="Tasty Steel Mouse"},
               new Product { Id = 6, Name="Intelligent Concrete Computer"},
               new Product { Id = 7, Name="Elegant Plastic Car"},
           };

            return products;
        }
    }
}
