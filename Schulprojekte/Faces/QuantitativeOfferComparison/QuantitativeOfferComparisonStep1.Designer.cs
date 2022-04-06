namespace Schulprojekte.Faces.QuantitativeOfferComparison
{
    partial class QuantitativeOfferComparisonStep1
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
            this.pnl_inputs = new System.Windows.Forms.Panel();
            this.lbl_stepOneHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_inputs
            // 
            this.pnl_inputs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_inputs.Location = new System.Drawing.Point(0, 77);
            this.pnl_inputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_inputs.Name = "pnl_inputs";
            this.pnl_inputs.Size = new System.Drawing.Size(1050, 185);
            this.pnl_inputs.TabIndex = 6;
            // 
            // lbl_stepOneHeader
            // 
            this.lbl_stepOneHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_stepOneHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stepOneHeader.Location = new System.Drawing.Point(0, 0);
            this.lbl_stepOneHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stepOneHeader.Name = "lbl_stepOneHeader";
            this.lbl_stepOneHeader.Size = new System.Drawing.Size(1050, 49);
            this.lbl_stepOneHeader.TabIndex = 7;
            this.lbl_stepOneHeader.Text = "Generelle Informationen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_stepOneHeader);
            this.panel1.Controls.Add(this.pnl_inputs);
            this.panel1.Location = new System.Drawing.Point(225, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 262);
            this.panel1.TabIndex = 8;
            // 
            // QuantitativeOfferComparisonStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "QuantitativeOfferComparisonStep1";
            this.Size = new System.Drawing.Size(1470, 692);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_inputs;
        private System.Windows.Forms.Label lbl_stepOneHeader;
        private System.Windows.Forms.Panel panel1;
    }
}
