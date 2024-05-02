using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class S8 : Telephone
    {
        private String model;
        private String battery;
        private int width;
        private int height;

        public S8(string model, string battery, int width, int height)
        {
            this.model = model;
            this.battery = battery;
            this.width = width;
            this.height = height;
        }
        
        public String getModel()
        {
            return model;
        }

        public String getBattery()
        {
            return battery;
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public override String ToString()
        {
            return "Model: " + model +
                "\nBattery: " + battery +
                "\nWidth: " + width +
                "\nHeight: " + height;
        }

    }
}
