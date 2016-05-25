namespace RouteIF
{
    partial class RouteIF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteIF));
            this.m_cbNetInterface = new System.Windows.Forms.ComboBox();
            this.m_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.m_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cbNetInterface
            // 
            this.m_cbNetInterface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cbNetInterface.ContextMenuStrip = this.m_contextMenuStrip;
            this.m_cbNetInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbNetInterface.FormattingEnabled = true;
            this.m_cbNetInterface.Location = new System.Drawing.Point(12, 12);
            this.m_cbNetInterface.Name = "m_cbNetInterface";
            this.m_cbNetInterface.Size = new System.Drawing.Size(230, 21);
            this.m_cbNetInterface.TabIndex = 0;
            this.m_cbNetInterface.SelectedIndexChanged += new System.EventHandler(this.m_cbNetInterface_SelectedIndexChanged);
            // 
            // m_contextMenuStrip
            // 
            this.m_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.m_toolStripComboBox});
            this.m_contextMenuStrip.Name = "m_contextMenuStrip";
            this.m_contextMenuStrip.Size = new System.Drawing.Size(182, 53);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // m_toolStripComboBox
            // 
            this.m_toolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_toolStripComboBox.Name = "m_toolStripComboBox";
            this.m_toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.m_toolStripComboBox.Visible = false;
            this.m_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.m_toolStripComboBox_SelectedIndexChanged);
            // 
            // m_notifyIcon
            // 
            this.m_notifyIcon.ContextMenuStrip = this.m_contextMenuStrip;
            this.m_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_notifyIcon.Icon")));
            this.m_notifyIcon.Text = "RouteIF";
            this.m_notifyIcon.Visible = true;
            this.m_notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.m_notifyIcon_MouseDoubleClick);
            // 
            // RouteIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 45);
            this.Controls.Add(this.m_cbNetInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RouteIF";
            this.Text = "RouteIF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RouteIF_FormClosing);
            this.Load += new System.EventHandler(this.RouteIF_Load);
            this.Resize += new System.EventHandler(this.RouteIF_Resize);
            this.m_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbNetInterface;
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
        private System.Windows.Forms.ContextMenuStrip m_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox m_toolStripComboBox;
    }
}

