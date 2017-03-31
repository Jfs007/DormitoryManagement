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
    public class Dormsever
    {
        Dormdao dormdao = new Dormdao();
        Dorm dorm = new Dorm();
        DataSet ds = new DataSet();
        JobSeach js = new JobSeach();
        public int getdormcount()
        {
            return dormdao.datacount();
        }
        public int add(Dorm dorm)
        {
            int num = js.seachdorm(dorm.Build.BuildNo,dorm.DormNo);
            if(num == 0)
            {
                dormdao.add(dorm);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //得到area字段不重复
        public List<Dorm> getdisArea()
        {
            string op ="buildArea";
            List<Dorm> list = new List<Dorm>();
            ds = dormdao.getdisdata(op);
            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Dorm dor = new Dorm();
                Build build = new Build();
                dor.Build = build;
                build.BuildArea = col[0].ToString();
               
                list.Add(dor);
            }
            ds.Tables[0].Clear();
            return list;
        }
        //得到no字段不重复
        public List<Dorm> getdisNo()
        {
            string op = "buildNo";
            List<Dorm> list = new List<Dorm>();
            ds = dormdao.getdisdata(op);
            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Dorm dor = new Dorm();
                Build build = new Build();
                dor.Build = build;
                build.BuildNo =int.Parse( col[0].ToString());

                list.Add(dor);
            }
            ds.Tables[0].Clear();
            return list;
        }
        //根据area查询
        public List<Dorm> getallBybuildArea(string buildArea)
        {
            List<Dorm> list = new List<Dorm>();
            ds = dormdao.getdrombyArea(buildArea);
           
            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Dorm dor = new Dorm();
                Build build = new Build();
                dor.Build = build;
                dor.DormId = int.Parse(col[0].ToString());
                build.BuildArea = col[1].ToString();
                build.BuildNo = int.Parse(col[2].ToString());
                dor.DormNo =int.Parse (col[3].ToString());
                dor.BedNum = int.Parse(col[4].ToString());
                dor.DormElse = (col[5].ToString());
                list.Add(dor);
            }
              ds.Tables[0].Clear();
            return list;
        }
        //根据no查询
        public List<Dorm> getallBybuildNo(string buildNo)
        {
            List<Dorm> list = new List<Dorm>();
            ds = dormdao.getdrombyArea(buildNo);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Dorm dor = new Dorm();
                Build build = new Build();
                dor.Build = build;
                dor.DormId = int.Parse(col[0].ToString());
                build.BuildArea = col[1].ToString();
                build.BuildNo = int.Parse(col[2].ToString());
                dor.DormNo = int.Parse(col[3].ToString());
                dor.BedNum = int.Parse(col[4].ToString());
                dor.DormElse = (col[5].ToString());
                list.Add(dor);
            }
             ds.Tables[0].Clear();
            return list;
        }
        //更新操作
        public int update(Dorm dorm)
        {
            int num = dormdao.regvali(dorm.DormNo, dorm.Build.BuildNo);
            if (num == 0)
            {
                dormdao.update(dorm);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //某区域所有楼---------------------------
        public List<Build> getdisByarea(string buildArea)
        {
            List<Build> list = new List<Build>();
            ds = js.getbuildNo(buildArea);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Build bui = new Build();
                // bui.BuildArea = col[1].ToString();
                bui.BuildNo = int.Parse(col[0].ToString());

                list.Add(bui);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //添加操作
        /* public int add(Dorm dorm)
         {
             int num = dormdao.regvali(dorm.DormNo, dorm.Build.BuildNo);
             if (num == 0)
             {
                 dormdao.add(dorm);
                 return 1;
             }
             else
             {
                 return 0;
             }
         }*/
    }
}
