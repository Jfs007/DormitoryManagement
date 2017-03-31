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
    public partial class RegForm : Form
    {
        Manager manager= new Manager();
        Managersever managernever = new Managersever();
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regNoText = textBox1.Text;
            string regPwdText = textBox2.Text;
            string regTypeText = comboBox1.Text;
            // MessageBox.Show(regTypeText);
            manager.LoginNo = regNoText;
            manager.LoginPwd = regPwdText;
            manager.LoginType = regTypeText;
            int num=managernever.Regmanager(manager);
            if (num == 0)
            {
                MessageBox.Show("注册失败，已存在改管理员");
            }
            else
            {
                MessageBox.Show("恭喜你，注册成功！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
