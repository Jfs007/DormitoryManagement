using DMdao;
using Mypojo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMsever
{
   public class Studentsever
    {
        JobSeach js = new JobSeach();
        Studentdao studentdao = new Studentdao();
        Student student = new Student();
        Dormreg dormreg = new Dormreg();
        DataSet ds = new DataSet();
        
        //获得剩余寝室
        public int getsydodrmbybndn(int buildNo, int dormNo)
        {
           int bedcount = studentdao.dormbedcount( buildNo, dormNo);
           int stucont = studentdao.dormstucount(buildNo, dormNo);
            int remainbed = bedcount - stucont;
            return remainbed;
        }
        //查找唯一的系
        public List<SubInfo> getdisDepart()
        {
            List<SubInfo> sulist = new List<SubInfo>();

            ds = js.getdisSub();

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                SubInfo subin = new SubInfo();
                // bui.BuildArea = col[1].ToString();
                subin.SubDepart = col[0].ToString();
               sulist.Add(subin);
            }
            ds.Tables.RemoveAt(0);
            return sulist;
        }
        //查找唯一的专业根据系
        public List<SubInfo> getdisProbyDep(string SubDepart)
        {
            List<SubInfo> sulist = new List<SubInfo>();
            ds = js.getdisProtbyDep(SubDepart);
            foreach (DataRow col in ds.Tables[0].Rows)
            {
                SubInfo subin = new SubInfo();
                // bui.BuildArea = col[1].ToString();
                subin.SubPro = col[0].ToString();
                sulist.Add(subin);
            }
            ds.Tables.RemoveAt(0);
            return sulist;
        }
        //添加学生
        public int addstu(Student student)
        {   
            int num =studentdao.regvali(student.StuNo);
            if(num==0) { 
            studentdao.add(student);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //根据性别查询宿舍楼号以及区域
        public List<Build> getbabnBysex(string buildMsg)
        {
            List<Build> list = new List<Build>();
            ds = studentdao.getbuildinfo(buildMsg);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Build bui = new Build();
                bui.BuildArea =col[1].ToString();
                bui.BuildNo = int.Parse(col[2].ToString());
              
                list.Add(bui);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //查询学生录入信息
        public List<Dormreg> getallstudormbyarea(string buildArea)
        {
            List<Dormreg> list = new List<Dormreg>();
            ds = studentdao.getallstudormbyarea(buildArea);

            foreach (DataRow col in ds.Tables[0].Rows)
            {   Student stu = new Student();
                Dormreg doreg = new Dormreg();
                doreg.Student = stu;
                
                stu.StuNo = col[0].ToString();
                doreg.BuildArea = col[1].ToString();
                doreg.BuildNo = int.Parse(col[2].ToString());
                doreg.DormNo = int.Parse(col[3].ToString());
                stu.StuName = col[5].ToString();
                stu.StuSex = col[6].ToString();
                stu.StuTime = col[7].ToString();
                stu.StuDepart = col[8].ToString();
                stu.StuPro = col[9].ToString();
                stu.StuElse = col[10].ToString();
                list.Add(doreg);
            }
            ds.Tables.RemoveAt(0);                                       
            return list;
        }
        //查找所有
        public List<Student> getallstudent()
        {
            List<Student> list = new List<Student>();
            ds = studentdao.getallstu();

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Student stu = new Student();

                stu.StuNo = col[0].ToString();
                stu.StuName = col[1].ToString();
                stu.StuSex = col[2].ToString();
                stu.StuTime = col[3].ToString();
                stu.StuDepart = col[4].ToString();
                stu.StuPro = col[5].ToString();
                stu.StuElse = col[6].ToString();
                list.Add(stu);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //查找楼号的所有寝室号
        public List<Dorm> getdormbybn(int buildNo)
        {
            List<Dorm> list = new List<Dorm>();
            ds = studentdao.getdorm(buildNo);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Dorm dor = new Dorm();
                dor.DormNo =int.Parse( col[0].ToString());
               

                list.Add(dor);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //判断学生是否已录入寝室
        public int regstudorm(string stuNo)
        {
            int num =studentdao.regdormvali(stuNo);
            return num;
        }
        //学生信息录入
        public void addStuDorminfo(Dormreg dormreg)
        {
            studentdao.addStuDorminfo(dormreg);
        }
    }
}
