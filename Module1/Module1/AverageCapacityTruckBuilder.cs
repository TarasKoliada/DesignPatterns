using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class AverageCapacityTruckBuilder : TruckBuilder
    {
        public override void SetColor()
        {
            truck.Color = "Red";
        }

        public override void SetManufactureDate()
        {
            truck.ManufactureDate = new DateTime(1987, 7, 20);
        }

        public override void SetName()
        {
            truck.Name = "BMW";
        }

        public override void SetPrice()
        {
            truck.Price = "30000$";
        }

        public override void SetType()
        {
            truck.Type = "Average Capacity Truck";
        }
    }
}
