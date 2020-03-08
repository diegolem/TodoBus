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
    public partial class RegistroUnidad : Form
    {
        public RegistroUnidad()
        {
            InitializeComponent();
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Unidades U = new Unidades();
            U.Show();
            this.Hide();
        }
    }
}
