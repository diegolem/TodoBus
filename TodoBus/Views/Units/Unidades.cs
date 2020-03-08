using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoBus.Views.Units
{
    public partial class Unidades : Form
    {
        public Unidades()
        {
            InitializeComponent();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Options.Width == 50)
            {
                Options.Visible = false;
                Options.Width = 215;
                PanelTransition.ShowSync(Options);
                LogoTransition.ShowSync(logo);
            }
            else
            {
                LogoTransition.Hide(logo);
                Options.Visible = false;
                Options.Width = 50;
                PanelTransition.ShowSync(Options);
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaUnidad_Click(object sender, EventArgs e)
        {
            RegistroUnidad RU = new RegistroUnidad();
            RU.Show();
            this.Hide();
        }
    }
}
