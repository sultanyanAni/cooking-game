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
        Dictionary<string, string> ingredients = new Dictionary<string, string>();
        Random gen = new Random();

        Customer Isaac;
        Dictionary<string, Food> foods;
        int x;
        int y;
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
            x = ClientSize.Width - 230;
            y = 0;
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

        private void CookServeDelicious_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                testLabel.Text = "Pepperoni";
            }
            else if (e.KeyCode == Keys.K)
            {
                testLabel.Text = "Chicken";
            }
            else if(e.KeyCode == Keys.C)
            {
                testLabel.Text = "Cheese";
            }
            else if(e.KeyCode == Keys.M)
            {
                testLabel.Text = "Mushrooms";
            }
            else if(e.KeyCode == Keys.A)
            {
                testLabel.Text = "Alfredo";
            }
            else if(e.KeyCode == Keys.T)
            {
                testLabel.Text = "Tomato Sauce";
            }
            else if(e.KeyCode == Keys.O)
            {
                testLabel.Text = "Olives";
            }
            else if(e.KeyCode == Keys.J)
            {
                testLabel.Text = "Jalapenos";
            }
            else if(e.KeyCode == Keys.B)
            {
                testLabel.Text = "Bacon";
            }
            else if(e.KeyCode == Keys.Q)
            {
                testLabel.Text = "Barbeque";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CustomerLabel.Focus();
            //erase

            //draw

        }
    }
}
