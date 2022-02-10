using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator CM = new();

            ParisWarehouse Paris = new(CM);
            LilleWarehouse Lille = new(CM);
            NiceWarehouse Nice = new(CM);

            Paris.Send("Nice", 100, new DateTime(2022, 12, 01));
            Paris.Send("Lille", 97, new DateTime(2022,12,03));
            Lille.Send("Nice", 75, new DateTime(2022, 12, 10));
            Nice.Send("Paris", 13, new DateTime(2022, 12, 30));
        }
    }
}
