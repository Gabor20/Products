namespace PorductAPI
{
    public class DTos //Data Transfer Object
    {
        public record ProductDto(Guid Id, string ProductName, int Productprice, DateTimeOffset CreatedTime, DateTimeOffset ModifiedTime);
    }
}
