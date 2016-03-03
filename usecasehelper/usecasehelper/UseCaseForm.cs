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


        public UseCase oldUseCase;
        private Graphics g;
        private int startcount;
        private List<UseCase> usecases;
        private bool saved;


        public UseCaseForm()
        {
            InitializeComponent();
            saved = false;

        }

        public UseCaseForm(UseCase usecase, Graphics g, List<Actor> actors,List<UseCase> usecases)
        {
            InitializeComponent();
            oldUseCase = usecase;
            tbNaam.Text = usecase.text;
            tbSamenvatting.Text = usecase.samenvatting;
            tbBeschrijving.Text = usecase.beschrijving;
            tbUitzondering.Text = usecase.uitzonderingen;
            tbResultaat.Text = usecase.resultaat;
            List<String> actorlist = usecases[usecases.FindIndex(x => x == usecase)].actors;
            this.usecases = usecases;

            
            foreach (Actor a in actors)
            {
                try
                {
                    if (actorlist.Contains(a.name)) clbActors.Items.Add(a.name, true);
                    else clbActors.Items.Add(a.name, false);
                }
                catch (NullReferenceException)
                {
                    clbActors.Items.Add(a.name, false);
                }
            }
            
            
            
                            


            this.g = g;

            tbNaam.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Save()
        {
            if(LegitName())
            {
                UseCase tempuc = new UseCase(g, tbNaam.Text, Convert.ToInt32(oldUseCase.cx), Convert.ToInt32(oldUseCase.cy));
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
                return true;
            }
            return false;
        }

        private bool LegitName()
        {
            List<UseCase> testlist = new List<UseCase>(usecases);
            testlist[testlist.FindIndex(x => x == this.oldUseCase)].text = tbNaam.Text;

            int duplicates = 0;
            foreach (UseCase uc in testlist)
            {
                if(tbNaam.Text == uc.text)
                {
                    duplicates++;
                }
            }
            return duplicates <= 1;
        }

        private void UseCaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!saved)
            {
                if (LegitName())
                {
                    Save();
                }
                else
                {
                    e.Cancel = true;
                    lblInUse.Visible = true;
                }
                    
            }
               
        }
    }
}
