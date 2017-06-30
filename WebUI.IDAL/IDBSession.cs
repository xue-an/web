 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebUI.Model;
using WebUI.IDAL;
using System.Data.SqlClient;
namespace WebUI.IDAL
{
	public partial  interface  IDbSession
    {  

	 int SaveChanges();

	 int ExecuteSql(string sql,params SqlParameter[] pars);
	 List<T> ExecuteQuery<T>(string sql, params System.Data.SqlClient.SqlParameter[] pars);
		
		IActionFilterDal ActionFilterDal { get; }
		
		IActionviewDal ActionviewDal { get; }
		
		IExamTureDal ExamTureDal { get; }
		
		IRestultDal RestultDal { get; }
		
		ISubjectDal SubjectDal { get; }
		
		ITable_1Dal Table_1Dal { get; }
		
		ITable_2Dal Table_2Dal { get; }
		
		IUserExamDal UserExamDal { get; }
		
		IUserInfoDal UserInfoDal { get; }
	}	
}