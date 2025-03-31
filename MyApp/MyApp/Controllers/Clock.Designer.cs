namespace MyApp.Controllers
{
    partial class Clock
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HHMM = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HHMM
            // 
            this.HHMM.AutoSize = true;
            this.HHMM.ForeColor = System.Drawing.Color.Red;
            this.HHMM.Location = new System.Drawing.Point(192, 53);
            this.HHMM.Name = "HHMM";
            this.HHMM.Size = new System.Drawing.Size(44, 16);
            this.HHMM.TabIndex = 0;
            this.HHMM.Text = "label1";
            this.HHMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.ForeColor = System.Drawing.Color.Red;
            this.seconds.Location = new System.Drawing.Point(309, 77);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(59, 16);
            this.seconds.TabIndex = 1;
            this.seconds.Text = "seconds";
            this.seconds.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.HHMM);
            this.DoubleBuffered = true;
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(484, 128);
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HHMM;
        private System.Windows.Forms.Label seconds;
    }
}
