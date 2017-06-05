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
        Queue<Customer> customers;
        Food food = new Food();
        List<FoodKey> foodKeys;
        List<Recipe.Ingredient> usedIngredients;
        LayerControl layers;
        string activeFood;
        int x;
        int y;
        int foodX;
        int foodY;
        Customer currentCustomer;
        string foodImage;
        Recipe.Ingredient currentIngredient;


        /// <summary>
        /// creates and returns a new FoodKey and places it at a specified location
        /// </summary>
        /// <param name="key">key that represents ingredient</param>
        /// <param name="ingredient">ingredient that will be printed in the FoodKey</param>
        /// <param name="location">point that the FoodKey will be located at</param>
        /// <returns></returns>
        FoodKey addNewFoodKey(Keys key, string ingredient, Point location)
        {
            FoodKey keyToCreate;
            keyToCreate = new FoodKey();
            keyToCreate.Init(key, ingredient);
            keyToCreate.Location = location;

            return keyToCreate;
        }
        void init()
        {
            foodKeys = new List<FoodKey>();
            layers = new LayerControl();
            usedIngredients = new List<Recipe.Ingredient>();
            customers = new Queue<Customer>();
            canvas = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            gfx = Graphics.FromImage(canvas);

            x = ClientSize.Width - 230;
            y = 0;
            foodX = ClientSize.Width / 5;
            foodY = 40;
        }
        public CookServeDelicious(string foodName)
        {
            InitializeComponent();
            init();
            this.KeyDown += CookServeDelicious_KeyDown;
            activeFood = foodName;
            customers.Enqueue(new Customer(activeFood));
            currentCustomer = customers.First();
        }
        private void CookServeDelicious_Load(object sender, EventArgs e)
        {

            gfx.DrawImage(Image.FromFile("Resources\\pizzaDough.png"), new Point(foodX, foodY));
            for (int i = 0; i < currentCustomer.food.FoodKeys(activeFood).Count; i++)
            {
                Keys keyIndex = currentCustomer.food.FoodKeys(activeFood).ToList()[i].Key;
                FoodKey newFoodKey = addNewFoodKey(keyIndex, currentCustomer.food.FoodKeys(activeFood)[keyIndex], new Point(x, y));

                Controls.Add(newFoodKey);
                foodKeys.Add(newFoodKey);
                y += newFoodKey.Height;
            }
        }

     
        private void CookServeDelicious_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (var ingredient in currentCustomer.food.GetFoodIngredients(activeFood))
            {
                if (e.KeyCode == ingredient.Key)
                {
                    layers.Add(ingredient);
                    foreach(var foodKey in foodKeys)
                    {
                       if(foodKey.key == ingredient.Key.ToString())
                        {
                            foodKey.deactivateKey();
                        }
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    submitOrder();
                    break;
                }
            }



        }

        private void submitOrder()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (customers.Count < 4)
            {
                customers.Enqueue(new Customer(activeFood));
            }


            layers.Draw(gfx, new Point(foodX, foodY));


            CustomerLabel.Text = customers.First().PrintOrder();
            mainPictureBox.Image = canvas;
        }

    }
}
