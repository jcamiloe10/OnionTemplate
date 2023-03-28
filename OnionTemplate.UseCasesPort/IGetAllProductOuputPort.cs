using OnionTemplate.Dtos;

namespace OnionTemplate.UseCasesPort
{
    public interface IGetAllProductOuputPort
    {
        Task Handle(IEnumerable<ProductDto> products);
    }
}
