using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public abstract class TruckBuilder
    {
        public Truck truck { get; set; }
        public TruckBuilder()
        {
            truck = new Truck();
        }
        

        public abstract void SetManufactureDate();
        public abstract void SetType();
        public abstract void SetName();
        public abstract void SetColor();
        public abstract void SetPrice();
    }
}
