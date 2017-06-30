using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebUI.IDAL;

namespace WebUI.DALFtory
{
    public class DbSessionFactory
    {
        public static IDbSession GetCurrentDbSession()
        {
            //return   new DbSession();

            IDbSession dbSession = (IDbSession)CallContext.GetData("DbSession");

            int threadId = Thread.CurrentThread.ManagedThreadId;

            if (dbSession == null)
            {
                dbSession = new DbSession();
                CallContext.SetData("DbSession", dbSession);
            }


            return dbSession;
        }

    }
}
