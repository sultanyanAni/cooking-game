using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniCookServe
{
    public partial class CookServeDelicious : Form
    {
        Random gen = new Random();
        Bitmap canvas;
        Graphics gfx;
        Customer Isaac;

        int x;
        int y;
        int pizzaX;
        int pizzaY;

        Dictionary<string, string> ingredients = new Dictionary<string, string>();
        Dictionary<string, bool> ingredientUsed;
        Dictionary<string, Food> foods;

        /// <summary>
        /// creates and returns a new FoodKey and places it at a specified location
        /// </summary>
        /// <param name="key">key that represents ingredient</param>
        /// <param name="ingredient">ingredient that will be printed in the FoodKey</param>
        /// <param name="location">point that the FoodKey will be located at</param>
        /// <returns></returns>
        FoodKey createNewFoodKey(string key, string ingredient, Point location)
        {
            FoodKey keyToCreate;
            keyToCreate = new FoodKey();
            keyToCreate.Init(key, ingredient);
            keyToCreate.Location = location;

            return keyToCreate;
        }

        void init()
        {
            canvas = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            gfx = Graphics.FromImage(canvas);

            x = ClientSize.Width - 230;
            y = 0;
            pizzaX = ClientSize.Width / 5;
            pizzaY = 40;

            ingredientUsed = new Dictionary<string, bool>();
            ingredientUsed.Add("Tomato Sauce", false);
            ingredientUsed.Add("Olives", false);
            ingredientUsed.Add("Pepperoni", false);

            ingredientUsed.Add("Cheese", false);
            ingredientUsed.Add("Alfredo", false);
            ingredientUsed.Add("Chicken", false);
            ingredientUsed.Add("Jalapenos", false);
            ingredientUsed.Add("Mushrooms", false);
            ingredientUsed.Add("Bacon", false);
            ingredientUsed.Add("Barbeque", false);

            // Dictionary<string, string> general = new Dictionary<string, string>();
            Dictionary<string, string> pizza = new Dictionary<string, string>();

            //Pizza Ingredients
            pizza.Add("Tomato Sauce", "T");
            pizza.Add("Olives", "O");
            pizza.Add("Pepperoni", "P");

            pizza.Add("Cheese", "C");
            pizza.Add("Alfredo", "A");
            pizza.Add("Chicken", "K");
            pizza.Add("Jalapenos", "J");
            pizza.Add("Mushrooms", "M");
            pizza.Add("Bacon", "B");
            pizza.Add("Barbeque", "Q");

            foods = new Dictionary<string, Food>();
            foods.Add("Pizza", new Food("Pizza", pizza));

            Isaac = new Customer(foods["Pizza"]);
            Isaac.Name = "Isaac";

            for (int i = 0; i < pizza.Count; i++)
            {
                FoodKey newFoodKey = createNewFoodKey(pizza.Values.ElementAt(i), pizza.Keys.ElementAt(i), new Point(x, y));

                Controls.Add(newFoodKey);
                y += newFoodKey.Height;
            }

            CustomerLabel.Text = Isaac.Name + " wants: " + Isaac.DesiredFood.PrintActiveValues();
        }

        public CookServeDelicious()
        {
            InitializeComponent();
            init();
            this.KeyDown += CookServeDelicious_KeyDown;
        }


        bool sauceDrawn = false;

        private void CookServeDelicious_KeyDown(object sender, KeyEventArgs e)
        {
            if (sauceDrawn == false)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        testLabel.Text = "Alfredo";
                        ingredientUsed["Alfredo"] = true;
                        sauceDrawn = true;
                        break;
                    case Keys.T:
                        testLabel.Text = "Tomato Sauce";
                        ingredientUsed["Tomato Sauce"] = true;
                        sauceDrawn = true;
                        break;
                    case Keys.Q:
                        testLabel.Text = "Barbeque";
                        ingredientUsed["Barbeque"] = true;
                        sauceDrawn = true;
                        break;
                    default:
                        testLabel.Text = "SAUCE FIRST";
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.P:
                        testLabel.Text = "Pepperoni";
                        ingredientUsed["Pepperoni"] = true;
                        break;
                    case Keys.K:
                        testLabel.Text = "Chicken";
                        ingredientUsed["Chicken"] = true;
                        break;
                    case Keys.C:
                        testLabel.Text = "Cheese";
                        ingredientUsed["Cheese"] = true;
                        break;
                    case Keys.M:
                        testLabel.Text = "Mushrooms";
                        ingredientUsed["Mushrooms"] = true;
                        break;
                    case Keys.O:
                        testLabel.Text = "Olives";
                        ingredientUsed["Olives"] = true;
                        break;
                    case Keys.J:
                        testLabel.Text = "Jalapenos";
                        ingredientUsed["Jalapenos"] = true;
                        break;
                    case Keys.B:
                        testLabel.Text = "Bacon";
                        ingredientUsed["Bacon"] = true;
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gfx.DrawImage(Properties.Resources.pizzaDough, new Point(pizzaX, pizzaY));

            if (ingredientUsed["Alfredo"] == true)
            {
                gfx.DrawImage(Properties.Resources.alfredoSauce, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Tomato Sauce"] == true)
            {
                gfx.DrawImage(Properties.Resources.tomatoSauce, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Barbeque"] == true)
            {
                gfx.DrawImage(Properties.Resources.bbqSauce, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Cheese"] == true)
            {
                gfx.DrawImage(Properties.Resources.cheese, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Bacon"] == true)
            {
                gfx.DrawImage(Properties.Resources.bacon, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Chicken"] == true)
            {
                gfx.DrawImage(Properties.Resources.chicken, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Jalapenos"] == true)
            {
                gfx.DrawImage(Properties.Resources.jalapenos, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Mushrooms"] == true)
            {
                gfx.DrawImage(Properties.Resources.mushroom, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Olives"] == true)
            {
                gfx.DrawImage(Properties.Resources.olives, new Point(pizzaX, pizzaY));
            }
            if (ingredientUsed["Pepperoni"] == true)
            {
                gfx.DrawImage(Properties.Resources.pepperoni, new Point(pizzaX, pizzaY));
            }
            mainPictureBox.Image = canvas;
        }


    }
}
