namespace Taskool
{
    partial class frmLogin
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.llbCadastrar = new System.Windows.Forms.LinkLabel();
            this.lblCaps = new System.Windows.Forms.Label();
            this.btnTeclado = new System.Windows.Forms.Button();
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(300, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(202, 100);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Bem-vindo ao Taskool\r\n\r\n\r\n            Usuário";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(283, 176);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(230, 20);
            this.tbxUsuario.TabIndex = 2;
            this.tbxUsuario.TextChanged += new System.EventHandler(this.tbxUsuario_TextChanged);
            this.tbxUsuario.Enter += new System.EventHandler(this.tbxUsuario_Enter);
            this.tbxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUsuario_KeyDown);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(332, 223);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(141, 23);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // llbCadastrar
            // 
            this.llbCadastrar.AutoSize = true;
            this.llbCadastrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCadastrar.Location = new System.Drawing.Point(361, 323);
            this.llbCadastrar.Name = "llbCadastrar";
            this.llbCadastrar.Size = new System.Drawing.Size(89, 17);
            this.llbCadastrar.TabIndex = 4;
            this.llbCadastrar.TabStop = true;
            this.llbCadastrar.Text = "Cadastre-se";
            this.llbCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCadastrar_Click);
            // 
            // lblCaps
            // 
            this.lblCaps.AutoSize = true;
            this.lblCaps.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaps.ForeColor = System.Drawing.Color.Gold;
            this.lblCaps.Location = new System.Drawing.Point(533, 177);
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(71, 16);
            this.lblCaps.TabIndex = 5;
            this.lblCaps.Text = "Caps Lock";
            this.lblCaps.Click += new System.EventHandler(this.lblCaps_Click);
            this.lblCaps.Leave += new System.EventHandler(this.tbxUsuario_Leave);
            // 
            // btnTeclado
            // 
            this.btnTeclado.Location = new System.Drawing.Point(168, 174);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(75, 23);
            this.btnTeclado.TabIndex = 6;
            this.btnTeclado.Text = "Teclado";
            this.btnTeclado.UseVisualStyleBackColor = true;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeclado);
            this.Controls.Add(this.lblCaps);
            this.Controls.Add(this.llbCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel llbCadastrar;
        private System.Windows.Forms.Label lblCaps;
        private System.Windows.Forms.Button btnTeclado;
    }
}