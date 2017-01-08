namespace myIS
{
    partial class SearchForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.d_name = new System.Windows.Forms.ComboBox();
            this.loca = new System.Windows.Forms.ComboBox();
            this.stret = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mstring = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "חיפוש תחום";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "חיפוש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(132, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "שם מודעה";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(264, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "מיקום תחום";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "הוסף תחום";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "חזרה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // d_name
            // 
            this.d_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_name.FormattingEnabled = true;
            this.d_name.Location = new System.Drawing.Point(123, 129);
            this.d_name.Name = "d_name";
            this.d_name.Size = new System.Drawing.Size(121, 21);
            this.d_name.TabIndex = 10;
            // 
            // loca
            // 
            this.loca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loca.FormattingEnabled = true;
            this.loca.Location = new System.Drawing.Point(218, 204);
            this.loca.Name = "loca";
            this.loca.Size = new System.Drawing.Size(121, 21);
            this.loca.TabIndex = 11;
            // 
            // stret
            // 
            this.stret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stret.FormattingEnabled = true;
            this.stret.Location = new System.Drawing.Point(43, 204);
            this.stret.Name = "stret";
            this.stret.Size = new System.Drawing.Size(121, 21);
            this.stret.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "רחוב";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mstring
            // 
            this.mstring.Location = new System.Drawing.Point(258, 333);
            this.mstring.Name = "mstring";
            this.mstring.Size = new System.Drawing.Size(100, 20);
            this.mstring.TabIndex = 14;
            this.mstring.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 364);
            this.Controls.Add(this.mstring);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stret);
            this.Controls.Add(this.loca);
            this.Controls.Add(this.d_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox d_name;
        private System.Windows.Forms.ComboBox loca;
        private System.Windows.Forms.ComboBox stret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mstring;
    }
}