namespace Taskool
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxTelefone = new System.Windows.Forms.TextBox();
            this.tBoxUsuario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnUsuarioGerarAleatorio = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dateTimeDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblEmailInvalido = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCadastro.Location = new System.Drawing.Point(330, 52);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(132, 24);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "Cadastre-se";
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(231, 129);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(242, 20);
            this.tBoxNome.TabIndex = 2;
            this.tBoxNome.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tBoxNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxNome_KeyDown);
            this.tBoxNome.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(231, 167);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(242, 20);
            this.tBoxEmail.TabIndex = 3;
            this.tBoxEmail.TextChanged += new System.EventHandler(this.tBoxEmail_TextChanged);
            this.tBoxEmail.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tBoxEmail.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tBoxTelefone
            // 
            this.tBoxTelefone.Location = new System.Drawing.Point(231, 206);
            this.tBoxTelefone.Name = "tBoxTelefone";
            this.tBoxTelefone.Size = new System.Drawing.Size(242, 20);
            this.tBoxTelefone.TabIndex = 4;
            this.tBoxTelefone.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tBoxTelefone.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tBoxUsuario
            // 
            this.tBoxUsuario.Location = new System.Drawing.Point(231, 246);
            this.tBoxUsuario.Name = "tBoxUsuario";
            this.tBoxUsuario.Size = new System.Drawing.Size(242, 20);
            this.tBoxUsuario.TabIndex = 5;
            this.tBoxUsuario.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tBoxUsuario.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(73, 131);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(73, 169);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefone.Location = new System.Drawing.Point(73, 208);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 18);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(73, 248);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnUsuarioGerarAleatorio
            // 
            this.btnUsuarioGerarAleatorio.Location = new System.Drawing.Point(508, 245);
            this.btnUsuarioGerarAleatorio.Name = "btnUsuarioGerarAleatorio";
            this.btnUsuarioGerarAleatorio.Size = new System.Drawing.Size(117, 21);
            this.btnUsuarioGerarAleatorio.TabIndex = 10;
            this.btnUsuarioGerarAleatorio.Text = "Gerar Aletório";
            this.btnUsuarioGerarAleatorio.UseVisualStyleBackColor = true;
            this.btnUsuarioGerarAleatorio.Click += new System.EventHandler(this.btnUsuarioGerarAleatorio_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataNascimento.Location = new System.Drawing.Point(73, 293);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(129, 18);
            this.lblDataNascimento.TabIndex = 11;
            this.lblDataNascimento.Text = "Data Nascimento";
            this.lblDataNascimento.Click += new System.EventHandler(this.lblDataNascimento_Click);
            // 
            // dateTimeDataNascimento
            // 
            this.dateTimeDataNascimento.Location = new System.Drawing.Point(231, 291);
            this.dateTimeDataNascimento.Name = "dateTimeDataNascimento";
            this.dateTimeDataNascimento.Size = new System.Drawing.Size(120, 20);
            this.dateTimeDataNascimento.TabIndex = 12;
            this.dateTimeDataNascimento.Enter += new System.EventHandler(this.Inputs_Enter);
            this.dateTimeDataNascimento.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFoto.Location = new System.Drawing.Point(73, 336);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(40, 18);
            this.lblFoto.TabIndex = 13;
            this.lblFoto.Text = "Foto";
            this.lblFoto.Click += new System.EventHandler(this.lblFoto_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(231, 331);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 14;
            this.btnFoto.Text = "Selecionar";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.Location = new System.Drawing.Point(334, 331);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(139, 161);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 15;
            this.fotoPictureBox.TabStop = false;
            // 
            // lblEmailInvalido
            // 
            this.lblEmailInvalido.AutoSize = true;
            this.lblEmailInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblEmailInvalido.Location = new System.Drawing.Point(506, 173);
            this.lblEmailInvalido.Name = "lblEmailInvalido";
            this.lblEmailInvalido.Size = new System.Drawing.Size(75, 13);
            this.lblEmailInvalido.TabIndex = 16;
            this.lblEmailInvalido.Text = "E-mail Inválido";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(231, 516);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(242, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(383, 291);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(90, 20);
            this.lblIdade.TabIndex = 18;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEmailInvalido);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.dateTimeDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.btnUsuarioGerarAleatorio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tBoxUsuario);
            this.Controls.Add(this.tBoxTelefone);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxTelefone;
        private System.Windows.Forms.TextBox tBoxUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnUsuarioGerarAleatorio;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dateTimeDataNascimento;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Label lblEmailInvalido;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblIdade;
    }
}