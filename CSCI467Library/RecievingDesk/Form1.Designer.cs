namespace RecievingDesk
{
    partial class Form1
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
            this.ItemRecievedCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckAccept = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.NumRecieved = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PartName = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemRecievedCode
            // 
            this.ItemRecievedCode.Location = new System.Drawing.Point(31, 58);
            this.ItemRecievedCode.Name = "ItemRecievedCode";
            this.ItemRecievedCode.Size = new System.Drawing.Size(229, 26);
            this.ItemRecievedCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item recieved code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckAccept
            // 
            this.CheckAccept.Location = new System.Drawing.Point(424, 54);
            this.CheckAccept.Name = "CheckAccept";
            this.CheckAccept.Size = new System.Drawing.Size(155, 34);
            this.CheckAccept.TabIndex = 2;
            this.CheckAccept.Text = "Check/Accept";
            this.CheckAccept.UseVisualStyleBackColor = true;
            this.CheckAccept.Click += new System.EventHandler(this.CheckAccpet_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(617, 56);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 32);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // NumRecieved
            // 
            this.NumRecieved.Location = new System.Drawing.Point(276, 58);
            this.NumRecieved.Name = "NumRecieved";
            this.NumRecieved.Size = new System.Drawing.Size(129, 26);
            this.NumRecieved.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number Recieved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Part Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // PartName
            // 
            this.PartName.AutoSize = true;
            this.PartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartName.Location = new System.Drawing.Point(27, 145);
            this.PartName.MinimumSize = new System.Drawing.Size(100, 2);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(100, 22);
            this.PartName.TabIndex = 8;
            this.PartName.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Location = new System.Drawing.Point(278, 145);
            this.Quantity.MinimumSize = new System.Drawing.Size(100, 2);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 22);
            this.Quantity.TabIndex = 10;
            this.Quantity.Text = " ";
            this.Quantity.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 318);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.PartName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumRecieved);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CheckAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemRecievedCode);
            this.Name = "Form1";
            this.Text = "Recieving Desk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemRecievedCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckAccept;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox NumRecieved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PartName;
        private System.Windows.Forms.Label Quantity;
    }
}

