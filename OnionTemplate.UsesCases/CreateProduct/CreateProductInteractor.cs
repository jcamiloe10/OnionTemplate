namespace OnionTemplate.UsesCases.CreateProduct
{
    using OnionTemplate.Dtos;
    using OnionTemplate.Entities.Interfaces;
    using OnionTemplate.UseCasesPort;
    using TravelOnionTemplate.Entities;

    public class CreateProductInteractor : ICreateProductInportPort
    {
        readonly IProductRepository productRepository;
        readonly ICreateProductOutputPort outputPort;

        public CreateProductInteractor(IProductRepository productRepository, ICreateProductOutputPort outputPort) =>
            (this.productRepository, this.outputPort) = (productRepository, outputPort);


        public async Task Handle(CreateProductDto product)
        {
            Product newProduct = new Product(product.Name);

            await this.productRepository.CreateProductAsync(newProduct);

            await this.outputPort.Handle(
                new ProductDto()
                {
                    Id = newProduct.Id,
                    Name = newProduct.Name
                });
        }
    }
}
