namespace FRS_Final
{
    partial class MakeRequest
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.lbltest = new System.Windows.Forms.Label();
            this.txtFacilityID = new System.Windows.Forms.ComboBox();
            this.txtModuleID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Required FacilityID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Required Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Required Timeslot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Module ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(381, 76);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(247, 22);
            this.txtUserID.TabIndex = 8;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(381, 194);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(247, 22);
            this.txtDate.TabIndex = 15;
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "8:00:00 AM-10:00:00 AM",
            "10:15:00 AM-12:15:00 PM",
            "1:15:00 PM-3:15:00 PM",
            "3:30:00 PM-5:30:00 PM"});
            this.cmbTime.Location = new System.Drawing.Point(381, 236);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(247, 24);
            this.cmbTime.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(12, 25);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(47, 20);
            this.lblBack.TabIndex = 18;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(711, 107);
            this.lbltest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(46, 17);
            this.lbltest.TabIndex = 19;
            this.lbltest.Text = "label9";
            // 
            // txtFacilityID
            // 
            this.txtFacilityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFacilityID.FormattingEnabled = true;
            this.txtFacilityID.Location = new System.Drawing.Point(381, 153);
            this.txtFacilityID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFacilityID.Name = "txtFacilityID";
            this.txtFacilityID.Size = new System.Drawing.Size(247, 24);
            this.txtFacilityID.TabIndex = 20;
            this.txtFacilityID.SelectedIndexChanged += new System.EventHandler(this.txtFacilityType_SelectedIndexChanged);
            // 
            // txtModuleID
            // 
            this.txtModuleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtModuleID.FormattingEnabled = true;
            this.txtModuleID.Location = new System.Drawing.Point(381, 113);
            this.txtModuleID.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(247, 24);
            this.txtModuleID.TabIndex = 21;
            // 
            // MakeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 376);
            this.Controls.Add(this.txtModuleID);
            this.Controls.Add(this.txtFacilityID);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MakeRequest";
            this.Text = "MakeRequest";
            this.Load += new System.EventHandler(this.MakeRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.ComboBox txtFacilityID;
        private System.Windows.Forms.ComboBox txtModuleID;
    }
}