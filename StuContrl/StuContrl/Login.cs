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
    public partial class Login : Form
    {
        Manager manager = new Manager();
        Managersever managersever = new Managersever();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"\skin\MacOS.ssk";
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            string loginNoText = textBox1.Text;
            string loginPwdText = textBox2.Text;
            if (loginNoText == "" && loginPwdText == "")
            {
                MessageBox.Show("抱歉，密码或者账号不能为空");
            }
            else
            {
                manager = managersever.valida(loginNoText, loginPwdText);
                if (manager==null)
                {
                    MessageBox.Show("登录失败");
                }
                else
                {
                    this.Hide();
                    if (manager.LoginType.Equals("总务处"))
                   {
                        homeForm hf = new homeForm(manager);
                        hf.Show();

                     }
                    else
                    {
                        if (manager.LoginType.Equals("维修部"))
                        {
                            wxbpage wp = new wxbpage(manager);
                             wp.Show();
                        }
                        else
                        {
                                lghpage lgpge = new lghpage(manager);
                                lgpge.Show();
                        }
                    }                 
                    
                }      
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
