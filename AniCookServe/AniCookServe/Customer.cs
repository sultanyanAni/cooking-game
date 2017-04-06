using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCookServe
{
    class Customer
    {
        public string Name;
        public Food DesiredFood; 


        //patience level to be added


        public Customer(Food food)
        {
            DesiredFood = food;
            DesiredFood.loadActiveIngredients();
        }

    }
}
