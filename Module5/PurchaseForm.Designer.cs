namespace Module5
{
    partial class PurchaseForm
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
            this.txtBookingReference = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbxFlightList = new System.Windows.Forms.GroupBox();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCabinClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPassportNumber = new System.Windows.Forms.Label();
            this.gbxAmenities = new System.Windows.Forms.GroupBox();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDuties = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxFlightList.SuspendLayout();
            this.gbxAmenities.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking reference:";
            // 
            // txtBookingReference
            // 
            this.txtBookingReference.Location = new System.Drawing.Point(139, 12);
            this.txtBookingReference.Name = "txtBookingReference";
            this.txtBookingReference.Size = new System.Drawing.Size(100, 23);
            this.txtBookingReference.TabIndex = 0;
            this.txtBookingReference.TextChanged += new System.EventHandler(this.txtBookingReference_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(245, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbxFlightList
            // 
            this.gbxFlightList.Controls.Add(this.cbChoose);
            this.gbxFlightList.Controls.Add(this.label2);
            this.gbxFlightList.Controls.Add(this.btnShow);
            this.gbxFlightList.Enabled = false;
            this.gbxFlightList.Location = new System.Drawing.Point(15, 45);
            this.gbxFlightList.Name = "gbxFlightList";
            this.gbxFlightList.Size = new System.Drawing.Size(592, 69);
            this.gbxFlightList.TabIndex = 2;
            this.gbxFlightList.TabStop = false;
            this.gbxFlightList.Text = "Flight list";
            // 
            // cbChoose
            // 
            this.cbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Location = new System.Drawing.Point(139, 29);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(306, 25);
            this.cbChoose.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose your flights:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(451, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(109, 25);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Amneties";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full name:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(86, 135);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(100, 17);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "[xxxxx xxxxx]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your cabin class is:";
            // 
            // labelCabinClass
            // 
            this.labelCabinClass.AutoSize = true;
            this.labelCabinClass.Location = new System.Drawing.Point(136, 172);
            this.labelCabinClass.Name = "labelCabinClass";
            this.labelCabinClass.Size = new System.Drawing.Size(100, 17);
            this.labelCabinClass.TabIndex = 0;
            this.labelCabinClass.Text = "[xxxxx xxxxx]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Passport number:";
            // 
            // labelPassportNumber
            // 
            this.labelPassportNumber.AutoSize = true;
            this.labelPassportNumber.Location = new System.Drawing.Point(353, 135);
            this.labelPassportNumber.Name = "labelPassportNumber";
            this.labelPassportNumber.Size = new System.Drawing.Size(100, 17);
            this.labelPassportNumber.TabIndex = 0;
            this.labelPassportNumber.Text = "[xxxxx xxxxx]";
            // 
            // gbxAmenities
            // 
            this.gbxAmenities.Controls.Add(this.clb);
            this.gbxAmenities.Controls.Add(this.label8);
            this.gbxAmenities.Enabled = false;
            this.gbxAmenities.Location = new System.Drawing.Point(15, 213);
            this.gbxAmenities.Name = "gbxAmenities";
            this.gbxAmenities.Size = new System.Drawing.Size(592, 137);
            this.gbxAmenities.TabIndex = 3;
            this.gbxAmenities.TabStop = false;
            this.gbxAmenities.Text = "AMONIC Airlines Amenities";
            // 
            // clb
            // 
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(9, 19);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(577, 112);
            this.clb.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Note: You cannot uncheck free item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Items selected:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Duties and taxes:";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(139, 363);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(40, 17);
            this.labelItems.TabIndex = 0;
            this.labelItems.Text = "[$xx]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total payable:";
            // 
            // labelDuties
            // 
            this.labelDuties.AutoSize = true;
            this.labelDuties.Location = new System.Drawing.Point(139, 391);
            this.labelDuties.Name = "labelDuties";
            this.labelDuties.Size = new System.Drawing.Size(40, 17);
            this.labelDuties.TabIndex = 0;
            this.labelDuties.Text = "[$xx]";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(139, 417);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 17);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "[$xx]";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(436, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save and Confirm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(436, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 453);
            this.Controls.Add(this.gbxAmenities);
            this.Controls.Add(this.gbxFlightList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBookingReference);
            this.Controls.Add(this.labelPassportNumber);
            this.Controls.Add(this.labelCabinClass);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDuties);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PurchaseForm";
            this.Text = "Purchase Amneties";
            this.gbxFlightList.ResumeLayout(false);
            this.gbxFlightList.PerformLayout();
            this.gbxAmenities.ResumeLayout(false);
            this.gbxAmenities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingReference;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbxFlightList;
        private System.Windows.Forms.ComboBox cbChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCabinClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPassportNumber;
        private System.Windows.Forms.GroupBox gbxAmenities;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelDuties;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.Label label8;
    }
}

