using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskool
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void lblDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lblFoto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Filtro que é aplicado no explorador de arquivos
            ofd.Filter = "Arquivos de Imagens(*.jpg;*.png)|*.jpg;*.png";
            //Chama a janela - Entra somente se confimar a seleção do arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carrega a foto no PictureBox
                fotoPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnUsuarioGerarAleatorio_Click(object sender, EventArgs e)
        {
            //Verifica se tem algo digitado no campo
            if(tBoxNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite um nome para gerar aleatório", "Erro");
            }

            //Verifica se tem o caracter 'Espaço' - tem 2 nomes digitados
            if(tBoxNome.Text.Split(' ').Length == 1)
            {
                MessageBox.Show("Não foi possível gerar aleatório", "Erro");
            }
            else
            {
                //Guarda o conteudo da caixa de texto
                string input = tBoxNome.Text;

                //Pega a posição do espaço
                int posEspaco = input.IndexOf(" ", 0);

                //Separa as duas partes
                string parte1 = input.Substring(0, posEspaco);
                string parte2 = input.Substring(posEspaco + 1, input.Length - (posEspaco + 1));

                //Junta o 1° nome + '.' + 2° nome + 2 dígitos do ano
                string userName = parte1 + "." + parte2 + dateTimeDataNascimento.Value.ToString("yy").ToString();
                tBoxUsuario.Text = userName;
            }
        }

        private static int CalculaIdade(DateTime dataNascimento)
        {
            //Pega o ano das datas de nascimento e substrai
            int idade = DateTime.Now.Year - dataNascimento.Year;

            //Verifica se i dia é anterior a data atual
            if(DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }

            return idade;
        }

        private void dateTimeDataNascimento_Leave(object sender, EventArgs e)
        {
            /*
                • Calcula a Idade
                • Verifica se a data atual é maior que a data do aniversário
                • value = conteudo slecionado no dateTimePicker
                • Now - É a data atual do sistema
            */

            if(dateTimeDataNascimento.Value < DateTime.Now)
            {
                //Chama a função que calcula a idade (F12 vai para a função)
                int resultado = CalculaIdade(dateTimeDataNascimento.Value);
                lblIdade.Text = $"{resultado} anos"; 
            }
        }

        bool isValidEmail;
        private void tBoxEmail_TextChanged(object sender, EventArgs e)
        {
            //cria um padrão regex
            string pattern = "[a-z]{3,}[.][a-z]{3,}[@][a-z]{3,}[.][a-z]{2,3}";
            //seta uma propriedade com a verificação do regex
            isValidEmail = Regex.IsMatch(tBoxEmail.Text, pattern);
            //Altera a visualização da label
            lblEmailInvalido.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!Utils.temCamposVazio(this))
            {
                //Todos os campos foram preenchidos - Salva no DB
                MessageBox.Show("Dados Salvos.",
                                "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                //Texto, título, botões, ícone
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Avaiso", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void Inputs_Leave(object sender, EventArgs e)
        {
            //exconde a borda do controle
            fotoPictureBox.Visible = false;

            Control c = sender as Control;
            if (c.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
            {
                DateTimePicker dtp = sender as DateTimePicker;
                // calcula a idade
                //Verifica se a data atual é maior que a data do aniversario
                //value = conteudo selecionado no datetimepicker
                //now é a data do sistema
                if (dtp.Value < DateTime.Now)
                {
                    //chama a função que calcula a idade (F12 - vai p a função)
                    int resultado = CalculaIdade(dtp.Value);
                    lblIdade.Text = $"{resultado} anos";
                }
            }
        }

        private void Inputs_Enter(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;
            if (tbx != null)
            {
                fotoPictureBox.Location = new Point(tbx.Location.X - 5, tbx.Location.Y - 5);
                fotoPictureBox.Size = new Size(tbx.Size.Width + 10, tbx.Size.Height + 10);
                fotoPictureBox.Visible = true;
            }
            else
            {

                DateTimePicker dtp = sender as DateTimePicker;

                if (dtp != null)
                {
                    fotoPictureBox.Location = new Point(dtp.Location.X - 5, dtp.Location.Y - 5);
                    fotoPictureBox.Size = new Size(dtp.Size.Width + 10, dtp.Size.Height + 10);
                    fotoPictureBox.Visible = true;
                }

            }
        }

        private void tBoxNome_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
