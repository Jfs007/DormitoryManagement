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
    public partial class Studormlistform : Form
    {
        Student student = new Student();
        Studentsever studentsever = new Studentsever();
        List<Student> slist = new List<Student>();
        List<Build> blist = new List<Build>();
        List<Dormreg> drlist = new List<Dormreg>();
        List<Dorm> dlist = new List<Dorm>();
        Dormreg dormreg = new Dormreg();
        Dormsever dormsever = new Dormsever();
        Dormdessever dormdessever = new Dormdessever();
        public Studormlistform()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            blist = dormdessever.getdisByarea(comboBox1.Text);
            for (int i = 0; i < blist.Count; i++)
            {


                comboBox2.Items.Add(blist[i].BuildNo);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void Studormlistform_Load(object sender, EventArgs e)
        {
            string buildAreaText = comboBox1.Text;
            //MessageBox.Show(loginTypeText);
            
            drlist = studentsever.getallstudormbyarea(buildAreaText);
            listView1.Items.Clear();
            for (int i = 0; i < drlist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(drlist[i].Student.StuNo);
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] { drlist[i].BuildArea, drlist[i].BuildNo.ToString(), drlist[i].DormNo.ToString(), drlist[i].Student.StuName, drlist[i].Student.StuSex, drlist[i].Student.StuTime, drlist[i].Student.StuDepart });
            }
            //
            comboBox1.SelectedIndex = 0;



        }

        private void button1_Click(object sender, EventArgs e)
        {    
            string buildAreaText = comboBox1.Text;
            //MessageBox.Show(loginTypeText);
            drlist = studentsever.getallstudormbyarea(buildAreaText) ;
            listView1.Items.Clear();
            for (int i = 0; i < drlist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(drlist[i].Student.StuNo);
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] {drlist[i].BuildArea,drlist[i].BuildNo.ToString(),drlist[i].DormNo.ToString(), drlist[i].Student.StuName, drlist[i].Student.StuSex, drlist[i].Student.StuTime, drlist[i].Student.StuDepart});
            }
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
    }
}
