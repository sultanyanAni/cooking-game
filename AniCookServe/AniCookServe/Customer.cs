using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCookServe
{
    class Customer
    {
        public string Name;
        public string DesiredFood;
        public Food food;


        string[] names= File.ReadAllLines("Names.csv");

        //patience level to be added
        public Customer(string activeFood)
        {
            food = new Food();
            DesiredFood = activeFood;
            food.selectFoodAndRecipe(DesiredFood);

            Name = selectName();           
        }

        private string selectName()
        {
            UniqueRandomNumber uniqueNum = new UniqueRandomNumber(names.Length);
            int recipeIndex = uniqueNum.Next(0, names.Length);
            return names[recipeIndex];            
        }
        public string PrintOrder()
        {
           return Name + " wants " + food.PrintRecipe();
        }

      

    }
}
