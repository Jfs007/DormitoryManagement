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
    
    public class Dormrepairdao
    {
     DormRepair dormRepair = new DormRepair();
        //getcon
        public SqlConnection getcon()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //根据楼号查询所有
        public DataSet getallrepairbybn(int buildNo)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormRepair where buildNo = {0} ", buildNo);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //查找所有维修记录
        public DataSet getallrepair()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormRepair  ");
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allreptable");
            return ds;

        }
        //查询所有维修记录 根据区域 
        public DataSet getallrepairbyarea(string buildArea)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormRepair where buildArea = '{0}' ", buildArea);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //查询所有维修记录 根据某int 类型
        public DataSet getallstudormbyint(string op, int intop)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormRepair where {0} = {1} ", op, intop);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //查询所有维修记录 根据某楼某寝室
        public DataSet getallbybndn(int buildNo, int dormNo)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormRepair where buildNo = {0} and dormNo = {1} ", buildNo, dormNo);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //添加信息
        public void add(DormRepair dormRepair)
        {
            this.dormRepair = dormRepair;
            SqlConnection con = getcon();
            string sqlstr = string.Format("insert into DB_DormRepair(buildArea,buildNo,dormNo,repairTime,dormJob)values('{0}',{1},{2},'{3}','{4}')",dormRepair.BuildArea,dormRepair.BuildNo,dormRepair.DormNo,dormRepair.RepairTime,dormRepair.DormJob);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        //修改记录 修理情况
        public void update(DormRepair dormRepair)
        {
            this.dormRepair = dormRepair;
            SqlConnection con = getcon();
            string sqlstr = string.Format("update DB_DormRepair set repairResult = '{0}' where repairId ={1}",dormRepair.RepairResult,dormRepair.RepairId);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        //
    }
}
