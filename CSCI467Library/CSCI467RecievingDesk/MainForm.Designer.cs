using System.Windows.Forms;

namespace AutoPartsSystem
{
    partial class MainForm
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
            this.EmployeeToolsTitle = new System.Windows.Forms.Label();
            this.EmployeeLOGOFF = new System.Windows.Forms.Button();
            this.AddItemToWarehouse_UIbutton = new System.Windows.Forms.Button();
            this.FullfillOrderButton = new System.Windows.Forms.Button();
            this.EmployeeToolsPanel = new System.Windows.Forms.Panel();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.UIlabel4 = new System.Windows.Forms.Label();
            this.AdminLOGOFF = new System.Windows.Forms.Button();
            this.CSTP_UIbutton = new System.Windows.Forms.Button();
            this.LoginPage = new System.Windows.Forms.Panel();
            this.Invalid_IDPW = new System.Windows.Forms.Panel();
            this.Invalid_flag = new System.Windows.Forms.Label();
            this.UIlabel3 = new System.Windows.Forms.Label();
            this.UIlabel2 = new System.Windows.Forms.Label();
            this.LOGIN_UIbutton = new System.Windows.Forms.Button();
            this.PW_entry = new System.Windows.Forms.TextBox();
            this.ID_entry = new System.Windows.Forms.TextBox();
            this.UIlabel1 = new System.Windows.Forms.Label();
            this.CSTP.SuspendLayout();
            this.EmployeeToolsPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.Invalid_IDPW.SuspendLayout();
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
            this.CSTP.Size = new System.Drawing.Size(819, 436);
            this.CSTP.TabIndex = 1;
            this.CSTP.Visible = false;
            // 
            // TaxPercent
            // 
            this.TaxPercent.Location = new System.Drawing.Point(337, 280);
            this.TaxPercent.Name = "TaxPercent";
            this.TaxPercent.Size = new System.Drawing.Size(100, 20);
            this.TaxPercent.TabIndex = 4;
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
            this.StateTextBox.TabIndex = 1;
            // 
            // ZIPTextBox
            // 
            this.ZIPTextBox.Location = new System.Drawing.Point(337, 230);
            this.ZIPTextBox.Name = "ZIPTextBox";
            this.ZIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZIPTextBox.TabIndex = 2;
            // 
            // ShippingCostTextBox
            // 
            this.ShippingCostTextBox.Location = new System.Drawing.Point(337, 256);
            this.ShippingCostTextBox.Name = "ShippingCostTextBox";
            this.ShippingCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShippingCostTextBox.TabIndex = 3;
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
            this.CSTPCancel.Location = new System.Drawing.Point(260, 313);
            this.CSTPCancel.Name = "CSTPCancel";
            this.CSTPCancel.Size = new System.Drawing.Size(75, 23);
            this.CSTPCancel.TabIndex = 5;
            this.CSTPCancel.Text = "&Cancel";
            this.CSTPCancel.UseVisualStyleBackColor = true;
            // 
            // CSTPUpdate
            // 
            this.CSTPUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSTPUpdate.Location = new System.Drawing.Point(429, 313);
            this.CSTPUpdate.Name = "CSTPUpdate";
            this.CSTPUpdate.Size = new System.Drawing.Size(75, 23);
            this.CSTPUpdate.TabIndex = 6;
            this.CSTPUpdate.Text = "Update";
            this.CSTPUpdate.UseVisualStyleBackColor = true;
            this.CSTPUpdate.Click += new System.EventHandler(this.CSTPUpdate_Click);
            // 
            // CSTP_Title
            // 
            this.CSTP_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSTP_Title.AutoSize = true;
            this.CSTP_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSTP_Title.Location = new System.Drawing.Point(224, 33);
            this.CSTP_Title.Name = "CSTP_Title";
            this.CSTP_Title.Size = new System.Drawing.Size(347, 25);
            this.CSTP_Title.TabIndex = 0;
            this.CSTP_Title.Text = "Change Shipping / Tax Parameters";
            // 
            // EmployeeToolsTitle
            // 
            this.EmployeeToolsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeToolsTitle.AutoSize = true;
            this.EmployeeToolsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeToolsTitle.Location = new System.Drawing.Point(314, 18);
            this.EmployeeToolsTitle.Name = "EmployeeToolsTitle";
            this.EmployeeToolsTitle.Size = new System.Drawing.Size(166, 25);
            this.EmployeeToolsTitle.TabIndex = 1;
            this.EmployeeToolsTitle.Text = "Employee Tools";
            // 
            // EmployeeLOGOFF
            // 
            this.EmployeeLOGOFF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeLOGOFF.Location = new System.Drawing.Point(356, 237);
            this.EmployeeLOGOFF.Name = "EmployeeLOGOFF";
            this.EmployeeLOGOFF.Size = new System.Drawing.Size(75, 23);
            this.EmployeeLOGOFF.TabIndex = 2;
            this.EmployeeLOGOFF.Text = "LOGOFF";
            this.EmployeeLOGOFF.UseVisualStyleBackColor = true;
            this.EmployeeLOGOFF.Click += new System.EventHandler(this.EmployeeLOGOFF_Click);
            // 
            // AddItemToWarehouse_UIbutton
            // 
            this.AddItemToWarehouse_UIbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddItemToWarehouse_UIbutton.Location = new System.Drawing.Point(412, 112);
            this.AddItemToWarehouse_UIbutton.Name = "AddItemToWarehouse_UIbutton";
            this.AddItemToWarehouse_UIbutton.Size = new System.Drawing.Size(130, 44);
            this.AddItemToWarehouse_UIbutton.TabIndex = 1;
            this.AddItemToWarehouse_UIbutton.Text = "Add Item To Warehouse";
            this.AddItemToWarehouse_UIbutton.UseVisualStyleBackColor = true;
            this.AddItemToWarehouse_UIbutton.Click += new System.EventHandler(this.AddItemToWarehouse_UIbutton_Click);
            // 
            // FullfillOrderButton
            // 
            this.FullfillOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullfillOrderButton.Location = new System.Drawing.Point(243, 112);
            this.FullfillOrderButton.Name = "FullfillOrderButton";
            this.FullfillOrderButton.Size = new System.Drawing.Size(130, 44);
            this.FullfillOrderButton.TabIndex = 0;
            this.FullfillOrderButton.Text = "FullfillOrder";
            this.FullfillOrderButton.UseVisualStyleBackColor = true;
            this.FullfillOrderButton.Click += new System.EventHandler(this.FulfillOrderButton_Click);
            // 
            // EmployeeToolsPanel
            // 
            this.EmployeeToolsPanel.Controls.Add(this.EmployeeLOGOFF);
            this.EmployeeToolsPanel.Controls.Add(this.EmployeeToolsTitle);
            this.EmployeeToolsPanel.Controls.Add(this.AddItemToWarehouse_UIbutton);
            this.EmployeeToolsPanel.Controls.Add(this.FullfillOrderButton);
            this.EmployeeToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeToolsPanel.Name = "EmployeeToolsPanel";
            this.EmployeeToolsPanel.Size = new System.Drawing.Size(819, 301);
            this.EmployeeToolsPanel.TabIndex = 10;
            this.EmployeeToolsPanel.Visible = false;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AdminPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminPanel.Controls.Add(this.UIlabel4);
            this.AdminPanel.Controls.Add(this.AdminLOGOFF);
            this.AdminPanel.Controls.Add(this.CSTP_UIbutton);
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(843, 446);
            this.AdminPanel.TabIndex = 7;
            this.AdminPanel.Visible = false;
            // 
            // UIlabel4
            // 
            this.UIlabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UIlabel4.AutoSize = true;
            this.UIlabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIlabel4.Location = new System.Drawing.Point(247, -1);
            this.UIlabel4.Name = "UIlabel4";
            this.UIlabel4.Size = new System.Drawing.Size(318, 39);
            this.UIlabel4.TabIndex = 0;
            this.UIlabel4.Text = "Administrator Tools";
            // 
            // AdminLOGOFF
            // 
            this.AdminLOGOFF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AdminLOGOFF.Location = new System.Drawing.Point(364, 363);
            this.AdminLOGOFF.Name = "AdminLOGOFF";
            this.AdminLOGOFF.Size = new System.Drawing.Size(75, 23);
            this.AdminLOGOFF.TabIndex = 6;
            this.AdminLOGOFF.Text = "LOGOFF";
            this.AdminLOGOFF.UseVisualStyleBackColor = true;
            this.AdminLOGOFF.Click += new System.EventHandler(this.AdminLOGOFF_Click);
            // 
            // CSTP_UIbutton
            // 
            this.CSTP_UIbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSTP_UIbutton.Location = new System.Drawing.Point(337, 169);
            this.CSTP_UIbutton.Name = "CSTP_UIbutton";
            this.CSTP_UIbutton.Size = new System.Drawing.Size(130, 44);
            this.CSTP_UIbutton.TabIndex = 5;
            this.CSTP_UIbutton.Text = "Change Shipping / Tax Parameters";
            this.CSTP_UIbutton.UseVisualStyleBackColor = true;
            this.CSTP_UIbutton.Click += new System.EventHandler(this.CSTP_UIbutton_Click);
            // 
            // LoginPage
            // 
            this.LoginPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginPage.Controls.Add(this.Invalid_IDPW);
            this.LoginPage.Controls.Add(this.UIlabel3);
            this.LoginPage.Controls.Add(this.UIlabel2);
            this.LoginPage.Controls.Add(this.LOGIN_UIbutton);
            this.LoginPage.Controls.Add(this.PW_entry);
            this.LoginPage.Controls.Add(this.ID_entry);
            this.LoginPage.Controls.Add(this.UIlabel1);
            this.LoginPage.Location = new System.Drawing.Point(0, 0);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(843, 545);
            this.LoginPage.TabIndex = 1;
            // 
            // Invalid_IDPW
            // 
            this.Invalid_IDPW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Invalid_IDPW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Invalid_IDPW.Controls.Add(this.Invalid_flag);
            this.Invalid_IDPW.Location = new System.Drawing.Point(318, 237);
            this.Invalid_IDPW.Name = "Invalid_IDPW";
            this.Invalid_IDPW.Size = new System.Drawing.Size(193, 29);
            this.Invalid_IDPW.TabIndex = 6;
            this.Invalid_IDPW.Visible = false;
            // 
            // Invalid_flag
            // 
            this.Invalid_flag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Invalid_flag.AutoSize = true;
            this.Invalid_flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invalid_flag.ForeColor = System.Drawing.Color.Red;
            this.Invalid_flag.Location = new System.Drawing.Point(31, 6);
            this.Invalid_flag.Name = "Invalid_flag";
            this.Invalid_flag.Size = new System.Drawing.Size(141, 16);
            this.Invalid_flag.TabIndex = 0;
            this.Invalid_flag.Text = "Invalid ID or Password";
            // 
            // UIlabel3
            // 
            this.UIlabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UIlabel3.AutoSize = true;
            this.UIlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIlabel3.Location = new System.Drawing.Point(377, 185);
            this.UIlabel3.Name = "UIlabel3";
            this.UIlabel3.Size = new System.Drawing.Size(78, 20);
            this.UIlabel3.TabIndex = 5;
            this.UIlabel3.Text = "Password";
            // 
            // UIlabel2
            // 
            this.UIlabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UIlabel2.AutoSize = true;
            this.UIlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIlabel2.Location = new System.Drawing.Point(365, 118);
            this.UIlabel2.Name = "UIlabel2";
            this.UIlabel2.Size = new System.Drawing.Size(100, 20);
            this.UIlabel2.TabIndex = 4;
            this.UIlabel2.Text = "Employee ID";
            // 
            // LOGIN_UIbutton
            // 
            this.LOGIN_UIbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LOGIN_UIbutton.Location = new System.Drawing.Point(380, 266);
            this.LOGIN_UIbutton.Name = "LOGIN_UIbutton";
            this.LOGIN_UIbutton.Size = new System.Drawing.Size(75, 23);
            this.LOGIN_UIbutton.TabIndex = 2;
            this.LOGIN_UIbutton.Text = "Log In";
            this.LOGIN_UIbutton.UseVisualStyleBackColor = true;
            this.LOGIN_UIbutton.Click += new System.EventHandler(this.LOGIN_UIbutton_Click);
            // 
            // PW_entry
            // 
            this.PW_entry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PW_entry.Location = new System.Drawing.Point(318, 211);
            this.PW_entry.Name = "PW_entry";
            this.PW_entry.PasswordChar = '*';
            this.PW_entry.Size = new System.Drawing.Size(193, 20);
            this.PW_entry.TabIndex = 1;
            // 
            // ID_entry
            // 
            this.ID_entry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ID_entry.Location = new System.Drawing.Point(318, 149);
            this.ID_entry.Name = "ID_entry";
            this.ID_entry.Size = new System.Drawing.Size(193, 20);
            this.ID_entry.TabIndex = 0;
            // 
            // UIlabel1
            // 
            this.UIlabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UIlabel1.AutoSize = true;
            this.UIlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIlabel1.Location = new System.Drawing.Point(240, 41);
            this.UIlabel1.Name = "UIlabel1";
            this.UIlabel1.Size = new System.Drawing.Size(298, 55);
            this.UIlabel1.TabIndex = 0;
            this.UIlabel1.Text = "    Zone Auto";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 546);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.CSTP);
            this.Controls.Add(this.EmployeeToolsPanel);
            this.Controls.Add(this.LoginPage);
            this.Name = "MainForm";
            this.CSTP.ResumeLayout(false);
            this.CSTP.PerformLayout();
            this.EmployeeToolsPanel.ResumeLayout(false);
            this.EmployeeToolsPanel.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.Invalid_IDPW.ResumeLayout(false);
            this.Invalid_IDPW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPage;
        private System.Windows.Forms.Panel Invalid_IDPW;
        private System.Windows.Forms.Label Invalid_flag;
        private System.Windows.Forms.Label UIlabel3;
        private System.Windows.Forms.Label UIlabel2;
        private System.Windows.Forms.Button LOGIN_UIbutton;
        private System.Windows.Forms.TextBox PW_entry;
        private System.Windows.Forms.TextBox ID_entry;
        private System.Windows.Forms.Label UIlabel1;


        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Label UIlabel4;
        private System.Windows.Forms.Button AdminLOGOFF;
        private System.Windows.Forms.Button CSTP_UIbutton;


        private System.Windows.Forms.Label EmployeeToolsTitle;
        private System.Windows.Forms.Button EmployeeLOGOFF;
        private System.Windows.Forms.Button AddItemToWarehouse_UIbutton;
        private System.Windows.Forms.Button FullfillOrderButton;
        private System.Windows.Forms.Panel EmployeeToolsPanel;

        private System.Windows.Forms.Panel CSTP;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox ZIPTextBox;
        private System.Windows.Forms.TextBox TaxPercent;
        private System.Windows.Forms.TextBox ShippingCostTextBox;

        private System.Windows.Forms.Button CSTPCancel;
        private System.Windows.Forms.Button CSTPUpdate;
        private System.Windows.Forms.Label CSTP_Title;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label ShippingCostLabel;
        

        

        private System.Windows.Forms.Label TaxValue;

    }
}











