using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class LilleWarehouse : Warehouse
    {
        public LilleWarehouse(Mediator mediator) : base(mediator)
        { this.SetName("Lille"); }

        public void Send(string destination, int quantity, DateTime date)
        {
            Console.WriteLine(date + " - " + this.GetName() + " " + quantity + " stock in transit...");
            mediator.Send(this, destination, quantity, date);
        }

        public static void Notify(Warehouse warehouse, int quantity, DateTime date)
        {
            Console.WriteLine(date + " - Lille Warehouse receive " + quantity + " stocks from "
              + warehouse.GetName());
        }
    }
}
