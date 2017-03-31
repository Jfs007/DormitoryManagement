using Mypojo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuContrl
{
    public partial class homeForm : Form
    {
        Manager manager = null;
        public homeForm(Manager manager)
        {
            this.manager = manager;

            InitializeComponent();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "管理员:"+"   " + this.manager.LoginNo + "登录中";
            // MessageBox.Show(manager.LoginNo);
        }

        private void 管理员注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            RegForm regform = new RegForm();
            regform.TopLevel = false;
            regform.Parent = this;
            regform.Show();
        }

        private void 管理员更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.TopLevel = false;
            update.Parent = this;
            update.Show();
        }

        private void 宿舍楼管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DFMform dfm = new DFMform(manager);
            dfm.TopLevel = false;
            dfm.Parent = this;
            dfm.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //statusStrip1.Text = "管理员" + this.manager.LoginNo + "登录中";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 宿舍管理DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dormform drm = new Dormform();
            drm.TopLevel = false;
            drm.Parent = this;
            drm.Show();
        }

        private void 信息登记EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sturegform stf = new Sturegform();
            stf.TopLevel = false;
            stf.Parent = this;
            stf.Show();
        }

        private void 入住登记ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dormregform drf = new dormregform();
            drf.TopLevel = false;
            drf.Parent = this;
            drf.Show();
        }

        private void 学生列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studormlistform sdlf = new Studormlistform();
            sdlf.TopLevel = false;
            sdlf.Parent = this;
            sdlf.Show();
        }

        private void 保修记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dormrepairform drpf = new Dormrepairform();
            drpf.TopLevel = false;
            drpf.Parent = this;
            drpf.Show();
        }

        private void 违规记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dormdesform ddsf = new Dormdesform();
            ddsf.TopLevel = false;
            ddsf.Parent = this;
            ddsf.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager = null;
            this.Close();
        }
    }
}
