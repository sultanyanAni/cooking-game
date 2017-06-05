using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniCookServe
{
    public partial class FoodKey : UserControl
    {
        public string key;
        Image deactivatedBackground;
        public FoodKey()
        {
            InitializeComponent();
            deactivatedBackground = Image.FromFile("Resources\\deactivatedFoodKeyBackground.png");
        }
        public void Init(Keys key, string ingredient)
        {
            foodKeyLabel.Text = key.ToString();
            this.key = key.ToString();
            ingredientLabel.Text = ingredient;
        }

        public void deactivateKey()
        {

            foodKeyBackground.BackgroundImage = deactivatedBackground;
            foodKeyLabel.BackColor = Color.DimGray;

        }


    }
}
