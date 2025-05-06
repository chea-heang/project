namespace project
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
            label1 = new Label();
            lbid = new Label();
            tbid = new TextBox();
            tbname = new TextBox();
            lbname = new Label();
            tbaddress = new TextBox();
            lbaddress = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lbsex = new Label();
            cbsex = new ComboBox();
            tbphone = new TextBox();
            lbphone = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 48);
            label1.TabIndex = 0;
            label1.Text = "Student Design";
            label1.Click += label1_Click;
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbid.Location = new Point(148, 88);
            lbid.Name = "lbid";
            lbid.Size = new Size(76, 45);
            lbid.TabIndex = 1;
            lbid.Text = "ID : ";
            // 
            // tbid
            // 
            tbid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbid.Location = new Point(230, 101);
            tbid.Name = "tbid";
            tbid.Size = new Size(193, 37);
            tbid.TabIndex = 2;
            tbid.TextChanged += textBox1_TextChanged;
            // 
            // tbname
            // 
            tbname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbname.Location = new Point(266, 177);
            tbname.Name = "tbname";
            tbname.Size = new Size(193, 37);
            tbname.TabIndex = 4;
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbname.Location = new Point(148, 164);
            lbname.Name = "lbname";
            lbname.Size = new Size(130, 45);
            lbname.TabIndex = 3;
            lbname.Text = "Name : ";
            // 
            // tbaddress
            // 
            tbaddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbaddress.Location = new Point(284, 348);
            tbaddress.Name = "tbaddress";
            tbaddress.Size = new Size(193, 37);
            tbaddress.TabIndex = 6;
            // 
            // lbaddress
            // 
            lbaddress.AutoSize = true;
            lbaddress.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbaddress.Location = new Point(132, 334);
            lbaddress.Name = "lbaddress";
            lbaddress.Size = new Size(160, 45);
            lbaddress.TabIndex = 5;
            lbaddress.Text = "Address : ";
            // 
            // lbsex
            // 
            lbsex.AutoSize = true;
            lbsex.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbsex.Location = new Point(148, 258);
            lbsex.Name = "lbsex";
            lbsex.Size = new Size(94, 45);
            lbsex.TabIndex = 7;
            lbsex.Text = "Sex : ";
            // 
            // cbsex
            // 
            cbsex.BackColor = SystemColors.ScrollBar;
            cbsex.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbsex.FormattingEnabled = true;
            cbsex.Items.AddRange(new object[] { "     F", "     M" });
            cbsex.Location = new Point(266, 271);
            cbsex.Name = "cbsex";
            cbsex.Size = new Size(182, 38);
            cbsex.TabIndex = 8;
            // 
            // tbphone
            // 
            tbphone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbphone.Location = new Point(718, 122);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(193, 37);
            tbphone.TabIndex = 10;
            // 
            // lbphone
            // 
            lbphone.AutoSize = true;
            lbphone.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbphone.Location = new Point(577, 109);
            lbphone.Name = "lbphone";
            lbphone.Size = new Size(135, 45);
            lbphone.TabIndex = 9;
            lbphone.Text = "Phone : ";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(130, 78);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(143, 49);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Design";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(130, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 49);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "MIS";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(567, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 195);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Major";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(130, 133);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(89, 49);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "BIT";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(780, 373);
            button1.Name = "button1";
            button1.Size = new Size(131, 56);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 680);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(tbphone);
            Controls.Add(lbphone);
            Controls.Add(cbsex);
            Controls.Add(lbsex);
            Controls.Add(tbaddress);
            Controls.Add(lbaddress);
            Controls.Add(tbname);
            Controls.Add(lbname);
            Controls.Add(tbid);
            Controls.Add(lbid);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbid;
        private TextBox tbid;
        private TextBox tbname;
        private Label lbname;
        private TextBox tbaddress;
        private Label lbaddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbsex;
        private ComboBox cbsex;
        private TextBox tbphone;
        private Label lbphone;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private Button button1;
    }
}
