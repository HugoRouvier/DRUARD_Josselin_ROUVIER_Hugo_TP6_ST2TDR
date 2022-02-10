using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROUVIER_Hugo_TP6_ST2TDR
{
    class PizzaBuilder : Builder
    {
        private Pizza Pizza; 

        public PizzaBuilder(){ this.Pizza = new Pizza(); }

        void Builder.reset()
        {
            this.Pizza = new Pizza();
        }
        void Builder.setSize(string size)
        {
            Pizza.SetSize(size);
        }

        void Builder.setPate(string pate)
        {
            Pizza.SetPate(pate);
        }

        void Builder.setSauce(string sauce)
        {
            Pizza.SetSauce(sauce);
        }

        void Builder.setIngredient(string ingredients)
        {
            Pizza.SetIngredients(ingredients);
        }

        public Pizza GetPizza() 
        {
            return this.Pizza;
        }


    }
}
