namespace OnionTemplate.UseCasesPort
{
    using OnionTemplate.Dtos;

    public interface ICreateProductInportPort
    {
        Task Handle(CreateProductDto product);
    }
}
