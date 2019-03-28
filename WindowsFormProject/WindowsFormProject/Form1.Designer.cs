namespace WindowsFormProject
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSubmit = new System.Windows.Forms.Button();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.txtOff = new System.Windows.Forms.TextBox();
            this.lblPeak = new System.Windows.Forms.Label();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInd = new System.Windows.Forms.RadioButton();
            this.btnCom = new System.Windows.Forms.RadioButton();
            this.btnRes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblKwh = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalCustomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Residential = new System.Windows.Forms.Label();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.txtIndCharge = new System.Windows.Forms.TextBox();
            this.txtComCharge = new System.Windows.Forms.TextBox();
            this.txtResCharge = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(503, 664);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 44);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(17, 371);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(351, 212);
            this.lstCustomers.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSubmit);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCharge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 253);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer";
            // 
            // txtSubmit
            // 
            this.txtSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSubmit.Location = new System.Drawing.Point(3, 215);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(326, 35);
            this.txtSubmit.TabIndex = 8;
            this.txtSubmit.Text = "Submit";
            this.txtSubmit.UseVisualStyleBackColor = true;
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(158, 94);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(163, 29);
            this.txtAccountNo.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(158, 46);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(163, 29);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Account No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // txtCharge
            // 
            this.txtCharge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCharge.Enabled = false;
            this.txtCharge.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(158, 157);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(115, 33);
            this.txtCharge.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Charge";
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.BackColor = System.Drawing.Color.Transparent;
            this.lblOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.Location = new System.Drawing.Point(71, 252);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(134, 24);
            this.lblOff.TabIndex = 72;
            this.lblOff.Text = "Off Peak Kwh";
            // 
            // txtOff
            // 
            this.txtOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOff.Location = new System.Drawing.Point(246, 252);
            this.txtOff.Name = "txtOff";
            this.txtOff.Size = new System.Drawing.Size(100, 29);
            this.txtOff.TabIndex = 71;
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.BackColor = System.Drawing.Color.Transparent;
            this.lblPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeak.Location = new System.Drawing.Point(71, 175);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(102, 24);
            this.lblPeak.TabIndex = 70;
            this.lblPeak.Text = "Peak Kwh";
            // 
            // txtPeak
            // 
            this.txtPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeak.Location = new System.Drawing.Point(246, 175);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(100, 29);
            this.txtPeak.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(213, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 35);
            this.label4.TabIndex = 68;
            this.label4.Text = "Electricity Bill Estimator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInd
            // 
            this.btnInd.AutoSize = true;
            this.btnInd.BackColor = System.Drawing.Color.Transparent;
            this.btnInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInd.Location = new System.Drawing.Point(276, 136);
            this.btnInd.Name = "btnInd";
            this.btnInd.Size = new System.Drawing.Size(92, 24);
            this.btnInd.TabIndex = 67;
            this.btnInd.TabStop = true;
            this.btnInd.Text = "Industrial";
            this.btnInd.UseVisualStyleBackColor = false;
            this.btnInd.CheckedChanged += new System.EventHandler(this.btnInd_CheckedChanged);
            // 
            // btnCom
            // 
            this.btnCom.AutoSize = true;
            this.btnCom.BackColor = System.Drawing.Color.Transparent;
            this.btnCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.Location = new System.Drawing.Point(144, 136);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(110, 24);
            this.btnCom.TabIndex = 66;
            this.btnCom.TabStop = true;
            this.btnCom.Text = "Commercial";
            this.btnCom.UseVisualStyleBackColor = false;
            this.btnCom.CheckedChanged += new System.EventHandler(this.btnCom_CheckedChanged);
            // 
            // btnRes
            // 
            this.btnRes.AutoSize = true;
            this.btnRes.BackColor = System.Drawing.Color.Transparent;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.Location = new System.Drawing.Point(15, 136);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(106, 24);
            this.btnRes.TabIndex = 65;
            this.btnRes.TabStop = true;
            this.btnRes.Text = "Residential";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.CheckedChanged += new System.EventHandler(this.btnRes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "Select Customer Type";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(276, 668);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 41);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblKwh
            // 
            this.lblKwh.AutoSize = true;
            this.lblKwh.BackColor = System.Drawing.Color.Transparent;
            this.lblKwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKwh.Location = new System.Drawing.Point(71, 213);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(50, 24);
            this.lblKwh.TabIndex = 62;
            this.lblKwh.Text = "Kwh";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(219, 290);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(127, 41);
            this.btnCalculate.TabIndex = 61;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtKwh
            // 
            this.txtKwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKwh.Location = new System.Drawing.Point(246, 210);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(100, 29);
            this.txtKwh.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalCustomer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Residential);
            this.groupBox2.Controls.Add(this.txtTotalCharge);
            this.groupBox2.Controls.Add(this.txtIndCharge);
            this.groupBox2.Controls.Add(this.txtComCharge);
            this.groupBox2.Controls.Add(this.txtResCharge);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(382, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 251);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sum of Charges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Customers";
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.Enabled = false;
            this.txtTotalCustomer.Location = new System.Drawing.Point(168, 211);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.Size = new System.Drawing.Size(104, 26);
            this.txtTotalCustomer.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total Charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Industrial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Commercial";
            // 
            // Residential
            // 
            this.Residential.AutoSize = true;
            this.Residential.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residential.Location = new System.Drawing.Point(45, 43);
            this.Residential.Name = "Residential";
            this.Residential.Size = new System.Drawing.Size(87, 16);
            this.Residential.TabIndex = 4;
            this.Residential.Text = "Residential";
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Enabled = false;
            this.txtTotalCharge.Location = new System.Drawing.Point(18, 211);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(118, 26);
            this.txtTotalCharge.TabIndex = 3;
            // 
            // txtIndCharge
            // 
            this.txtIndCharge.Enabled = false;
            this.txtIndCharge.Location = new System.Drawing.Point(113, 121);
            this.txtIndCharge.Name = "txtIndCharge";
            this.txtIndCharge.Size = new System.Drawing.Size(100, 26);
            this.txtIndCharge.TabIndex = 2;
            // 
            // txtComCharge
            // 
            this.txtComCharge.Enabled = false;
            this.txtComCharge.Location = new System.Drawing.Point(177, 66);
            this.txtComCharge.Name = "txtComCharge";
            this.txtComCharge.Size = new System.Drawing.Size(100, 26);
            this.txtComCharge.TabIndex = 1;
            // 
            // txtResCharge
            // 
            this.txtResCharge.Enabled = false;
            this.txtResCharge.Location = new System.Drawing.Point(48, 66);
            this.txtResCharge.Name = "txtResCharge";
            this.txtResCharge.Size = new System.Drawing.Size(100, 26);
            this.txtResCharge.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormProject.Properties.Resources.bulb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 737);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOff);
            this.Controls.Add(this.txtOff);
            this.Controls.Add(this.lblPeak);
            this.Controls.Add(this.txtPeak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInd);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblKwh);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtKwh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Residential";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtSubmit;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.TextBox txtOff;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton btnInd;
        private System.Windows.Forms.RadioButton btnCom;
        private System.Windows.Forms.RadioButton btnRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblKwh;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Residential;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.TextBox txtIndCharge;
        private System.Windows.Forms.TextBox txtComCharge;
        private System.Windows.Forms.TextBox txtResCharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalCustomer;
    }
}

