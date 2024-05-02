using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    //Factory Design Pattern: Sınıfın içinde kurucu-yıkıcı fonksiyon olmayan, başka sınıflardan nesne üreten bir tasarım kalıbıdır.
    internal class TelephoneFactory
    {
        //Aslında ürettiğimiz şey Telephone nesnesi
        public static Telephone GetTelephone(String model, String battery, int width, int height)
        {
            Telephone telephone;

            Console.WriteLine(model);

            if (model == "S8")
                telephone = new S8(model, battery, width, height);

            else if (model == "Note8")
                telephone = new Note8(model, battery, width, height);

            else
                throw new Exception("Geçerli bir model değildir!");


            return telephone;
        }
    }
}
