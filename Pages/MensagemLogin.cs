using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace IncentivoPro.Pages
{
    public class MensagemTemporaria : Form
    {
        private const int FADE_DURATION = 300; // Reduzindo a duração do fade para ser mais rápido.

        public MensagemTemporaria(string mensagem, int duracao)
        {
            Label label = new Label
            {
                Text = mensagem,
                AutoSize = true,
                Font = new Font("Segoe UI", 18, FontStyle.Regular), // Fonte mais moderna.
                ForeColor = Color.FromArgb(255, 255, 255), 
                TextAlign = ContentAlignment.MiddleCenter, // Centralizar o texto.
            };

            this.Controls.Add(label);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(46, 14, 55); // Cor de fundo mais clara e suave.
            this.Opacity = 0;
            this.Padding = new Padding(20); // Adiciona um pequeno padding para margens.
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            label.Location = new Point(this.ClientSize.Width / 2 - label.Width / 2, this.ClientSize.Height / 2 - label.Height / 2);

            this.Paint += MensagemTemporaria_Paint; //Adiciona o evento de pintura.
            MostrarMensagem(duracao);
        }

        private void MensagemTemporaria_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 10; // Raio para as bordas arredondadas.
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private async void MostrarMensagem(int duracao)
        {
            await FadeIn();
            await Task.Delay(duracao);
            await FadeOut();

            this.Close();
        }

        private async Task FadeIn()
        {
            while (this.Opacity < 1)
            {
                this.Opacity += 0.1; // Aumentando a velocidade do fade.
                await Task.Delay(FADE_DURATION / 10);
            }
        }

        private async Task FadeOut()
        {
            while (this.Opacity > 0)
            {
                this.Opacity -= 0.1; // Aumentando a velocidade do fade.
                await Task.Delay(FADE_DURATION / 10);
            }
        }
    }
}