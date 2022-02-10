using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Warehouse
    {
        public Mediator mediator;
        private string Name;
        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public Warehouse(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
