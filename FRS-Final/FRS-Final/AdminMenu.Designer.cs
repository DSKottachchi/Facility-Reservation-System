namespace FRS_Final
{
    partial class AdminMenu
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
            this.btnViewRes = new System.Windows.Forms.Button();
            this.btnViewRqst = new System.Windows.Forms.Button();
            this.btnCRes = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Menu";
            // 
            // btnViewRes
            // 
            this.btnViewRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRes.Location = new System.Drawing.Point(101, 129);
            this.btnViewRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewRes.Name = "btnViewRes";
            this.btnViewRes.Size = new System.Drawing.Size(237, 38);
            this.btnViewRes.TabIndex = 3;
            this.btnViewRes.Text = "View Reservations";
            this.btnViewRes.UseVisualStyleBackColor = true;
            this.btnViewRes.Click += new System.EventHandler(this.btnViewRes_Click);
            // 
            // btnViewRqst
            // 
            this.btnViewRqst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRqst.Location = new System.Drawing.Point(101, 66);
            this.btnViewRqst.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewRqst.Name = "btnViewRqst";
            this.btnViewRqst.Size = new System.Drawing.Size(237, 40);
            this.btnViewRqst.TabIndex = 4;
            this.btnViewRqst.Text = "View Pending Requests";
            this.btnViewRqst.UseVisualStyleBackColor = true;
            this.btnViewRqst.Click += new System.EventHandler(this.btnViewRqst_Click);
            // 
            // btnCRes
            // 
            this.btnCRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRes.Location = new System.Drawing.Point(101, 188);
            this.btnCRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnCRes.Name = "btnCRes";
            this.btnCRes.Size = new System.Drawing.Size(237, 40);
            this.btnCRes.TabIndex = 5;
            this.btnCRes.Text = "Cancel Reservations";
            this.btnCRes.UseVisualStyleBackColor = true;
            this.btnCRes.Click += new System.EventHandler(this.btnCRes_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogout.Location = new System.Drawing.Point(352, 20);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(40, 13);
            this.lblLogout.TabIndex = 6;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 279);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnCRes);
            this.Controls.Add(this.btnViewRqst);
            this.Controls.Add(this.btnViewRes);
            this.Controls.Add(this.label1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewRes;
        private System.Windows.Forms.Button btnViewRqst;
        private System.Windows.Forms.Button btnCRes;
        private System.Windows.Forms.LinkLabel lblLogout;
    }
}