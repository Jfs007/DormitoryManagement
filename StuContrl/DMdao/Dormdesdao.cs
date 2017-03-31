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
   public class Dormdesdao
    {
        DormRepair dormRepair = new DormRepair();
        DormDes dormDes = new DormDes();
        //getcon
        public SqlConnection getcon()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //查找寝室是否有人
        
        //根据楼号查询所有
        public DataSet getalldesbybn(int buildNo)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormDes where buildNo = {0} ", buildNo);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //请忽略
        public DataSet getalldes()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormDes  ");
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //查询所有维修记录 根据区域 
        public DataSet getalldesbyarea(string buildArea)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormDes where buildArea = '{0}' ", buildArea);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //查询所有维修记录 根据某int 类型
        public DataSet getallstudormbyint(string op, int intop)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormDes where {0} = {1} ", op, intop);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //查询所有违规记录 根据某楼某寝室
        public DataSet getallbybndn(int buildNo, int dormNo)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormDes where buildNo = {0} and dormNo = {1} ", buildNo, dormNo);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //添加信息
        public void add(DormDes dormDes)
        {
            this.dormDes = dormDes;
            SqlConnection con = getcon();
            string sqlstr = string.Format("insert into DB_DormDes(buildArea,buildNo,dormNo,foulsTime,dormMsg)values('{0}',{1},{2},'{3}','{4}')",  dormDes.BuildArea, dormDes.BuildNo, dormDes.DormNo,dormDes.FoulsTime, dormDes.DormMsg);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        //修改记录 修理情况
        public void update(DormDes dormDes)
        {
            this.dormDes = dormDes;
            SqlConnection con = getcon();
            string sqlstr = string.Format("update  DB_DormDes set dormResult = '{0}' where msgId ={1}", dormDes.DormResult, dormDes.MsgId);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

    }
}
