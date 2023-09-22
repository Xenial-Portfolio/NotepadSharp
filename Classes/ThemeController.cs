using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotepadSharp.Classes
{
    public class ThemeController
    {
        public void SetColorButton(Button btn, Color themeColorForeGround, Color themeColorBackground)
        {
            btn.ForeColor = themeColorForeGround;
            btn.BackColor = themeColorBackground;
        }

        public void SetColorLabel(Label lbl, Color themeColorForeGround, Color themeColorBackground)
        {
            lbl.ForeColor = themeColorForeGround;
            lbl.BackColor = themeColorBackground;
        }

        public void SetColorPanel(Panel pnl, Color themeColorForeGround, Color themeColorBackground)
        {
            pnl.ForeColor = themeColorForeGround;
            pnl.BackColor = themeColorBackground;
        }

        public void SetColorInnerPanel(Panel pnl, Color themeColorForeGround, Color themeColorBackground)
        {
            foreach (Control pnlControl in pnl.Controls)
            {
                if (pnlControl.GetType() == typeof(Button))
                    SetColorButton(pnlControl as Button, themeColorForeGround, themeColorBackground);

                if (pnlControl.GetType() == typeof(RichTextBox))
                    SetColorTextBox(pnlControl as RichTextBox, themeColorForeGround, themeColorBackground);
            }
        }

        public void SetColorTextBox(RichTextBox tb, Color themeColorForeGround, Color themeColorBackground)
        {
            Console.WriteLine(tb.Name);
            tb.ForeColor = themeColorForeGround;
            tb.BackColor = themeColorBackground;
        }

        public void SetToolStripColor(ToolStrip toolStrip, Color foreColor, Color backColor)
        {
            toolStrip.ForeColor = foreColor;
            toolStrip.BackColor = backColor;

            foreach (ToolStripMenuItem stripControl in toolStrip.Items)
            {
                stripControl.BackColor = backColor;
                stripControl.ForeColor = foreColor;
            }
        }

        public void SetTheme(Form form/*, Color foreColor, Color backColor*/)
        {
            form.BackColor = Color.White;
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(Button))
                    SetColorButton(control as Button, Color.Black, Color.White);

                if (control.GetType() == typeof(Label))
                    SetColorLabel(control as Label, Color.Black, Color.White);

                if (control.GetType() == typeof(Panel))
                {
                    SetColorPanel(control as Panel, Color.Black, Color.White);
                    SetColorInnerPanel(control as Panel, Color.Black, Color.White);
                }

                if (control.GetType() == typeof(RichTextBox))
                    SetColorTextBox(control as RichTextBox, Color.Black, Color.White);

                if (control.GetType() == typeof(ToolStrip))
                    SetToolStripColor(control as ToolStrip, Color.Black, Color.White);

            }
        }
    }
}
