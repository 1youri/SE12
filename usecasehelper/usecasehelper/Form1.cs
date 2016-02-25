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
        public List<UseCase> useCases = new List<UseCase>();
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
            bool selectionfound = false;

            if (rbUseCase.Checked)
            {
                int index = 0;
                bool ucupdate = false;
                UseCaseForm form = new UseCaseForm();

                foreach (UseCase u in useCases)
                {
                    
                    if(u.rect.Contains(e.Location))
                    {
                        if (u.selected)
                        {
                            form = new UseCaseForm(u, index);
                            form.ShowDialog();
                            ucupdate = true;
                            

                        }
                        u.selected = true;
                        selectionfound = true;
                    }
                    else u.selected = false;
                    index++;
                }

                if(ucupdate) useCases[form.index] = form.thisusecase;
                if (!selectionfound) useCases.Add(new UseCase(this.CreateGraphics(),"Click to insert Text", mouseX, mouseY));
                pbDraw.Refresh();
            }

        }

        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (UseCase u in useCases)
            {
                Brush toBrush = new SolidBrush(Color.Black);
                if (u.selected) toBrush = new SolidBrush(Color.Red);

                Pen toPen;
                if (!u.selected) toPen = defaultpen;
                else toPen = selectedpen;

                g.DrawString(u.text, new Font("Comic Sans MS", 14), toBrush, u.x, u.y);
                g.DrawEllipse(toPen, u.rect);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            useCases.Clear();
            pbDraw.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeSelected();
        }

        private void removeSelected()
        {
            int toRemove = -1;
            int index = 0;
            foreach (UseCase u in useCases)
            {
                if (u.selected)
                {
                    toRemove = index;
                }
                index++;
            }
            if (toRemove != -1)
            {
                useCases.RemoveAt(toRemove);
                removeSelected();
                pbDraw.Refresh();
            }
        }
    }
}
