namespace NokaAdventures
{
    partial class BookingStatuses
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
            this.PageTitle = new System.Windows.Forms.Label();
            this.dgvBookingStatus = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.StatusDesciption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.BackColor = System.Drawing.Color.Transparent;
            this.PageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(171, 9);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(226, 31);
            this.PageTitle.TabIndex = 0;
            this.PageTitle.Text = "Booking Statuses";
            this.PageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvBookingStatus
            // 
            this.dgvBookingStatus.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvBookingStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusDesciption,
            this.Update,
            this.Delete});
            this.dgvBookingStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBookingStatus.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBookingStatus.Location = new System.Drawing.Point(45, 56);
            this.dgvBookingStatus.Name = "dgvBookingStatus";
            this.dgvBookingStatus.Size = new System.Drawing.Size(488, 256);
            this.dgvBookingStatus.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(429, 318);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(103, 38);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add Status";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // StatusDesciption
            // 
            this.StatusDesciption.HeaderText = "Status Desciption";
            this.StatusDesciption.Name = "StatusDesciption";
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update Status";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete Status";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // BookingStatuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(588, 391);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dgvBookingStatus);
            this.Controls.Add(this.PageTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BookingStatuses";
            this.Text = "BookingStatuses";
            this.Load += new System.EventHandler(this.BookingStatuses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.DataGridView dgvBookingStatus;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDesciption;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}