using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal interface Telephone
    {
        String getModel();
        String getBattery();
        int getWidth();
        int getHeight();
    }
}
