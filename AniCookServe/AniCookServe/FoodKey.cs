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
        public FoodKey()
        {
            InitializeComponent();
        }
        public void Init(string key, string ingredient)
        {
            foodKeyLabel.Text = key;
            ingredientLabel.Text = ingredient;
        }

       
    }
}
