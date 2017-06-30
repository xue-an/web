 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebUI.Model;
using WebUI.IDAL;

namespace WebUI.IDAL
{
   
   
	
	public partial interface IActionFilterDal :IBaseDAL<ActionFilter>
    { 
	}	
	
	public partial interface IActionviewDal :IBaseDAL<Actionview>
    { 
	}	
	
	public partial interface IExamTureDal :IBaseDAL<ExamTure>
    { 
	}	
	
	public partial interface IRestultDal :IBaseDAL<Restult>
    { 
	}	
	
	public partial interface ISubjectDal :IBaseDAL<Subject>
    { 
	}	
	
	public partial interface ITable_1Dal :IBaseDAL<Table_1>
    { 
	}	
	
	public partial interface ITable_2Dal :IBaseDAL<Table_2>
    { 
	}	
	
	public partial interface IUserExamDal :IBaseDAL<UserExam>
    { 
	}	
	
	public partial interface IUserInfoDal :IBaseDAL<UserInfo>
    { 
	}	
	
}