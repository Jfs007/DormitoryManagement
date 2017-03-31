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
    public partial class addDes : Form
    {
        Student student = new Student();
        Dormdessever dormdessever = new Dormdessever();
        List<DormRepair> drlist = new List<DormRepair>();
        List<Build> blist = new List<Build>();
        List<Dorm> dlist = new List<Dorm>();
        Dormreg dormreg = new Dormreg();
        DormDes dormDes = new DormDes();
        public addDes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            blist = dormdessever.getdisByarea(comboBox1.Text);
            for (int i = 0; i < blist.Count; i++)
            {


                comboBox2.Items.Add(blist[i].BuildNo);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            dlist = dormdessever.getdormbybn(int.Parse(comboBox2.Text));
            for (int i = 0; i < dlist.Count; i++)
            {

                comboBox3.Items.Add(dlist[i].DormNo);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            string stime = DateTime.Now.ToString();
            comboBox4.Items.Add(stime);
        }

        private void addDes_Load(object sender, EventArgs e)
        {
            string stime = DateTime.Now.ToString();
            comboBox4.Items.Add(stime);
            comboBox4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buildAreaText = comboBox1.Text;
            string buildNoText = comboBox2.Text;
            string dormNoText = comboBox3.Text;
            string repairTimeText = comboBox4.Text;
            string dormJobText = textBox1.Text;
            dormDes.BuildArea = buildAreaText;
            dormDes.BuildNo = int.Parse(buildNoText);
            dormDes.DormNo = int.Parse(dormNoText);
            dormDes.FoulsTime = repairTimeText;
            dormDes.DormMsg = dormJobText;
           
          int result =  dormdessever.add(dormDes);
            if(result == 1) {
            MessageBox.Show("维修登记完成"); }
            else
            {
                MessageBox.Show("该寝室未入住");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
