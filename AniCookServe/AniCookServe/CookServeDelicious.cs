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
        string activeFood;
        int x;
        int y;
        int foodX;
        int foodY;

        string foodImage;
        
        

        /// <summary>
        /// creates and returns a new FoodKey and places it at a specified location
        /// </summary>
        /// <param name="key">key that represents ingredient</param>
        /// <param name="ingredient">ingredient that will be printed in the FoodKey</param>
        /// <param name="location">point that the FoodKey will be located at</param>
        /// <returns></returns>
        FoodKey createNewFoodKey(Keys key, string ingredient, Point location)
        {
            FoodKey keyToCreate;
            keyToCreate = new FoodKey();
            keyToCreate.Init(key, ingredient);
            keyToCreate.Location = location;

            return keyToCreate;
        }

  
       
        void init()
        {
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
            customers.Enqueue(new Customer(activeFood) );
        }
        private void CookServeDelicious_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < customers.First().food.FoodKeys(activeFood).Count; i++)
            {
                Keys keyIndex = customers.First().food.FoodKeys(activeFood).ToList()[i].Key;
                FoodKey newFoodKey = createNewFoodKey(keyIndex, customers.First().food.FoodKeys(activeFood)[keyIndex], new Point(x,y));

                Controls.Add(newFoodKey);
                y += newFoodKey.Height;
            }
            
        }

        private void CookServeDelicious_KeyDown(object sender, KeyEventArgs e)
        {
            foreach(var ingredient in customers.First().food.ActiveRecipe)
            {
                if (e.KeyCode == ingredient.Key)
                {
                    foodImage = ingredient.Image;
                }
                if(e.KeyCode == Keys.Enter)
                {
                    submitOrder();
                    break;
                }
            }


          
        }

        private void submitOrder()
        {
            
        }
        Image newImage;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (customers.Count < 4)
            {
                customers.Enqueue(new Customer(activeFood));
            }
            if (foodImage != null)
            {
                newImage = Image.FromFile(foodImage);
                gfx.DrawImage(newImage, new Point(foodX, foodY));
            }

            
            CustomerLabel.Text = customers.First().PrintOrder();
       
        }

    }
}
