using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boteco
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void pbxCliente_Click(object sender, EventArgs e)
        {
            FrmClient client = new FrmClient();
            client.Show();
        }

        private void pbxFechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClient client = new FrmClient();
            client.Show();
        }
    }
}
