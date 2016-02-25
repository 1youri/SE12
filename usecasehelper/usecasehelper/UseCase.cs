using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace usecasehelper
{
    class UseCase
    {

        public string text;
        public float x;
        public float y;

        public UseCase(string t, int mx, int my)
        {
            this.text = t;
            this.x = mx;
            this.y = my;
        }
    }
}
