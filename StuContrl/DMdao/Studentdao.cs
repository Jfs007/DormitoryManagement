
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
    public class Studentdao
    {
        Student student = new Student();
        Dormreg dormreg = new Dormreg();
        Build build = new Build();
        //getcon
        public SqlConnection getcon()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //添加
        public void add(Student student)
        {
            this.student = student;
            SqlConnection con = getcon();
            string sqlstr = string.Format("insert into DB_StuInfo(stuNo,stuName,stuSex,stuTime,stuDepart,stuPro,stuElse)values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')", student.StuNo, student.StuName, student.StuSex, student.StuTime,student.StuDepart,student.StuPro,student.StuElse);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        //查找某宿舍楼宿舍的学生数
        public int dormstucount(int buildNo, int dormNo)
        {
            int count = 0;
            SqlConnection con = getcon();
            con.Open();
            string strsql =string.Format( "select count(*) from DB_DormRegister where buildNo ={0}  and dormNo = {1}",buildNo, dormNo);
            SqlCommand com = new SqlCommand(strsql, con);
            count = (int)com.ExecuteScalar();
            con.Close();
            return count;


        }
        //查找某宿舍楼宿舍床位数从dorm表查
        public int dormbedcount(int buildNo, int dormNo)
        {
            int count = 0;
            SqlConnection con = getcon();
            con.Open();
            string strsql = string.Format("select bedNum  from DB_DormInfo where buildNo ={0}  and dormNo = {1} ", buildNo, dormNo);
            SqlCommand com = new SqlCommand(strsql, con);
             SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                count =(int) dr["bedNum"];
            }
            dr.Close();
            con.Close();
            return count;


        }

        //查找所有宿舍根据性别，从build表
        public DataSet getbuildinfo(string buildMsg)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select  * from DB_BuildInfo where buildMsg = '{0}' ", buildMsg);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "buildtable");
            return ds;

        }
        //查找楼号的所有寝室，从dorm表
        public DataSet getdorm(int buildNo )
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select  dormNo from DB_DormInfo where buildNo = {0} ",buildNo );
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "dormNotable");
            return ds;

        }
        //查找所有
        public DataSet getallstu()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_StuInfo");
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //教检学生 通过查找学号
        public int regvali(string stuNo)
        {
            string sqlstr = string.Format("select count(*) from DB_StuInfo where stuNO= '{0}'", stuNo);
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
        //教检是否已录入宿舍
        public int regdormvali(string stuNo)
        {
            string sqlstr = string.Format("select count(*) from DB_DormRegister where stuNO= '{0}'", stuNo);
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
        //查询所有学生宿舍录入信息 根据区域
        public DataSet getallstudormbyarea(string buildArea)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select * from DB_DormRegister,DB_StuInfo where DB_DormRegister.stuNo = DB_StuInfo.stuNo and buildArea = '{0}' " , buildArea);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //查询所有学生宿舍录入信息 根据某int 类型
        public DataSet getallstudormbyint(string op , int intop)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            string sqlstr = string.Format("select DB_DormRegister.* DB_StuInfo.* from DB_DormRegister,DB_StuInfo where DB_DormRegister.stuNo = DB_StuInfo.stuNo and {0} = {1} ", op ,intop);
            SqlDataAdapter datp = new SqlDataAdapter(sqlstr, con);
            datp.Fill(ds, "allstutable");
            return ds;

        }
        //添加学生宿舍录入信息
        public void addStuDorminfo(Dormreg dormreg)
        {
            this.dormreg = dormreg;
            SqlConnection con = getcon();
            string sqlstr = string.Format("insert into DB_DormRegister(stuNo,buildArea,buildNo,dormNo)values('{0}','{1}',{2},{3})", dormreg.Student.StuNo, dormreg.BuildArea,dormreg.BuildNo, dormreg.DormNo);
            SqlCommand com = new SqlCommand(sqlstr, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
