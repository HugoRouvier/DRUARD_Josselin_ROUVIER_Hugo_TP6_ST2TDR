using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Concrete Mediators encapsulate relations between each components 
namespace MediatorPattern
{
    class ConcreteMediator : Mediator
    {
        public void Send(Warehouse warehouse, string destination, int quantity, DateTime date)
        {
            if(destination == "Paris")
            {
                ParisWarehouse.Notify(warehouse, quantity, date);
            }
            else if (destination == "Lille")
            {
                LilleWarehouse.Notify(warehouse, quantity, date);
            }
            else if (destination == "Nice")
            {
                NiceWarehouse.Notify(warehouse, quantity, date);
            }
        }
    }
}
