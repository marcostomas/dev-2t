using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taskool.Models;
using Taskool.Repositories;

namespace Taskool.Views
{
    public partial class frmListaUsuario : Form
    {
        public frmListaUsuario()
        {
            InitializeComponent();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            usuarioRepository repository = new usuarioRepository();

            //TODO: Terminar frmListaUsuario
            //dgvAluno.DataSource = repository.buscarTodos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            usuarioRepository repository = new usuarioRepository();

            new frmCadastro().ShowDialog();

            dgvAluno.DataSource = null;
            //TODO: Terminar frmListaUsuario
            //dgvAluno.DataSource = usuarioRepository.buscarTodos();
        }
    }
}
