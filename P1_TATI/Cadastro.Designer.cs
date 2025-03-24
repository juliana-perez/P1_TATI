namespace P1_TATI
{
    partial class frm_Cadastro
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
            lbl_nome = new Label();
            lbl_usuario = new Label();
            lbl_senha = new Label();
            lbl_pais = new Label();
            lbl_emissora = new Label();
            lbl_telefone = new Label();
            lbl_email = new Label();
            btn_cadastrar = new Button();
            btn_limpar = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            grb_cadastro = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grb_cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.ImageAlign = ContentAlignment.MiddleRight;
            lbl_nome.Location = new Point(43, 38);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(96, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome Completo";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.ImageAlign = ContentAlignment.MiddleRight;
            lbl_usuario.Location = new Point(43, 67);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(47, 15);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.ImageAlign = ContentAlignment.MiddleRight;
            lbl_senha.Location = new Point(43, 96);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha";
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.ImageAlign = ContentAlignment.MiddleRight;
            lbl_pais.Location = new Point(43, 187);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(28, 15);
            lbl_pais.TabIndex = 3;
            lbl_pais.Text = "País";
            // 
            // lbl_emissora
            // 
            lbl_emissora.AutoSize = true;
            lbl_emissora.ImageAlign = ContentAlignment.MiddleRight;
            lbl_emissora.Location = new Point(43, 216);
            lbl_emissora.Name = "lbl_emissora";
            lbl_emissora.Size = new Size(125, 15);
            lbl_emissora.TabIndex = 5;
            lbl_emissora.Text = "Emissora/Organização";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.ImageAlign = ContentAlignment.MiddleRight;
            lbl_telefone.Location = new Point(43, 154);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(51, 15);
            lbl_telefone.TabIndex = 6;
            lbl_telefone.Text = "Telefone";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.ImageAlign = ContentAlignment.MiddleRight;
            lbl_email.Location = new Point(43, 125);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(41, 15);
            lbl_email.TabIndex = 7;
            lbl_email.Text = "E-mail";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.HotTrack;
            btn_cadastrar.ForeColor = Color.White;
            btn_cadastrar.Location = new Point(417, 260);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 23);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(509, 260);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(486, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 96);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(305, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(162, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(305, 23);
            textBox5.TabIndex = 15;
            // 
            // grb_cadastro
            // 
            grb_cadastro.Controls.Add(btn_limpar);
            grb_cadastro.Controls.Add(btn_cadastrar);
            grb_cadastro.Location = new Point(28, 4);
            grb_cadastro.Name = "grb_cadastro";
            grb_cadastro.Size = new Size(661, 326);
            grb_cadastro.TabIndex = 16;
            grb_cadastro.TabStop = false;
            grb_cadastro.Text = "Cadastro de imprensa";
            // 
            // frm_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_email);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_emissora);
            Controls.Add(lbl_pais);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(lbl_nome);
            Controls.Add(grb_cadastro);
            Name = "frm_Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grb_cadastro.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_usuario;
        private Label lbl_senha;
        private Label lbl_pais;
        private Label lbl_emissora;
        private Label lbl_telefone;
        private Label lbl_email;
        private Button btn_cadastrar;
        private Button btn_limpar;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox grb_cadastro;
    }
}