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
    public partial class wxbpage : Form
    {
        Manager manager = null;
        
        public wxbpage(Manager manager)
        {  // string type = "";
            this.manager = manager;
            InitializeComponent();
        }

        private void 保修记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repairresult rpr = new repairresult();
            rpr.TopLevel = false;
            rpr.Parent = this;
            rpr.Show();
        }

        private void 维修记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dormrepairform drpf = new Dormrepairform();
            drpf.TopLevel = false;
            drpf.Parent = this;
            drpf.Show();
        }

        private void 管理员注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wxbupdate wxbup = new wxbupdate(manager);
            wxbup.TopLevel = false;
            wxbup.Parent = this;
            wxbup.Show();
        }

        private void wxbpage_Load(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager = null;
            this.Close();
        }
    }
}
