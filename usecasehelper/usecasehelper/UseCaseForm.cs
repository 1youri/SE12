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
    public partial class UseCaseForm : Form
    {
        public UseCase thisusecase { get; set; }
        public int index { get; set; }


        private UseCase oldUseCase;
        private Graphics g;
        private List<Actor> actors;
        private List<UseCase> usecases;
        private bool saved;


        public UseCaseForm()
        {
            InitializeComponent();
            saved = false;

        }

        public UseCaseForm(UseCase usecase, int index, Graphics g, List<Actor> actors,List<UseCase> usecases, List<String> selectedactors)
        {
            InitializeComponent();
            oldUseCase = usecase;
            tbNaam.Text = usecase.text;
            tbSamenvatting.Text = usecase.samenvatting;
            tbBeschrijving.Text = usecase.beschrijving;
            tbUitzondering.Text = usecase.uitzonderingen;
            tbResultaat.Text = usecase.resultaat;
            this.actors = actors;
            this.usecases = usecases;
            
            foreach (Actor a in actors)
            {
                try
                {
                    if (selectedactors.Contains(a.name)) clbActors.Items.Add(a.name, true);
                    else clbActors.Items.Add(a.name, false);
                }
                catch (NullReferenceException)
                {
                    clbActors.Items.Add(a.name, false);
                }
            }
            
            
            
                            


            this.g = g;
            this.index = index;

            tbNaam.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!saved) SaveChanges();
        }

        private void SaveChanges()
        {
            if(!Checkname())
            {
                //UseCase b = new UseCase(tbNaam.Text,oldUseCase.x,oldUseCase.y,oldUseCase.textwidth, oldUseCase.textheight, oldUseCase.rect);
                UseCase tempuc = new UseCase(index, g, tbNaam.Text, Convert.ToInt32(oldUseCase.cx), Convert.ToInt32(oldUseCase.cy));
                tempuc.text = tbNaam.Text;
                tempuc.samenvatting = tbSamenvatting.Text;
                tempuc.beschrijving = tbBeschrijving.Text;
                tempuc.uitzonderingen = tbUitzondering.Text;
                tempuc.resultaat = tbResultaat.Text;

                tempuc.actors = new List<String>();
                foreach (var lbi in clbActors.CheckedItems)
                {
                    tempuc.actors.Add(lbi.ToString());
                }

                saved = true;


                thisusecase = tempuc;
                this.Close();
            }
            
        }

        private bool Checkname()
        {
            int duplicates = 0;
            foreach (UseCase uc in usecases)
            {
                if(tbNaam.Text == uc.text)
                {
                    lblInUse.Visible = true;
                    duplicates++;
                }
            }
            return duplicates > 0;
        }

        private void UseCaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!saved)
            {
                if (Checkname())
                {
                    e.Cancel = true;
                    lblInUse.Visible = true;
                }
                else SaveChanges();
            }
               
        }
    }
}
