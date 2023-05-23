namespace CarsDatabase
{
    partial class frmAdd
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
            this.frmAvailableLabel = new System.Windows.Forms.Label();
            this.frmRentalPerDayLabel = new System.Windows.Forms.Label();
            this.frmDateRegisteredLabel = new System.Windows.Forms.Label();
            this.frmEngineSizeLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.frmVehicleRegLabel = new System.Windows.Forms.Label();
            this.frmDateRegistered = new System.Windows.Forms.TextBox();
            this.frmEngineSize = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.frmRentalPerDay = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // frmAvailableLabel
            // 
            this.frmAvailableLabel.AutoSize = true;
            this.frmAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAvailableLabel.Location = new System.Drawing.Point(42, 188);
            this.frmAvailableLabel.Name = "frmAvailableLabel";
            this.frmAvailableLabel.Size = new System.Drawing.Size(65, 18);
            this.frmAvailableLabel.TabIndex = 24;
            this.frmAvailableLabel.Text = "Available";
            // 
            // frmRentalPerDayLabel
            // 
            this.frmRentalPerDayLabel.AutoSize = true;
            this.frmRentalPerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmRentalPerDayLabel.Location = new System.Drawing.Point(41, 160);
            this.frmRentalPerDayLabel.Name = "frmRentalPerDayLabel";
            this.frmRentalPerDayLabel.Size = new System.Drawing.Size(107, 18);
            this.frmRentalPerDayLabel.TabIndex = 23;
            this.frmRentalPerDayLabel.Text = "Rental Per Day";
            // 
            // frmDateRegisteredLabel
            // 
            this.frmDateRegisteredLabel.AutoSize = true;
            this.frmDateRegisteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDateRegisteredLabel.Location = new System.Drawing.Point(41, 132);
            this.frmDateRegisteredLabel.Name = "frmDateRegisteredLabel";
            this.frmDateRegisteredLabel.Size = new System.Drawing.Size(114, 18);
            this.frmDateRegisteredLabel.TabIndex = 22;
            this.frmDateRegisteredLabel.Text = "Date Registered";
            // 
            // frmEngineSizeLabel
            // 
            this.frmEngineSizeLabel.AutoSize = true;
            this.frmEngineSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEngineSizeLabel.Location = new System.Drawing.Point(41, 104);
            this.frmEngineSizeLabel.Name = "frmEngineSizeLabel";
            this.frmEngineSizeLabel.Size = new System.Drawing.Size(86, 18);
            this.frmEngineSizeLabel.TabIndex = 21;
            this.frmEngineSizeLabel.Text = "Engine Size";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMakeLabel.Location = new System.Drawing.Point(41, 75);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(56, 23);
            this.frmMakeLabel.TabIndex = 20;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmVehicleRegLabel
            // 
            this.frmVehicleRegLabel.AutoSize = true;
            this.frmVehicleRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleRegLabel.Location = new System.Drawing.Point(41, 47);
            this.frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            this.frmVehicleRegLabel.Size = new System.Drawing.Size(195, 18);
            this.frmVehicleRegLabel.TabIndex = 19;
            this.frmVehicleRegLabel.Text = "Vehicle Registration Number";
            // 
            // frmDateRegistered
            // 
            this.frmDateRegistered.Location = new System.Drawing.Point(278, 131);
            this.frmDateRegistered.Name = "frmDateRegistered";
            this.frmDateRegistered.Size = new System.Drawing.Size(121, 22);
            this.frmDateRegistered.TabIndex = 29;
            this.frmDateRegistered.TextChanged += new System.EventHandler(this.frmDateRegistered_TextChanged);
            // 
            // frmEngineSize
            // 
            this.frmEngineSize.Location = new System.Drawing.Point(278, 103);
            this.frmEngineSize.Name = "frmEngineSize";
            this.frmEngineSize.Size = new System.Drawing.Size(179, 22);
            this.frmEngineSize.TabIndex = 28;
            this.frmEngineSize.TextChanged += new System.EventHandler(this.frmEngineSize_TextChanged);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(277, 75);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(247, 22);
            this.frmMake.TabIndex = 27;
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVehicleReg.Location = new System.Drawing.Point(278, 47);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.Size = new System.Drawing.Size(179, 22);
            this.frmVehicleReg.TabIndex = 26;
            this.frmVehicleReg.TextChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Checked = true;
            this.frmAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.frmAvailable.Location = new System.Drawing.Point(278, 187);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(18, 17);
            this.frmAvailable.TabIndex = 25;
            this.frmAvailable.UseVisualStyleBackColor = true;
            this.frmAvailable.CheckedChanged += new System.EventHandler(this.frmAvailable_TextChanged);
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Location = new System.Drawing.Point(278, 159);
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(145, 22);
            this.frmRentalPerDay.TabIndex = 30;
            this.frmRentalPerDay.ValueChanged += new System.EventHandler(this.frmRentalPerDay_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(35, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 48);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(221, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 48);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(404, 228);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 48);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 306);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.frmDateRegistered);
            this.Controls.Add(this.frmEngineSize);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.frmVehicleReg);
            this.Controls.Add(this.frmAvailable);
            this.Controls.Add(this.frmAvailableLabel);
            this.Controls.Add(this.frmRentalPerDayLabel);
            this.Controls.Add(this.frmDateRegisteredLabel);
            this.Controls.Add(this.frmEngineSizeLabel);
            this.Controls.Add(this.frmMakeLabel);
            this.Controls.Add(this.frmVehicleRegLabel);
            this.Name = "frmAdd";
            this.ShowIcon = false;
            this.Text = "Task A";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmAvailableLabel;
        private System.Windows.Forms.Label frmRentalPerDayLabel;
        private System.Windows.Forms.Label frmDateRegisteredLabel;
        private System.Windows.Forms.Label frmEngineSizeLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label frmVehicleRegLabel;
        private System.Windows.Forms.TextBox frmDateRegistered;
        private System.Windows.Forms.TextBox frmEngineSize;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.NumericUpDown frmRentalPerDay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}