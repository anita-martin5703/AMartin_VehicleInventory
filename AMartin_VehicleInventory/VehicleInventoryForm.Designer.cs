// Anita Martin
// amartin98@cnm.edu
// Title: Vehicle Class Inventory

// VehicleInventoryForm.Designer.cs

namespace AMartin_VehicleInventory
{
    partial class VehicleInventoryForm
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
            this.tabNewVehicle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txbVIN = new System.Windows.Forms.TextBox();
            this.txbLicense = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tabInventoryList = new System.Windows.Forms.TabPage();
            this.txbSummary = new System.Windows.Forms.TextBox();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.tabNewVehicle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabInventoryList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNewVehicle
            // 
            this.tabNewVehicle.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabNewVehicle.Controls.Add(this.tabPage1);
            this.tabNewVehicle.Controls.Add(this.tabInventoryList);
            this.tabNewVehicle.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNewVehicle.Location = new System.Drawing.Point(9, 6);
            this.tabNewVehicle.Multiline = true;
            this.tabNewVehicle.Name = "tabNewVehicle";
            this.tabNewVehicle.SelectedIndex = 0;
            this.tabNewVehicle.Size = new System.Drawing.Size(871, 642);
            this.tabNewVehicle.TabIndex = 0;
            this.tabNewVehicle.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbResults);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.cbType);
            this.tabPage1.Controls.Add(this.txbVIN);
            this.tabPage1.Controls.Add(this.txbLicense);
            this.tabPage1.Controls.Add(this.lblType);
            this.tabPage1.Controls.Add(this.lblVIN);
            this.tabPage1.Controls.Add(this.lblLicense);
            this.tabPage1.Controls.Add(this.lblHeading);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Vehicle Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(265, 393);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.ReadOnly = true;
            this.txbResults.Size = new System.Drawing.Size(314, 151);
            this.txbResults.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(365, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 42);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.cbType.Location = new System.Drawing.Point(365, 266);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(215, 25);
            this.cbType.TabIndex = 16;
            this.cbType.Text = "Sedan";
            // 
            // txbVIN
            // 
            this.txbVIN.Location = new System.Drawing.Point(365, 207);
            this.txbVIN.Name = "txbVIN";
            this.txbVIN.Size = new System.Drawing.Size(215, 22);
            this.txbVIN.TabIndex = 15;
            // 
            // txbLicense
            // 
            this.txbLicense.Location = new System.Drawing.Point(365, 147);
            this.txbLicense.Name = "txbLicense";
            this.txbLicense.Size = new System.Drawing.Size(215, 22);
            this.txbLicense.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(284, 272);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 18);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type: ";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.Location = new System.Drawing.Point(292, 211);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(41, 18);
            this.lblVIN.TabIndex = 12;
            this.lblVIN.Text = "VIN: ";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(262, 151);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(71, 18);
            this.lblLicense.TabIndex = 11;
            this.lblLicense.Text = "License: ";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(328, 90);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(234, 32);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "New Vehicle Form";
            // 
            // tabInventoryList
            // 
            this.tabInventoryList.Controls.Add(this.txbSummary);
            this.tabInventoryList.Controls.Add(this.lbInventory);
            this.tabInventoryList.Location = new System.Drawing.Point(4, 4);
            this.tabInventoryList.Name = "tabInventoryList";
            this.tabInventoryList.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventoryList.Size = new System.Drawing.Size(843, 634);
            this.tabInventoryList.TabIndex = 1;
            this.tabInventoryList.Text = "Inventory List";
            this.tabInventoryList.UseVisualStyleBackColor = true;
            // 
            // txbSummary
            // 
            this.txbSummary.Location = new System.Drawing.Point(160, 446);
            this.txbSummary.Multiline = true;
            this.txbSummary.Name = "txbSummary";
            this.txbSummary.ReadOnly = true;
            this.txbSummary.Size = new System.Drawing.Size(570, 160);
            this.txbSummary.TabIndex = 1;
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.ItemHeight = 16;
            this.lbInventory.Location = new System.Drawing.Point(160, 30);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(571, 388);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbInventory_MouseDoubleClick);
            // 
            // VehicleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 656);
            this.Controls.Add(this.tabNewVehicle);
            this.Name = "VehicleInventoryForm";
            this.Text = "Form1";
            this.tabNewVehicle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabInventoryList.ResumeLayout(false);
            this.tabInventoryList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNewVehicle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txbVIN;
        private System.Windows.Forms.TextBox txbLicense;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabPage tabInventoryList;
        private System.Windows.Forms.TextBox txbSummary;
        private System.Windows.Forms.ListBox lbInventory;
    }
}

