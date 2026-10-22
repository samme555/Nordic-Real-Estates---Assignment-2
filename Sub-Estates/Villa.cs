using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordic_Real_Estates___Version_2
{
    public class Villa : Residential
    {
        public bool HasGarage { get; set; }
        public double GardenArea { get; set; }

        public Villa(int id, Address address, int numberOfRooms, double livingArea, bool hasGarage, double gardenArea) : base(id, address, numberOfRooms, livingArea)
        {
            HasGarage = hasGarage;
            GardenArea = gardenArea;
        }

        public override string ToString()
        {
            return $"Villa - ID: {ID}\n" +
                $"Address: {Address.Street}, {Address.ZipCode}, {Address.City}, {Address.Countries}\n" +
                $"Rooms: {NumberOfRooms}, Has Garage: {HasGarage}\n" +
                $"Living Area: Inside: {LivingArea} m², Garden: {GardenArea} m²\n" +
                $"--------------------------------------------------------------";
        }
    }
}
