using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROUVIER_Hugo_TP6_ST2TDR
{
    class Director
    {
        private Builder builder;


        void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }

        public void MediumPizzaCheese(Builder builder)
        {
            builder.reset();
            builder.setSize("medium");
            builder.setPate("fine");
            builder.setSauce("tomate");
            builder.setIngredient("cheese + mozzarella + goat cheese");
        }

        public void SmallPizzaChicken(Builder builder)
        {
            builder.reset();
            builder.setSize("small");
            builder.setPate("large");
            builder.setSauce("cream");
            builder.setIngredient("chicken + onion + pepper");
        }

        public void LargePizzaPepperoni(Builder builder)
        {
            builder.reset();
            builder.setSize("large");
            builder.setPate("crust");
            builder.setSauce("Tomato");
            builder.setIngredient("mozzarella + pepperoni + pepper + onion + japalenos");
        }

    }
}
