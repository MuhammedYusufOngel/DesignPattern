using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Home
    {
        private String city;
        private String town;
        private String street;

        private int apartYear;
        private int numberOfBalcony;
        private int numberOfRoom;
        private int numberOfWC;

        private Boolean isDublex;
        private Boolean isFurnished;
        private Boolean hasCarPark;
        private Boolean hasChildPark;
        private Boolean hasAirConditioning;
        private Boolean hasPool;

        public Home()
        {

        }

        public Home(string city, string town, string street, int apartYear, int numberOfBalcony, int numberOfRoom, int numberOfWC, bool isDublex, bool isFurnished, bool hasCarPark, bool hasChildPark, bool hasAirConditioning, bool hasPool)
        {
            this.city = city;
            this.town = town;
            this.street = street;
            this.apartYear = apartYear;
            this.numberOfBalcony = numberOfBalcony;
            this.numberOfRoom = numberOfRoom;
            this.numberOfWC = numberOfWC;
            this.isDublex = isDublex;
            this.isFurnished = isFurnished;
            this.hasCarPark = hasCarPark;
            this.hasChildPark = hasChildPark;
            this.hasAirConditioning = hasAirConditioning;
            this.hasPool = hasPool;
        }

        //Zorunlu
        public Home(string city, string town, string street, int apartYear, int numberOfBalcony, int numberOfRoom, int numberOfWC)
        {
            this.city = city;
            this.town = town;
            this.street = street;
            this.apartYear = apartYear;
            this.numberOfBalcony = numberOfBalcony;
            this.numberOfRoom = numberOfRoom;
            this.numberOfWC = numberOfWC;
        }

        public void setCity(String city)
        {
            this.city = city;
        }
        public void setTown(String Town)
        {
            this.town = Town;
        }
        public void setStreet(String Street)
        {
            this.street = Street;
        }

        public void setApartYear(int ApartYear)
        {
            this.apartYear = ApartYear;
        }
        public void setNumberOfBalcony(int NumberOfBalcony)
        {
            this.numberOfBalcony = NumberOfBalcony;
        }
        public void setnumberOfRoom(int numberOfRoom)
        {
            this.numberOfRoom = numberOfRoom;
        }

        public void setnumberOfWC(int numberOfWC)
        {
            this.numberOfWC = numberOfWC;
        }
        public void setIsDublex(Boolean IsDublex)
        {
            this.isDublex = IsDublex;
        }
        public void setIsFurnished(Boolean IsFurnished)
        {
            this.isFurnished = IsFurnished;
        }
        public void setHasCarPark(Boolean HasCarPark)
        {
            this.hasCarPark = HasCarPark;
        }
        public void setHasChildPark(Boolean HasChildPark)
        {
            this.hasChildPark = HasChildPark;
        }
        public void setHasAirConditioning(Boolean HasAirConditioning)
        {
            this.hasAirConditioning = HasAirConditioning;
        }
        public void setHasPool(Boolean HasPool)
        {
            this.hasPool = HasPool;
        }

        public override String ToString()
        {
            return "City: " + city +
                "\nTown: " + town +
                "\nStreet: " + street +
                "\nNumber Of Room: " + numberOfRoom +
                "\nNumber Of Balcony: " + numberOfBalcony +
                "\nNumber Of WC: " + numberOfWC +
                "\nis Dublex: " + isDublex +
                "\nis Furnished: " + isFurnished +
                "\nHas Child Park: " + hasChildPark +
                "\nHas Car Park: " + hasCarPark +
                "\nHas Air Conditioning: " + hasAirConditioning +
                "\nHas Pool: " + hasPool;
        }
    }
}
