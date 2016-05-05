namespace RecievingDesk.Panels
{
    partial class AddItemToWarehouse
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
            this.AddItemToWareHouse_Panel = new System.Windows.Forms.Panel();
            this.UIlabel11 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.AddItemCancel = new System.Windows.Forms.Button();
            this.AddItemUpdate = new System.Windows.Forms.Button();
            this.AddItemPage_Title = new System.Windows.Forms.Label();
            this.DataGrid_Label = new System.Windows.Forms.Label();
            this.AddItemToWareHouse_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItemToWareHouse_Panel
            // 
            this.AddItemToWareHouse_Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemToWareHouse_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddItemToWareHouse_Panel.Controls.Add(this.UIlabel11);
            this.AddItemToWareHouse_Panel.Controls.Add(this.dataGrid);
            this.AddItemToWareHouse_Panel.Controls.Add(this.AddItemCancel);
            this.AddItemToWareHouse_Panel.Controls.Add(this.AddItemUpdate);
            this.AddItemToWareHouse_Panel.Controls.Add(this.AddItemPage_Title);
            this.AddItemToWareHouse_Panel.Controls.Add(this.DataGrid_Label);
            this.AddItemToWareHouse_Panel.Location = new System.Drawing.Point(0, 0);
            this.AddItemToWareHouse_Panel.Name = "AddItemToWareHouse_Panel";
            this.AddItemToWareHouse_Panel.Size = new System.Drawing.Size(819, 506);
            this.AddItemToWareHouse_Panel.TabIndex = 8;
            this.AddItemToWareHouse_Panel.Visible = false;
            // 
            // UIlabel11
            // 
            this.UIlabel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UIlabel11.AutoSize = true;
            this.UIlabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIlabel11.Location = new System.Drawing.Point(274, 15);
            this.UIlabel11.Name = "UIlabel11";
            this.UIlabel11.Size = new System.Drawing.Size(236, 25);
            this.UIlabel11.TabIndex = 0;
            this.UIlabel11.Text = "Add Item at Warehouse";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.DataMember = "";
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(279, 78);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(231, 290);
            this.dataGrid.TabIndex = 8;
            // 
            // AddItemCancel
            // 
            this.AddItemCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemCancel.Location = new System.Drawing.Point(249, 385);
            this.AddItemCancel.Name = "AddItemCancel";
            this.AddItemCancel.Size = new System.Drawing.Size(75, 23);
            this.AddItemCancel.TabIndex = 4;
            this.AddItemCancel.Text = "&Cancel";
            this.AddItemCancel.UseVisualStyleBackColor = true;
            this.AddItemCancel.Click += new System.EventHandler(this.AddItemCancel_Click);
            // 
            // AddItemUpdate
            // 
            this.AddItemUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemUpdate.Location = new System.Drawing.Point(473, 385);
            this.AddItemUpdate.Name = "AddItemUpdate";
            this.AddItemUpdate.Size = new System.Drawing.Size(75, 23);
            this.AddItemUpdate.TabIndex = 3;
            this.AddItemUpdate.Text = "Update";
            this.AddItemUpdate.UseVisualStyleBackColor = true;
            this.AddItemUpdate.Click += new System.EventHandler(this.AddItemUpdate_Click);
            // 
            // AddItemPage_Title
            // 
            this.AddItemPage_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemPage_Title.AutoSize = true;
            this.AddItemPage_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemPage_Title.Location = this.UIlabel11.Location;
            this.AddItemPage_Title.Name = "AddItemPage_Title";
            this.AddItemPage_Title.Size = new System.Drawing.Size(136, 25);
            this.AddItemPage_Title.TabIndex = 0;
            this.AddItemPage_Title.Text = "Recieve Item";
            // 
            // DataGrid_Label
            // 
            this.DataGrid_Label.Anchor = this.dataGrid.Anchor;
            this.DataGrid_Label.AutoSize = this.dataGrid.AutoSize;
            this.DataGrid_Label.Location = new System.Drawing.Point(276, 55);
            this.DataGrid_Label.Name = "DataGrid_Label";
            this.DataGrid_Label.Size = new System.Drawing.Size(200, 20);
            this.DataGrid_Label.TabIndex = 1;
            this.DataGrid_Label.Text = "Parts In Stock";
            // 
            // AddItemToWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddItemToWareHouse_Panel);
            this.Name = "AddItemToWarehouse";
            this.Size = new System.Drawing.Size(819, 506);
            this.AddItemToWareHouse_Panel.ResumeLayout(false);
            this.AddItemToWareHouse_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddItemToWareHouse_Panel;
        private System.Windows.Forms.Label UIlabel11;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.Button AddItemCancel;
        private System.Windows.Forms.Button AddItemUpdate;
        private System.Windows.Forms.Label AddItemPage_Title;
        private System.Windows.Forms.Label DataGrid_Label;
    }
}
