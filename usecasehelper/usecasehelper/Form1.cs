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
        public List<UseCase> useCases;
        public List<Actor> actors;
        public List<Line> lines;

        Pen selectedpen;
        Pen defaultpen;
        Brush bgbrush;
        private int ucindex;
        private int acindex;


        public Form1()
        {
            InitializeComponent();

            useCases = new List<UseCase>();
            actors = new List<Actor>();
            lines = new List<Line>();

            selectedpen = new Pen(Color.Red, 4);
            defaultpen = new Pen(Color.Black, 2);
            bgbrush = new SolidBrush(Color.White);

            ucindex = 0;
            acindex = 0;

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
                            form = new UseCaseForm(u, index, this.CreateGraphics(),actors,useCases,u.actors);
                            form.ShowDialog();
                            ucupdate = true;
                            

                        }
                        u.selected = true;
                        selectionfound = true;
                    }
                    else u.selected = false;
                    index++;
                }

                if(ucupdate)
                {
                    useCases[form.index] = form.thisusecase;
                    UpdateLines();
                }
                
                if (!selectionfound)
                {
                    useCases.Add(new UseCase(ucindex, this.CreateGraphics(), "Click to insert Text", mouseX, mouseY));
                    form = new UseCaseForm(useCases[ucindex], ucindex, this.CreateGraphics(), actors, useCases, useCases[ucindex].actors);
                    form.ShowDialog();
                    useCases[ucindex] = form.thisusecase;
                    UpdateLines();

                    ucindex++;
                }
                pbDraw.Refresh();
            }
            if(rbActor.Checked)
            {
                int index = 0;
                bool acupdate = false;
                ActorForm form = new ActorForm(0, "___");

                foreach (Actor a in actors)
                {
                    if (a.rect.Contains(e.Location))
                    {
                        if (a.selected)
                        {
                            form = new ActorForm(index,a.name);
                            form.ShowDialog();
                            acupdate = true;
                        }
                        a.selected = true;
                        selectionfound = true;
                    }
                    else a.selected = false;
                    index++;
                    
                }
                if (acupdate) actors[form.index].name = form.ActorName;
                if(!selectionfound)
                {
                    actors.Add(new Actor(acindex, "___", mouseX, mouseY));
                    form = new ActorForm(acindex, "actor name");
                    form.ShowDialog();
                    actors[acindex].name = form.ActorName;
                    UpdateLines();



                    acindex++;
                }
                pbDraw.Refresh();
            }

            if(rbLine.Checked)
            {
                int ux;
                int uy;
                int ax;
                int ay;
                foreach (UseCase u in useCases)
                {
                    if(u.rect.Contains(e.Location))
                    {
                        ux = Convert.ToInt32(u.cx);
                        uy = Convert.ToInt32(u.cy);
                    }
                }
                foreach (Actor a in actors)
                {
                    if(a.rect.Contains(e.Location))
                    {
                        ax = a.x;
                        ay = a.y;
                    }
                }
            }

        }

        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            Brush toBrush = new SolidBrush(Color.Black);
            Pen toPen = defaultpen;
            Graphics g = e.Graphics;

            foreach (Line l in lines)
            {
                g.DrawLine(defaultpen, l.x1, l.y1, l.x2, l.y2);
            }

            foreach (UseCase u in useCases)
            {
                if (u.selected) toBrush = new SolidBrush(Color.Red);
                else toBrush = new SolidBrush(Color.Black);
                if (u.selected) toPen = selectedpen;
                else toPen = defaultpen;

                g.FillEllipse(bgbrush, u.rect);
                g.DrawString(u.text, new Font("Comic Sans MS", 14), toBrush, u.x, u.y);
                g.DrawEllipse(toPen, u.rect);

                
                
            }

            foreach (Actor a in actors)
            {
                if (a.selected) toBrush = new SolidBrush(Color.Red);
                else toBrush = new SolidBrush(Color.Black);
                if (a.selected) toPen = selectedpen;
                else toPen = defaultpen;

                Actor.DrawActor(g,toPen, toBrush, a.x, a.y,a.name);
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            useCases.Clear();
            actors.Clear();
            UpdateLines();
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

        private void UpdateLines()
        {
            lines = new List<Line>();
            foreach (UseCase uc in useCases)
            {
                foreach (Actor a in actors)
                {
                    if (uc.actors.Contains(a.name))
                    {
                        lines.Add(new Line(Convert.ToInt32(uc.cx), Convert.ToInt32(uc.cy), a.x, a.y));
                    }
                }
            }
        }

        private void rbActor_CheckedChanged(object sender, EventArgs e)
        {
            DeselectAll();
        }

        private void rbUseCase_CheckedChanged(object sender, EventArgs e)
        {
            DeselectAll();
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {
            DeselectAll();
        }

        private void DeselectAll()
        {
            foreach (UseCase u in useCases)
            {
                u.selected = false;
            }
            foreach (Actor a in actors)
            {
                a.selected = false;
            }
            

            pbDraw.Refresh();
        }
    }
}
