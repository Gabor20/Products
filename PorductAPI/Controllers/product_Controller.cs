using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static PorductAPI.DTos;

namespace PorductAPI.Controllers
{
    [Route("product")]
    [ApiController]
    public class product_Controller : ControllerBase
    {
        private static readonly List<ProductDto> products = new()
        {
            new ProductDto(Guid.NewGuid(), "Termék1",2500,DateTimeOffset.UtcNow, DateTimeOffset.UtcNow),
            new ProductDto(Guid.NewGuid(), "Termék2",5500,DateTimeOffset.UtcNow, DateTimeOffset.UtcNow),
            new ProductDto(Guid.NewGuid(), "Termék3",25000,DateTimeOffset.UtcNow, DateTimeOffset.UtcNow),
        };

        [HttpGet]
        public IEnumerable<ProductDto> Getall()
        {
            return products;
        }

        [HttpGet("{id}")]
        public ProductDto GetById(Guid id)
        {
            var product = products.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }
        [HttpPost]
        public ProductDto PostProduct(CreateProductDto createProduct)
        {
            var product = new ProductDto(
                Guid.NewGuid(),
                createProduct.ProductName,
                createProduct.ProductPrice,
                DateTimeOffset.UtcNow,
                DateTimeOffset.UtcNow
                );
            products.Add(product);
            return product;
        }
        [HttpPut]
        public ProductDto PullProduct(Guid id, UpdateProductDto updateProduct)
        {
            var existingProduct = products.Where(x => x.Id == id).FirstOrDefault();
            var product = existingProduct with
            {
                ProductName = updateProduct.ProductName,
                Productprice= updateProduct.ProductPrice,
                ModifiedTime = DateTimeOffset.UtcNow,
            };

            var index = products.FindIndex(x => x.Id == id);
            products[index] = product;
            return product;
        }

        [HttpDelete]
        public string DeleteProduct(Guid id)
        {
            var index = products.FindIndex(x => x.Id == id);
            products.RemoveAt(index);
            return "Termék törölve";
        }
        /*public ProductDto DeleteProduct(Guid id, DeleteProductDto deleteProduct)
        {

        }*/
    }
}
