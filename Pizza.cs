using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROUVIER_Hugo_TP6_ST2TDR
{
    class Pizza
    {
        private string Size;
        private string Sauce;
        private string Pate;
        private string Ingredients;

        public void SetSize(string size)
        {
            this.Size = size;
        }
        public void SetPate(String pate)
        {
            this.Pate = pate;
        }

        public void SetSauce(String sauce)
        {
            this.Sauce = sauce;
        }

        public void SetIngredients(String contenu)
        {
            this.Ingredients = contenu;
        }

        override
        public String ToString()
        {
            return "Pizza [ Taille = " + Size + "Pate =" + Pate + ", Sauce =" + Sauce + ", Ingredients =" + Ingredients + "]";
        }
    }
}
