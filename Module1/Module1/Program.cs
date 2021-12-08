using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            TruckBuilder truckBuilder = new AverageCapacityTruckBuilder();
            Truck averageTruck = order.CreateOrder(truckBuilder);
            Console.WriteLine(averageTruck.ToString());

            truckBuilder = new HugeCapacityTruckBuilder();
            Truck HugeTruck = order.CreateOrder(truckBuilder);
            Console.WriteLine(HugeTruck.ToString());

        }
    }
}
