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
    public partial class dormregform : Form
    {
        Student student = new Student();
        Studentsever studentsever = new Studentsever();
        List<Student> slist = new List<Student>();
        List<Build> blist = new List<Build>();
        List<Dorm> dlist = new List<Dorm>();
        Dormreg dormreg = new Dormreg();

        public dormregform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
                //判断学生是否已录入
                //dormNo.Items.Clear();
                buildArea.Items.Clear();
                buildNo.Items.Clear();
                dormNo.Items.Clear();
                string stuNotext = listView1.FocusedItem.SubItems[0].Text;
                string stuNametext = listView1.FocusedItem.SubItems[1].Text;
                string stuSextext = listView1.FocusedItem.SubItems[2].Text;
                string stuDeparttext = listView1.FocusedItem.SubItems[3].Text;
                string stuProtext = listView1.FocusedItem.SubItems[4].Text;
                string buildAreatext = buildArea.Text;
                //判断学生是否已录入
                int num = studentsever.regstudorm(stuNotext);
                if (num == 1)
                {
                    MessageBox.Show("该同学已录入寝室", "提示");
                }
                //信息读写
                string dormNotext = dormNo.Text;
                stuNo.Text = stuNotext;
                stuName.Text = stuNametext;
                stuSex.Text = stuSextext;
                stuDepart.Text = stuDeparttext;
                stuPro.Text = stuProtext;
                blist = studentsever.getbabnBysex(stuSextext);
            //过滤重复----------------------------------
            for (int ii = 0; ii < blist.Count() - 1; ii++)
            {
                for (int j = blist.Count() - 1; j > ii; j--)
                {
                    if (blist[j].BuildArea.Equals(blist[ii].BuildArea))
                    {
                        blist[j].BuildArea="";
                    }
                }
            }
            //
            for (int i = 0; i < blist.Count; i++)
                {
                if (blist[i].BuildArea == "") { 
                  
                }
                else {buildArea.Items.Add(blist[i].BuildArea); }  
                    buildNo.Items.Add(blist[i].BuildNo);
                }

                //dormNo.SelectedIndex = 0;
                buildArea.SelectedIndex = 0;
                buildNo.SelectedIndex = 0;
                //int remindbedcount = studentsever.getsydodrmbybndn(int.Parse(buildNotext), int.Parse(dormNotext));
                //remainbed.Text = remindbedcount.ToString();
            }
        
        private void dormregform_Load(object sender, EventArgs e)
        {
            slist = studentsever.getallstudent();
            for (int i = 0; i < slist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(slist[i].StuNo.ToString());
                listView1.Items.Add(lvi);
                lvi.SubItems.AddRange(new string[] { slist[i].StuName, slist[i].StuSex.ToString(),slist[i].StuDepart.ToString(),slist[i].StuPro });
            }
          

        }

        private void buildNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buildAreatext = buildArea.Text;
            string dormNotext = dormNo.Text;
            dormNo.Items.Clear();
            string buildNotext = buildNo.Text;
            dlist = studentsever.getdormbybn(int.Parse(buildNotext));
            for (int i = 0; i < dlist.Count; i++)
            {
                dormNo.Items.Add(dlist[i].DormNo);

            }
            dormNo.SelectedIndex = 0;
        }

        private void dormNo_DropDown(object sender, EventArgs e)
        {   //dormNo.Items.Clear();
           // string buildAreatext = buildArea.Text;
            //string dormNotext = dormNo.Text;
            //dormNo.Items.Clear();
            //string buildNotext = buildNo.Text;
            //dlist = studentsever.getdormbybn(int.Parse(buildNotext));
            //for (int i = 0; i < dlist.Count; i++)
            //{
               // dormNo.Items.Add(dlist[i].DormNo);

           // }
            //dormNo.SelectedIndex = 0;
          

        }

        private void dormNo_DropDownClosed(object sender, EventArgs e)
        {
            //dormNo.Items.Clear();
       
        }

        private void dormNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            remainbed.Text = "";
            string buildAreatext = buildArea.Text;
            string dormNotext = dormNo.Text;
            string buildNotext = buildNo.Text;
            //dormNo.SelectedIndex = 0;
            if (dormNo.Text != "")
            {
                int remindbedcount = studentsever.getsydodrmbybndn(int.Parse(buildNotext), int.Parse(dormNotext));
                remainbed.Text = remindbedcount.ToString();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            dormreg.Student = stu;
            stu.StuNo = stuNo.Text;
            dormreg.BuildArea = buildArea.Text;
            dormreg.BuildNo = int.Parse(buildNo.Text);
            dormreg.DormNo = int.Parse(dormNo.Text);
            
            if(int.Parse(remainbed.Text )== 0 )
            {
                MessageBox.Show("该宿舍人已满");
            }
            else {
            if(studentsever.regstudorm(stuNo.Text)==1)
                {
                    MessageBox.Show("该学生已经录入寝室了,录入失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
            studentsever.addStuDorminfo(dormreg);
                MessageBox.Show("学生录入宿舍成功"); }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
