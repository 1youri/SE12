using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace usecasehelper
{
    public class UseCase
    {

        public string text;
        public float x;
        public float y;
        public float textwidth;
        public float textheight;
        public bool selected;
        public Rectangle rect;

        public string samenvatting;
        public string actoren;
        public string aanamen;
        public string beschrijving;
        public string uitzonderingen;
        public string resultaat;

        public UseCase(Graphics g, string t, int mx, int my)
        {
            this.x = mx;
            this.y = my;
            this.text = t;

            this.textwidth = g.MeasureString(text, new Font("Comic Sans MS", 14)).Width;
            this.textheight = g.MeasureString(text, new Font("Comic Sans MS", 14)).Height;
            rect = new Rectangle(mx-10, my-10, Convert.ToInt32(textwidth)+20, Convert.ToInt32(textheight)+20);


            selected = false;
        }

        public UseCase(string text, float x, float y, float textwidth, float textheight, Rectangle rect)
        {
            this.text = text;
            this.x = x;
            this.y = y;
            this.textwidth = textwidth;
            this.textheight = textheight;
            this.rect = rect;
            selected = false;
        }
    }
}
