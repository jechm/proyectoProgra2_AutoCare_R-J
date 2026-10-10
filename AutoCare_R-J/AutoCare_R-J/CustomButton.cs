using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AutoCare_R_J
{
    public class CustomButton : Button
    {
        private int borderRadius = 15;
        private Color customBackColor = Color.FromArgb(33, 150, 243); // Azul por defecto
        private Image buttonIcon;
        private Size iconSize = new Size(20, 20); // Tamaño estándar para el icono

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        public Color CustomBackColor
        {
            get => customBackColor;
            set { customBackColor = value; this.Invalidate(); }
        }

        public Image ButtonIcon
        {
            get => buttonIcon;
            set { buttonIcon = value; this.Invalidate(); }
        }

        public Size IconSize
        {
            get => iconSize;
            set { iconSize = value; this.Invalidate(); }
        }

        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(160, 45);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = new Rectangle(0, 0, this.Width, this.Height);

            using (GraphicsPath pathSurface = GetPath(rectSurface, borderRadius))
            {
                this.Region = new Region(pathSurface);

                // 1. Dibujar el fondo personalizado
                using (SolidBrush brush = new SolidBrush(customBackColor))
                {
                    pevent.Graphics.FillPath(brush, pathSurface);
                }

                // 2. Dibujar el icono y el texto organizados
                if (buttonIcon != null)
                {
                    // Calcular posición del icono (a la izquierda, centrado verticalmente)
                    int spacing = 10;

                    // Medir el texto para calcular el bloque completo y centrarlo bonito
                    SizeF textSize = pevent.Graphics.MeasureString(this.Text, this.Font);
                    int totalWidth = iconSize.Width + spacing + (int)textSize.Width;

                    int startX = (this.Width - totalWidth) / 2;
                    int startY = (this.Height - iconSize.Height) / 2;

                    // Dibujar imagen
                    Rectangle iconRect = new Rectangle(startX, startY, iconSize.Width, iconSize.Height);
                    pevent.Graphics.DrawImage(buttonIcon, iconRect);

                    // Dibujar texto al lado del icono
                    Rectangle textRect = new Rectangle(startX + iconSize.Width + spacing, 0, this.Width - (startX + iconSize.Width + spacing), this.Height);
                    TextRenderer.DrawText(
                        pevent.Graphics,
                        this.Text,
                        this.Font,
                        textRect,
                        this.ForeColor,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak
                    );
                }
                else
                {
                    // Si no hay icono, centrar solo el texto normalmente (con soporte multilínea)
                    TextRenderer.DrawText(
                        pevent.Graphics,
                        this.Text,
                        this.Font,
                        rectSurface,
                        this.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak
                    );
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