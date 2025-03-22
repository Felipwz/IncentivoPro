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
            btnTeste = new Button();
            mensagem = new Label();
            SuspendLayout();
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(348, 176);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(75, 23);
            btnTeste.TabIndex = 0;
            btnTeste.Text = "Botão";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // mensagem
            // 
            mensagem.AutoSize = true;
            mensagem.Location = new Point(366, 238);
            mensagem.Name = "mensagem";
            mensagem.Size = new Size(33, 15);
            mensagem.TabIndex = 1;
            mensagem.Text = "Teste\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mensagem);
            Controls.Add(btnTeste);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTeste;
        private Label mensagem;
    }
}
