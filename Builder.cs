using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROUVIER_Hugo_TP6_ST2TDR
{
    interface Builder
    {
        void reset() { }
        void setSize(string size) { }
        void setPate(string pate) { }
        void setSauce(string sauce){ }
        void setIngredient(string ingredients) { }

    }
}
