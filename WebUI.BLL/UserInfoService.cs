using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.IBLL;
using WebUI.Model;

namespace WebUI.BLL
{
    public partial class UserInfoService : BaseServer<UserInfo>, IUserInfoService
    {
        public bool del()
        {
         
            string sql = "delete from UserInfoes where id=@id";
            return this.DbSession.ExecuteSql(sql) > 0;
         
        }
    }
}
