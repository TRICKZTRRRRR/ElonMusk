using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonMusk
{
    #region Model
    public class RCCar
    {
        private sbyte batteryCapacity;
        private int hasDroven;
        private sbyte batteryLife;
        private string color;

        public sbyte BatteryCapacity
        {
            get { return batteryCapacity; }
            set { batteryCapacity = value; }
        }

        public int HasDroven
        {
            get { return hasDroven; }
            private set { hasDroven = value;}
        }

        public sbyte BatteryLife
        {
            get { return batteryLife; }
            private set { batteryLife = value;}
        }

        public string Color
        {
            get { return color; }
            private set { color = value; }
        }
    }
    #endregion
}
