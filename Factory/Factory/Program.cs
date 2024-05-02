using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telephone s8 = TelephoneFactory.GetTelephone("S8", "2600mah", 4, 7);

            Telephone note8 = TelephoneFactory.GetTelephone("Note8", "3000mah", 5, 8);

            Console.WriteLine(s8);
            Console.WriteLine(note8);

            Console.ReadLine();
        }
    }
}
