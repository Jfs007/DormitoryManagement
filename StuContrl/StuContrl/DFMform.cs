using DMsever;
using Microsoft.VisualBasic;
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
    public partial class DFMform : Form
    {
        Build build = new Build();
        Buildsever buildsever = new Buildsever();
        List<Build> list = new List<Build>();
        Manager manager = null;
        public DFMform(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DFMform_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void seach_Click(object sender, EventArgs e)
        {
            string buildAreaText = comboBox1.Text;
            //MessageBox.Show(loginTypeText);
            list = buildsever.getallBybuildArea(buildAreaText);
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(list[i].BuildId.ToString());
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] { list[i].BuildArea, list[i].BuildNo.ToString(), list[i].BuildMsg.ToString() });
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buildid = listView1.FocusedItem.SubItems[0].Text;
            string buildarea = listView1.FocusedItem.SubItems[1].Text;
            string buildno = listView1.FocusedItem.SubItems[2].Text;
            string buildmsg = listView1.FocusedItem.SubItems[3].Text;
            textBox1.Text = buildid;
            textBox2.Text = buildarea;
            textBox3.Text = buildno;
            comboBox2.Text = buildmsg;
        }

        private void update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待，功能尚未上线");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int num = buildsever.regbuildNo(int.Parse(textBox3.Text));
            if (num == 1)
            {
                build.BuildNo = int.Parse(textBox3.Text);
                buildsever.delete(build.BuildNo);
                MessageBox.Show("删除成功");
            }

        }

        private void add_Click(object sender, EventArgs e)
        {   
            build.BuildArea = textBox6.Text;
            build.BuildNo = int.Parse(textBox7.Text);
            build.BuildMsg = comboBox3.Text;
            int num = buildsever.regbuildNo(int.Parse(textBox7.Text));
            if (num == 1)
            {
                buildsever.add(build);
                MessageBox.Show("已添加完毕");
            }
            else
            {
                MessageBox.Show("楼已存在");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strname = manager.LoginNo;
            string name = string.Format("请输入管理员{0}的密码，否则禁止执行该操作", strname);
            string psd = Interaction.InputBox(name,"请输入密码","",200 ,100);
            if (psd.Equals(manager.LoginNo))
            {
                //可以执行
                MessageBox.Show("该楼层已被移除");
                buildsever.delete(int.Parse(textBox7.Text));
            }
            else
            {
                MessageBox.Show("密码错误你没权限");
            }
          
        }
    }
}

