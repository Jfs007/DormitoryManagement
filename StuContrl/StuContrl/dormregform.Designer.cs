namespace StuContrl
{
    partial class dormregform
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
            this.stuNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buildNo = new System.Windows.Forms.ComboBox();
            this.dormNo = new System.Windows.Forms.ComboBox();
            this.remainbed = new System.Windows.Forms.TextBox();
            this.stuPro = new System.Windows.Forms.TextBox();
            this.stuDepart = new System.Windows.Forms.TextBox();
            this.stuSex = new System.Windows.Forms.TextBox();
            this.stuName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buildArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stuNo
            // 
            this.stuNo.Location = new System.Drawing.Point(122, 25);
            this.stuNo.Name = "stuNo";
            this.stuNo.Size = new System.Drawing.Size(100, 21);
            this.stuNo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buildNo);
            this.groupBox1.Controls.Add(this.dormNo);
            this.groupBox1.Controls.Add(this.remainbed);
            this.groupBox1.Controls.Add(this.stuPro);
            this.groupBox1.Controls.Add(this.stuDepart);
            this.groupBox1.Controls.Add(this.stuSex);
            this.groupBox1.Controls.Add(this.stuName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buildArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stuNo);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息登记";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buildNo
            // 
            this.buildNo.FormattingEnabled = true;
            this.buildNo.Location = new System.Drawing.Point(344, 56);
            this.buildNo.Name = "buildNo";
            this.buildNo.Size = new System.Drawing.Size(85, 20);
            this.buildNo.TabIndex = 20;
            this.buildNo.SelectedIndexChanged += new System.EventHandler(this.buildNo_SelectedIndexChanged);
            // 
            // dormNo
            // 
            this.dormNo.FormattingEnabled = true;
            this.dormNo.Location = new System.Drawing.Point(344, 82);
            this.dormNo.Name = "dormNo";
            this.dormNo.Size = new System.Drawing.Size(85, 20);
            this.dormNo.TabIndex = 19;
            this.dormNo.DropDown += new System.EventHandler(this.dormNo_DropDown);
            this.dormNo.SelectedIndexChanged += new System.EventHandler(this.dormNo_SelectedIndexChanged);
            this.dormNo.DropDownClosed += new System.EventHandler(this.dormNo_DropDownClosed);
            // 
            // remainbed
            // 
            this.remainbed.Location = new System.Drawing.Point(344, 113);
            this.remainbed.Name = "remainbed";
            this.remainbed.Size = new System.Drawing.Size(58, 21);
            this.remainbed.TabIndex = 18;
            // 
            // stuPro
            // 
            this.stuPro.Location = new System.Drawing.Point(122, 146);
            this.stuPro.Name = "stuPro";
            this.stuPro.Size = new System.Drawing.Size(100, 21);
            this.stuPro.TabIndex = 17;
            // 
            // stuDepart
            // 
            this.stuDepart.Location = new System.Drawing.Point(122, 117);
            this.stuDepart.Name = "stuDepart";
            this.stuDepart.Size = new System.Drawing.Size(100, 21);
            this.stuDepart.TabIndex = 16;
            // 
            // stuSex
            // 
            this.stuSex.Location = new System.Drawing.Point(122, 87);
            this.stuSex.Name = "stuSex";
            this.stuSex.Size = new System.Drawing.Size(100, 21);
            this.stuSex.TabIndex = 15;
            // 
            // stuName
            // 
            this.stuName.Location = new System.Drawing.Point(122, 55);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(100, 21);
            this.stuName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "剩余床位号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "宿舍号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "宿舍楼号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "地理区域";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "专业名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "系名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "性别";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名";
            // 
            // buildArea
            // 
            this.buildArea.FormattingEnabled = true;
            this.buildArea.Location = new System.Drawing.Point(344, 26);
            this.buildArea.Name = "buildArea";
            this.buildArea.Size = new System.Drawing.Size(85, 20);
            this.buildArea.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "学号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(275, 191);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 183);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "系名";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "专业名";
            // 
            // dormregform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 444);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "dormregform";
            this.Text = "学生入住登记";
            this.Load += new System.EventHandler(this.dormregform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox stuNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox buildArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuPro;
        private System.Windows.Forms.TextBox stuDepart;
        private System.Windows.Forms.TextBox stuSex;
        private System.Windows.Forms.TextBox stuName;
        private System.Windows.Forms.TextBox remainbed;
        private System.Windows.Forms.ComboBox buildNo;
        private System.Windows.Forms.ComboBox dormNo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}