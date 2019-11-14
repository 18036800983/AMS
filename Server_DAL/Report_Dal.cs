using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Report_Dal
    {

        /// <summary>
        /// get table by condition
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="condition"></param>
        /// <returns></returns>
        public string GetTableByCondition<T>(string condition)
        {
            var sql = "select * from " + typeof(T).Name + " where " + condition;
            return sql;
        }

        /// <summary>
        /// get table count
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public string GetTableCount(string tableName)
        {
            var sql = $@"select i.rows as [RowCount]
                        from sys.tables as t, sysindexes as i
                        where t.object_id = i.id and i.indid <=1 and t.name='{tableName}'";
            return sql;
        }
    }
}
