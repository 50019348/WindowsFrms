
namespace BookTaxi
{
    partial class frmMainMenu
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
            this.lblBookingNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblEndLocation = new System.Windows.Forms.Label();
            this.txtBookingNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.txtEndLocation = new System.Windows.Forms.TextBox();
            this.lstAllBookings = new System.Windows.Forms.ListBox();
            this.lblAllBookings = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookingNumber
            // 
            this.lblBookingNumber.AutoSize = true;
            this.lblBookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNumber.Location = new System.Drawing.Point(59, 41);
            this.lblBookingNumber.Name = "lblBookingNumber";
            this.lblBookingNumber.Size = new System.Drawing.Size(146, 20);
            this.lblBookingNumber.TabIndex = 0;
            this.lblBookingNumber.Text = "Booking Number:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(59, 91);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(142, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartLocation.Location = new System.Drawing.Point(60, 163);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(128, 20);
            this.lblStartLocation.TabIndex = 2;
            this.lblStartLocation.Text = "Start Location:";
            // 
            // lblEndLocation
            // 
            this.lblEndLocation.AutoSize = true;
            this.lblEndLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndLocation.Location = new System.Drawing.Point(59, 225);
            this.lblEndLocation.Name = "lblEndLocation";
            this.lblEndLocation.Size = new System.Drawing.Size(120, 20);
            this.lblEndLocation.TabIndex = 3;
            this.lblEndLocation.Text = "End Location:";
            // 
            // txtBookingNumber
            // 
            this.txtBookingNumber.Location = new System.Drawing.Point(62, 66);
            this.txtBookingNumber.Name = "txtBookingNumber";
            this.txtBookingNumber.Size = new System.Drawing.Size(138, 20);
            this.txtBookingNumber.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(62, 119);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(137, 20);
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(62, 185);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(136, 20);
            this.txtStartLocation.TabIndex = 6;
            // 
            // txtEndLocation
            // 
            this.txtEndLocation.Location = new System.Drawing.Point(62, 252);
            this.txtEndLocation.Name = "txtEndLocation";
            this.txtEndLocation.Size = new System.Drawing.Size(135, 20);
            this.txtEndLocation.TabIndex = 7;
            // 
            // lstAllBookings
            // 
            this.lstAllBookings.FormattingEnabled = true;
            this.lstAllBookings.Location = new System.Drawing.Point(428, 69);
            this.lstAllBookings.Name = "lstAllBookings";
            this.lstAllBookings.Size = new System.Drawing.Size(334, 329);
            this.lstAllBookings.TabIndex = 8;
            // 
            // lblAllBookings
            // 
            this.lblAllBookings.AutoSize = true;
            this.lblAllBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBookings.Location = new System.Drawing.Point(430, 41);
            this.lblAllBookings.Name = "lblAllBookings";
            this.lblAllBookings.Size = new System.Drawing.Size(108, 20);
            this.lblAllBookings.TabIndex = 9;
            this.lblAllBookings.Text = "All Bookings";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(51, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 38);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(51, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(428, 402);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(333, 33);
            this.btnViewAll.TabIndex = 13;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAllBookings);
            this.Controls.Add(this.lstAllBookings);
            this.Controls.Add(this.txtEndLocation);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtBookingNumber);
            this.Controls.Add(this.lblEndLocation);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblBookingNumber);
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblEndLocation;
        private System.Windows.Forms.TextBox txtBookingNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.TextBox txtEndLocation;
        private System.Windows.Forms.ListBox lstAllBookings;
        private System.Windows.Forms.Label lblAllBookings;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewAll;
    }
}

