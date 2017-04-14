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
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            CookServeDelicious form = new CookServeDelicious("Pizza");
            form.Show();
        }
    }
}
