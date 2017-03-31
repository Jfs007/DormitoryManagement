using DMsever;
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
    public partial class Dormform : Form
    {
        List<Build> blist = new List<Build>();
        Build build = new Build();
        Dormsever dormsever = new Dormsever();
        Dorm dorm = new Dorm();
        List<Dorm> list = new List<Dorm>();
        public Dormform()
        {
            InitializeComponent();
        }

        private void Dormform_Load(object sender, EventArgs e)
        {
            advarea.SelectedIndex = 0;
            blist = dormsever.getdisByarea(advarea.Text);
            for (int i = 0; i < blist.Count; i++)
            {

                comboBox1.Items.Add(blist[i].BuildNo);
            }
            comboBox1.SelectedIndex = 0;
            addid.Text = (dormsever.getdormcount()+1).ToString();
            list = dormsever.getdisArea();
            for(int i =0; i<list.Count; i++)
            {
                areainfo.Items.Add(list[i].Build.BuildArea);
            }
            areainfo.SelectedIndex = 0;
            list = dormsever.getdisNo();
            //MessageBox.Show("d");
            for (int i = 0; i < list.Count; i++)
            {
                dormNoInfo.Items.Add(list[i].Build.BuildNo.ToString());
            }
            dormNoInfo.SelectedIndex = 0;

        }

        private void dormNoInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dormNoInfo_Click(object sender, EventArgs e)
        {   
            
        }

        private void reload_Click(object sender, EventArgs e)
        {
            areainfo.Items.Clear();
            dormNoInfo.Items.Clear();
            list = dormsever.getdisArea();
            for (int i = 0; i < list.Count; i++)
            {
                areainfo.Items.Add(list[i].Build.BuildArea);
            }
            areainfo.SelectedIndex = 0;
            list = dormsever.getdisNo();
            //MessageBox.Show("d");
            for (int i = 0; i < list.Count; i++)
            {
                dormNoInfo.Items.Add(list[i].Build.BuildNo.ToString());
            }
            dormNoInfo.SelectedIndex = 0;
        }

        private void seach_Click(object sender, EventArgs e)
        {
            string buildAreaText = areainfo.Text;
            //MessageBox.Show(loginTypeText);
            list = dormsever.getallBybuildArea(buildAreaText);
            listView1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(list[i].DormId.ToString());
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] { list[i].Build.BuildArea, list[i].Build.BuildNo.ToString(), list[i].DormNo.ToString(),list[i].BedNum.ToString(),list[i].DormElse });
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dormid = listView1.FocusedItem.SubItems[0].Text;
            string buildarea = listView1.FocusedItem.SubItems[1].Text;
            string buildno = listView1.FocusedItem.SubItems[2].Text;
            string dormno = listView1.FocusedItem.SubItems[3].Text;
            string bednum = listView1.FocusedItem.SubItems[4].Text;
            string dormelse = listView1.FocusedItem.SubItems[5].Text;
            updid.Text = dormid;
            upbarea.Text = buildarea;
            upbno.Text = buildno;
            updno.Text = dormno;
            updnum.Text = bednum;
            upmsg.Text = dormelse;
        }

        private void update_Click(object sender, EventArgs e)
        {
           // Build build = new Build();
            dorm.Build = build;
            build.BuildArea = upbarea.Text;
            build.BuildNo =int.Parse(upbno.Text) ;
            dorm.DormNo = int.Parse(updno.Text);
            dorm.BedNum = int.Parse(updnum.Text);
            dorm.DormElse = upmsg.Text;
            int num =dormsever.update(dorm);
            if (num == 1)
            { MessageBox.Show("更新成功"); }
            else
            {
                MessageBox.Show("更新失败");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void areainfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            dorm.Build = build;
            build.BuildArea = advarea.Text;
            build.BuildNo = int.Parse(comboBox1.Text);
            dorm.DormNo = int.Parse(addno.Text);
            dorm.BedNum = int.Parse(addnum.Text);
            dorm.DormElse = admsg.Text;
            if (admsg.Text == ""&&addnum.Text=="")
            {
                MessageBox.Show("备注不能为空");
            }
            //Build build = new Build();
            
            else{
                int result = dormsever.add(dorm);
                if (result == 1)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("该寝室已存在，不需要重复添加");
                }
                }
           // dorm.DormElse = upmsg.Text;
        }

        private void advarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
           // List<Build> blist = new List<Build>();
            blist=dormsever.getdisByarea(advarea.Text);
            for (int i = 0; i < blist.Count; i++)
            {

                comboBox1.Items.Add(blist[i].BuildNo);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void admsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
