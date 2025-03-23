using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace IncentivoPro.Pages
{
    public class MensagemTemporaria : Form
    {
        private const int FADE_DURATION = 300;

        public MensagemTemporaria(string mensagem, int duracao, string tipoDeMensagem)
        {
            
            Panel panel = new Panel
            {
                Padding = new Padding(10), 
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            
            if (tipoDeMensagem == "aviso")
            {
                panel.BackColor = Color.FromArgb(161, 160, 50);
            }
            else if (tipoDeMensagem == "sucesso")
            {
                panel.BackColor = Color.FromArgb(39, 12, 46);
            }
            else
            {
                panel.BackColor = Color.FromArgb(247, 13, 12);
            }

            
            Label label = new Label
            {
                ForeColor = Color.FromArgb(255, 255, 255),
                Text = mensagem,
                AutoSize = true,
                Font = new Font("Segoe UI", 18, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            
            panel.Controls.Add(label);

            
            this.Controls.Add(panel);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            
            label.Location = new Point(panel.ClientSize.Width / 2 - label.Width / 2, panel.ClientSize.Height / 2 - label.Height / 2);

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Opacity = 0;

            this.Paint += MensagemTemporaria_Paint;
            MostrarMensagem(duracao);
        }

        private void MensagemTemporaria_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 10;
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
                this.Opacity += 0.1;
                await Task.Delay(FADE_DURATION / 10);
            }
        }

        private async Task FadeOut()
        {
            while (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
                await Task.Delay(FADE_DURATION / 10);
            }
        }
    }
}