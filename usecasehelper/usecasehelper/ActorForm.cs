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
        public int index;

        public ActorForm(int index, string name)
        {
            InitializeComponent();
            this.index = index;
            tbActornaam.Text = name;
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
    }
}
