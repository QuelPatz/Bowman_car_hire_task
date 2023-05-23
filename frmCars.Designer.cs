using System;

namespace CarsDatabase
{
    partial class frmCars
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmVehicleRegistrationNumberLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.frmEngineSizeLabel = new System.Windows.Forms.Label();
            this.frmDateRegisteredLabel = new System.Windows.Forms.Label();
            this.frmRentalPerDayLabel = new System.Windows.Forms.Label();
            this.frmAvailableLabel = new System.Windows.Forms.Label();
            this.frmVehicleRegistrationNumber = new System.Windows.Forms.TextBox();
            this.frmEngineSize = new System.Windows.Forms.TextBox();
            this.frmDateReg = new System.Windows.Forms.TextBox();
            this.frmRentalPerDay = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.recordCount = new System.Windows.Forms.TextBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(592, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 49);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(592, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(592, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(592, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(592, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(592, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(34, 393);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(102, 49);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(132, 393);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 49);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(367, 393);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 49);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(465, 393);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(102, 49);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Checked = true;
            this.frmAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.frmAvailable.Location = new System.Drawing.Point(286, 288);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(18, 17);
            this.frmAvailable.TabIndex = 10;
            this.frmAvailable.UseVisualStyleBackColor = true;
            this.frmAvailable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAvailable_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bowman Car Hire";
            // 
            // frmVehicleRegistrationNumberLabel
            // 
            this.frmVehicleRegistrationNumberLabel.AutoSize = true;
            this.frmVehicleRegistrationNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleRegistrationNumberLabel.Location = new System.Drawing.Point(43, 116);
            this.frmVehicleRegistrationNumberLabel.Name = "frmVehicleRegistrationNumberLabel";
            this.frmVehicleRegistrationNumberLabel.Size = new System.Drawing.Size(214, 20);
            this.frmVehicleRegistrationNumberLabel.TabIndex = 12;
            this.frmVehicleRegistrationNumberLabel.Text = "Vehicle registration number";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMakeLabel.Location = new System.Drawing.Point(43, 149);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(49, 20);
            this.frmMakeLabel.TabIndex = 13;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmEngineSizeLabel
            // 
            this.frmEngineSizeLabel.AutoSize = true;
            this.frmEngineSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEngineSizeLabel.Location = new System.Drawing.Point(43, 182);
            this.frmEngineSizeLabel.Name = "frmEngineSizeLabel";
            this.frmEngineSizeLabel.Size = new System.Drawing.Size(98, 20);
            this.frmEngineSizeLabel.TabIndex = 14;
            this.frmEngineSizeLabel.Text = "Engine Size";
            // 
            // frmDateRegisteredLabel
            // 
            this.frmDateRegisteredLabel.AutoSize = true;
            this.frmDateRegisteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDateRegisteredLabel.Location = new System.Drawing.Point(43, 217);
            this.frmDateRegisteredLabel.Name = "frmDateRegisteredLabel";
            this.frmDateRegisteredLabel.Size = new System.Drawing.Size(131, 20);
            this.frmDateRegisteredLabel.TabIndex = 15;
            this.frmDateRegisteredLabel.Text = "Date Registered";
            // 
            // frmRentalPerDayLabel
            // 
            this.frmRentalPerDayLabel.AutoSize = true;
            this.frmRentalPerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmRentalPerDayLabel.Location = new System.Drawing.Point(43, 249);
            this.frmRentalPerDayLabel.Name = "frmRentalPerDayLabel";
            this.frmRentalPerDayLabel.Size = new System.Drawing.Size(123, 20);
            this.frmRentalPerDayLabel.TabIndex = 16;
            this.frmRentalPerDayLabel.Text = "Rental Per Day";
            // 
            // frmAvailableLabel
            // 
            this.frmAvailableLabel.AutoSize = true;
            this.frmAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAvailableLabel.Location = new System.Drawing.Point(43, 281);
            this.frmAvailableLabel.Name = "frmAvailableLabel";
            this.frmAvailableLabel.Size = new System.Drawing.Size(76, 20);
            this.frmAvailableLabel.TabIndex = 17;
            this.frmAvailableLabel.Text = "Available";
            // 
            // frmVehicleRegistrationNumber
            // 
            this.frmVehicleRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleRegistrationNumber.Location = new System.Drawing.Point(286, 116);
            this.frmVehicleRegistrationNumber.Name = "frmVehicleRegistrationNumber";
            this.frmVehicleRegistrationNumber.Size = new System.Drawing.Size(166, 22);
            this.frmVehicleRegistrationNumber.TabIndex = 18;
            this.frmVehicleRegistrationNumber.TextChanged += new System.EventHandler(this.frmVehicleRegistrationNumber_TextChanged);
            this.frmVehicleRegistrationNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVehicleRegistrationNumber_KeyDown);
            // 
            // frmEngineSize
            // 
            this.frmEngineSize.Location = new System.Drawing.Point(286, 180);
            this.frmEngineSize.Name = "frmEngineSize";
            this.frmEngineSize.Size = new System.Drawing.Size(166, 22);
            this.frmEngineSize.TabIndex = 20;
            this.frmEngineSize.TextChanged += new System.EventHandler(this.frmEngine_TextChanged);
            this.frmEngineSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEngineSize_KeyDown);
            // 
            // frmDateReg
            // 
            this.frmDateReg.Location = new System.Drawing.Point(286, 215);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(121, 22);
            this.frmDateReg.TabIndex = 21;
            this.frmDateReg.TextChanged += new System.EventHandler(this.frmDateReg_TextChanged);
            this.frmDateReg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDateReg_KeyDown);
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Location = new System.Drawing.Point(286, 249);
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(121, 22);
            this.frmRentalPerDay.TabIndex = 22;
            this.frmRentalPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frmRentalPerDay.TextChanged += new System.EventHandler(this.frmRentalPerDay_TextChanged);
            this.frmRentalPerDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRentalPerDay_KeyDown);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(286, 149);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(255, 22);
            this.frmMake.TabIndex = 19;
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            this.frmMake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMake_KeyDown);
            // 
            // recordCount
            // 
            this.recordCount.Location = new System.Drawing.Point(240, 407);
            this.recordCount.Name = "recordCount";
            this.recordCount.Size = new System.Drawing.Size(121, 22);
            this.recordCount.TabIndex = 22;
            this.recordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recordCount.Click += new System.EventHandler(this.recordCount_TextChanged_1);
            this.recordCount.TextChanged += new System.EventHandler(this.recordCount_TextChanged_1);
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.Transparent;
            this.updatePanel.Location = new System.Drawing.Point(34, 93);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(543, 235);
            this.updatePanel.TabIndex = 23;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(710, 458);
            this.Controls.Add(this.frmAvailable);
            this.Controls.Add(this.frmEngineSize);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.frmAvailableLabel);
            this.Controls.Add(this.frmRentalPerDayLabel);
            this.Controls.Add(this.frmDateReg);
            this.Controls.Add(this.frmDateRegisteredLabel);
            this.Controls.Add(this.frmVehicleRegistrationNumber);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.frmEngineSizeLabel);
            this.Controls.Add(this.frmMakeLabel);
            this.Controls.Add(this.frmVehicleRegistrationNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updatePanel);
            this.Name = "frmCars";
            this.ShowIcon = false;
            this.Text = "Task A";
            this.Load += new System.EventHandler(this.frmCars_Load_1);
            this.Click += new System.EventHandler(this.frmCars_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frmVehicleRegistrationNumberLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label frmEngineSizeLabel;
        private System.Windows.Forms.Label frmDateRegisteredLabel;
        private System.Windows.Forms.Label frmRentalPerDayLabel;
        private System.Windows.Forms.Label frmAvailableLabel;
        private System.Windows.Forms.TextBox frmVehicleRegistrationNumber;
        private System.Windows.Forms.TextBox frmEngineSize;
        private System.Windows.Forms.TextBox frmDateReg;
        private System.Windows.Forms.TextBox frmRentalPerDay;
        private System.Windows.Forms.TextBox recordCount;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.Panel updatePanel;
    }
}