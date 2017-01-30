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
        public Dictionary<string, string> allIngredients = new Dictionary<string, string>();
        public Dictionary<string, string> activeIngredients = new Dictionary<string, string>();

        public Food(string name, Dictionary<string, string> ingredients)
        {

            allIngredients = ingredients;
            activeIngredients = new Dictionary<string, string>();
        }

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
