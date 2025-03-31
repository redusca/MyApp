using MyApp.Controllers;
using MyApp.Resources.button;
using System.Drawing;

namespace MyApp
{
    partial class AppWin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBar = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new MyApp.Resources.button.MButton();
            this.SettingButton = new MyApp.Resources.button.MButton();
            this.clock = new MyApp.Controllers.Clock();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleBar.Controls.Add(this.closeButton);
            this.titleBar.Controls.Add(this.SettingButton);
            this.titleBar.Controls.Add(this.AppName);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(608, 32);
            this.titleBar.TabIndex = 1;
            // 
            // AppName
            // 
            this.AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.Red;
            this.AppName.Location = new System.Drawing.Point(0, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(100, 32);
            this.AppName.TabIndex = 2;
            this.AppName.Text = "label2";
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.background.Location = new System.Drawing.Point(0, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(608, 224);
            this.background.TabIndex = 2;
            this.background.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(256, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "C";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(576, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // SettingButton
            // 
            this.SettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Location = new System.Drawing.Point(538, 0);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(32, 32);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            this.SettingButton.MouseEnter += new System.EventHandler(this.SettingButton_MouseEnter);
            this.SettingButton.MouseLeave += new System.EventHandler(this.SettingButton_MouseLeave);
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.Color.Transparent;
            this.clock.ForeColor = System.Drawing.Color.Transparent;
            this.clock.Location = this.label1.Location;
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(484, 128);
            this.clock.TabIndex = 0;
            // 
            // AppWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(608, 224);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AppWin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ApplicationWindow";
            this.Load += new System.EventHandler(this.AppWin_Load);
            this.Shown += new System.EventHandler(this.AppWin_Shown);
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MButton closeButton;
        private System.Windows.Forms.Panel titleBar;
        private MButton SettingButton;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label label1;
        private Clock clock;
    }
}

