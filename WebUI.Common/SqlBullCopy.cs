using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Common
{
   public class SqlBullCopy
    {

        public static void BulkToDB(DataTable dt)
        {
            SqlConnection sqlConn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
            SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlConn);
            bulkCopy.DestinationTableName = "Table_1";   //指定的表的
            bulkCopy.BatchSize = dt.Rows.Count;    //要插入的数量
            bulkCopy.BulkCopyTimeout = 60000;//允许的秒数
            
            try
            {
                sqlConn.Open();
                if (dt != null && dt.Rows.Count != 0)
                    bulkCopy.WriteToServer(dt);                 //将所有行复制到指定的表中 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn.Close();
                if (bulkCopy != null)
                    bulkCopy.Close();
            }
        }

        public static DataTable GetTableSchema()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]{
             new DataColumn("Id",typeof(int)),
             new DataColumn("UserName",typeof(string)),
            new DataColumn("Pwd",typeof(string))});

            return dt;
        }
        

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            for (int multiply = 0; multiply < 10; multiply++)
            {
                DataTable dt = GetTableSchema();
                for (int count = multiply * 100000; count < (multiply + 1) * 100000; count++)
                {
                    DataRow r = dt.NewRow();
                    r[0] = count;
                    r[1] = string.Format("User-{0}", count * multiply);
                    r[2] = string.Format("Pwd-{0}", count * multiply);
                    dt.Rows.Add(r);
                }
                sw.Start();
                BulkToDB(dt);
                sw.Stop();
                Console.WriteLine(string.Format("Elapsed Time is {0} Milliseconds", sw.ElapsedMilliseconds));
            }

            Console.ReadLine();
        }
    }
}
