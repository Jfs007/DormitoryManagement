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
   public class Builddao
    {
        Build build = new Build();
        public SqlConnection getcon()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //
       
        //
        public Build byNo(int buildNo)
        {

            //int num = 0;
            string sqlstr = string.Format("select * from DB_BuildInfo where buildNo={0}", buildNo);
            SqlConnection con = getcon();
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            //num = (int)com.ExecuteScalar();
            SqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    build.BuildId = int.Parse(dataReader["buildId"].ToString());
                    build.BuildArea= dataReader["buildArea"].ToString();
                    build.BuildNo = int.Parse(dataReader["buildNo"].ToString());
                    build.BuildMsg = dataReader["buildMsg"].ToString();
                }
                dataReader.Close();
            }
            else
            {
                build = null;
            }
            con.Close();
            return build;


        }
        //add
        public void bybuild(Build build)
        {
            this.build = build;
            SqlConnection con = getcon();
            string sqlstr = string.Format("insert into DB_BuildInfo(buildArea,buildNo,buildMsg)values('{0}','{1}','{2}')", build.BuildArea, build.BuildNo, build.BuildMsg);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        //seach
        public DataSet getbuildinfo(string buildArea)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_BuildInfo where buildArea = '{0}' ", buildArea);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "buildtable");
            return ds;

        }
        //update
        public void update(Build build)
        {
            this.build= build;
            SqlConnection con = getcon();
            string sqlstr = string.Format("update DB_BuildInfo set buildArea = '{0}',buildNo = '{1}',buildMsg = '{2}' where buildId ='{3}'", build.BuildArea, build.BuildNo, build.BuildMsg, build.BuildId);
            SqlCommand com = new SqlCommand(sqlstr, con);
           // string sqlstr1= string.Format("update DB_BuildInfo set buildArea = '{0}',buildNo = '{1}',buildMsg = '{2}' where buildId ='{3}'", build.BuildArea, build.BuildNo, build.BuildMsg, build.BuildId);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        //delete
        public void delete(int no)
        {
            SqlConnection con = getcon();
            string sqlstr0 = string.Format("delete from DB_DormRegister where buildNo = {0}", no);
            //SqlCommand com = new SqlCommand(sqlstr0, con);
            string sqlstr1 = string.Format("delete from DB_DormInfo where buildNo = {0}", no);
            con.Open();
            SqlCommand com0 = new SqlCommand(sqlstr0, con);
            SqlCommand com1 = new SqlCommand(sqlstr1, con);
            string sqlstr = string.Format("delete from DB_BuildInfo where buildNo = {0}", no);
            SqlCommand com = new SqlCommand(sqlstr, con);
            com.ExecuteNonQuery();
            com1.ExecuteNonQuery();
            con.Close();
        }
    }
}
