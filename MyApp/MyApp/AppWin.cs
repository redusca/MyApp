using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MyApp.Controllers;
using MyApp.factory;

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
        private const int YForm = 608;
        private const int XFrom = 224;
        #endregion

        public AppWin()
        {
            InitializeComponent();
        }
        private void AppWin_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            SetLocationAndSize();
            Background();
            Buttons();
          
        }

        private void Background()
        {
            AppName.Text = "MyApp";
            AppName.Font = new Font("Arial", 12, FontStyle.Bold);
            AppName.Location = new Point(0, 0);
            AppName.Size = new Size(100, 32);
            AppName.BackColor = Color.Transparent;

            titleBar.Location = new Point(0, 0);
            titleBar.Size = new Size(YForm, 32);
            titleBar.BackgroundImage = Properties.Resources.WoodTitleBar;
            titleBar.BackColor = Color.Transparent;

            background.Location = new Point(0, 0);
            background.Size = new Size(YForm, XFrom);
            background.Image = Properties.Resources.MossyRocks_LateNightSky;
            background.BackColor = Color.Transparent;

            clock.BackColor = Color.Transparent;
            clock.ForeColor = Color.Transparent;
            clock.Parent = background;
        }

        private void SetLocationAndSize()
        {
            //Form location
            int screenWidth = GetSystemMetrics(SM_CXSCREEN);
            Location = new Point(screenWidth - YForm, 0);

            //Form size
            Size = new Size(YForm, XFrom);
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

        private void Buttons()
        {
            closeButton.Location = new Point(YForm - 32, 0);
            closeButton.Size = new Size(32, 32);
            closeButton.BackColor = Color.Transparent;
            closeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeButton.Image = Properties.Resources.CloseButton;

            SettingButton.Location = new Point(YForm - 64, 0);
            SettingButton.Size = new Size(32, 32);
            SettingButton.BackColor = Color.Transparent;
            SettingButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SettingButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SettingButton.Image = Properties.Resources.SettingButton;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.CloseButtonHover;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.CloseButton;
        }
        private void SettingButton_MouseEnter(object sender, EventArgs e)
        {
            SettingButton.Image = Properties.Resources.SettingButtonHover;
        }
        private void SettingButton_MouseLeave(object sender, EventArgs e)
        {
            SettingButton.Image = Properties.Resources.SettingButton;
        }
        #endregion

        private void SettingButton_Click(object sender, EventArgs e)
        {
            var set = SettingFactory.Instance.CreateOrReturnForm();
            set.Show();
            set.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
