using System;
namespace TurntablTowers.ApartmentTypes
{
    public class BasicApartment : Apartment
    {
        public BasicApartment(int floorNumber, string doorNumber, string residentName,apartmentType apartmentType)
        :base(floorNumber,doorNumber,residentName, apartmentType.BASIC)
        {
        }

        public override void ringbell()
        {
            try
            {
                bool doorAnswered = new Random().Next(0, 100) <= 10 ? true : false;
                if (doorAnswered)
                {
                    Console.WriteLine("Good day from {0}", ResidentName);
                }
                else
                {
                    throw new NobodyHomeException("Sorry, we're not availabe at the moment");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message) ;
            }
        }
    }
}
