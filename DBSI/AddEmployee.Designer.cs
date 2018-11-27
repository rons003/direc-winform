namespace DBSI
{
    partial class AddEmployee
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
            this.lastname_tb = new System.Windows.Forms.TextBox();
            this.firstname_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.middlename_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contact_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.national_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adress_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // lastname_tb
            // 
            this.lastname_tb.Location = new System.Drawing.Point(116, 77);
            this.lastname_tb.Name = "lastname_tb";
            this.lastname_tb.Size = new System.Drawing.Size(147, 20);
            this.lastname_tb.TabIndex = 1;
            // 
            // firstname_tb
            // 
            this.firstname_tb.Location = new System.Drawing.Point(116, 103);
            this.firstname_tb.Name = "firstname_tb";
            this.firstname_tb.Size = new System.Drawing.Size(147, 20);
            this.firstname_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // middlename_tb
            // 
            this.middlename_tb.Location = new System.Drawing.Point(116, 129);
            this.middlename_tb.Name = "middlename_tb";
            this.middlename_tb.Size = new System.Drawing.Size(147, 20);
            this.middlename_tb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Middle Name";
            // 
            // contact_tb
            // 
            this.contact_tb.Location = new System.Drawing.Point(116, 182);
            this.contact_tb.Name = "contact_tb";
            this.contact_tb.Size = new System.Drawing.Size(147, 20);
            this.contact_tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact No.";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(116, 208);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(147, 20);
            this.email_tb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // national_tb
            // 
            this.national_tb.Location = new System.Drawing.Point(116, 289);
            this.national_tb.Name = "national_tb";
            this.national_tb.Size = new System.Drawing.Size(147, 20);
            this.national_tb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "National";
            // 
            // gender_cb
            // 
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gender_cb.Location = new System.Drawing.Point(116, 155);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(147, 21);
            this.gender_cb.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "New Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // adress_rtb
            // 
            this.adress_rtb.Location = new System.Drawing.Point(116, 237);
            this.adress_rtb.Name = "adress_rtb";
            this.adress_rtb.Size = new System.Drawing.Size(147, 46);
            this.adress_rtb.TabIndex = 18;
            this.adress_rtb.Text = "";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 392);
            this.Controls.Add(this.adress_rtb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.national_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contact_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.middlename_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstname_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastname_tb);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastname_tb;
        private System.Windows.Forms.TextBox firstname_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox middlename_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contact_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox national_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox adress_rtb;
    }
}