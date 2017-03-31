namespace StuContrl
{
    partial class Sturegform
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
            this.stuNo = new System.Windows.Forms.TextBox();
            this.stuSex = new System.Windows.Forms.ComboBox();
            this.stuElse = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stupro = new System.Windows.Forms.ComboBox();
            this.stuDepart = new System.Windows.Forms.ComboBox();
            this.stuTime = new System.Windows.Forms.ComboBox();
            this.StuName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.关闭 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stuNo
            // 
            this.stuNo.Location = new System.Drawing.Point(93, 27);
            this.stuNo.Name = "stuNo";
            this.stuNo.Size = new System.Drawing.Size(100, 21);
            this.stuNo.TabIndex = 1;
            // 
            // stuSex
            // 
            this.stuSex.FormattingEnabled = true;
            this.stuSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.stuSex.Location = new System.Drawing.Point(93, 104);
            this.stuSex.Name = "stuSex";
            this.stuSex.Size = new System.Drawing.Size(62, 20);
            this.stuSex.TabIndex = 2;
            // 
            // stuElse
            // 
            this.stuElse.FormattingEnabled = true;
            this.stuElse.ItemHeight = 12;
            this.stuElse.Items.AddRange(new object[] {
            "九零后",
            "八零后"});
            this.stuElse.Location = new System.Drawing.Point(93, 263);
            this.stuElse.Name = "stuElse";
            this.stuElse.Size = new System.Drawing.Size(146, 52);
            this.stuElse.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stupro);
            this.groupBox1.Controls.Add(this.stuDepart);
            this.groupBox1.Controls.Add(this.stuElse);
            this.groupBox1.Controls.Add(this.stuSex);
            this.groupBox1.Controls.Add(this.stuTime);
            this.groupBox1.Controls.Add(this.StuName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.stuNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生基本信息";
            // 
            // stupro
            // 
            this.stupro.FormattingEnabled = true;
            this.stupro.Location = new System.Drawing.Point(93, 221);
            this.stupro.Name = "stupro";
            this.stupro.Size = new System.Drawing.Size(121, 20);
            this.stupro.TabIndex = 13;
            // 
            // stuDepart
            // 
            this.stuDepart.FormattingEnabled = true;
            this.stuDepart.Location = new System.Drawing.Point(93, 181);
            this.stuDepart.Name = "stuDepart";
            this.stuDepart.Size = new System.Drawing.Size(121, 20);
            this.stuDepart.TabIndex = 12;
            this.stuDepart.SelectedIndexChanged += new System.EventHandler(this.stuDepart_SelectedIndexChanged);
            // 
            // stuTime
            // 
            this.stuTime.FormattingEnabled = true;
            this.stuTime.Location = new System.Drawing.Point(93, 141);
            this.stuTime.Name = "stuTime";
            this.stuTime.Size = new System.Drawing.Size(87, 20);
            this.stuTime.TabIndex = 11;
            this.stuTime.SelectedIndexChanged += new System.EventHandler(this.stuTime_SelectedIndexChanged);
            // 
            // StuName
            // 
            this.StuName.Location = new System.Drawing.Point(93, 62);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(100, 21);
            this.StuName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "备注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 224);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "专业名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "所在系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "入学时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(73, 379);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "确定";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // 关闭
            // 
            this.关闭.Location = new System.Drawing.Point(195, 379);
            this.关闭.Name = "关闭";
            this.关闭.Size = new System.Drawing.Size(75, 23);
            this.关闭.TabIndex = 5;
            this.关闭.Text = "关闭";
            this.关闭.UseVisualStyleBackColor = true;
            this.关闭.Click += new System.EventHandler(this.关闭_Click);
            // 
            // Sturegform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 438);
            this.Controls.Add(this.关闭);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "Sturegform";
            this.Text = "学生基本信息登记";
            this.Load += new System.EventHandler(this.Sturegform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stuNo;
        private System.Windows.Forms.ComboBox stuSex;
        private System.Windows.Forms.ListBox stuElse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox stupro;
        private System.Windows.Forms.ComboBox stuDepart;
        private System.Windows.Forms.ComboBox stuTime;
        private System.Windows.Forms.TextBox StuName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 关闭;
    }
}