///<summary>
///uhhhhhh yeah inherits from the institutional class which inherits from estate class. the other sub-estate classes inherit from their corresponding "estate-type"
///class aswwell. holds a bunch of relevant information that a school might use.
/// </summary>
namespace Nordic_Real_Estates___Version_2
{
    public class School : Institutional
    {
        public bool HasCafeteria { get; set; }
        public int NumberOfClassrooms { get; set; }

        public School(int id, Address address, int capacity, int numberOfBuildings, bool hasCafeteria, int numberOfClassrooms) : base(id, address, capacity, numberOfBuildings)
        {
            HasCafeteria = hasCafeteria;
            NumberOfClassrooms = numberOfClassrooms;
        }

        public override string ToString() //cool text that uses all the necessary variables to display in the ListBox view in the program.
        {
            return $"School - ID: {ID}\n" +
                $"Address: {Address.Street}, {Address.ZipCode}, {Address.City}, {Address.Countries}\n" +
                $"Capacity: {Capacity}, Buildings: {NumberOfBuildings}\n" +
                $"Classrooms: {NumberOfClassrooms}, Has Cafeteria: {HasCafeteria}\n" +
                $"--------------------------------------------------------------";
        }
    }
}
