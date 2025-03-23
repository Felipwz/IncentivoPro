namespace IncentivoPro
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
            panel1 = new Panel();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            checkBoxMostrarSenha = new CheckBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            btnFechar = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(104, 32, 123);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 353);
            panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(280, 109);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(273, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(279, 193);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(273, 23);
            txtSenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 3;
            // 
            // checkBoxMostrarSenha
            // 
            checkBoxMostrarSenha.AutoSize = true;
            checkBoxMostrarSenha.Location = new Point(451, 222);
            checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            checkBoxMostrarSenha.Size = new Size(102, 19);
            checkBoxMostrarSenha.TabIndex = 4;
            checkBoxMostrarSenha.Text = "Mostrar Senha";
            checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            checkBoxMostrarSenha.CheckedChanged += checkViewPassWord_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Purple;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(280, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 91);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 175);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Senha:";
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = true;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(572, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(19, 21);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(280, 22);
            label4.Name = "label4";
            label4.Size = new Size(200, 40);
            label4.TabIndex = 9;
            label4.Text = "Login Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(593, 352);
            Controls.Add(label4);
            Controls.Add(btnFechar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(checkBoxMostrarSenha);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private CheckBox checkBoxMostrarSenha;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private Label btnFechar;
        private Label label4;
    }
}
