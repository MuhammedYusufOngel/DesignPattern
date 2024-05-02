using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<10;i++)
            {
                Singleton singleton = Singleton.getSingleton();
            }
            Console.ReadLine();
        }
    }
}
