using OnionTemplate.Dtos;
using OnionTemplate.Entities.Interfaces;
using OnionTemplate.UseCasesPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelOnionTemplate.Entities;

namespace OnionTemplate.UsesCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInportPort
    {
        readonly IProductRepository productRepository;
        readonly ICreateProductOutputPort outputPort;

        public CreateProductInteractor(IProductRepository productRepository, ICreateProductOutputPort outputPort) =>
            (this.productRepository, this.outputPort) = (productRepository, outputPort);


        public async Task Handle(CreatePorductDto product)
        {
            Product newProduct = new Product()
            {
                Name = product.Name
            };

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
