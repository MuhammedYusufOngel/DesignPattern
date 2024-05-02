using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Builder kullanmadan yapılan oluşumlar
             * 
             * Nesne şu anda kararsız bir yapıda. Çünkü oluştururken aslında hepsi varsayılan değerde başlıyor.
             * Home home1 = new Home();
            home1.setCity("Istanbul");
            home1.setTown("Atasehir");
            home1.setStreet("Ataturk Mah.");
            home1.setnumberOfRoom(3);
            home1.setApartYear(2020);
            home1.setHasAirConditioning(true);

            //Çok karmaşık
            Home home2 = new Home("Ankara", "Cankaya", "Karanfil", 2008, 1, 3, 1, false, false, false, false, true, false);*/

            //Bir yandan zorunlu alanlar, sonra ekstra alanlar dolduruluyor ve en sonunda ev oluşturuluyor.
            Home home = HomeBuilder.startBuild("Istanbul", "Umraniye", "Tatlisu", 2007, 3)
                .setHasAirConditioning(true)
                .setHasCarPark(true)
                .build();


            //printHome(home1);

            //printHome(home2);

            printHome(home);

            Console.ReadLine();
        }

        private static void printHome(Home home)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Home");
            Console.WriteLine("-----------------");
            Console.WriteLine(home);
        }
    }
}
