using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskool.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUsuario newMIDChild = new frmListaUsuario();

            //Configura o form Pai para a janela Filha
            newMIDChild.MdiParent = this;

            //Mostra o novo form
            newMIDChild.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre f = new frmSobre();

            f.ShowDialog(this);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja fechar?", "Confirmação", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               e.Cancel = true;
            }
        }
    }
}
