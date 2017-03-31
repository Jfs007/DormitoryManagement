using DMdao;
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
    public partial class desresult : Form
    {
        Student student = new Student();
        Dormdessever dormdessever = new Dormdessever();
        List<DormDes> dslist = new List<DormDes>();
        List<Build> blist = new List<Build>();
        List<Dorm> dlist = new List<Dorm>();
        Dormreg dormreg = new Dormreg();
        DormDes dormDes = new DormDes();
        public desresult()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void desresult_Load(object sender, EventArgs e)
        {
            dslist=dormdessever.getalldes();
            for (int i = 0; i < dslist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dslist[i].MsgId.ToString());
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] { dslist[i].BuildArea, dslist[i].BuildNo.ToString(), dslist[i].DormNo.ToString(), dslist[i].FoulsTime, dslist[i].DormMsg ,dslist[i].DormResult});
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msgIdText = listView1.FocusedItem.SubItems[0].Text;
            string buildAreaText = listView1.FocusedItem.SubItems[1].Text;
            string buildNoText = listView1.FocusedItem.SubItems[2].Text;
            string dormNoText = listView1.FocusedItem.SubItems[3].Text;
            string foulsTimeText = listView1.FocusedItem.SubItems[4].Text;
            string dormMsgText = listView1.FocusedItem.SubItems[5].Text;
            string dormResultText = listView1.FocusedItem.SubItems[6].Text;

            textBox1.Text = msgIdText;
            textBox2.Text = buildNoText;
            textBox3.Text = foulsTimeText;
            textBox4.Text = dormMsgText;
            textBox5.Text = buildAreaText;
            textBox6.Text = dormNoText;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dormDes.DormResult = textBox7.Text;
            dormDes.MsgId = int.Parse(textBox1.Text);
            dormdessever.update(dormDes);
            MessageBox.Show("已发布");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
