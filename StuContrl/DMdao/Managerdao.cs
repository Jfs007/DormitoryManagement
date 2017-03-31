using Mypojo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMdao
{
    public class Managerdao
    {
        Manager manager = new Manager();
        public SqlConnection getcon()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //根据账号找此管理员
        public Manager byName(string name)
        {
            
            //int num = 0;
            string sqlstr = string.Format("select * from DB_ManageInfo where loginNo='{0}'", name);
            SqlConnection con = getcon();
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            //num = (int)com.ExecuteScalar();
            SqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {  
                    manager.LoginNo = (string)dataReader["loginNo"];
                    manager.LoginPwd = (string)dataReader["loginPwd"];
                    manager.LoginType = (string)dataReader["loginType"];

                }
                dataReader.Close();
            }
            else
            {
                manager = null;
            }
            con.Close();
            return manager;


        }
        //管理员注册操作
        public void bymanager(Manager manager)
        {   this.manager = manager;
            SqlConnection con = getcon();
            string sqlstr = string.Format("insert into DB_ManageInfo(loginNo,loginPwd,loginType)values('{0}','{1}','{2}')", manager.LoginNo, manager.LoginPwd, manager.LoginType);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
           
        }
        //查询所有管理员，创建dataset
        public DataSet getmanageinfo(string loginType)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_ManageInfo where loginType = '{0}' ", loginType);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "managertable");
            return ds;

        }
        //查询管理员是否已注册，规则是相同的权限管理员名字不能重名
       public int regvali( string no,string type)
        {
            string sqlstr = string.Format("select count(*) from DB_ManageInfo where loginNo='{0}' and loginType='{1}'", no,type);
            SqlConnection con = getcon();
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            int num=(int)com.ExecuteScalar();
            if (num == 0) {
            con.Close();
            return 0;
            }
            else
            {
            con.Close();
            return 1;
            }
            
        }
        //更新操作
        public void update(Manager manager)
        {
            this.manager = manager;
            SqlConnection con = getcon();
            string sqlstr = string.Format("update DB_ManageInfo set loginNo = '{0}',loginPwd = '{1}',loginType = '{2}' where loginId ='{3}'", manager.LoginNo, manager.LoginPwd, manager.LoginType,manager.LoginId);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        //删除操作
        public void delete(int id)
        {       
            SqlConnection con = getcon();
            string sqlstr = string.Format("delete from DB_ManageInfo where loginId = '{0}'",id);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

    }
}
