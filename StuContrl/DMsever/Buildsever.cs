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
    public class Buildsever
    {
        Build build = new Build();
        Builddao builddao = new Builddao();
        DataSet ds = new DataSet();
        //查询
        public List<Build> getallBybuildArea(string buildArea)
        {
            List<Build> list = new List<Build>();
            ds = builddao.getbuildinfo(buildArea);

            foreach (DataRow col in ds.Tables[0].Rows)
            {
                Build bui = new Build();
                bui.BuildId = int.Parse(col[0].ToString());
                bui.BuildArea = col[1].ToString();
                bui.BuildNo = int.Parse(col[2].ToString());
                bui.BuildMsg =(col[3].ToString());
                list.Add(bui);
            }
           ds.Tables[0].Clear();
            return list;
        }
        //更新
        public void update(Build build)
        {
            builddao.update(build);
        }
        //删除
        public void delete(int no)
        {
            builddao.delete(no);
        }
        //添加
        public void add(Build build)
        {
            builddao.bybuild(build);
        }
        //验证
        public int regbuildNo(int no)
        {
            //this.build = build;
            
            if (builddao.byNo(no)==null)
            //查不到记录，返回1，可以添加
            {
               
                return 1;
            }
            //楼层已存在
            else
                return 0;

        }
    }
}
