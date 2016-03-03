using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace usecasehelper
{
    public class Actor
    {

        public string name;
        public int x;
        public int y;
        public bool selected;
        public Rectangle rect;

        public Actor(string naam, int x, int y)
        {
            this.name = naam;
            this.x = x;
            this.y = y;

            selected = false;
            this.rect = new Rectangle(x - 30, y - 50, 60, 110);
        }

        public static Rectangle DrawActor(Graphics g,Pen pen, Brush brush, int x, int y,string name)
        {
            Rectangle rect = new Rectangle(x - 30, y - 50, 60, 110);
            g.FillRectangle(Brushes.White, rect);
            g.DrawEllipse(pen, x-15 , y - 50, 30, 30); //head
            g.DrawLine(pen, x, y - 20, x, y + 21); //torso
            g.DrawLine(pen, x - 30, y - 10, x + 30, y - 10); //arms
            g.DrawLine(pen, x, y + 20, x - 20, y + 60); //leftleg
            g.DrawLine(pen, x, y + 20, x + 20, y + 60);//rightleg

            g.DrawString(name, new Font("Comic Sans MS", 14), brush, x - g.MeasureString(name, new Font("Comic Sans MS", 14)).Width / 2, y + 70);

            return rect;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
