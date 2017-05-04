using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniCookServe
{
    public class Food
    {

        string[] recipes = File.ReadAllLines("Food.csv");
        Dictionary<string, List<Recipe>> foods;
        // public string FoodName;
        private Dictionary<Keys, string> foodKeys;
        List<Recipe.Ingredient> allIngredients;
        public Recipe ActiveRecipe;

        string activeFood;




        public Food()
        {
            foods = new Dictionary<string, List<Recipe>>();
            foodKeys = new Dictionary<Keys, string>();
            allIngredients = new List<Recipe.Ingredient>(); 
           
            //loops through each recipe so it can be added to foods
            for (int i = 1; i < recipes.Length; i++)
            {
                //the data from the text file is split at each comma
                string[] data = recipes[i].Split(',');

                //the first element in the data array is the name of the food 
                string foodName = data[0];

                //the second element in the data array is the name of the recipe
                string recipeName = data[1];

                //Do we already have this food?
                //if we do not, it is added as a new food
                if (!foods.ContainsKey(foodName))
                {
                    foods.Add(foodName, new List<Recipe>());
                }

                var currentRecipe = new Recipe() { Name = recipeName };

                for (int j = 2; j < data.Length; j += 3)
                {
                    currentRecipe.Add(new Recipe.Ingredient() { Name = data[j], Key = (Keys)Enum.Parse(typeof(Keys), data[j + 1]), Image = data[j + 2] });
                }

                foods[foodName].Add(currentRecipe);

            }
        }
        public List<Recipe.Ingredient> GetFoodIngredients(string food)
        {
            for (int i = 1; i < recipes.Length; i++)
            {
    
                string[] data = recipes[i].Split(',');
                for (int j = 2; j < data.Length; j += 3)
                {
                    allIngredients.Add(new Recipe.Ingredient() { Name = data[j], Key = (Keys)Enum.Parse(typeof(Keys), data[j + 1]), Image = data[j + 2] });
                }

            }
            
            return allIngredients;
        }
        public Dictionary<Keys,string> FoodKeys(string food)
        {
            for (int i = 1; i < recipes.Length; i++)
            {
                string[] data = recipes[i].Split(',');

                for (int j = 3; j < data.Length; j += 3)
                {
                    if (!foodKeys.ContainsKey((Keys)Enum.Parse(typeof(Keys), data[j])))
                    {
                        foodKeys.Add((Keys)Enum.Parse(typeof(Keys), data[j]), data[j - 1]);
                    }
                }

            }

            return foodKeys;

        }
        public void selectFoodAndRecipe(string foodName)
        {
            activeFood = foodName;
            ActiveRecipe = SelectRandomRecipe(activeFood);
        }

        //Selects a random recipe from a given food
        private Recipe SelectRandomRecipe(string foodName)
        {
          
            //loop through foods and save recipes associated with activeFood into an array
            List<Recipe> activeFoodRecipes = new List<Recipe>();
            for (int i = 0; i < foods.Count; i++)
            {
                if (foods.ContainsKey(foodName))
                {
                    for (int j = 0; j < foods[foodName].Count; j++)
                    {
                        activeFoodRecipes.Add(foods[foodName][j]);
                    }
                }
            }

            UniqueRandomNumber uniqueNum = new UniqueRandomNumber(activeFoodRecipes.Count);
            int recipeIndex = uniqueNum.Next(0, activeFoodRecipes.Count);
            ActiveRecipe = activeFoodRecipes[recipeIndex];
            return ActiveRecipe;

        }

        public string PrintRecipe()
        {
            

            string output = "";
            for (int i = 0; i < ActiveRecipe.Count; i++)
            {

                output += ActiveRecipe[i].Name + ", ";

            }
            output = output.Remove(output.Length - 2, 2);
            bool nextLine = false;
            for (int i = 1; i < output.Length; i++)
            {
                if (i % 45 == 0)
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
