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
    public partial class ActorForm : Form
    {
        public string ActorName { get; set; }
        public Actor actor { get; set; }

        private List<Actor> actors;
        private bool saved;

        public ActorForm(Actor a, List<Actor> actors)
        {
            InitializeComponent();
            
            this.actor = a;
            this.actors = actors;

            tbActornaam.Text = a.name;
            tbActornaam.SelectAll();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!saved)
            {
                if (Save())
                {
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                    lblInUse.Visible = true;
                }
            }
            
        }

        private bool Save()
        {
            if(LegitName())
            {
                this.ActorName = tbActornaam.Text;
                saved = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LegitName()
        {
            int duplicates = 0;
            List<Actor> testlist = new List<Actor>(actors);
            testlist[testlist.FindIndex(x => x == this.actor)].name = tbActornaam.Text;

            //testlist.Add(new Actor(tbActornaam.Text, 0, 0));
            foreach (Actor a in testlist)
            {
                if (a.name == tbActornaam.Text) duplicates++;
            }
            return duplicates <= 1;
        }
    }
}
