using System;
using System.Collections.Generic;
using TurntablTowers.ApartmentTypes;

namespace TurntablTowers
{
    public class TurnTablTower 
    {
       
        //list of apartments
        List<Apartment> allApartments = new List<Apartment>();

        private readonly int NumberOfFloors;
        private readonly int NumberOfApartmentPerFloor;

        public TurnTablTower(int NumberOfFloors, int NumberOfApartmentPerFloor)
        {
            this.NumberOfFloors = NumberOfFloors;
            this.NumberOfApartmentPerFloor = NumberOfApartmentPerFloor;

            for (int index = 0; index < NumberOfFloors; index++)
            {
                for (int apartments = 1; apartments <= NumberOfApartmentPerFloor; apartments++)
                {
                    apartmentType apt = (apartmentType)new Random().Next(0, 3);

                    switch (apt)
                    {
                        case 0:
                            Apartment basic = new BasicApartment(index, (index +""+ apartments), "Manager's name ", apartmentType.BASIC);
                            allApartments.Add(basic);
                            break;

                        case (TurntablTowers.apartmentType)1:
                            Apartment silver = new SilverApartment(index, index +""+ apartments, "Family Residence ", apartmentType.SILVER);
                            allApartments.Add(silver);
                            break;

                        case (TurntablTowers.apartmentType)2:
                            Apartment grand = new GrandApartment(index, index + ""+ apartments, "There's always a butler ", apartmentType.GRAND);
                            allApartments.Add(grand);
                            break;

                        default:
                            Console.WriteLine("No specified room");
                            break;

                    }
                }
            }

        }

        //Apartment(floorno, doorno, residentname,apartment type)
        //loop over the type of apartment

        public TurnTablTower()
        {
        }


        public void TakeTheRegister()
        {
            Console.WriteLine("Resident Name ------------ Apartment Type");
            Console.WriteLine("____________________________________________");
            /*foreach (Apartment resident in allApartments)
            {

                Console.WriteLine(resident.ResidentName +"\t"+ resident.ApartmentType);
            }*/

            allApartments.ForEach(resident => Console.WriteLine(resident.ResidentName + "\t" + resident.ApartmentType));
        }

        public void RingAllBells()
        {
            Console.WriteLine("Survey to confirm which families are around. Thanks!");
            Console.WriteLine("_____________________________________________________");

            //be able to ring all the doorbells and get a report of who didn't answer the doorbell.
            //foreach (Apartment apartment in allApartments)
            //{
            //    //Console.WriteLine(apartment.ToString());
            //    apartment.ringbell();
            //}

            allApartments.ForEach(apartment => apartment.ringbell());
        }
    }
}