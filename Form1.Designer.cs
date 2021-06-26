
namespace ContactTracingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.fstNm = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.Label();
            this.ins4 = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactLb = new System.Windows.Forms.Label();
            this.addLb = new System.Windows.Forms.Label();
            this.mailLb = new System.Windows.Forms.Label();
            this.TempLb = new System.Windows.Forms.Label();
            this.SympLb = new System.Windows.Forms.Label();
            this.privLb = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DateLb = new System.Windows.Forms.Label();
            this.timeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(217, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(252, 27);
            this.Title.TabIndex = 0;
            this.Title.Text = "Contact Tracing Form";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // fstNm
            // 
            this.fstNm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fstNm.ForeColor = System.Drawing.Color.White;
            this.fstNm.Location = new System.Drawing.Point(143, 164);
            this.fstNm.Name = "fstNm";
            this.fstNm.Size = new System.Drawing.Size(125, 27);
            this.fstNm.TabIndex = 1;
            this.fstNm.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.note.ForeColor = System.Drawing.Color.White;
            this.note.Location = new System.Drawing.Point(12, 67);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(647, 61);
            this.note.TabIndex = 2;
            this.note.Text = resources.GetString("note.Text");
            this.note.UseCompatibleTextRendering = true;
            this.note.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ins4
            // 
            this.ins4.AutoSize = true;
            this.ins4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ins4.ForeColor = System.Drawing.Color.White;
            this.ins4.Location = new System.Drawing.Point(12, 48);
            this.ins4.Name = "ins4";
            this.ins4.Size = new System.Drawing.Size(320, 19);
            this.ins4.TabIndex = 3;
            this.ins4.Text = "Good day! Please fill up the following:\r\n";
            this.ins4.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLb.ForeColor = System.Drawing.Color.White;
            this.nameLb.Location = new System.Drawing.Point(12, 138);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(65, 19);
            this.nameLb.TabIndex = 4;
            this.nameLb.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // ContactLb
            // 
            this.ContactLb.AutoSize = true;
            this.ContactLb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactLb.ForeColor = System.Drawing.Color.White;
            this.ContactLb.Location = new System.Drawing.Point(182, 269);
            this.ContactLb.Name = "ContactLb";
            this.ContactLb.Size = new System.Drawing.Size(149, 19);
            this.ContactLb.TabIndex = 8;
            this.ContactLb.Text = "Contact Number:";
            // 
            // addLb
            // 
            this.addLb.AutoSize = true;
            this.addLb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addLb.ForeColor = System.Drawing.Color.White;
            this.addLb.Location = new System.Drawing.Point(12, 217);
            this.addLb.Name = "addLb";
            this.addLb.Size = new System.Drawing.Size(81, 19);
            this.addLb.TabIndex = 9;
            this.addLb.Text = "Address:";
            // 
            // mailLb
            // 
            this.mailLb.AutoSize = true;
            this.mailLb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mailLb.ForeColor = System.Drawing.Color.White;
            this.mailLb.Location = new System.Drawing.Point(12, 269);
            this.mailLb.Name = "mailLb";
            this.mailLb.Size = new System.Drawing.Size(58, 19);
            this.mailLb.TabIndex = 10;
            this.mailLb.Text = "Email:";
            // 
            // TempLb
            // 
            this.TempLb.AutoSize = true;
            this.TempLb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TempLb.ForeColor = System.Drawing.Color.White;
            this.TempLb.Location = new System.Drawing.Point(383, 269);
            this.TempLb.Name = "TempLb";
            this.TempLb.Size = new System.Drawing.Size(116, 19);
            this.TempLb.TabIndex = 11;
            this.TempLb.Text = "Temperature:";
            // 
            // SympLb
            // 
            this.SympLb.AutoSize = true;
            this.SympLb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SympLb.ForeColor = System.Drawing.Color.White;
            this.SympLb.Location = new System.Drawing.Point(12, 330);
            this.SympLb.Name = "SympLb";
            this.SympLb.Size = new System.Drawing.Size(99, 19);
            this.SympLb.TabIndex = 12;
            this.SympLb.Text = "Symptoms:";
            // 
            // privLb
            // 
            this.privLb.AutoSize = true;
            this.privLb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.privLb.ForeColor = System.Drawing.Color.White;
            this.privLb.Location = new System.Drawing.Point(12, 392);
            this.privLb.Name = "privLb";
            this.privLb.Size = new System.Drawing.Size(708, 97);
            this.privLb.TabIndex = 13;
            this.privLb.Text = resources.GetString("privLb.Text");
            this.privLb.UseCompatibleTextRendering = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(383, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(182, 291);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(12, 291);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(12, 239);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(647, 27);
            this.textBox6.TabIndex = 18;
            // 
            // DateLb
            // 
            this.DateLb.AutoSize = true;
            this.DateLb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLb.ForeColor = System.Drawing.Color.White;
            this.DateLb.Location = new System.Drawing.Point(291, 138);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(110, 19);
            this.DateLb.TabIndex = 19;
            this.DateLb.Text = "Date of Visit:";
            // 
            // timeLB
            // 
            this.timeLB.AutoSize = true;
            this.timeLB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLB.ForeColor = System.Drawing.Color.White;
            this.timeLB.Location = new System.Drawing.Point(501, 138);
            this.timeLB.Name = "timeLB";
            this.timeLB.Size = new System.Drawing.Size(110, 19);
            this.timeLB.TabIndex = 20;
            this.timeLB.Text = "Time of Visit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(725, 561);
            this.Controls.Add(this.timeLB);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.privLb);
            this.Controls.Add(this.SympLb);
            this.Controls.Add(this.TempLb);
            this.Controls.Add(this.mailLb);
            this.Controls.Add(this.addLb);
            this.Controls.Add(this.ContactLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.ins4);
            this.Controls.Add(this.note);
            this.Controls.Add(this.fstNm);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox fstNm;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label ins4;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ContactLb;
        private System.Windows.Forms.Label addLb;
        private System.Windows.Forms.Label mailLb;
        private System.Windows.Forms.Label TempLb;
        private System.Windows.Forms.Label SympLb;
        private System.Windows.Forms.Label privLb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.Label timeLB;
    }
}

