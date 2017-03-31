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
      public class Dormdessever
    {
       // Dormrepairdao dormrepairdao = new Dormrepairdao();
        Studentdao studentdao = new Studentdao();
        Student student = new Student();
        Dormreg dormreg = new Dormreg();
        DormDes dormDes = new DormDes();
        Dormdesdao dormdesdao = new Dormdesdao();
        //DormRepair dormRepair = new DormRepair();
        JobSeach js = new JobSeach();
        DataSet ds = new DataSet();
        //记录违规
        public int add(DormDes dormDes)
        {
            int result = js.seachpersonfromdorm(dormDes.BuildNo, dormDes.DormNo);
            if (result == 0)
            {
                return 0;
            }
            else {
                dormdesdao.add(dormDes);
                return 1;
            }
        }
        //违规更新
        public void update(DormDes dormDes) {
            dormdesdao.update(dormDes);
        }

        //楼号下的所有寝室 ------------------------------
        public List<Dorm> getdormbybn(int buildNo)
        {
            List<Dorm> list = new List<Dorm>();
            ds = js.getdorm(buildNo);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Dorm dor = new Dorm();
                dor.DormNo = int.Parse(col[0].ToString());
                list.Add(dor);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //某区域下的所有楼号-------------------------------
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
        //查找所有记录
        public List<DormDes> getalldes()
        {
            List<DormDes> list = new List<DormDes>();
            ds = dormdesdao.getalldes();

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                DormDes ddes = new DormDes();
                ddes.MsgId = int.Parse(col[0].ToString());
                ddes.BuildArea = col[1].ToString();
                ddes.BuildNo = int.Parse(col[2].ToString());
                ddes.DormNo = int.Parse(col[3].ToString());
                ddes.FoulsTime = col[4].ToString();
                ddes.DormMsg = col[5].ToString();
                ddes.DormResult = col[6].ToString();
                list.Add(ddes);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //根据区域查找所有记录
        public List<DormDes> getalldesbyarea(string buildArea)
        {
            List<DormDes> list = new List<DormDes>();
            ds = dormdesdao.getalldesbyarea(buildArea);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                DormDes ddes = new DormDes();
                ddes.MsgId = int.Parse(col[0].ToString());
                ddes.BuildArea = col[1].ToString();
                ddes.BuildNo = int.Parse(col[2].ToString());
                ddes.DormNo = int.Parse(col[3].ToString());
                ddes.FoulsTime= col[4].ToString();
                ddes.DormMsg = col[5].ToString();
                ddes.DormResult = col[6].ToString();
                list.Add(ddes);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //根据楼号查找所有记录
        public List<DormDes> getalldesbybn(int buildNo)
        {
            List<DormDes> list = new List<DormDes>();
            ds = dormdesdao.getalldesbybn(buildNo);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                DormDes ddes = new DormDes();
                ddes.MsgId = int.Parse(col[0].ToString());
                ddes.BuildArea = col[1].ToString();
                ddes.BuildNo = int.Parse(col[2].ToString());
                ddes.DormNo = int.Parse(col[3].ToString());
                ddes.FoulsTime = col[4].ToString();
                ddes.DormMsg = col[5].ToString();
                ddes.DormResult = col[6].ToString();
                list.Add(ddes);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //根据某楼寝室查询查找所有记录
        public List<DormDes> getalldesbydn(int buildNo, int dormNo)
        {
            List<DormDes> list = new List<DormDes>();
            ds = dormdesdao.getallbybndn(buildNo, dormNo);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                DormDes ddes = new DormDes();
                ddes.MsgId = int.Parse(col[0].ToString());
                ddes.BuildArea = col[1].ToString();
                ddes.BuildNo = int.Parse(col[2].ToString());
                ddes.DormNo = int.Parse(col[3].ToString());
                ddes.FoulsTime = col[4].ToString();
                ddes.DormMsg = col[5].ToString();
                ddes.DormResult = col[6].ToString();
                list.Add(ddes);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
    }
}
