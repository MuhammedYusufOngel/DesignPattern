using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Note8Factory : TelephoneFactory
    {
        public Telephone GetTelephone(String model, String battery, int width, int height)
        {
            return new Note8(model, battery, width, height);
        }
    }
}
