using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCookServe
{
    public class Food
    {
        public string FoodName;

        //all ingredients that can be used to create a specfic type of food
        public Dictionary<string, string> allIngredients = new Dictionary<string, string>();

        //active ingredients that a customer wants on their food 
        public Dictionary<string, string> activeIngredients = new Dictionary<string, string>();

        /// <summary>
        /// Creates food that has a name and has its own set of ingredients. 
        /// </summary>
        /// <param name="name">name of the food</param>
        /// <param name="ingredients">dictionary of ingredients that can be used to create food</param>
        public Food(string name, Dictionary<string, string> ingredients)
        {

            allIngredients = ingredients;
            activeIngredients = new Dictionary<string, string>();
        }

        /// <summary>
        /// loads a random number of random toppings
        /// (WILL BE REPLACED WITH RECIPES)
        /// </summary>
        public void loadActiveIngredients()
        {
            UniqueRandomNumber uniqueNum = new UniqueRandomNumber(allIngredients.Count);
            int numOfToppings = Global.Random.Next(1, allIngredients.Count);
            for (int i = 0; i < numOfToppings; i++)
            {
                int index = uniqueNum.Next(0, allIngredients.Count);
                string key = allIngredients.Keys.ElementAt(index);
                string value = allIngredients.Values.ElementAt(index);
                activeIngredients.Add(key, value);
            }
        }

        /// <summary>
        /// Returns a string that prints out a list of randomly chosen ingredients.
        /// (WILL PRINT OUT SPECIFIC RECIPES)
        /// </summary>
        /// <returns></returns>
        public string PrintActiveValues()
        {
            string output = "";
            for (int i = 0; i < activeIngredients.Count; i++)
            {

                output += activeIngredients.Keys.ElementAt(i) + ", ";

            }
            output = output.Remove(output.Length - 2, 2);
            bool nextLine = false;
            for (int i = 1; i < output.Length; i++)
            {
                if (i % 50 == 0)
                {
                    nextLine = true;
                }
                if (nextLine && output[i] == ' ')
                {
                    output = output.Insert(i, "\n");
                    nextLine = false;
                }
            }

            return output;
        }





    }
}
