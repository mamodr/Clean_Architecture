

namespace Eshop.Domain.ValueObjects;
public class Address : ValueObject
{
    public String Street { get; private set; }
    public String City { get; private set; }
   
    public String ZipCode { get; private set; }

    public Address() { }

    public Address(string street, string city,  string zipcode)
    {
        Street = street;
        City = city;
       
        ZipCode = zipcode;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street;
        yield return City;
        
        yield return ZipCode;
    }
}
