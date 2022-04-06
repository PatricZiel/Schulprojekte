namespace Schulprojekte.Faces.QuantitativeOfferComparison
{
    partial class QuantitativeOfferComparisonStep2
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
            this.lbl_stepTwoHeader = new System.Windows.Forms.Label();
            this.input_offerName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_inputs
            // 
            this.pnl_inputs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_inputs.Location = new System.Drawing.Point(0, 77);
            this.pnl_inputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_inputs.Name = "pnl_inputs";
            this.pnl_inputs.Size = new System.Drawing.Size(1050, 385);
            this.pnl_inputs.TabIndex = 7;
            // 
            // lbl_stepTwoHeader
            // 
            this.lbl_stepTwoHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_stepTwoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stepTwoHeader.Location = new System.Drawing.Point(0, 0);
            this.lbl_stepTwoHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stepTwoHeader.Name = "lbl_stepTwoHeader";
            this.lbl_stepTwoHeader.Size = new System.Drawing.Size(502, 58);
            this.lbl_stepTwoHeader.TabIndex = 9;
            this.lbl_stepTwoHeader.Text = "Angebotsinformationen - ";
            // 
            // input_offerName
            // 
            this.input_offerName.Dock = System.Windows.Forms.DockStyle.Right;
            this.input_offerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_offerName.Location = new System.Drawing.Point(504, 0);
            this.input_offerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_offerName.Name = "input_offerName";
            this.input_offerName.Size = new System.Drawing.Size(546, 53);
            this.input_offerName.TabIndex = 1;
            this.input_offerName.TabStop = false;
            this.input_offerName.Text = "Angebot";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_stepTwoHeader);
            this.panel3.Controls.Add(this.input_offerName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 58);
            this.panel3.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.pnl_inputs);
            this.panel6.Location = new System.Drawing.Point(225, 77);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1050, 462);
            this.panel6.TabIndex = 10;
            // 
            // QuantitativeOfferComparisonStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "QuantitativeOfferComparisonStep2";
            this.Size = new System.Drawing.Size(1470, 769);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_inputs;
        private System.Windows.Forms.Label lbl_stepTwoHeader;
        private System.Windows.Forms.TextBox input_offerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
    }
}
