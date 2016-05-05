namespace RecievingDesk.Panels
{
    partial class ChangeShippingAndTax
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
            this.CSTP = new System.Windows.Forms.Panel();
            this.TaxPercent = new System.Windows.Forms.TextBox();
            this.TaxValue = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.ZIPTextBox = new System.Windows.Forms.TextBox();
            this.ShippingCostTextBox = new System.Windows.Forms.TextBox();
            this.ShippingCostLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.CSTPCancel = new System.Windows.Forms.Button();
            this.CSTPUpdate = new System.Windows.Forms.Button();
            this.CSTP_Title = new System.Windows.Forms.Label();
            this.CSTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // CSTP
            // 
            this.CSTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSTP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CSTP.Controls.Add(this.TaxPercent);
            this.CSTP.Controls.Add(this.TaxValue);
            this.CSTP.Controls.Add(this.StateTextBox);
            this.CSTP.Controls.Add(this.ZIPTextBox);
            this.CSTP.Controls.Add(this.ShippingCostTextBox);
            this.CSTP.Controls.Add(this.ShippingCostLabel);
            this.CSTP.Controls.Add(this.zipLabel);
            this.CSTP.Controls.Add(this.StateLabel);
            this.CSTP.Controls.Add(this.CSTPCancel);
            this.CSTP.Controls.Add(this.CSTPUpdate);
            this.CSTP.Controls.Add(this.CSTP_Title);
            this.CSTP.Location = new System.Drawing.Point(0, 0);
            this.CSTP.Name = "CSTP";
            this.CSTP.Size = new System.Drawing.Size(819, 508);
            this.CSTP.TabIndex = 2;
            this.CSTP.Visible = false;
            // 
            // TaxPercent
            // 
            this.TaxPercent.Location = new System.Drawing.Point(337, 280);
            this.TaxPercent.Name = "TaxPercent";
            this.TaxPercent.Size = new System.Drawing.Size(100, 20);
            this.TaxPercent.TabIndex = 13;
            // 
            // TaxValue
            // 
            this.TaxValue.AutoSize = true;
            this.TaxValue.Location = new System.Drawing.Point(259, 283);
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Size = new System.Drawing.Size(65, 13);
            this.TaxValue.TabIndex = 12;
            this.TaxValue.Text = "Tax Percent";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(337, 204);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(100, 20);
            this.StateTextBox.TabIndex = 11;
            // 
            // ZIPTextBox
            // 
            this.ZIPTextBox.Location = new System.Drawing.Point(337, 230);
            this.ZIPTextBox.Name = "ZIPTextBox";
            this.ZIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZIPTextBox.TabIndex = 10;
            // 
            // ShippingCostTextBox
            // 
            this.ShippingCostTextBox.Location = new System.Drawing.Point(337, 256);
            this.ShippingCostTextBox.Name = "ShippingCostTextBox";
            this.ShippingCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShippingCostTextBox.TabIndex = 9;
            // 
            // ShippingCostLabel
            // 
            this.ShippingCostLabel.AutoSize = true;
            this.ShippingCostLabel.Location = new System.Drawing.Point(259, 259);
            this.ShippingCostLabel.Name = "ShippingCostLabel";
            this.ShippingCostLabel.Size = new System.Drawing.Size(72, 13);
            this.ShippingCostLabel.TabIndex = 8;
            this.ShippingCostLabel.Text = "Shipping Cost";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(259, 237);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(52, 13);
            this.zipLabel.TabIndex = 7;
            this.zipLabel.Text = "ZIP Code";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(259, 211);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 6;
            this.StateLabel.Text = "State";
            // 
            // CSTPCancel
            // 
            this.CSTPCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSTPCancel.Location = new System.Drawing.Point(260, 349);
            this.CSTPCancel.Name = "CSTPCancel";
            this.CSTPCancel.Size = new System.Drawing.Size(75, 23);
            this.CSTPCancel.TabIndex = 5;
            this.CSTPCancel.Text = "&Cancel";
            this.CSTPCancel.UseVisualStyleBackColor = true;
            // 
            // CSTPUpdate
            // 
            this.CSTPUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSTPUpdate.Location = new System.Drawing.Point(429, 349);
            this.CSTPUpdate.Name = "CSTPUpdate";
            this.CSTPUpdate.Size = new System.Drawing.Size(75, 23);
            this.CSTPUpdate.TabIndex = 4;
            this.CSTPUpdate.Text = "Update";
            this.CSTPUpdate.UseVisualStyleBackColor = true;
            this.CSTPUpdate.Click += new System.EventHandler(this.CSTPUpdate_Click);
            // 
            // CSTP_Title
            // 
            this.CSTP_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSTP_Title.AutoSize = true;
            this.CSTP_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSTP_Title.Location = new System.Drawing.Point(224, 69);
            this.CSTP_Title.Name = "CSTP_Title";
            this.CSTP_Title.Size = new System.Drawing.Size(347, 25);
            this.CSTP_Title.TabIndex = 0;
            this.CSTP_Title.Text = "Change Shipping / Tax Parameters";
            // 
            // ChangeShippingAndTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CSTP);
            this.Name = "ChangeShippingAndTax";
            this.Size = new System.Drawing.Size(819, 508);
            this.CSTP.ResumeLayout(false);
            this.CSTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CSTP;
        private System.Windows.Forms.Button CSTPCancel;
        private System.Windows.Forms.Button CSTPUpdate;
        private System.Windows.Forms.Label CSTP_Title;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label ShippingCostLabel;
        private System.Windows.Forms.TextBox ShippingCostTextBox;
        private System.Windows.Forms.TextBox ZIPTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox TaxPercent;
        private System.Windows.Forms.Label TaxValue;
    }
}
