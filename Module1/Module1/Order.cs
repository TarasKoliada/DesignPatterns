using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Order
    {
        public Truck CreateOrder(TruckBuilder truckBuilder)
        {
            truckBuilder.SetManufactureDate();
            truckBuilder.SetName();
            truckBuilder.SetPrice();
            truckBuilder.SetType();
            truckBuilder.SetColor();
            return truckBuilder.truck;
        }
    }
}
