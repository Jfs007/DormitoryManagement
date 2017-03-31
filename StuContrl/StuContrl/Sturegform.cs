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
    public partial class Sturegform : Form
    {
        Dormsever dormsever = new Dormsever();
        Studentsever studentsever = new Studentsever();
        Dorm dorm = new Dorm();
        List<Dorm> list = new List<Dorm>();
        Student student = new Student();
        List<SubInfo> sulist = new List<SubInfo>();
        SubInfo subinfo = new SubInfo();
        public Sturegform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            stuTime.Items.Clear();
            string stime = DateTime.Now.ToString();
            stuTime.Items.Add(stime);
            student.StuNo = stuNo.Text;
            student.StuName = StuName.Text;
            student.StuSex = stuSex.Text;
            student.StuTime = stuTime.Text;
            student.StuDepart = stuDepart.Text;
            student.StuPro = stupro.Text;
            student.StuElse = stuElse.Text;
            if (stuNo.Text =="" && StuName.Text =="")
            {
                MessageBox.Show("学号和密码不能为空");
            }
         
          
            else
        {
           int num = studentsever.addstu(student);
            if(num == 1)
            {
                MessageBox.Show("学生登记成功");
            }
            else
            {
                MessageBox.Show("该同学已登记不需要再次登记");
            }
        }
        }

        private void Sturegform_Load(object sender, EventArgs e)
        {
            stuTime.Items.Clear();
            string stime = DateTime.Now.ToString();
            stuTime.Items.Add(stime);
            stuDepart.Items.Clear();
            sulist = studentsever.getdisDepart();
            for (int i = 0; i < sulist.Count; i++)
            {
                stuDepart.Items.Add(sulist[i].SubDepart);
            }
           // stuSex.SelectedIndex = 0;
            stuTime.SelectedIndex = 0;
            
            //stuPro.SelectedIndex = 0;
           

        }

        private void stuDepart_SelectedIndexChanged(object sender, EventArgs e)
        {   //stuDepart.SelectedIndex = 0;
            // stuPro.Text = "";
            string stuDepartText = stuDepart.Text.ToString();
            stupro.Items.Clear();
            sulist = studentsever.getdisProbyDep(stuDepartText);
            for (int i = 0; i < sulist.Count; i++)
            {

                stupro.Items.Add(sulist[i].SubPro);
            }
            //stupro.SelectedIndex = 0;
        }

        private void 关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stuTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
