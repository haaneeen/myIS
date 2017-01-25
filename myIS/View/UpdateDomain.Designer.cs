namespace myIS
{
    partial class UpdateDomain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stret = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.partnerOfDoman = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.comboDName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.find = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "עדכון תחום או מחיקת תחום ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dCost);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stret);
            this.groupBox1.Controls.Add(this.loc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.partnerOfDoman);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 272);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "נתונים על תחום";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboId
            // 
            this.comboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(291, 64);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(121, 21);
            this.comboId.Sorted = true;
            this.comboId.TabIndex = 37;
            this.comboId.SelectedIndexChanged += new System.EventHandler(this.comboId_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(401, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 28);
            this.label10.TabIndex = 36;
            this.label10.Text = ":מספר מודעה";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dCost
            // 
            this.dCost.Location = new System.Drawing.Point(135, 183);
            this.dCost.Name = "dCost";
            this.dCost.Size = new System.Drawing.Size(117, 20);
            this.dCost.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(258, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = ": עלות תחום";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(175, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = ": רחוב ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stret
            // 
            this.stret.Location = new System.Drawing.Point(12, 141);
            this.stret.Name = "stret";
            this.stret.Size = new System.Drawing.Size(132, 20);
            this.stret.TabIndex = 31;
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(12, 99);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(132, 20);
            this.loc.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(127, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = ": עיר מתקיים בה התחום";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 28;
            // 
            // partnerOfDoman
            // 
            this.partnerOfDoman.Location = new System.Drawing.Point(291, 143);
            this.partnerOfDoman.Name = "partnerOfDoman";
            this.partnerOfDoman.Size = new System.Drawing.Size(62, 20);
            this.partnerOfDoman.TabIndex = 27;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(12, 59);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(132, 20);
            this.year.TabIndex = 26;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(359, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = ":כמות שותפים מקסמלית";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(249, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = ": בעל תחום";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(408, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = ":תיאור תחום";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(165, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 43);
            this.label5.TabIndex = 3;
            this.label5.Text = ":תאריך התחלת האירוע של המודעה ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(285, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = ":שם מודעה";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(211, 432);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 7;
            this.delete.Text = "מחק";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(118, 432);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "ביטול";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(309, 432);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 9;
            this.update.Text = "עדכן";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // comboDName
            // 
            this.comboDName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDName.FormattingEnabled = true;
            this.comboDName.Location = new System.Drawing.Point(247, 11);
            this.comboDName.Name = "comboDName";
            this.comboDName.Size = new System.Drawing.Size(121, 21);
            this.comboDName.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.find);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboDName);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel2.Location = new System.Drawing.Point(11, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 44);
            this.panel2.TabIndex = 27;
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.find.Location = new System.Drawing.Point(12, 11);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 2;
            this.find.Text = "מצא";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(397, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = ":שם מודעה";
            // 
            // UpdateDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(516, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDomain";
            this.Text = "UpdateDomain";
            this.Load += new System.EventHandler(this.UpdateDomain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stret;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox partnerOfDoman;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboDName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label13;
    }
}