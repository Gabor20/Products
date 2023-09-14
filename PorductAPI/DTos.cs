using System.Reflection.Metadata;

namespace PorductAPI
{
    public class DTos //Data Transfer Object
    {
        public record ProductDto(Guid Id, string ProductName, int Productprice, DateTimeOffset CreatedTime, DateTimeOffset ModifiedTime);

        public record CreateProductDto(string ProductName, int ProductPrice);
        public record UpdateProductDto(string ProductName, int ProductPrice); //innen kapja az inputot
    }
}
