///<summary>
///further inheritance down the estate lineage. inherits from estate. holds basic variables that a residential estate might use.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    public abstract class Residential : Estate
    {
        public int NumberOfRooms { get; set; }
        public double LivingArea { get; set; }

        public Residential(int id, Address address, int numberOfRooms, double livingArea) : base (id, address)
        {
            NumberOfRooms = numberOfRooms;
            LivingArea = livingArea;
        }
    }
}
