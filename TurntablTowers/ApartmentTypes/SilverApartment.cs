using System;
namespace TurntablTowers.ApartmentTypes
{
    public class SilverApartment : Apartment
    {
        public SilverApartment(int floorNumber, string doorNumber, string residentName,apartmentType apartmentType)
        :base(floorNumber,doorNumber,residentName,apartmentType.SILVER)
        {
        }

        public override void ringbell()
        {
            try
            {
                bool doorAnswered = new Random().Next(0, 100) <= 80 ? true : false;
                if (doorAnswered)
                {
                    Console.WriteLine("Good day! from {0}", ResidentName);
                }
                else
                {
                    throw new NobodyHomeException("Nobody home exception");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
