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
    public partial class repairresult : Form
    {
        Student student = new Student();
        Dormrepairsever dormrepairsever = new Dormrepairsever();
        List<DormRepair> drlist = new List<DormRepair>();
        List<Build> blist = new List<Build>();
        List<Dorm> dlist = new List<Dorm>();
        Dormreg dormreg = new Dormreg();
        DormRepair dormRepair = new DormRepair();
        public repairresult()
        {
            InitializeComponent();
        }

        private void repairresult_Load(object sender, EventArgs e)
        {
            drlist = dormrepairsever.getallrepair();
            for (int i = 0; i < drlist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(drlist[i].RepairId.ToString());
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] { drlist[i].BuildArea, drlist[i].BuildNo.ToString(), drlist[i].DormNo.ToString(), drlist[i].RepairTime, drlist[i].DormJob, drlist[i].RepairResult });
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string repairIdText = listView1.FocusedItem.SubItems[0].Text;
            string buildAreaText = listView1.FocusedItem.SubItems[1].Text;
            string buildNoText = listView1.FocusedItem.SubItems[2].Text;
            string dormNoText = listView1.FocusedItem.SubItems[3].Text;
            string repairTimeText = listView1.FocusedItem.SubItems[4].Text;
            string dormJobText = listView1.FocusedItem.SubItems[5].Text;
            string repairResultText = listView1.FocusedItem.SubItems[6].Text;

            textBox1.Text = repairIdText;
            textBox2.Text = buildNoText;
            textBox3.Text = repairTimeText;
            textBox4.Text = dormJobText;
            textBox5.Text = buildAreaText;
            textBox6.Text = dormNoText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dormRepair.RepairResult = textBox7.Text;
            dormRepair.RepairId = int.Parse(textBox1.Text);
            dormrepairsever.update(dormRepair);
            MessageBox.Show("已发布");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
