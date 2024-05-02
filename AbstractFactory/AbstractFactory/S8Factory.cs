using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class S8Factory : TelephoneFactory
    {
        public Telephone GetTelephone(String model, String battery, int width, int height)
        {
            return new S8(model, battery, width, height);
        }
    }
}
