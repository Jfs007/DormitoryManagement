namespace StuContrl
{
    partial class Dormform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dormNoInfo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.seach = new System.Windows.Forms.Button();
            this.areainfo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.advarea = new System.Windows.Forms.ComboBox();
            this.admsg = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addnum = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.addno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.upmsg = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.upbarea = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.updnum = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.upbno = new System.Windows.Forms.TextBox();
            this.updno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.updid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dormNoInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reload);
            this.groupBox1.Controls.Add(this.seach);
            this.groupBox1.Controls.Add(this.areainfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "地理区域查询";
            // 
            // dormNoInfo
            // 
            this.dormNoInfo.FormattingEnabled = true;
            this.dormNoInfo.Location = new System.Drawing.Point(238, 28);
            this.dormNoInfo.Name = "dormNoInfo";
            this.dormNoInfo.Size = new System.Drawing.Size(73, 20);
            this.dormNoInfo.TabIndex = 24;
            this.dormNoInfo.SelectedIndexChanged += new System.EventHandler(this.dormNoInfo_SelectedIndexChanged);
            this.dormNoInfo.Click += new System.EventHandler(this.dormNoInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "宿舍楼号";
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(379, 26);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(47, 23);
            this.reload.TabIndex = 22;
            this.reload.Text = "刷新";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // seach
            // 
            this.seach.Location = new System.Drawing.Point(327, 26);
            this.seach.Name = "seach";
            this.seach.Size = new System.Drawing.Size(47, 23);
            this.seach.TabIndex = 21;
            this.seach.Text = "查询";
            this.seach.UseVisualStyleBackColor = true;
            this.seach.Click += new System.EventHandler(this.seach_Click);
            // 
            // areainfo
            // 
            this.areainfo.FormattingEnabled = true;
            this.areainfo.Location = new System.Drawing.Point(87, 26);
            this.areainfo.Name = "areainfo";
            this.areainfo.Size = new System.Drawing.Size(73, 20);
            this.areainfo.TabIndex = 3;
            this.areainfo.SelectedIndexChanged += new System.EventHandler(this.areainfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "地理区域";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(12, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 199);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "地理区域";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "宿舍楼号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "宿舍号";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "床位数";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 297);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 189);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.advarea);
            this.tabPage1.Controls.Add(this.admsg);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.addnum);
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Controls.Add(this.addno);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.addid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 20);
            this.comboBox1.TabIndex = 30;
            // 
            // advarea
            // 
            this.advarea.FormattingEnabled = true;
            this.advarea.Items.AddRange(new object[] {
            "东区",
            "西区"});
            this.advarea.Location = new System.Drawing.Point(322, 17);
            this.advarea.Name = "advarea";
            this.advarea.Size = new System.Drawing.Size(74, 20);
            this.advarea.TabIndex = 29;
            this.advarea.SelectedIndexChanged += new System.EventHandler(this.advarea_SelectedIndexChanged);
            // 
            // admsg
            // 
            this.admsg.FormattingEnabled = true;
            this.admsg.ItemHeight = 12;
            this.admsg.Items.AddRange(new object[] {
            "标准间",
            "豪华间"});
            this.admsg.Location = new System.Drawing.Point(120, 106);
            this.admsg.Name = "admsg";
            this.admsg.Size = new System.Drawing.Size(120, 40);
            this.admsg.TabIndex = 28;
            this.admsg.SelectedIndexChanged += new System.EventHandler(this.admsg_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "宿舍号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addnum
            // 
            this.addnum.FormattingEnabled = true;
            this.addnum.Items.AddRange(new object[] {
            "4",
            "6"});
            this.addnum.Location = new System.Drawing.Point(120, 77);
            this.addnum.Name = "addnum";
            this.addnum.Size = new System.Drawing.Size(74, 20);
            this.addnum.TabIndex = 17;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(282, 123);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(47, 23);
            this.add.TabIndex = 23;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addno
            // 
            this.addno.Location = new System.Drawing.Point(322, 47);
            this.addno.Name = "addno";
            this.addno.Size = new System.Drawing.Size(74, 21);
            this.addno.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "床位数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "宿舍楼号";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "地理区域";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "编号";
            // 
            // addid
            // 
            this.addid.Location = new System.Drawing.Point(120, 17);
            this.addid.Name = "addid";
            this.addid.Size = new System.Drawing.Size(74, 21);
            this.addid.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.upmsg);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.upbarea);
            this.tabPage2.Controls.Add(this.delete);
            this.tabPage2.Controls.Add(this.updnum);
            this.tabPage2.Controls.Add(this.update);
            this.tabPage2.Controls.Add(this.upbno);
            this.tabPage2.Controls.Add(this.updno);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.updid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "更新记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // upmsg
            // 
            this.upmsg.FormattingEnabled = true;
            this.upmsg.ItemHeight = 12;
            this.upmsg.Items.AddRange(new object[] {
            "标准间",
            "豪华间",
            "破烂间"});
            this.upmsg.Location = new System.Drawing.Point(131, 111);
            this.upmsg.Name = "upmsg";
            this.upmsg.Size = new System.Drawing.Size(120, 40);
            this.upmsg.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "备注";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "宿舍号";
            // 
            // upbarea
            // 
            this.upbarea.Location = new System.Drawing.Point(333, 22);
            this.upbarea.Name = "upbarea";
            this.upbarea.Size = new System.Drawing.Size(74, 21);
            this.upbarea.TabIndex = 11;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(360, 128);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(47, 23);
            this.delete.TabIndex = 10;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // updnum
            // 
            this.updnum.FormattingEnabled = true;
            this.updnum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.updnum.Location = new System.Drawing.Point(131, 82);
            this.updnum.Name = "updnum";
            this.updnum.Size = new System.Drawing.Size(74, 20);
            this.updnum.TabIndex = 3;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(293, 128);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(47, 23);
            this.update.TabIndex = 9;
            this.update.Text = "更新";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // upbno
            // 
            this.upbno.Location = new System.Drawing.Point(131, 49);
            this.upbno.Name = "upbno";
            this.upbno.Size = new System.Drawing.Size(74, 21);
            this.upbno.TabIndex = 0;
            // 
            // updno
            // 
            this.updno.Location = new System.Drawing.Point(333, 52);
            this.updno.Name = "updno";
            this.updno.Size = new System.Drawing.Size(74, 21);
            this.updno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "床位数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "宿舍楼号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "地理区域";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "编号";
            // 
            // updid
            // 
            this.updid.Location = new System.Drawing.Point(131, 22);
            this.updid.Name = "updid";
            this.updid.Size = new System.Drawing.Size(74, 21);
            this.updid.TabIndex = 0;
            // 
            // Dormform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 487);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "Dormform";
            this.Text = "学生宿舍基本信息";
            this.Load += new System.EventHandler(this.Dormform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dormNoInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button seach;
        private System.Windows.Forms.ComboBox areainfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox updnum;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox upbno;
        private System.Windows.Forms.TextBox updno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox updid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox upbarea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox upmsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox addnum;
        private System.Windows.Forms.TextBox addno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox advarea;
        private System.Windows.Forms.ListBox admsg;
    }
}