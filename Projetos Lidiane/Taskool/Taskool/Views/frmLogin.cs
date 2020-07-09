using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taskool.Views;

namespace Taskool
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | Taskool";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //para bloquear o Ctrl C + Ctrl V
            tbxUsuario.ShortcutsEnabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            if(tbxUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário", "Erro");
            }
            else
            {
                MessageBox.Show("Bem-Vindo", "Entrada");
                new frmPrincipal().ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Esconde a Label
            lblCaps.Visible = isCapsLockActive();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool isCapsLockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            lblCaps.Visible = false;
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            //Para este processo funcionar é necessário mudar as configurações
            System.Diagnostics.Process.Start("osk.exe");
            tbxUsuario.Focus();
        }

        private void lblCaps_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }
    }
}
