namespace OnionTemplate.UsesCases.GetAllProducts
{
    using OnionTemplate.Dtos;
    using OnionTemplate.Entities.Interfaces;
    using OnionTemplate.UseCasesPort;

    public class GetAllProductInteractor : IGetAllProductInputPort
    {
        readonly IProductRepository productRepository;
        readonly IGetAllProductOuputPort ouputPort;

        public GetAllProductInteractor(IProductRepository productRepository, IGetAllProductOuputPort ouputPort) =>
                                        (this.productRepository, this.ouputPort) = (productRepository, ouputPort);

        public async Task Handle()
        {
            var products = (await productRepository.GetAllAsync()).Select(product =>
             new ProductDto
             {
                 Id = product.Id,
                 Name = product.Name
             });

            await ouputPort.Handle(products);
        }
    }
}
