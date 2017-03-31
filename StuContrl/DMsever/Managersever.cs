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
    public class Managersever
    {  //验证
        Manager manager = new Manager();
        Managerdao managerdao = new Managerdao();
        DataSet ds = new DataSet();
        public Manager valida(string loginNo, string loginPwd)
        {
            manager = managerdao.byName(loginNo);
            // Console.Write(user);
            if (manager == null)
            { return manager; }
            else
            {
                if (manager.LoginPwd.Equals(loginPwd))
                {    
                    return manager;
                }
                else
                {
                    manager = null;
                    return manager;
                }
            }
            // return 0;
        }
        //管理员注册
        public int Regmanager(Manager manager)
        {
            this.manager = manager;
           int num= managerdao.regvali(manager.LoginNo, manager.LoginType);
            if (num == 0)
            //查不到记录，返回1，可以更新
            {
                managerdao.bymanager(manager);
                return 1;
            }
            //管理员已存在
            else
                return 0;

        }
        //
        public List<Manager> getallBylogintype(string loginType)
        {
            List<Manager> list = new List<Manager>();
            ds = managerdao.getmanageinfo(loginType);
            
            foreach(DataRow col in ds.Tables[0].Rows)
            {
                Manager man = new Manager();
                man.LoginId = int.Parse(col[0].ToString());
                man.LoginNo = col[1].ToString();
                man.LoginPwd = col[2].ToString();
                man.LoginType = col[3].ToString();
                list.Add(man);
            }
            ds.Tables[0].Clear();
            return list;
        }
        //删除
        public void delete(int id)
        {
            managerdao.delete(id);
        }
        //更新
       public void update(Manager manager)
        {   
            managerdao.update(manager);
        }
    }
    
}
