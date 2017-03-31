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
    public class Dormdao
    {    //得到con
        Dorm dorm = new Dorm();
        public SqlConnection getcon()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //教检
        public int regvali(int dormNo, int buildNo)
        {
            string sqlstr = string.Format("select count(*) from DB_DormInfo where dormNo= {0} and buildNo= {1}", dormNo, buildNo);
            SqlConnection con = getcon();
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            int num = (int)com.ExecuteScalar();
            if (num == 0)
            {
                con.Close();
                return 0;
            }
            else
            {
                con.Close();
                return 1;
            }

        }
        //查询某楼层的宿舍
        //添加根据dorm
        public void add(Dorm dorm)
        {
            this.dorm = dorm;
            SqlConnection con = getcon();
            string sqlstr = string.Format("insert into DB_DormInfo(buildArea,buildNo,dormNo,bedNum,dormElse)values('{0}',{1},{2},{3},'{4}')", dorm.Build.BuildArea, dorm.Build.BuildNo, dorm.DormNo, dorm.BedNum, dorm.DormElse);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        //更新根据dorm
        public void update(Dorm dorm)
        {
            this.dorm = dorm;
            SqlConnection con = getcon();
            string sqlstr = string.Format("update DB_DormInfo set buildArea = '{0}',buildNo = {1},dormNo = {2}, bedNum = {3}, dormElse = '{4}' where dormId ={5}", dorm.Build.BuildArea, dorm.Build.BuildNo, dorm.DormNo, dorm.BedNum, dorm.DormElse, dorm.DormId);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        //通过Area查询所有获得ds
        public DataSet getdrombyArea(string buildArea)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from  DB_DormInfo where buildArea = '{0}' ", buildArea);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "dormtable");
            return ds;

        }
        //通过宿舍楼号查询获得ds
        public DataSet getdromByNo(int buildNo)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from  DB_DormInfo where buildArea = {0} ", buildNo);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "dormtable");
            return ds;

        }
        //测试封装 有错误
        public DataSet gtest(object op)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from  DB_DormInfo where {0} = '{1}' ", op.ToString(),op);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "buildtable");
            return ds;

        }
        //查询单数据获得ds 
        public DataSet getdisdata(object op)
        {    
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr =string.Format( "select distinct {0}  from DB_DormInfo" ,op);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "dormtable");
            return ds;

        }
        //查询记录数
        public int datacount()
        {
            int count=0;
            SqlConnection con = getcon();
            con.Open();
            string strsql = "select count(*) from DB_DormInfo";
            SqlCommand com = new SqlCommand(strsql, con);
            count= (int)com.ExecuteScalar();
            con.Close();
            return count;

            
        }

    }
}
