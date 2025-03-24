namespace P1_TATI
{
    partial class frm_index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_index));
            btn_login = new Button();
            btn_Cadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(314, 102);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += button1_Click;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(314, 131);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(75, 23);
            btn_Cadastrar.TabIndex = 1;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(141, 5);
            label1.Name = "label1";
            label1.Size = new Size(471, 45);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Acesso de Imprensa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(251, 44);
            label2.Name = "label2";
            label2.Size = new Size(223, 15);
            label2.TabIndex = 3;
            label2.Text = "Acesso restrito à profissinais de imprensa";
            // 
            // frm_index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(707, 287);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_login);
            Name = "frm_index";
            Text = "Informações para Imprensa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Button btn_Cadastrar;
        private Label label1;
        private Label label2;
    }
}
