namespace Schulprojekte.Faces.CheckDigit
{
    partial class CheckDigitTemplate
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
            this.pnl_templateContent = new System.Windows.Forms.Panel();
            this.pnl_digitStepSwitch = new System.Windows.Forms.Panel();
            this.pnl_digitStepSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_templateContent
            // 
            this.pnl_templateContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_templateContent.Location = new System.Drawing.Point(0, 65);
            this.pnl_templateContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_templateContent.Name = "pnl_templateContent";
            this.pnl_templateContent.Size = new System.Drawing.Size(980, 535);
            this.pnl_templateContent.TabIndex = 0;
            // 
            // pnl_digitStepSwitch
            // 
            this.pnl_digitStepSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_digitStepSwitch.Location = new System.Drawing.Point(0, 0);
            this.pnl_digitStepSwitch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_digitStepSwitch.Name = "pnl_digitStepSwitch";
            this.pnl_digitStepSwitch.Size = new System.Drawing.Size(980, 65);
            this.pnl_digitStepSwitch.TabIndex = 1;
            // 
            // CheckDigitTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_digitStepSwitch);
            this.Controls.Add(this.pnl_templateContent);
            this.Name = "CheckDigitTemplate";
            this.Size = new System.Drawing.Size(980, 600);
            this.pnl_digitStepSwitch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_templateContent;
        private System.Windows.Forms.Panel pnl_digitStepSwitch;
        
    }
}
