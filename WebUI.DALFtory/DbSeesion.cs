

using System.Linq;
using System.Text;

using WebUI.IDAL;
using WebUI.DAL;
using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Collections.Generic;
using WebUI.Model;

namespace WebUI.DALFtory
{
    /// <summary>
    /// DbSession:本质就是一个简单工厂，就是这么一个简单工厂，但从抽象意义上来说，它就是整个数据库访问层的统一入口。
    /// 因为拿到了DbSession就能够拿到整个数据库访问层所有的dal。
    /// </summary>
    public partial class DbSession :IDbSession
    {  
	
		private IActionFilterDal _ActionFilterDal;
		public IActionFilterDal ActionFilterDal {
            get {
                if (_ActionFilterDal == null)
                {
                    _ActionFilterDal =new ActionFilterDal();
                }
                return _ActionFilterDal;
            }
        }
	
		private IActionviewDal _ActionviewDal;
		public IActionviewDal ActionviewDal {
            get {
                if (_ActionviewDal == null)
                {
                    _ActionviewDal =new ActionviewDal();
                }
                return _ActionviewDal;
            }
        }
	
		private IExamTureDal _ExamTureDal;
		public IExamTureDal ExamTureDal {
            get {
                if (_ExamTureDal == null)
                {
                    _ExamTureDal =new ExamTureDal();
                }
                return _ExamTureDal;
            }
        }
	
		private IRestultDal _RestultDal;
		public IRestultDal RestultDal {
            get {
                if (_RestultDal == null)
                {
                    _RestultDal =new RestultDal();
                }
                return _RestultDal;
            }
        }
	
		private ISubjectDal _SubjectDal;
		public ISubjectDal SubjectDal {
            get {
                if (_SubjectDal == null)
                {
                    _SubjectDal =new SubjectDal();
                }
                return _SubjectDal;
            }
        }
	
		private ITable_1Dal _Table_1Dal;
		public ITable_1Dal Table_1Dal {
            get {
                if (_Table_1Dal == null)
                {
                    _Table_1Dal =new Table_1Dal();
                }
                return _Table_1Dal;
            }
        }
	
		private ITable_2Dal _Table_2Dal;
		public ITable_2Dal Table_2Dal {
            get {
                if (_Table_2Dal == null)
                {
                    _Table_2Dal =new Table_2Dal();
                }
                return _Table_2Dal;
            }
        }
	
		private IUserExamDal _UserExamDal;
		public IUserExamDal UserExamDal {
            get {
                if (_UserExamDal == null)
                {
                    _UserExamDal =new UserExamDal();
                }
                return _UserExamDal;
            }
        }
	
		private IUserInfoDal _UserInfoDal;
		public IUserInfoDal UserInfoDal {
            get {
                if (_UserInfoDal == null)
                {
                    _UserInfoDal =new UserInfoDal();
                }
                return _UserInfoDal;
            }
        }


        public DbContext Db
        {
            get { return EFDbContextFactory.GetCurrentDbContext(); }//完成EF上下文创建
        }
   
      public int SaveChanges()
        {

     
            return Db.SaveChanges();

        }


		        /// <summary>
        /// ef的sql语句
        /// </summary>
        /// <param name="sql">select delete from</param>
        /// <param name="pars">参数；</param>
        /// <returns></returns>
         public int ExecuteSql(string sql,params SqlParameter[] pars)
        {
            
            return Db.Database.ExecuteSqlCommand(sql, pars);
        }
        public List<T> ExecuteQuery<T>(string sql, params System.Data.SqlClient.SqlParameter[] pars)
        {
            return Db.Database.SqlQuery<T>(sql, pars).ToList();
        }



    }	
}