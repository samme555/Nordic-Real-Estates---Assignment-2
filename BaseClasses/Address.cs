///<summary>
/// holds a bunch of variables for address information. 
/// dont think theres much more to say here. street, zipcode, city and countries is accessed through this class by the program.
/// </summary>

namespace Nordic_Real_Estates___Version_2 
{
    public class Address
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public Countries Countries { get; set; }

        public Address(string street, string zipCode, string city, Countries countries)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Countries = countries;
        }
    }
}
