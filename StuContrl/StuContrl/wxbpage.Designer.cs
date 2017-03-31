namespace StuContrl
{
    partial class wxbpage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保修管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保修记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维修记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.保修管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员注册ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // 管理员注册ToolStripMenuItem
            // 
            this.管理员注册ToolStripMenuItem.Name = "管理员注册ToolStripMenuItem";
            this.管理员注册ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.管理员注册ToolStripMenuItem.Text = "密码修改";
            this.管理员注册ToolStripMenuItem.Click += new System.EventHandler(this.管理员注册ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 保修管理ToolStripMenuItem
            // 
            this.保修管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保修记录ToolStripMenuItem,
            this.维修记录ToolStripMenuItem});
            this.保修管理ToolStripMenuItem.Name = "保修管理ToolStripMenuItem";
            this.保修管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.保修管理ToolStripMenuItem.Text = "保修管理(&P)";
            // 
            // 保修记录ToolStripMenuItem
            // 
            this.保修记录ToolStripMenuItem.Name = "保修记录ToolStripMenuItem";
            this.保修记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保修记录ToolStripMenuItem.Text = "维修反馈";
            this.保修记录ToolStripMenuItem.Click += new System.EventHandler(this.保修记录ToolStripMenuItem_Click);
            // 
            // 维修记录ToolStripMenuItem
            // 
            this.维修记录ToolStripMenuItem.Name = "维修记录ToolStripMenuItem";
            this.维修记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.维修记录ToolStripMenuItem.Text = "维修记录";
            this.维修记录ToolStripMenuItem.Click += new System.EventHandler(this.维修记录ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // wxbpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 591);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "wxbpage";
            this.Text = "浙江水利水电宿舍管理系统";
            this.Load += new System.EventHandler(this.wxbpage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保修管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保修记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维修记录ToolStripMenuItem;
    }
}