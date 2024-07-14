using System;
using System.Windows.Forms;

namespace TranslationApp
{
    public class CenteredTextBox : TextBox
    {
        public CenteredTextBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Multiline = true;  // Set to true since your text boxes are multiline
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(this.BackColor);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, flags);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Invalidate();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.Invalidate(); 
        }
    }
}