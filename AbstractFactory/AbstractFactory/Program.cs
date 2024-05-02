using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        //Abstract Factory Design Pattern: Çok fazla üretmemiz gereken nesnelerde if-else kullanmak yerine dilediğimiz nesneyi kendimiz çağırırız.
        static void Main(string[] args)
        {
            S8Factory factory = new S8Factory();
            Telephone s8 = factory.GetTelephone("S8", "2600mah", 2, 9);

            Note8Factory note8Factory = new Note8Factory();
            Telephone note8 = note8Factory.GetTelephone("Note8", "3000mah", 4, 10);

            Console.WriteLine(note8);
            Console.WriteLine("------------");
            Console.WriteLine(s8);
            Console.ReadLine();
        }
    }
}
