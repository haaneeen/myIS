namespace myIS
{
    partial class Add_Domain
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
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "הוספת  תחום חדש ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.max);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "נתונים דימוגרפיים";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(23, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(117, 20);
            this.name.TabIndex = 12;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(309, 27);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(117, 20);
            this.id.TabIndex = 11;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(309, 64);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(117, 20);
            this.desc.TabIndex = 10;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(23, 67);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(117, 20);
            this.num.TabIndex = 9;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(23, 102);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 20);
            this.date.TabIndex = 8;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(287, 101);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(117, 20);
            this.max.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(146, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = ":תאריך";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(410, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = ":מספר משתתפים מקסמלי";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(146, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = ":שם תחום";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(146, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = ": מספר משתתפים";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(434, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = ":תיאור תחום";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(432, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = ":מספר תחום";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(118, 330);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 30);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "בטל";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(294, 330);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(97, 30);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "הוסף";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Add_Domain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 396);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Add_Domain";
            this.Text = "Add_Domain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Ok;
    }
}