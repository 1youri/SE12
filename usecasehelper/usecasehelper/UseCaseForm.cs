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
        private UseCase oldUseCase;
        public int index { get; set; }
        public UseCaseForm()
        {
            InitializeComponent();
        }

        public UseCaseForm(UseCase usecase, int index)
        {
            InitializeComponent();
            oldUseCase = usecase;
            tbNaam.Text = usecase.text;
            tbSamenvatting.Text = usecase.samenvatting;
            tbActoren.Text = "nog leeg";
            tbBeschrijving.Text = usecase.beschrijving;
            tbUitzondering.Text = usecase.uitzonderingen;
            tbResultaat.Text = usecase.resultaat;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UseCase tempuc = new UseCase(tbNaam.Text,oldUseCase.x,oldUseCase.y,oldUseCase.textwidth, oldUseCase.textheight, oldUseCase.rect);
            tempuc.text = tbNaam.Text;
            tempuc.samenvatting = tbSamenvatting.Text;
            tempuc.actoren = "";
            tempuc.beschrijving = tbBeschrijving.Text;
            tempuc.uitzonderingen = tbUitzondering.Text;
            tempuc.resultaat = tbResultaat.Text;
            thisusecase = tempuc;
            this.Close();
        }
    }
}
