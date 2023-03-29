using Microsoft.AspNetCore.Mvc;
using OnionTemplate.Dtos;
using OnionTemplate.Presenters;
using OnionTemplate.UseCasesPort;

namespace OnionTemplate.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInportPort inputPort;
        readonly ICreateProductOutputPort outputPort;

        public CreateProductController(ICreateProductInportPort inputPort, ICreateProductOutputPort outputPort) => (this.inputPort, this.outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<ProductDto> CreateProduct(CreateProductDto product)
        {
            await inputPort.Handle(product);
            return ((IPresenter<ProductDto>)this.outputPort).Content;
        }
    }
}
