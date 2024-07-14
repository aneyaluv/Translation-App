using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace TranslationApp
{
    public class RoundedPanel : Panel
    {
        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White; 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 30; 

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); 
                path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); 
                path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90); 
                path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90); 
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(Color.FromArgb(99, 89, 133), 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
