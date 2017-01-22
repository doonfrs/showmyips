namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listboxIPs = new System.Windows.Forms.ListBox();
            this.buttonCopytoClipboard = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.checkboxShowInActive = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listboxIPs
            // 
            this.listboxIPs.FormattingEnabled = true;
            this.listboxIPs.Location = new System.Drawing.Point(12, 12);
            this.listboxIPs.Name = "listboxIPs";
            this.listboxIPs.Size = new System.Drawing.Size(273, 303);
            this.listboxIPs.TabIndex = 0;
            // 
            // buttonCopytoClipboard
            // 
            this.buttonCopytoClipboard.Location = new System.Drawing.Point(291, 41);
            this.buttonCopytoClipboard.Name = "buttonCopytoClipboard";
            this.buttonCopytoClipboard.Size = new System.Drawing.Size(141, 23);
            this.buttonCopytoClipboard.TabIndex = 1;
            this.buttonCopytoClipboard.Text = "Copy to Clipboard";
            this.buttonCopytoClipboard.UseVisualStyleBackColor = true;
            this.buttonCopytoClipboard.Click += new System.EventHandler(this.buttonCopytoClipboard_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(291, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(141, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkboxShowInActive
            // 
            this.checkboxShowInActive.AutoSize = true;
            this.checkboxShowInActive.Location = new System.Drawing.Point(291, 297);
            this.checkboxShowInActive.Name = "checkboxShowInActive";
            this.checkboxShowInActive.Size = new System.Drawing.Size(95, 17);
            this.checkboxShowInActive.TabIndex = 2;
            this.checkboxShowInActive.Text = "Show InActive";
            this.checkboxShowInActive.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Show My IPs";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // chkStartUp
            // 
            this.chkStartUp.AutoSize = true;
            this.chkStartUp.Location = new System.Drawing.Point(291, 274);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(114, 17);
            this.chkStartUp.TabIndex = 2;
            this.chkStartUp.Text = "Start with windows";
            this.chkStartUp.UseVisualStyleBackColor = true;
            this.chkStartUp.CheckedChanged += new System.EventHandler(this.chkStartUp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(291, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimize will go to tray";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkStartUp);
            this.Controls.Add(this.checkboxShowInActive);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonCopytoClipboard);
            this.Controls.Add(this.listboxIPs);
            this.Name = "frmMain";
            this.Text = "Show My IPs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxIPs;
        private System.Windows.Forms.Button buttonCopytoClipboard;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkboxShowInActive;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.Label label1;
    }
}

