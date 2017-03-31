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
    public partial class Dormdesform : Form
    {
        Student student = new Student();
        Dormdessever dormdessever = new Dormdessever();
        List<DormDes> dslist = new List<DormDes>();
        List<Build> blist = new List<Build>();
        List<Dorm> dlist = new List<Dorm>();
        Dormreg dormreg = new Dormreg();
        public Dormdesform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buildAreaText = comboBox1.Text;
            string buildNoText = comboBox2.Text;
            string dormNoText = comboBox3.Text;
            //MessageBox.Show(loginTypeText);
            if (dormNoText == "")
            {  if(buildNoText == "") { 
                dslist = dormdessever.getalldesbyarea(buildAreaText);}
                else
                {
                dslist = dormdessever.getalldesbybn(int.Parse(buildNoText));
                }
            }
           
            else
            {
                dslist = dormdessever.getalldesbydn(int.Parse(buildNoText), int.Parse(dormNoText));
            }
            listView1.Items.Clear();
            for (int i = 0; i < dslist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dslist[i].MsgId.ToString());
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] { dslist[i].BuildArea, dslist[i].BuildNo.ToString(), dslist[i].DormNo.ToString(), dslist[i].FoulsTime, dslist[i].DormMsg ,dslist[i].DormResult});
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            blist = dormdessever.getdisByarea(comboBox1.Text);
            for (int i = 0; i < blist.Count; i++)
            {


                comboBox2.Items.Add(blist[i].BuildNo);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            dlist = dormdessever.getdormbybn(int.Parse(comboBox2.Text));
            for (int i = 0; i < dlist.Count; i++)
            {

                comboBox3.Items.Add(dlist[i].DormNo);
            }
            comboBox3.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Items.Clear();
            comboBox2.Items.Clear();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
