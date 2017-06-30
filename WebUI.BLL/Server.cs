 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebUI.Model;
using WebUI.IBLL;

namespace WebUI.BLL
{
	
	public partial class ActionFilterService:BaseServer<ActionFilter>,IActionFilterService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ActionFilterDal;
        }
    }
	
	public partial class ActionviewService:BaseServer<Actionview>,IActionviewService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ActionviewDal;
        }
    }
	
	public partial class ExamTureService:BaseServer<ExamTure>,IExamTureService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ExamTureDal;
        }
    }
	
	public partial class RestultService:BaseServer<Restult>,IRestultService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.RestultDal;
        }
    }
	
	public partial class SubjectService:BaseServer<Subject>,ISubjectService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.SubjectDal;
        }
    }
	
	public partial class Table_1Service:BaseServer<Table_1>,ITable_1Service
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.Table_1Dal;
        }
    }
	
	public partial class Table_2Service:BaseServer<Table_2>,ITable_2Service
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.Table_2Dal;
        }
    }
	
	public partial class UserExamService:BaseServer<UserExam>,IUserExamService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.UserExamDal;
        }
    }
	
	public partial class UserInfoService:BaseServer<UserInfo>,IUserInfoService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.UserInfoDal;
        }
    }
	
}