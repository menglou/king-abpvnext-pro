using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ClickHouse.King.AbpVnextPro.ClickHouse
{
    public interface IBasicClickHouseRepository<T> where T : class
    {
        Task ExecuteNoQuery(string sql, CommandType commandType, CancellationToken cancellationToken = default, params DbParameter[] parameters);
        Task ExecuteNoQuery(string sql, CancellationToken cancellationToken = default, params DbParameter[] parameters);
        Task<T> ExecuteScalar<T>(string sql, CommandType commandType, CancellationToken cancellationToken = default, params DbParameter[] parameters);
        Task<T> ExecuteScalar<T>(string sql, CancellationToken cancellationToken = default, params DbParameter[] parameters);
        Task<DataTable> ExecuteDataTable(string sql, CommandType commandType, CancellationToken cancellationToken = default, params DbParameter[] parameters);
        Task<DataTable> ExecuteDataTable(string sql, CancellationToken cancellationToken = default, params DbParameter[] parameters);
        Task<List<T>> ExecuteList<T>(string sql, CommandType commandType, CancellationToken cancellationToken = default, params DbParameter[] parameters) ;

        Task<List<T>> ExecuteList<T>(string sql, CancellationToken cancellationToken = default, params DbParameter[] parameters) ;
        Task<(ulong, DataTable)> ExecuteDataTableByPagination(string sql, int pageindex, int pagesize, CancellationToken cancellationToken = default, params DbParameter[] parameters);
        Task<(ulong, List<T>)> ExecuteListByPagination<T>(string sql, int pageindex, int pagesize, CancellationToken cancellationToken = default, params DbParameter[] parameters) ;
        void BulkInsert(List<T> sourceList, string tbName = "");
        void SignleInsert(T source, string tbName = "");


    }
}
