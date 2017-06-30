using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebUI.DAL
{
   public class EFDbContextFactory
    {
        public static DbContext GetCurrentDbContext()
        {
            //return new DataModelContainer();
            //先去线程数据槽里去拿数据
            //if 有数据，直接返回
            //如果没有数据： 创建一个Ef上下文，然后放到数据槽里面去。返回数据。

            DbContext db = (DbContext)CallContext.GetData("DbContext");

            int id = Thread.CurrentThread.ManagedThreadId;

            if (db == null)
            {
                db = new Model.aaEntities();
                CallContext.SetData("DbContext", db);
            }
            return db;
        }

    }
}
