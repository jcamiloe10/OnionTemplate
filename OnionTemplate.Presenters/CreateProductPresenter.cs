namespace OnionTemplate.Presenters
{
    using OnionTemplate.Dtos;
    using OnionTemplate.UseCasesPort;

    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDto>
    {
        public ProductDto Content { get; private set; }

        public Task Handle(ProductDto product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
