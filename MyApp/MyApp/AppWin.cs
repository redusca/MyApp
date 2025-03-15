using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyApp
{
    public partial class AppWin : Form
    {
        #region user32.dll Constants
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);
        private const int SM_CXSCREEN = 0;
        private const int SM_CYSCREEN = 1;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOACTIVATE = 0x0010;

        private const int WM_MOUSEACTIVATE = 0x0021;
        private const int MA_NOACTIVATE = 3;
        #endregion

        #region WinForm Size Constants  
        private const int heightResolutionFrom = 600;
        private const int heightResolutionTo = 200;
        #endregion

        public AppWin()
        {
            InitializeComponent();
            InitializeCloseButton();
        }

        private void AppWin_Load(object sender, EventArgs e)
        {
            SetLocationAndSize();
        }

        private void SetLocationAndSize()
        {
            //Form location
            int screenWidth = GetSystemMetrics(SM_CXSCREEN);
            Location = new Point(screenWidth - heightResolutionFrom, 0);

            //Form size
            Size = new Size(heightResolutionFrom, heightResolutionTo);
            AutoSize = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void AppWin_Shown(object sender, EventArgs e)
        {
            //Set form to bottom
            SetWindowPos(this.Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEACTIVATE)
            {
                m.Result = (IntPtr)MA_NOACTIVATE;
                return;
            }
            base.WndProc(ref m);
        }

        #region Button Events
        private void InitializeCloseButton()
        {
     
        }

        
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.download__4_;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.SUschi;
        }
        #endregion

    }
}
