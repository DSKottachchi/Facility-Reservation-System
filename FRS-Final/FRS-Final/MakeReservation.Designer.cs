namespace FRS_Final
{
    partial class MakeReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtReqID = new System.Windows.Forms.TextBox();
            this.txtModuleID = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.classGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFacility = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Request ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "User ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Facility ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reservation Time";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(272, 206);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(168, 22);
            this.txtUserID.TabIndex = 8;
            // 
            // txtReqID
            // 
            this.txtReqID.Location = new System.Drawing.Point(272, 244);
            this.txtReqID.Name = "txtReqID";
            this.txtReqID.ReadOnly = true;
            this.txtReqID.Size = new System.Drawing.Size(168, 22);
            this.txtReqID.TabIndex = 9;
            // 
            // txtModuleID
            // 
            this.txtModuleID.Location = new System.Drawing.Point(272, 282);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.ReadOnly = true;
            this.txtModuleID.Size = new System.Drawing.Size(168, 22);
            this.txtModuleID.TabIndex = 10;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(272, 169);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(168, 22);
            this.txtTime.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(272, 133);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(168, 22);
            this.txtDate.TabIndex = 12;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(292, 348);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 38);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // classGrid
            // 
            this.classGrid.AllowUserToAddRows = false;
            this.classGrid.AllowUserToDeleteRows = false;
            this.classGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGrid.Location = new System.Drawing.Point(516, 133);
            this.classGrid.Name = "classGrid";
            this.classGrid.ReadOnly = true;
            this.classGrid.RowTemplate.Height = 24;
            this.classGrid.Size = new System.Drawing.Size(356, 182);
            this.classGrid.TabIndex = 14;
            this.classGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classGrid_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Classes reserved for this timeslot today";
            // 
            // txtFacility
            // 
            this.txtFacility.FormattingEnabled = true;
            this.txtFacility.Location = new System.Drawing.Point(272, 94);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(168, 24);
            this.txtFacility.TabIndex = 16;
            // 
            // MakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.txtFacility);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.classGrid);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtModuleID);
            this.Controls.Add(this.txtReqID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MakeReservation";
            this.Text = "MakeReservation";
            this.Load += new System.EventHandler(this.MakeReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtReqID;
        private System.Windows.Forms.TextBox txtModuleID;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView classGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtFacility;
    }
}