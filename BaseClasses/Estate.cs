using System.Text.Json.Serialization;

///<summary>
/// inherits from IEstate, base class for all estates and holds ID and address. Address property is accessed from the Address class as far as i understand it.
/// abstract ToString method is for the inheriting classes to overwrite and make a clean string representation of the estate.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Villa), "Villa")]
    [JsonDerivedType(typeof(Shop), "Shop")]
    [JsonDerivedType(typeof(School), "School")]
    public abstract class Estate : IEstate
    {
        public int ID { get; set; }
        public Address Address { get; set; }

        public Estate(int id, Address address)
        {
            ID = id;
            Address = address;
        }

        public abstract override string ToString();
    }
}
