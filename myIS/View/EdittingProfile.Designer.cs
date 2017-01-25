namespace myIS
{
    partial class EdittingProfile
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
            this.delete = new System.Windows.Forms.Button();
            this.my_Cancel = new System.Windows.Forms.Button();
            this.my_ok = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.org = new System.Windows.Forms.ComboBox();
            this.mynote = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.perBox4 = new System.Windows.Forms.CheckBox();
            this.dustAllergy = new System.Windows.Forms.CheckBox();
            this.education = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.havePet = new System.Windows.Forms.CheckBox();
            this.smok = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.TextStreet = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.year = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.monBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dayBox1 = new System.Windows.Forms.ComboBox();
            this.genbox = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.meter = new System.Windows.Forms.ComboBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(233, 540);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 27);
            this.delete.TabIndex = 33;
            this.delete.Text = "מחק";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // my_Cancel
            // 
            this.my_Cancel.Location = new System.Drawing.Point(60, 540);
            this.my_Cancel.Name = "my_Cancel";
            this.my_Cancel.Size = new System.Drawing.Size(98, 27);
            this.my_Cancel.TabIndex = 32;
            this.my_Cancel.Text = "בטל";
            this.my_Cancel.UseVisualStyleBackColor = true;
            this.my_Cancel.Click += new System.EventHandler(this.my_Cancel_Click);
            // 
            // my_ok
            // 
            this.my_ok.Location = new System.Drawing.Point(417, 540);
            this.my_ok.Name = "my_ok";
            this.my_ok.Size = new System.Drawing.Size(98, 27);
            this.my_ok.TabIndex = 31;
            this.my_ok.Text = "עדכן";
            this.my_ok.UseVisualStyleBackColor = true;
            this.my_ok.Click += new System.EventHandler(this.my_ok_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.org);
            this.groupBox4.Controls.Add(this.mynote);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.perBox4);
            this.groupBox4.Controls.Add(this.dustAllergy);
            this.groupBox4.Controls.Add(this.education);
            this.groupBox4.Controls.Add(this.text);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.havePet);
            this.groupBox4.Controls.Add(this.smok);
            this.groupBox4.Location = new System.Drawing.Point(26, 399);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 109);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "רשימת העדפות";
            // 
            // org
            // 
            this.org.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.org.FormattingEnabled = true;
            this.org.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.org.Location = new System.Drawing.Point(129, 14);
            this.org.Name = "org";
            this.org.Size = new System.Drawing.Size(33, 21);
            this.org.TabIndex = 23;
            // 
            // mynote
            // 
            this.mynote.Location = new System.Drawing.Point(143, 82);
            this.mynote.Name = "mynote";
            this.mynote.Size = new System.Drawing.Size(202, 20);
            this.mynote.TabIndex = 29;
            this.mynote.TextChanged += new System.EventHandler(this.mynote_TextChanged);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(362, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 29);
            this.label18.TabIndex = 26;
            this.label18.Text = ": הערות";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // perBox4
            // 
            this.perBox4.AutoSize = true;
            this.perBox4.Location = new System.Drawing.Point(71, 47);
            this.perBox4.Name = "perBox4";
            this.perBox4.Size = new System.Drawing.Size(110, 17);
            this.perBox4.TabIndex = 28;
            this.perBox4.Text = "אלרגיה לבשמים";
            this.perBox4.UseVisualStyleBackColor = true;
            // 
            // dustAllergy
            // 
            this.dustAllergy.AutoSize = true;
            this.dustAllergy.Location = new System.Drawing.Point(207, 47);
            this.dustAllergy.Name = "dustAllergy";
            this.dustAllergy.Size = new System.Drawing.Size(97, 17);
            this.dustAllergy.TabIndex = 27;
            this.dustAllergy.Text = "אלרגיה לאבק";
            this.dustAllergy.UseVisualStyleBackColor = true;
            // 
            // education
            // 
            this.education.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.education.FormattingEnabled = true;
            this.education.Items.AddRange(new object[] {
            "Higher education",
            "Medium Education",
            "Low education"});
            this.education.Location = new System.Drawing.Point(310, 43);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(109, 21);
            this.education.TabIndex = 26;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(433, 43);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(50, 29);
            this.text.TabIndex = 25;
            this.text.Text = ": השכלה";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(168, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 18);
            this.label16.TabIndex = 23;
            this.label16.Text = ": שומר על סדר וארגון ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // havePet
            // 
            this.havePet.AutoSize = true;
            this.havePet.Location = new System.Drawing.Point(302, 16);
            this.havePet.Name = "havePet";
            this.havePet.Size = new System.Drawing.Size(81, 17);
            this.havePet.TabIndex = 22;
            this.havePet.Text = "חיות מחמד";
            this.havePet.UseVisualStyleBackColor = true;
            // 
            // smok
            // 
            this.smok.Location = new System.Drawing.Point(429, 18);
            this.smok.Name = "smok";
            this.smok.Size = new System.Drawing.Size(54, 17);
            this.smok.TabIndex = 0;
            this.smok.Text = "מעשן";
            this.smok.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.firBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(26, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 72);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "יצירת קשר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "-";
            // 
            // firBox
            // 
            this.firBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firBox.FormattingEnabled = true;
            this.firBox.Items.AddRange(new object[] {
            "054",
            "050",
            "052",
            "053"});
            this.firBox.Location = new System.Drawing.Point(294, 34);
            this.firBox.Name = "firBox";
            this.firBox.Size = new System.Drawing.Size(40, 21);
            this.firBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(73, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = ":דואר אלקטרוני ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(370, 35);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(86, 20);
            this.tel.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(324, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = ":טלפון נייד";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.street);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Controls.Add(this.TextStreet);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(20, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 53);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "כתובת";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(23, 26);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(132, 20);
            this.street.TabIndex = 13;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(271, 26);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(117, 20);
            this.city.TabIndex = 15;
            // 
            // TextStreet
            // 
            this.TextStreet.Location = new System.Drawing.Point(131, 26);
            this.TextStreet.Name = "TextStreet";
            this.TextStreet.Size = new System.Drawing.Size(100, 25);
            this.TextStreet.TabIndex = 13;
            this.TextStreet.Text = ":רחוב";
            this.TextStreet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(394, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = ":עיר";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "עדכון פרופיל ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.meter);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.monBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dayBox1);
            this.groupBox1.Controls.Add(this.genbox);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fn);
            this.groupBox1.Controls.Add(this.ln);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 170);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "נתונים דימוגרפיים";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(135, 32);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(39, 20);
            this.year.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(117, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "/";
            // 
            // monBox2
            // 
            this.monBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monBox2.FormattingEnabled = true;
            this.monBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monBox2.Location = new System.Drawing.Point(68, 32);
            this.monBox2.Name = "monBox2";
            this.monBox2.Size = new System.Drawing.Size(43, 21);
            this.monBox2.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "/";
            // 
            // dayBox1
            // 
            this.dayBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayBox1.FormattingEnabled = true;
            this.dayBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayBox1.Location = new System.Drawing.Point(6, 32);
            this.dayBox1.Name = "dayBox1";
            this.dayBox1.Size = new System.Drawing.Size(38, 21);
            this.dayBox1.TabIndex = 23;
            // 
            // genbox
            // 
            this.genbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genbox.FormattingEnabled = true;
            this.genbox.Items.AddRange(new object[] {
            "male",
            "female"});
            this.genbox.Location = new System.Drawing.Point(20, 138);
            this.genbox.Name = "genbox";
            this.genbox.Size = new System.Drawing.Size(121, 21);
            this.genbox.TabIndex = 23;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(271, 127);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(117, 20);
            this.pass.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(146, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = ":מין";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(394, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = ": סיסמה";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(272, 32);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(117, 20);
            this.fn.TabIndex = 10;
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(272, 81);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(117, 20);
            this.ln.TabIndex = 9;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(20, 103);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(62, 20);
            this.age.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(146, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = ":גיל";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(146, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = ":מצב משפחתי";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(169, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = ":תאריך לידה";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(394, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = ": שם משפחה";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(400, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = ":שם פרטי";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // meter
            // 
            this.meter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meter.FormattingEnabled = true;
            this.meter.Location = new System.Drawing.Point(19, 67);
            this.meter.Name = "meter";
            this.meter.Size = new System.Drawing.Size(121, 21);
            this.meter.TabIndex = 27;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(62, 37);
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Size = new System.Drawing.Size(117, 20);
            this.mail.TabIndex = 23;
            // 
            // EdittingProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 599);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.my_Cancel);
            this.Controls.Add(this.my_ok);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EdittingProfile";
            this.Text = "EdittingProfile";
            this.Load += new System.EventHandler(this.EdittingProfile_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button my_Cancel;
        private System.Windows.Forms.Button my_ok;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox org;
        private System.Windows.Forms.TextBox mynote;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox perBox4;
        private System.Windows.Forms.CheckBox dustAllergy;
        private System.Windows.Forms.ComboBox education;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox havePet;
        private System.Windows.Forms.CheckBox smok;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox firBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label TextStreet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox monBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox dayBox1;
        private System.Windows.Forms.ComboBox genbox;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox meter;
        private System.Windows.Forms.TextBox mail;
    }
}