using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.Controllers
{
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            HHMM.Font = new Font("Arial", 32);
            HHMM.Text = DateTime.Now.ToString("HH - mm");

            seconds.Font = new Font("Arial", 16);
            seconds.Location = new Point
            {
                X = HHMM.Location.X + HHMM.Width - 10,
                Y = HHMM.Location.Y + 20
            };
            seconds.Text = DateTime.Now.ToString("ss");
        }

       private void timer1_Tick(object sender, EventArgs e)
       {
            HHMM.Text = DateTime.Now.ToString("HH - mm");

            seconds.Text = DateTime.Now.ToString(" ss");
       }
    }
}
