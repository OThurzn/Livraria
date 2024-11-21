namespace desktopLivraria
{
    partial class fomr_login
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(840, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(600, 217);
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(221, 46);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(600, 293);
            this.txt_senha.Multiline = true;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(221, 48);
            this.txt_senha.TabIndex = 2;
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_acessar.ForeColor = System.Drawing.Color.White;
            this.btn_acessar.Location = new System.Drawing.Point(926, 227);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(221, 41);
            this.btn_acessar.TabIndex = 3;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(926, 286);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(221, 41);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(600, 186);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(57, 24);
            this.User.TabIndex = 5;
            this.User.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(600, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // fomr_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::desktopLivraria.Properties.Resources.Sem_título1;
            this.ClientSize = new System.Drawing.Size(1264, 793);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fomr_login";
            this.Text = "form_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label2;
    }
}

