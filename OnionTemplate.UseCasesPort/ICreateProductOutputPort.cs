namespace OnionTemplate.UseCasesPort
{
    using OnionTemplate.Dtos;

    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDto product);
    }
}
