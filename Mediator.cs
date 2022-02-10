using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The Mediator interface which decalre methods of communication with components
namespace MediatorPattern
{
    interface Mediator
    {
        public void Send(Warehouse warehouse, string destination, int quantity, DateTime date);
    }
}
