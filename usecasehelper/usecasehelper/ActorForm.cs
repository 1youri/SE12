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

        public ActorForm(Actor a, List<Actor> actors)
        {
            InitializeComponent();
            tbActornaam.Text = a.name;
            this.actor = a;
            tbActornaam.SelectAll();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ActorName = tbActornaam.Text;
            this.Close();
        }

        private void ActorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ActorName = tbActornaam.Text;
        }

        private void Save()
        {
            if(!CheckName())
            {
                this.ActorName = tbActornaam.Text;
                this.Close();
            }
            else
            {
                
            }
        }

        private bool CheckName()
        {
            int duplicates = 0;
            List<Actor> testlist = new List<Actor>(actors);
            testlist.Add(new Actor(tbActornaam.Text, 0, 0));
            foreach (Actor a in testlist)
            {
                if (a.name == tbActornaam.Text) duplicates++;
            }
            return duplicates < 1;
        }
    }
}
