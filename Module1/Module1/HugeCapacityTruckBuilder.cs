using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class HugeCapacityTruckBuilder : TruckBuilder
    {
        public override void SetColor()
        {
            truck.Color = "Blue";
        }

        public override void SetManufactureDate()
        {
            truck.ManufactureDate = new DateTime(2000, 10, 11);
        }

        public override void SetName()
        {
            truck.Name = "Mercedes";
        }

        public override void SetPrice()
        {
            truck.Price = "50000$";
        }

        public override void SetType()
        {
            truck.Type = "Huge Capacity";
        }
    }
}
