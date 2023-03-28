namespace OnionTemplate.Presenters
{
    using OnionTemplate.Dtos;
    using OnionTemplate.UseCasesPort;

    public class GetAllProductPresenter : IGetAllProductOuputPort, IPresenter<IEnumerable<ProductDto>>
    {
        public IEnumerable<ProductDto> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDto> products)
        {
            Content = products;
            return Task.CompletedTask;
        }
    }
}
