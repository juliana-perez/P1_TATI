namespace P1_TATI
{
    partial class frm_Login
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
            btn_entrar = new Button();
            btn_Cancelar = new Button();
            btn_redefinir = new Button();
            lbl_usuario = new Label();
            lbl_senha = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(68, 119);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 23);
            btn_entrar.TabIndex = 0;
            btn_entrar.Text = "ENTRAR";
            btn_entrar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(184, 119);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_redefinir
            // 
            btn_redefinir.Location = new Point(299, 119);
            btn_redefinir.Name = "btn_redefinir";
            btn_redefinir.Size = new Size(121, 23);
            btn_redefinir.TabIndex = 2;
            btn_redefinir.Text = "Redefinir Senha";
            btn_redefinir.UseVisualStyleBackColor = true;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(69, 22);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(50, 15);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuário:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(69, 62);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(161, 18);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(259, 23);
            txt_usuario.TabIndex = 5;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(161, 54);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(259, 23);
            txt_senha.TabIndex = 6;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 165);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_redefinir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_entrar);
            Name = "frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_entrar;
        private Button btn_Cancelar;
        private Button btn_redefinir;
        private Label lbl_usuario;
        private Label lbl_senha;
        private TextBox txt_usuario;
        private TextBox txt_senha;
    }
}