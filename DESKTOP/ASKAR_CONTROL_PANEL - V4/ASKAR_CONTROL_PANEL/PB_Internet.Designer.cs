﻿namespace ASKAR_CONTROL_PANEL
{
    partial class PB_Internet
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
            this.wBrowserInternet = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wBrowserInternet
            // 
            this.wBrowserInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wBrowserInternet.Location = new System.Drawing.Point(0, 0);
            this.wBrowserInternet.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBrowserInternet.Name = "wBrowserInternet";
            this.wBrowserInternet.ScriptErrorsSuppressed = true;
            this.wBrowserInternet.Size = new System.Drawing.Size(1339, 352);
            this.wBrowserInternet.TabIndex = 0;
            this.wBrowserInternet.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // PB_Internet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wBrowserInternet);
            this.Name = "PB_Internet";
            this.Size = new System.Drawing.Size(1339, 352);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wBrowserInternet;
    }
}
