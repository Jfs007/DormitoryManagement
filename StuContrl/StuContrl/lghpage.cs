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
    public partial class lghpage : Form
    {
        Manager manager = null;
        public lghpage(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void repairpage_Load(object sender, EventArgs e)
        {

        }

        private void 保修记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addrepair adrp = new addrepair();
            adrp.TopLevel = false;
            adrp.Parent = this;
            adrp.Show();
        }

        private void 处理意见ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desresult dsu = new desresult();
            dsu.TopLevel = false;
            dsu.Parent = this;
            dsu.Show();
        }

        private void 违规记录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dormdesform ddsf = new Dormdesform();
            ddsf.TopLevel = false;
            ddsf.Parent = this;
            ddsf.Show();
        }

        private void 违规记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            addDes adDes = new addDes();
            adDes.TopLevel = false;
            adDes.Parent = this;
            adDes.Show();
        }

        private void 管理员注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lghupdate lghup = new lghupdate(manager);
            lghup.TopLevel = false;
            lghup.Parent = this;
            lghup.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager = null;
            MessageBox.Show("将退出...");
            this.Close();
        }
    }
}
