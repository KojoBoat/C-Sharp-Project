using System;
namespace TurntablTowers.ApartmentTypes
{
    public class GrandApartment : Apartment
    {
        public GrandApartment(int floorNumber,string doorNumber,string residentName, apartmentType apartmentType)
        :base(floorNumber,doorNumber,residentName,apartmentType.GRAND)
        {
        }

        public override void ringbell()
        {
            Console.WriteLine("Good day");
        }
    }
}
