using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Doppler.Components
{
    /// <summary>
    /// Component for winform to create switch button
    /// </summary>
    public class Switch : CheckBox
    {
        private readonly Color ColorUncheck = Color.White;
        private readonly Color ColorCheck = Color.Black;

        public Switch()
        {
            this.Appearance = Appearance.Button;
            this.AutoSize = false;
            this.MinimumSize = new Size(30, 15);
            this.Size = new Size(40, 20);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.LightGray;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Color backColor = this.Checked ? ColorCheck : ColorUncheck;

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = rect.Height; // arrondi = hauteur → pillule
                path.AddArc(rect.X, rect.Y, radius, radius, 90, 180);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 180);
                path.CloseFigure();

                // Appliquer la Region arrondie au contrôle
                this.Region = new Region(path);

                // Dessiner le fond arrondi
                using (SolidBrush brush = new SolidBrush(backColor))
                    pevent.Graphics.FillPath(brush, path);

                using (Pen pen = new Pen(Color.DarkGray, 1))
                    pevent.Graphics.DrawPath(pen, path);
            }

            // Curseur rond
            int diameter = this.Height - 4;
            int x = this.Checked ? this.Width - diameter - 2 : 2;
            Rectangle knob = new Rectangle(x, 2, diameter, diameter);

            using (SolidBrush brush = new SolidBrush(Color.White))
                pevent.Graphics.FillEllipse(brush, knob);

            using (Pen pen = new Pen(Color.DarkGray, 1))
                pevent.Graphics.DrawEllipse(pen, knob);
        }
    }
}