using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniCookServe
{
    public class Ingredient
    {
        string name;

        //associated key
        Keys key;

        //associated picture
        Image picture;

        public Ingredient(string name, Keys key, Image picture)
        {
            this.name = name;
            this.key = key;
            this.picture = picture;
        }

    }
}
