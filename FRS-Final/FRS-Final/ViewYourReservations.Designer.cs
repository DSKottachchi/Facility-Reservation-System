namespace FRS_Final
{
    partial class ViewYourReservations
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
            this.resGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.resGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // resGrid
            // 
            this.resGrid.AllowUserToAddRows = false;
            this.resGrid.AllowUserToDeleteRows = false;
            this.resGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resGrid.Location = new System.Drawing.Point(31, 138);
            this.resGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resGrid.Name = "resGrid";
            this.resGrid.RowTemplate.Height = 24;
            this.resGrid.Size = new System.Drawing.Size(806, 167);
            this.resGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(291, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Reservations";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblMsg.Location = new System.Drawing.Point(267, 70);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(292, 22);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "There are no reservations for today";
            this.lblMsg.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(10, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 13);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = true;
            this.btnBack.Text = "Back";
            this.btnBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnBack_LinkClicked);
            // 
            // ViewYourReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewYourReservations";
            this.Text = "ViewYourReservations";
            this.Load += new System.EventHandler(this.ViewYourReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel btnBack;
    }
}