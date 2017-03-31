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
    public partial class Update : Form
    {
        Manager manager = new Manager();
        Managersever managersever = new Managersever();
        List<Manager> list = new List<Manager>();
        public Update()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginTypeText = comboBox1.Text;
            //MessageBox.Show(loginTypeText);
            list = managersever.getallBylogintype(loginTypeText);
            managerlv.Items.Clear();
           for(int i = 0; i < list.Count; i++) {                        
            ListViewItem lvi = new ListViewItem(list[i].LoginId.ToString());
            managerlv.Items.Add(lvi);
            lvi.SubItems.AddRange(new string[] { list[i].LoginNo, list[i].LoginPwd, list[i].LoginType });
            
            }
            //MessageBox.Show(list[1].LoginNo);
        }

        private void Update_Load(object sender, EventArgs e)
        {
           
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            string loginid = textBox2.Text;
            string loginno = textBox3.Text;
            string loginpwd = textBox4.Text;
            string logintype = comboBox2.Text;
            manager.LoginId = int.Parse(loginid);
            manager.LoginNo = loginno;
            manager.LoginPwd = loginpwd;
            manager.LoginType = logintype;
            int num = managersever.Regmanager(manager);
            if(num == 1) {
            managersever.update(manager);
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("已有该管理员了");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListView listview =new ListView()
           string loginid= managerlv.FocusedItem.SubItems[0].Text;
           string loginno = managerlv.FocusedItem.SubItems[1].Text;
           string loginpwd = managerlv.FocusedItem.SubItems[2].Text;
           string logintype = managerlv.FocusedItem.SubItems[3].Text;
           textBox2.Text = loginid;
           textBox3.Text = loginno;
           textBox4.Text = loginpwd;
           comboBox2.Text = logintype;
            // MessageBox.Show(s);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
