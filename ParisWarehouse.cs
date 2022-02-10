using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class ParisWarehouse : Warehouse
    {
        public ParisWarehouse(Mediator mediator) : base(mediator)
        { this.SetName("Paris"); }

        public void Send(string destination, int quantity, DateTime date)
        {
            Console.WriteLine(date + " - " + this.GetName() + " " + quantity + " stock in transit...");
            mediator.Send(this, destination, quantity, date);
        }

        public static void Notify(Warehouse warehouse, int quantity, DateTime date)
        {
            Console.WriteLine(date + " - Paris Warehouse receive " + quantity + " stocks from "
              + warehouse.GetName());
        }
    }
}
