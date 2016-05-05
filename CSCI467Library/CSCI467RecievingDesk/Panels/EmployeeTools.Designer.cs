namespace RecievingDesk.Panels
{
    partial class EmployeeTools
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
            this.EmployeeToolsTitle = new System.Windows.Forms.Label();
            this.EmployeeLOGOFF = new System.Windows.Forms.Button();
            this.AddItemToWarehouse_UIbutton = new System.Windows.Forms.Button();
            this.FullfillOrderButton = new System.Windows.Forms.Button();
            this.EmployeeToolsPanel = new System.Windows.Forms.Panel();
            this.EmployeeToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeToolsTitle
            // 
            this.EmployeeToolsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeToolsTitle.AutoSize = true;
            this.EmployeeToolsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeToolsTitle.Location = new System.Drawing.Point(314, 121);
            this.EmployeeToolsTitle.Name = "EmployeeToolsTitle";
            this.EmployeeToolsTitle.Size = new System.Drawing.Size(166, 25);
            this.EmployeeToolsTitle.TabIndex = 1;
            this.EmployeeToolsTitle.Text = "Employee Tools";
            // 
            // EmployeeLOGOFF
            // 
            this.EmployeeLOGOFF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeLOGOFF.Location = new System.Drawing.Point(356, 340);
            this.EmployeeLOGOFF.Name = "EmployeeLOGOFF";
            this.EmployeeLOGOFF.Size = new System.Drawing.Size(75, 23);
            this.EmployeeLOGOFF.TabIndex = 7;
            this.EmployeeLOGOFF.Text = "LOGOFF";
            this.EmployeeLOGOFF.UseVisualStyleBackColor = true;
            this.EmployeeLOGOFF.Click += new System.EventHandler(this.LOGOFF_Click);
            // 
            // AddItemToWarehouse_UIbutton
            // 
            this.AddItemToWarehouse_UIbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemToWarehouse_UIbutton.Location = new System.Drawing.Point(412, 215);
            this.AddItemToWarehouse_UIbutton.Name = "AddItemToWarehouse_UIbutton";
            this.AddItemToWarehouse_UIbutton.Size = new System.Drawing.Size(130, 44);
            this.AddItemToWarehouse_UIbutton.TabIndex = 8;
            this.AddItemToWarehouse_UIbutton.Text = "Add Item To Warehouse";
            this.AddItemToWarehouse_UIbutton.UseVisualStyleBackColor = true;
            this.AddItemToWarehouse_UIbutton.Click += new System.EventHandler(this.AddItemToWarehouse_UIbutton_Click);
            // 
            // FullfillOrderButton
            // 
            this.FullfillOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullfillOrderButton.Location = new System.Drawing.Point(243, 215);
            this.FullfillOrderButton.Name = "FullfillOrderButton";
            this.FullfillOrderButton.Size = new System.Drawing.Size(130, 44);
            this.FullfillOrderButton.TabIndex = 9;
            this.FullfillOrderButton.Text = "FullfilOrder";
            this.FullfillOrderButton.UseVisualStyleBackColor = true;
            this.FullfillOrderButton.Click += new System.EventHandler(this.FullfillOrderButton_Click_1);
            // 
            // EmployeeToolsPanel
            // 
            this.EmployeeToolsPanel.Controls.Add(this.EmployeeLOGOFF);
            this.EmployeeToolsPanel.Controls.Add(this.EmployeeToolsTitle);
            this.EmployeeToolsPanel.Controls.Add(this.AddItemToWarehouse_UIbutton);
            this.EmployeeToolsPanel.Controls.Add(this.FullfillOrderButton);
            this.EmployeeToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeToolsPanel.Name = "EmployeeToolsPanel";
            this.EmployeeToolsPanel.Size = new System.Drawing.Size(819, 506);
            this.EmployeeToolsPanel.TabIndex = 10;
            // 
            // EmployeeTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeToolsPanel);
            this.Name = "EmployeeTools";
            this.Size = new System.Drawing.Size(819, 506);
            this.EmployeeToolsPanel.ResumeLayout(false);
            this.EmployeeToolsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmployeeToolsTitle;
        private System.Windows.Forms.Button EmployeeLOGOFF;
        private System.Windows.Forms.Button AddItemToWarehouse_UIbutton;
        private System.Windows.Forms.Button FullfillOrderButton;
        private System.Windows.Forms.Panel EmployeeToolsPanel;
    }
}
