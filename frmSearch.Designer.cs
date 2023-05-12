namespace CarsDatabase
{
    partial class frmSearch
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
            this.formDataGrid = new System.Windows.Forms.DataGridView();
            this.frmRunButton = new System.Windows.Forms.Button();
            this.frmCloseButton = new System.Windows.Forms.Button();
            this.frmPanel = new System.Windows.Forms.Panel();
            this.fromFieldLabel = new System.Windows.Forms.Label();
            this.frmOperatorLabel = new System.Windows.Forms.Label();
            this.frmValueLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGrid)).BeginInit();
            this.frmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formDataGrid
            // 
            this.formDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGrid.Location = new System.Drawing.Point(32, 148);
            this.formDataGrid.Name = "formDataGrid";
            this.formDataGrid.RowHeadersWidth = 51;
            this.formDataGrid.RowTemplate.Height = 24;
            this.formDataGrid.Size = new System.Drawing.Size(581, 215);
            this.formDataGrid.TabIndex = 0;
            // 
            // frmRunButton
            // 
            this.frmRunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmRunButton.Location = new System.Drawing.Point(493, 32);
            this.frmRunButton.Name = "frmRunButton";
            this.frmRunButton.Size = new System.Drawing.Size(107, 52);
            this.frmRunButton.TabIndex = 1;
            this.frmRunButton.Text = "Run";
            this.frmRunButton.UseVisualStyleBackColor = true;
            // 
            // frmCloseButton
            // 
            this.frmCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmCloseButton.Location = new System.Drawing.Point(493, 90);
            this.frmCloseButton.Name = "frmCloseButton";
            this.frmCloseButton.Size = new System.Drawing.Size(107, 52);
            this.frmCloseButton.TabIndex = 2;
            this.frmCloseButton.Text = "Close";
            this.frmCloseButton.UseVisualStyleBackColor = true;
            // 
            // frmPanel
            // 
            this.frmPanel.Controls.Add(this.cmbOperator);
            this.frmPanel.Controls.Add(this.cmbField);
            this.frmPanel.Controls.Add(this.textBox5);
            this.frmPanel.Controls.Add(this.frmValueLabel);
            this.frmPanel.Controls.Add(this.frmOperatorLabel);
            this.frmPanel.Controls.Add(this.fromFieldLabel);
            this.frmPanel.Location = new System.Drawing.Point(32, 32);
            this.frmPanel.Name = "frmPanel";
            this.frmPanel.Size = new System.Drawing.Size(416, 103);
            this.frmPanel.TabIndex = 3;
            // 
            // fromFieldLabel
            // 
            this.fromFieldLabel.AutoSize = true;
            this.fromFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromFieldLabel.Location = new System.Drawing.Point(17, 19);
            this.fromFieldLabel.Name = "fromFieldLabel";
            this.fromFieldLabel.Size = new System.Drawing.Size(39, 18);
            this.fromFieldLabel.TabIndex = 0;
            this.fromFieldLabel.Text = "Field";
            // 
            // frmOperatorLabel
            // 
            this.frmOperatorLabel.AutoSize = true;
            this.frmOperatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOperatorLabel.Location = new System.Drawing.Point(147, 19);
            this.frmOperatorLabel.Name = "frmOperatorLabel";
            this.frmOperatorLabel.Size = new System.Drawing.Size(67, 18);
            this.frmOperatorLabel.TabIndex = 1;
            this.frmOperatorLabel.Text = "Operator";
            // 
            // frmValueLabel
            // 
            this.frmValueLabel.AutoSize = true;
            this.frmValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmValueLabel.Location = new System.Drawing.Point(255, 19);
            this.frmValueLabel.Name = "frmValueLabel";
            this.frmValueLabel.Size = new System.Drawing.Size(44, 18);
            this.frmValueLabel.TabIndex = 2;
            this.frmValueLabel.Text = "Value";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(258, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 22);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Yes";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 90;
            this.vScrollBar1.Location = new System.Drawing.Point(588, 151);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 181);
            this.vScrollBar1.TabIndex = 4;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 70;
            this.hScrollBar1.Location = new System.Drawing.Point(34, 332);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(554, 27);
            this.hScrollBar1.TabIndex = 5;
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(20, 55);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(107, 24);
            this.cmbField.TabIndex = 6;
            this.cmbField.Text = "Available";
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(150, 55);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(66, 24);
            this.cmbOperator.TabIndex = 16;
            this.cmbOperator.Text = "=";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 377);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.frmPanel);
            this.Controls.Add(this.frmCloseButton);
            this.Controls.Add(this.frmRunButton);
            this.Controls.Add(this.formDataGrid);
            this.Name = "frmSearch";
            this.ShowIcon = false;
            this.Text = "Task A Search";
            ((System.ComponentModel.ISupportInitialize)(this.formDataGrid)).EndInit();
            this.frmPanel.ResumeLayout(false);
            this.frmPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView formDataGrid;
        private System.Windows.Forms.Button frmRunButton;
        private System.Windows.Forms.Button frmCloseButton;
        private System.Windows.Forms.Panel frmPanel;
        private System.Windows.Forms.Label frmValueLabel;
        private System.Windows.Forms.Label frmOperatorLabel;
        private System.Windows.Forms.Label fromFieldLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.ComboBox cmbField;
    }
}