using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biografen
{
    public partial class View : Form, IView
    {
        private Model model = new Model();
        private IPresenter iPresenter;

        public View()
        {
            InitializeComponent();
        }

        public Model Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;

                txtAntal.Text = model.LedigaPlatser;
                lblResultat.Text = model.Resultat;
            }
        }

        public void AttachPresenter(IPresenter presenter)
        {
            iPresenter = presenter;
        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            model.Resultat = lblResultat.Text;
            model.LedigaPlatser = txtAntal.Text;

            // Nedan kan man anropa olika metoder i (I)Presenter klassen
            iPresenter.CheckNumberOfSeats();
        }
    }
}
