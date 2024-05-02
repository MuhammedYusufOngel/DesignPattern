using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Abstract Factory Design Pattern: Çok fazla üretmemiz gereken nesnelerde if-else kullanmak yerine dilediğimiz nesneyi kendimiz çağırırız.
    internal interface TelephoneFactory
    {
        Telephone GetTelephone(String model, String battery, int width, int height);
    }
}
