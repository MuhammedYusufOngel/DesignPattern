using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class HomeBuilder
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

        //Zorunlu alanları belirlediğimiz bu fonksiyonla zorunlu olan değerlerin girilmesi gerek.
        public static HomeBuilder startBuild(String city, String town, String street, int apartYear, int numberOfRoom)
        {
            HomeBuilder builder = new HomeBuilder();
            builder.city = city;
            builder.town = town;
            builder.street = street;
            builder.apartYear = apartYear;
            builder.numberOfRoom = numberOfRoom;

            return new HomeBuilder();
        }

        //Ev oluşturuluyor
        public Home build()
        {
            Home home = new Home();

            home.setCity(city);
            home.setTown(town);
            home.setStreet(street);
            home.setApartYear(apartYear);
            home.setNumberOfBalcony(numberOfBalcony);
            home.setnumberOfRoom(numberOfRoom);
            home.setnumberOfWC(numberOfWC);
            home.setIsDublex(isDublex);
            home.setIsFurnished(isFurnished);
            home.setHasCarPark(hasCarPark);
            home.setHasChildPark(hasChildPark);
            
            return home;
        }

        public HomeBuilder setNumberOfBalcony(int numberOfBalcony)
        {
            this.numberOfBalcony = numberOfBalcony;
            return this;
        }

        public HomeBuilder setnumberOfWC(int numberOfWC)
        {
            this.numberOfWC = numberOfWC;
            return this;
        }
        public HomeBuilder setIsDublex(Boolean isDublex)
        {
            this.isDublex = isDublex;
            return this;
        }
        public HomeBuilder setIsFurnished(Boolean IsFurnished)
        {
            this.isFurnished = IsFurnished;
            return this;
        }
        public HomeBuilder setHasCarPark(Boolean HasCarPark)
        {
            this.hasCarPark = HasCarPark;
            return this;
        }
        public HomeBuilder setHasChildPark(Boolean HasChildPark)
        {
            this.hasChildPark = HasChildPark;
            return this;
        }
        public HomeBuilder setHasAirConditioning(Boolean HasAirConditioning)
        {
            this.hasAirConditioning = HasAirConditioning;
            return this;
        }
        public HomeBuilder setHasPool(Boolean HasPool)
        {
            this.hasPool = HasPool;
            return this;
        }
    }
}
