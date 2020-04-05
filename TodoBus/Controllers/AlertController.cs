using System.Windows.Forms;

namespace TodoBus.Controllers
{
    class AlertController
    {
        public void errorCountRelationships(string entity, string relationships)
        {
            MessageBox.Show("Para registrar " + entity + ", primero registra " + relationships + "", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void errorInSaveChanges(string entity)
        {
            if(entity != "")
            {
                MessageBox.Show("Ya existe " + entity + " con estas mismas caracteristicas", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ocurrio un error, revise los datos", "TodoBus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
