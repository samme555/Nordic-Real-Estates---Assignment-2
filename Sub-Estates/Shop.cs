using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordic_Real_Estates___Version_2
{
    public class Shop : Commercial
    {
        public bool HasStorage { get; set; }
        public int NumberOfEntrances { get; set; }

        public Shop(int id, Address address, int numberOfEmployees, double businessArea, bool hasStorage, int numberOfEntrances) : base(id, address, numberOfEmployees, businessArea)
        {
            HasStorage = hasStorage;
            NumberOfEntrances = numberOfEntrances;
        }

        public override string ToString()
        {
            return $"Shop - ID: {ID}\n" +
                $"Address: {Address.Street}, {Address.ZipCode}, {Address.City}, {Address.Countries}\n" +
                $"Business Area: {BusinessArea} m², Entrances: {NumberOfEntrances}, Has Storage: {HasStorage}\n" +
                $"--------------------------------------------------------------";
        }
    }
}
