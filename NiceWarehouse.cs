using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Components are various classes that contain the main logic
namespace MediatorPattern
{
    class NiceWarehouse : Warehouse

    {
        public NiceWarehouse(Mediator mediator) : base(mediator)
        { this.SetName("Nice"); }

        public void Send(string destination, int quantity, DateTime date)
        {
            Console.WriteLine(date + " - " + this.GetName() + " " + quantity + " stock in transit...");
            mediator.Send(this, destination, quantity, date);
        }

        public static void Notify(Warehouse warehouse, int quantity, DateTime date)
        {
            Console.WriteLine(date + " - Nice Warehouse receive " + quantity + " stocks from "
                + warehouse.GetName());
        }
    }
}
