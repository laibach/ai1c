namespace AllInOneCase
{
    partial class AIOC
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIOC));
            this.contextMenuStripAIOC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.einfuegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.casesVerwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.symbolAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripAIOC.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripAIOC
            // 
            this.contextMenuStripAIOC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einfuegenToolStripMenuItem,
            this.toolStripSeparator2,
            this.casesVerwaltenToolStripMenuItem,
            this.symbolAnzeigenToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStripAIOC.Name = "contextMenuStripAIOC";
            this.contextMenuStripAIOC.Size = new System.Drawing.Size(226, 126);
            this.contextMenuStripAIOC.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripAIOC_Opening);
            this.contextMenuStripAIOC.MouseLeave += new System.EventHandler(this.contextMenuStripAIOC_MouseLeave);
            // 
            // einfuegenToolStripMenuItem
            // 
            this.einfuegenToolStripMenuItem.Name = "einfuegenToolStripMenuItem";
            this.einfuegenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.einfuegenToolStripMenuItem.Text = "Einfügen";
            this.einfuegenToolStripMenuItem.Click += new System.EventHandler(this.einfuegenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // casesVerwaltenToolStripMenuItem
            // 
            this.casesVerwaltenToolStripMenuItem.Name = "casesVerwaltenToolStripMenuItem";
            this.casesVerwaltenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.casesVerwaltenToolStripMenuItem.Text = "Cases verwalten";
            this.casesVerwaltenToolStripMenuItem.Click += new System.EventHandler(this.casesVerwaltenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.exitToolStripMenuItem.Text = "Exit - AllInOneCase verlassen";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "All in 1 Case";
            this.notifyIcon1.BalloonTipTitle = "AI1C";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripAIOC;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // symbolAnzeigenToolStripMenuItem
            // 
            this.symbolAnzeigenToolStripMenuItem.Name = "symbolAnzeigenToolStripMenuItem";
            this.symbolAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.symbolAnzeigenToolStripMenuItem.Text = "Symbol anzeigen";
            this.symbolAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.symbolAnzeigenToolStripMenuItem_Click);
            // 
            // AIOC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AllInOneCase.Properties.Resources.attach;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(66, 82);
            this.ContextMenuStrip = this.contextMenuStripAIOC;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AIOC";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AIOC_DragEnter);
            this.DoubleClick += new System.EventHandler(this.AIOC_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.AIOC_Resize);
            this.contextMenuStripAIOC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripAIOC;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfuegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem casesVerwaltenToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem symbolAnzeigenToolStripMenuItem;
    }
}

