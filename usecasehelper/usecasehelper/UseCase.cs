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
        public List<String> actors;

        public int index;
        public string text;
        public int x;
        public int y;
        public float textwidth;
        public float textheight;
        public bool selected;
        public Rectangle rect;

        public string samenvatting;
        public string aanamen;
        public string beschrijving;
        public string uitzonderingen;
        public string resultaat;
        

        public float cx;
        public float cy;

        public UseCase(int index, Graphics g, string t, int mx, int my)
        {
            this.cx = mx;
            this.cy = my;
            this.text = t;
            this.index = index;

            this.textwidth = g.MeasureString(text, new Font("Comic Sans MS", 14)).Width;
            this.textheight = g.MeasureString(text, new Font("Comic Sans MS", 14)).Height;

            this.x = Convert.ToInt32(cx - textwidth / 2);
            this.y = Convert.ToInt32(cy - textheight / 2);

            rect = new Rectangle(x-10, y-10, Convert.ToInt32(textwidth)+20, Convert.ToInt32(textheight)+20);


            selected = false;
        }
    }
}
