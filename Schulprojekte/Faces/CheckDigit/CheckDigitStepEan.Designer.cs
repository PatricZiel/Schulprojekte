namespace Schulprojekte.Faces.CheckDigit
{
    partial class CheckDigitStepEan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_validateButton = new System.Windows.Forms.Button();
            this.lbl_resultMessage = new System.Windows.Forms.Label();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_inputs);
            this.panel1.Location = new System.Drawing.Point(225, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 262);
            this.panel1.TabIndex = 8;
            // 
            // btn_validateButton
            // 
            this.btn_validateButton.Location = new System.Drawing.Point(225, 347);
            this.btn_validateButton.Name = "btn_validateButton";
            this.btn_validateButton.Size = new System.Drawing.Size(133, 37);
            this.btn_validateButton.TabIndex = 9;
            this.btn_validateButton.UseVisualStyleBackColor = true;
            this.btn_validateButton.Click += new System.EventHandler(this.btn_validateButton_Click);
            // 
            // lbl_resultMessage
            // 
            this.lbl_resultMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultMessage.Location = new System.Drawing.Point(383, 347);
            this.lbl_resultMessage.Name = "lbl_resultMessage";
            this.lbl_resultMessage.Size = new System.Drawing.Size(892, 98);
            this.lbl_resultMessage.TabIndex = 10;
            // 
            // CheckDigitStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_resultMessage);
            this.Controls.Add(this.btn_validateButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CheckDigitStep";
            this.Size = new System.Drawing.Size(1470, 692);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_inputs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_validateButton;
        private System.Windows.Forms.Label lbl_resultMessage;
    }
}
