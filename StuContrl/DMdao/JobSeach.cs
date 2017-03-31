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
    public class JobSeach
    {
        Student student = new Student();
        Dormreg dormreg = new Dormreg();
        Build build = new Build();
        SubInfo subinfo = new SubInfo();
        //getcon
        public SqlConnection getcon()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //查找唯一的系
        public DataSet getdisSub()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select distinct subDepart from DB_SubInfo");
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "Subtable");
            return ds;

        }
        //根据系查找专业
        public DataSet getdisProtbyDep(string subDepart)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select  subPro from DB_SubInfo where subDepart = '{0}'" ,subDepart);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "Subtable");
            return ds;

        }
        //查找地理区域所有楼号
        public DataSet getbuildNo(string buildArea)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select buildNo from DB_BuildInfo where buildArea = '{0}' ", buildArea);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "buildNotable");
            return ds;

        }
        //查找楼号所有寝室
        public DataSet getdorm(int buildNo)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select  dormNo from DB_DormInfo where buildNo = {0} ", buildNo);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "dormNotable");
            return ds;

        }
        // 查找某寝室是否有人
        public int seachpersonfromdorm(int buildNo, int dormNo)
        {
            int num = 0;
            // DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select  count(*) from DB_DormRegister where buildNo = {0} and dormNo ={1} ", buildNo,dormNo);
            // SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            //datp.Fill(ds, "dormNotable");
            num = (int)com.ExecuteScalar();
            //不存在
            if (num == 0)
            {
                return 0;
            }
            else { return 1; }
            // return ds;

        }
        //查找记录
        public int seachdorm(int buildNo , int dormNo)
        {
            int num = 0;
           // DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select  count(*) from DB_DormInfo where buildNo = {0} and dormNo = {1} ", buildNo,dormNo);
            // SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            //datp.Fill(ds, "dormNotable");
           num=(int) com.ExecuteScalar();
            //不存在
            if(num== 0)
            {
                return 0;
            }
            else { return 1; }
           // return ds;

        }
    }
}
