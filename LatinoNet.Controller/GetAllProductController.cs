using Microsoft.AspNetCore.Mvc;
using OnionTemplate.Dtos;
using OnionTemplate.Presenters;
using OnionTemplate.UseCasesPort;

namespace OnionTemplate.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductController
    {
        private readonly IGetAllProductInputPort inputPort;
        private readonly IGetAllProductOuputPort outputPort;

        public GetAllProductController(IGetAllProductInputPort inputPort, IGetAllProductOuputPort outputPort) =>
                                     (this.inputPort, this.outputPort) = (inputPort, outputPort);


        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            await this.inputPort.Handle();

            return ((IPresenter<IEnumerable<ProductDto>>)this.outputPort).Content;
        }
    }
}
