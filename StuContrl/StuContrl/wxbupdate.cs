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
    public partial class wxbupdate : Form
    {
        Managersever managersever = new Managersever();
        Manager manager = new Manager();
        public wxbupdate( Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void wxbupdate_Load(object sender, EventArgs e)
        {
            textBox1.Text = manager.LoginPwd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.LoginPwd =  textBox1.Text;
            managersever.update(manager);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
