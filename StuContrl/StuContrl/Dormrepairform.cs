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
    public partial class Dormrepairform : Form
    {
        Student student = new Student();
        Dormrepairsever dormrepairsever = new Dormrepairsever();
        List<DormRepair> drlist = new List<DormRepair>();
        List<Build> blist = new List<Build>();
        List<Dorm> dlist = new List<Dorm>();
        Dormreg dormreg = new Dormreg();
        public Dormrepairform()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            blist = dormrepairsever.getdisByarea(comboBox1.Text);
            for (int i = 0; i < blist.Count; i++)
            {
                
                
                comboBox2.Items.Add(blist[i].BuildNo);
            }

            //dormNo.SelectedIndex = 0;
           //comboBox1.SelectedIndex = 0;
           comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            dlist = dormrepairsever.getdormbybn(int.Parse(comboBox2.Text));
            for (int i = 0; i < dlist.Count; i++)
            {

                comboBox3.Items.Add(dlist[i].DormNo);
            }

            //dormNo.SelectedIndex = 0;
            //comboBox1.SelectedIndex = 0;
            //comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buildAreaText = comboBox1.Text;
            string buildNoText = comboBox2.Text;
            string dormNoText = comboBox3.Text;
            //MessageBox.Show(loginTypeText);
            if(dormNoText=="")
            {
                if (buildNoText == "") {
                drlist = dormrepairsever.getallrepairbyarea(buildAreaText);
                }
                else
                {
                drlist = dormrepairsever.getallrepairbybn(int.Parse(buildNoText));
                }
            }
            
            else
            {          
                drlist = dormrepairsever.getallrepairbydn(int.Parse(buildNoText), int.Parse(dormNoText));
            }
            listView1.Items.Clear();
            for (int i = 0; i < drlist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(drlist[i].RepairId.ToString());
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] {drlist[i].BuildArea, drlist[i].BuildNo.ToString(), drlist[i].DormNo.ToString(), drlist[i].RepairTime, drlist[i].DormJob,drlist[i].RepairResult });
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dormrepairform_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
