using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Design_Pattern
{
    //Singleton, bir sınıfın program içinde sadece bir kere oluşmasıdır.
    internal class Singleton
    {
        //Sınıfın içinde sınıf oluşur. (Everloading)
        private static Singleton instance;

        private static int sayi = 0;

        //Belirli bir nesne üzerinde eşzamanlı erişimi kısıtlar (Java'daki synchronized komutu gibi)
        private static readonly object lockObject = new object();

        private Singleton()
        {
            Console.WriteLine("Oluştu");
        }
        public static Singleton getSingleton()
        {
            sayi++;
            Console.WriteLine(sayi);

            
            //Lazy Loading
            if(instance == null)
            {
                lock(lockObject)
                {
                    instance = new Singleton();
                }
                
            }

            return instance;
        }

    }
}
