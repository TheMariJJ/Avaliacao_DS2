using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Avaliacao_Mariana
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente frmCliente = new CadCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void celularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCelular frmCelular = new CadCelular();
            frmCelular.MdiParent = this;
            frmCelular.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/mm/yyyy");
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void clienteConsultaTSM_Click(object sender, EventArgs e)
        {
            ConsultaCliente frmConCliente = new ConsultaCliente();
            frmConCliente.MdiParent = this;
            frmConCliente.Show();
        }

        private void celularConsultaTSM_Click(object sender, EventArgs e)
        {
            ConsultaCelular frmConCel = new ConsultaCelular();
            frmConCel.MdiParent = this;
            frmConCel.Show();
        }
    }
}
