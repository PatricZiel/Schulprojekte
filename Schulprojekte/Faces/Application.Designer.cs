namespace Schulprojekte
{
    partial class Application
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
            this.pnl_appHeader = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.lbl_appHeader = new System.Windows.Forms.Label();
            this.pnl_appMainPart = new System.Windows.Forms.Panel();
            this.pnl_siteContent = new System.Windows.Forms.Panel();
            this.sidebar = new Schulprojekte.UIElements.Sidebar();
            this.pnl_appHeader.SuspendLayout();
            this.pnl_appMainPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_appHeader
            // 
            this.pnl_appHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.pnl_appHeader.Controls.Add(this.closeButton);
            this.pnl_appHeader.Controls.Add(this.lbl_appHeader);
            this.pnl_appHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_appHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_appHeader.Name = "pnl_appHeader";
            this.pnl_appHeader.Size = new System.Drawing.Size(980, 40);
            this.pnl_appHeader.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(944, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.onClose);
            // 
            // lbl_appHeader
            // 
            this.lbl_appHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_appHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_appHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appHeader.ForeColor = System.Drawing.Color.White;
            this.lbl_appHeader.Location = new System.Drawing.Point(0, 0);
            this.lbl_appHeader.Name = "lbl_appHeader";
            this.lbl_appHeader.Size = new System.Drawing.Size(980, 40);
            this.lbl_appHeader.TabIndex = 0;
            this.lbl_appHeader.Text = "Schulprojekte";
            this.lbl_appHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_appHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_appHeader_MouseDown);
            this.lbl_appHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_appHeader_MouseUp);
            // 
            // pnl_appMainPart
            // 
            this.pnl_appMainPart.Controls.Add(this.pnl_siteContent);
            this.pnl_appMainPart.Controls.Add(this.pnl_appHeader);
            this.pnl_appMainPart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_appMainPart.Location = new System.Drawing.Point(20, 0);
            this.pnl_appMainPart.Name = "pnl_appMainPart";
            this.pnl_appMainPart.Size = new System.Drawing.Size(980, 600);
            this.pnl_appMainPart.TabIndex = 3;
            // 
            // pnl_siteContent
            // 
            this.pnl_siteContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_siteContent.Location = new System.Drawing.Point(0, 40);
            this.pnl_siteContent.Name = "pnl_siteContent";
            this.pnl_siteContent.Size = new System.Drawing.Size(980, 560);
            this.pnl_siteContent.TabIndex = 2;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(64)))), ((int)(((byte)(105)))));
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(20, 600);
            this.sidebar.TabIndex = 4;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnl_appMainPart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Application";
            this.pnl_appHeader.ResumeLayout(false);
            this.pnl_appMainPart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_appHeader;
        private System.Windows.Forms.Label lbl_appHeader;
        private System.Windows.Forms.Panel pnl_appMainPart;
        private System.Windows.Forms.Panel pnl_siteContent;
        private UIElements.Sidebar sidebar;
        private System.Windows.Forms.Button closeButton;
    }
}

