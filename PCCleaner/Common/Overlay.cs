using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Common
{
    public class Overlay : Form
    {
        private static readonly int HTTRANSPARENT = -1;
        private static readonly int WM_NCHITTEST = 0x0084;
        private static readonly int WS_EX_TOOLWINDOW = 0x00000080;
        private static readonly int SW_SHOWNOACTIVATE = 4;

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private Overlay(Form parent)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.SetStyle(ControlStyles.Selectable, false);

            parent.LocationChanged += (o, e) => { this.ResetLocationAndSize(parent); };
            parent.SizeChanged += (o, e) => { this.ResetLocationAndSize(parent); };
            parent.Activated += (o, e) => { this.Hide(); };

            this.ResetLocationAndSize(parent);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOOLWINDOW;
                return createParams;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
                return;
            }

            base.WndProc(ref m);
        }

        private void ResetLocationAndSize(Form parent)
        {
            Point location = parent.PointToScreen(Point.Empty);
            this.Bounds = new Rectangle(location, parent.ClientSize);
        }

        //
        public static void ShowOverlay(Form parent, Form child)
        {
            Overlay overlay = new Overlay(parent);
            overlay.Name = "OverlayForm";
            overlay.Show(parent);

            child.Activated += (o, e) => { ShowWindow(overlay.Handle, SW_SHOWNOACTIVATE); };
            child.FormClosed += (o, e) => { overlay.Close(); };
        }

    }
}
