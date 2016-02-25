using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usecasehelper
{
    public partial class Form1 : Form
    {
        List<UseCase> useCases = new List<UseCase>();
        Pen selectedpen = new Pen(Color.Red, 4);
        Pen defaultpen = new Pen(Color.Black, 2);


        public Form1()
        {
            InitializeComponent();
        }

        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            int mouseX = e.Location.X;
            int mouseY = e.Location.Y;

            if (rbUseCase.Checked)
            {
                useCases.Add(new UseCase("Click to insert Text", mouseX, mouseY));
                pbDraw.Refresh();
            }

        }

        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (UseCase u in useCases)
            {
                float textwidth = g.MeasureString(u.text, new Font("Comic Sans MS", 14)).Width;
                float textheight = g.MeasureString(u.text, new Font("Comic Sans MS", 14)).Height;

                g.DrawString(u.text, new Font("Comic Sans MS", 14), new SolidBrush(Color.Black), u.x, u.y);


                g.DrawEllipse(defaultpen, u.x-10, u.y-10, textwidth+20, textheight+20);
            }
        }
    }
}
