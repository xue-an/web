 

using WebUI.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebUI.Model;


namespace WebUI.IBLL
{
   
   
	
	public  partial interface IActionFilterService :IBaseServer<ActionFilter>
	{
    }
	
	public  partial interface IActionviewService :IBaseServer<Actionview>
	{
    }
	
	public  partial interface IExamTureService :IBaseServer<ExamTure>
	{
    }
	
	public  partial interface IRestultService :IBaseServer<Restult>
	{
    }
	
	public  partial interface ISubjectService :IBaseServer<Subject>
	{
    }
	
	public  partial interface ITable_1Service :IBaseServer<Table_1>
	{
    }
	
	public  partial interface ITable_2Service :IBaseServer<Table_2>
	{
    }
	
	public  partial interface IUserExamService :IBaseServer<UserExam>
	{
    }
	
	public  partial interface IUserInfoService :IBaseServer<UserInfo>
	{
    }
	
}