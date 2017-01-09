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
    public partial class Form1 : Form
    {
        Dictionary<string, string> ingredients = new Dictionary<string, string>();
        Random gen = new Random();
        void init()
        {
     
            //creating a dictionary of ingrediencts so they can be stored with a corresponding letter index
            
            ingredients.Add("C", "Cheese");
            ingredients.Add("M", "Marinara");
            ingredients.Add("A", "Alfredo");
            ingredients.Add("P", "Pepperoni");
            ingredients.Add("K", "Chicken");
            ingredients.Add("J", "Jalapenos");
            ingredients.Add("S", "Mushrooms");
            ingredients.Add("O", "Olives");
            ingredients.Add("B","Bacon");
            ingredients.Add("Q", "Barbeque")
        }

        public Form1()
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
