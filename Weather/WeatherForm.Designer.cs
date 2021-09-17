namespace WeatherApp
{
    partial class WeatherForm
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
            this.components = new System.ComponentModel.Container();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCBCity = new System.Windows.Forms.Label();
            this.historicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCurrentConditions = new System.Windows.Forms.Label();
            this.dgvHistoricalData = new System.Windows.Forms.DataGridView();
            this.lblHistoricalData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblCloudCover = new System.Windows.Forms.Label();
            this.lblCurrentConditionsDescrip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricalData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCity
            // 
            this.cbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(43, 45);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.Sorted = true;
            this.cbCity.TabIndex = 0;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.CbCity_SelectedIndexChanged);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            // 
            // lblCBCity
            // 
            this.lblCBCity.AutoSize = true;
            this.lblCBCity.Location = new System.Drawing.Point(13, 49);
            this.lblCBCity.Name = "lblCBCity";
            this.lblCBCity.Size = new System.Drawing.Size(24, 13);
            this.lblCBCity.TabIndex = 1;
            this.lblCBCity.Text = "City";
            // 
            // lblCurrentConditions
            // 
            this.lblCurrentConditions.AutoSize = true;
            this.lblCurrentConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentConditions.Location = new System.Drawing.Point(394, 78);
            this.lblCurrentConditions.Name = "lblCurrentConditions";
            this.lblCurrentConditions.Size = new System.Drawing.Size(59, 13);
            this.lblCurrentConditions.TabIndex = 3;
            this.lblCurrentConditions.Text = "Conditions:";
            // 
            // dgvHistoricalData
            // 
            this.dgvHistoricalData.AllowUserToAddRows = false;
            this.dgvHistoricalData.AllowUserToResizeRows = false;
            this.dgvHistoricalData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoricalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricalData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHistoricalData.Location = new System.Drawing.Point(16, 126);
            this.dgvHistoricalData.MultiSelect = false;
            this.dgvHistoricalData.Name = "dgvHistoricalData";
            this.dgvHistoricalData.ReadOnly = true;
            this.dgvHistoricalData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHistoricalData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricalData.Size = new System.Drawing.Size(304, 146);
            this.dgvHistoricalData.TabIndex = 4;
            this.dgvHistoricalData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistoricalData_CellClick);
            // 
            // lblHistoricalData
            // 
            this.lblHistoricalData.AutoSize = true;
            this.lblHistoricalData.Location = new System.Drawing.Point(13, 110);
            this.lblHistoricalData.Name = "lblHistoricalData";
            this.lblHistoricalData.Size = new System.Drawing.Size(76, 13);
            this.lblHistoricalData.TabIndex = 5;
            this.lblHistoricalData.Text = "Historical Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wind Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Humidity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cloud Cover:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(478, 101);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(0, 13);
            this.lblTemperature.TabIndex = 10;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(478, 126);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblWindSpeed.TabIndex = 11;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(478, 151);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(0, 13);
            this.lblHumidity.TabIndex = 12;
            // 
            // lblCloudCover
            // 
            this.lblCloudCover.AutoSize = true;
            this.lblCloudCover.Location = new System.Drawing.Point(478, 176);
            this.lblCloudCover.Name = "lblCloudCover";
            this.lblCloudCover.Size = new System.Drawing.Size(0, 13);
            this.lblCloudCover.TabIndex = 13;
            // 
            // lblCurrentConditionsDescrip
            // 
            this.lblCurrentConditionsDescrip.AutoSize = true;
            this.lblCurrentConditionsDescrip.Location = new System.Drawing.Point(478, 78);
            this.lblCurrentConditionsDescrip.Name = "lblCurrentConditionsDescrip";
            this.lblCurrentConditionsDescrip.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentConditionsDescrip.TabIndex = 14;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(425, 31);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 18);
            this.lblCity.TabIndex = 15;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(415, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 16;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(370, 215);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 13);
            this.lblErrors.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteRow
            // 
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(180, 22);
            this.deleteRow.Text = "Delete";
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 292);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCurrentConditionsDescrip);
            this.Controls.Add(this.lblCloudCover);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHistoricalData);
            this.Controls.Add(this.dgvHistoricalData);
            this.Controls.Add(this.lblCurrentConditions);
            this.Controls.Add(this.lblCBCity);
            this.Controls.Add(this.cbCity);
            this.Name = "WeatherForm";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricalData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Label lblCBCity;
        private System.Windows.Forms.BindingSource historicalBindingSource;
        private System.Windows.Forms.Label lblCurrentConditions;
        private System.Windows.Forms.DataGridView dgvHistoricalData;
        private System.Windows.Forms.Label lblHistoricalData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblCloudCover;
        private System.Windows.Forms.Label lblCurrentConditionsDescrip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRow;
    }
}