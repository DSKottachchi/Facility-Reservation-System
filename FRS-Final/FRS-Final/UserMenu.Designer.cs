namespace FRS_Final
{
    partial class UserMenu
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
            this.lblUserMenu = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnCRequest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUserMenu
            // 
            this.lblUserMenu.AutoSize = true;
            this.lblUserMenu.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMenu.Location = new System.Drawing.Point(253, 25);
            this.lblUserMenu.Name = "lblUserMenu";
            this.lblUserMenu.Size = new System.Drawing.Size(93, 35);
            this.lblUserMenu.TabIndex = 0;
            this.lblUserMenu.Text = "Menu";
            this.lblUserMenu.Click += new System.EventHandler(this.lblUserMenu_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(201, 92);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(212, 42);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Make Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnCRequest
            // 
            this.btnCRequest.Location = new System.Drawing.Point(201, 156);
            this.btnCRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCRequest.Name = "btnCRequest";
            this.btnCRequest.Size = new System.Drawing.Size(212, 41);
            this.btnCRequest.TabIndex = 2;
            this.btnCRequest.Text = "View Pending Requests";
            this.btnCRequest.UseVisualStyleBackColor = true;
            this.btnCRequest.Click += new System.EventHandler(this.btnCRequest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Reservations For Today";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogout.Location = new System.Drawing.Point(473, 25);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(52, 17);
            this.lblLogout.TabIndex = 6;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 506);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCRequest);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblUserMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnCRequest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lblLogout;
    }
}