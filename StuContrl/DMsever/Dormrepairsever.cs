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
   public class Dormrepairsever
    {   Dormrepairdao dormrepairdao = new Dormrepairdao();
        Studentdao studentdao = new Studentdao();
        Student student = new Student();
        Dormreg dormreg = new Dormreg();
        DormRepair dormRepair = new DormRepair();
        JobSeach js = new JobSeach();
        DataSet ds = new DataSet();
        //添加方法
        public int add(DormRepair dormRepair)
        {
            int result = js.seachpersonfromdorm(dormRepair.BuildNo, dormRepair.DormNo);
            if(result == 0)
            {
                return 0;
            }
            else {
            dormrepairdao.add(dormRepair);
                return 1;
            }
        }
        //维修更新
        public void update(DormRepair dormRepair)
        {
            dormrepairdao.update(dormRepair);
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
        public List<DormRepair> getallrepair()
        {
            List<DormRepair> list = new List<DormRepair>();
            ds = dormrepairdao.getallrepair();

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                DormRepair dopa = new DormRepair();
                dopa.RepairId = int.Parse(col[0].ToString());
                dopa.BuildArea = col[1].ToString();
                dopa.BuildNo = int.Parse(col[2].ToString());
                dopa.DormNo = int.Parse(col[3].ToString());
                dopa.RepairTime = col[4].ToString();
                dopa.DormJob = col[5].ToString();
                dopa.RepairResult = col[6].ToString();
                list.Add(dopa);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //根据区域查找所有记录
        public List<DormRepair> getallrepairbyarea(string buildArea)
        {
            List<DormRepair> list = new List<DormRepair>();
            ds = dormrepairdao.getallrepairbyarea(buildArea) ;

            foreach (DataRow col in ds.Tables[0].Rows)
            {
               DormRepair dopa = new DormRepair();
                dopa.RepairId = int.Parse(col[0].ToString());
                dopa.BuildArea = col[1].ToString();
                dopa.BuildNo = int.Parse(col[2].ToString());
                dopa.DormNo = int.Parse(col[3].ToString());
                dopa.RepairTime = col[4].ToString();
                dopa.DormJob = col[5].ToString();
                dopa.RepairResult = col[6].ToString();
                list.Add(dopa);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //根据楼号查找所有记录
        public List<DormRepair> getallrepairbybn(int buildNo)
        {
            List<DormRepair> list = new List<DormRepair>();
            ds = dormrepairdao.getallrepairbybn(buildNo);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                DormRepair dopa = new DormRepair();
                dopa.RepairId = int.Parse(col[0].ToString());
                dopa.BuildArea = col[1].ToString();
                dopa.BuildNo = int.Parse(col[2].ToString());
                dopa.DormNo = int.Parse(col[3].ToString());
                dopa.RepairTime = col[4].ToString();
                dopa.DormJob = col[5].ToString();
                dopa.RepairResult = col[6].ToString();
                list.Add(dopa);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
        //根据某楼寝室查询查找所有记录
        public List<DormRepair> getallrepairbydn(int buildNo,int dormNo)
        {
            List<DormRepair> list = new List<DormRepair>();
            ds = dormrepairdao.getallbybndn(buildNo, dormNo);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                DormRepair dopa = new DormRepair();
                dopa.RepairId = int.Parse(col[0].ToString());
                dopa.BuildArea = col[1].ToString();
                dopa.BuildNo = int.Parse(col[2].ToString());
                dopa.DormNo = int.Parse(col[3].ToString());
                dopa.RepairTime = col[4].ToString();
                dopa.DormJob = col[5].ToString();
                dopa.RepairResult = col[6].ToString();
                list.Add(dopa);
            }
            ds.Tables.RemoveAt(0);
            return list;
        }
    }
}
