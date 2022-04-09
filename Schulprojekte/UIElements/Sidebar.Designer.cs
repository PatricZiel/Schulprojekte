using Schulprojekte.Handler;

namespace Schulprojekte.UIElements
{
    partial class Sidebar
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sidebar));
            this.pnl_toggleBar = new System.Windows.Forms.Panel();
            this.pnl_toggleIcon = new System.Windows.Forms.Panel();
            this.pnl_sidebarContent = new System.Windows.Forms.Panel();
            this.pnl_sidebarContentHeader = new System.Windows.Forms.Panel();
            this.pnl_sidebarContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_toggleBar
            // 
            this.pnl_toggleBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnl_toggleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.pnl_toggleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_toggleBar.Location = new System.Drawing.Point(270, 0);
            this.pnl_toggleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_toggleBar.Name = "pnl_toggleBar";
            this.pnl_toggleBar.Size = new System.Drawing.Size(30, 923);
            this.pnl_toggleBar.TabIndex = 0;
            this.pnl_toggleBar.Click += new System.EventHandler(this.toggleSidebar);
            // 
            // pnl_toggleIcon
            // 
            this.pnl_toggleIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnl_toggleIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.pnl_toggleIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_toggleIcon.BackgroundImage")));
            this.pnl_toggleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_toggleIcon.Location = new System.Drawing.Point(270, 877);
            this.pnl_toggleIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_toggleIcon.Name = "pnl_toggleIcon";
            this.pnl_toggleIcon.Size = new System.Drawing.Size(30, 46);
            this.pnl_toggleIcon.TabIndex = 1;
            this.pnl_toggleIcon.Click += new System.EventHandler(this.toggleSidebar);
            // 
            // pnl_sidebarContent
            // 
            this.pnl_sidebarContent.Controls.Add(this.pnl_sidebarContentHeader);
            this.pnl_sidebarContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebarContent.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebarContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_sidebarContent.Name = "pnl_sidebarContent";
            this.pnl_sidebarContent.Size = new System.Drawing.Size(270, 923);
            this.pnl_sidebarContent.TabIndex = 2;
            // 
            // pnl_sidebarContentHeader
            // 
            this.pnl_sidebarContentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(56)))), ((int)(((byte)(95)))));
            this.pnl_sidebarContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sidebarContentHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebarContentHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_sidebarContentHeader.Name = "pnl_sidebarContentHeader";
            this.pnl_sidebarContentHeader.Size = new System.Drawing.Size(270, 154);
            this.pnl_sidebarContentHeader.TabIndex = 0;
            // 
            // Sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.pnl_sidebarContent);
            this.Controls.Add(this.pnl_toggleIcon);
            this.Controls.Add(this.pnl_toggleBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sidebar";
            this.Size = new System.Drawing.Size(300, 923);
            this.SizeChanged += new System.EventHandler(this.onSidebarSizeChange);
            this.pnl_sidebarContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_toggleBar;
        private System.Windows.Forms.Panel pnl_toggleIcon;
        private System.Windows.Forms.Panel pnl_sidebarContent;
        private System.Windows.Forms.Panel pnl_sidebarContentHeader;
    }
}
