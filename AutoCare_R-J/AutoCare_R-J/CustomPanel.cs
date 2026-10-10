using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AutoCare_R_J
{
    public class CustomPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;

        public CustomPanel()
        {
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Definir el rectángulo usando todo el tamaño del panel
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetPath(rect, BorderRadius))
            {
                // Rellenar el fondo de blanco
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Dibujar un borde gris muy sutil y elegante
                using (Pen pen = new Pen(Color.FromArgb(218, 224, 233), 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Width - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Width - d, rect.Height - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Height - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}