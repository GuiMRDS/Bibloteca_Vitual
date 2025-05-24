namespace Bibloteca_Vitual
{
    partial class Form1
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
            btnLogin = new Button();
            btnCadastro = new Button();
            label1 = new Label();
            btnColaborador = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(153, 119);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 72);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = SystemColors.Highlight;
            btnCadastro.Font = new Font("Arial", 9F);
            btnCadastro.ForeColor = SystemColors.Control;
            btnCadastro.Location = new Point(153, 215);
            btnCadastro.Margin = new Padding(4, 5, 4, 5);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(174, 72);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F);
            label1.Location = new Point(90, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(321, 45);
            label1.TabIndex = 2;
            label1.Text = "Biblioteca Virtual ";
            // 
            // btnColaborador
            // 
            btnColaborador.BackColor = SystemColors.Highlight;
            btnColaborador.ForeColor = SystemColors.Control;
            btnColaborador.Location = new Point(572, 58);
            btnColaborador.Margin = new Padding(4, 5, 4, 5);
            btnColaborador.Name = "btnColaborador";
            btnColaborador.Size = new Size(243, 43);
            btnColaborador.TabIndex = 3;
            btnColaborador.Text = "Área do colaborador";
            btnColaborador.UseVisualStyleBackColor = false;
            btnColaborador.Click += btnColaborador_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(894, 373);
            Controls.Add(btnColaborador);
            Controls.Add(label1);
            Controls.Add(btnCadastro);
            Controls.Add(btnLogin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCadastro;
        private Label label1;
        private Button btnColaborador;
    }
}
