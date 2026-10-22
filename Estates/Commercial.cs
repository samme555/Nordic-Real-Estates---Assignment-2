///<summary>
///further inheritance down the estate lineage. inherits from estate. holds basic variables that a commercial estate might use.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    public abstract class Commercial : Estate
    {
        public int NumberOfEmployees { get; set; }
        public double BusinessArea { get; set; }

        public Commercial(int id, Address address, int numberOfEmployees, double businessArea) : base(id, address)
        {
            NumberOfEmployees = numberOfEmployees;
            BusinessArea = businessArea;
        }
    }
}
