using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniCookServe
{
    public partial class CookServeDelicious : Form
    {
        Dictionary<string, string> ingredients = new Dictionary<string, string>();
        Random gen = new Random();

        Customer Isaac;
        Dictionary<string, Food> foods;

        void init()
        {
            Dictionary<string, string> general = new Dictionary<string, string>();
            Dictionary<string, string> pizza = new Dictionary<string, string>();
            //Pizza Ingredients
            pizza.Add("Tomato Sauce", "T");
            pizza.Add("Olives", "O");
            pizza.Add("Pepperoni", "P");

            //General Ingredients
            pizza.Add("Cheese", "C");
            pizza.Add("Alfredo", "A");
            pizza.Add("Chicken", "K");
            pizza.Add("Jalapenos", "J");
            pizza.Add("Mushrooms", "M");
            pizza.Add("Bacon", "B");
            pizza.Add("Barbeque", "B");

            //creating a dictionary of ingrediencts so they can be stored with a corresponding letter index
            foods = new Dictionary<string, Food>();
            foods.Add("Pizza", new Food("Pizza", pizza));

            Isaac = new Customer(foods["Pizza"]);
            Isaac.Name = "Isaac";


            CustomerLabel.Text = Isaac.Name + " wants: " + Isaac.DesiredFood.PrintActiveValues();

        }

        public CookServeDelicious()
        {
            InitializeComponent();
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = ingredients.Keys.ElementAt(gen.Next(1, 8));
            testLabel.Text = ingredients[test];
            letterLabel.Text = test;


        }
    }
}
