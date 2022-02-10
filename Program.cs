using System;

namespace ROUVIER_Hugo_TP6_ST2TDR
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            PizzaBuilder builder = new PizzaBuilder();

            director.MediumPizzaCheese(builder);
            Pizza pizza1 = builder.GetPizza();
            Console.WriteLine(pizza1.ToString());


            director.SmallPizzaChicken(builder);
            Pizza pizza2 = builder.GetPizza();
            Console.WriteLine(pizza2.ToString());

            director.LargePizzaPepperoni(builder);
            Pizza pizza3 = builder.GetPizza();
            Console.WriteLine(pizza3.ToString());
            

        }
    }
}
