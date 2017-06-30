using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.IBLL
{
    public interface IBaseServer<T> where T:class,new()
    {
        T Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        int Delete(params int[] ids);

        //u=>true
        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);//规约设计模式。 where a>10

        IQueryable<T> LoadPageEntities<S>(int pageSize, int pageIndex, out int total,
                                                  Expression<Func<T, bool>> whereLambda
                                                  , Expression<Func<T, S>> orderbyLambda, bool isAsc);


        int Savechanges();

    }
}
