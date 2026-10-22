///<summary>
///further inheritance down the estate lineage. inherits from estate. holds basic variables that an institutional estate might use.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    public abstract class Institutional : Estate
    {
        public int Capacity { get; set; }
        public int NumberOfBuildings { get; set; }

        public Institutional(int id, Address address, int capacity, int numberOfBuildings) : base(id, address)
        {
            Capacity = capacity;
            NumberOfBuildings = numberOfBuildings;
        }
    }
}
