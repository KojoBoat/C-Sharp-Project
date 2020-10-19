using System;
namespace TurntablTowers
{
    public abstract class Apartment
    {
        
        private string residentName;
        private int floorNumber;
        private apartmentType apartmentType;

        public int ApartmentNumber
        {
            get { return ApartmentNumber; }
        }

        protected Apartment(int floorNumber, string doorNumber,string residentName, apartmentType apartmentType)
        {
            this.floorNumber = floorNumber;
            this.doorNumber = doorNumber;
            this.residentName = residentName;
            this.apartmentType = apartmentType;
        }

        public apartmentType ApartmentType
        {
           get { return apartmentType; }
        }


        public int FloorNumber 
        {
            get { return floorNumber; }
        }

        private string doorNumber;

        public string DoorNumber
        {
            get
            {
                return floorNumber + "" + ApartmentNumber;
            }
        }

        public override string ToString()
        {
            return "Floor Number: " + floorNumber + " Door Number: " + doorNumber + " Resident Name: " + residentName + " Apartment Type: " + apartmentType;
        }

        public string ResidentName
        {
            get { return residentName; }
        }



        public abstract void ringbell();
    }
}
