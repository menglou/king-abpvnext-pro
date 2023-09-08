using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace King.AbpVnextPro.ClickHouse.King.AbpVnextPro.ClickHouse
{
    public  class ClickHouseRepository<T>: IBasicClickHouseRepository<T>, IDisposable where T:class
    {
        private readonly IClickHouseProvider _clickHouseProvider;
        protected ClickHouseRepository(IClickHouseProvider clickHouseProvider)
        {
            _clickHouseProvider = clickHouseProvider;
        }

        private IFreeSql fsql => _clickHouseProvider.GetClient();


        public virtual async  Task ExecuteNoQuery(string sql, CommandType commandType, params DbParameter[] parameters)
        {
            try
            {
                await fsql.Ado.ExecuteNonQueryAsync(commandType, sql, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }
        }

        public virtual async Task ExecuteNoQuery(string sql, params DbParameter[] parameters)
        {
            try
            {

                await ExecuteNoQuery(sql, CommandType.Text, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }
        }

        public virtual async Task<T> ExecuteScalar<T>(string sql, CommandType commandType, params DbParameter[] parameters)
        {
            T result;
            try
            {
                result = await fsql.Ado.QuerySingleAsync<T>(commandType, sql, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException:e);
            }

            return result;
        }

        public virtual async Task<T> ExecuteScalar<T>(string sql, params DbParameter[] parameters)
        {
            T result;
            try
            {
                result = await ExecuteScalar<T>(sql, CommandType.Text, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }

            return result;
        }


        /// <summary>
        /// 执行sql返回一个DataTable
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数</param>
        /// <returns></returns>
        public virtual async Task<DataTable> ExecuteDataTable(string sql, CommandType commandType, params DbParameter[] parameters)
        {
            DataTable result;
            try
            {
                result = await fsql.Ado.ExecuteDataTableAsync(commandType, sql, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }

            return result;
        }

        /// <summary>
        /// 执行sql返回一个DataTable
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数</param>
        /// <returns></returns>
        public virtual async Task<DataTable> ExecuteDataTable(string sql, params DbParameter[] parameters)
        {
            DataTable result;
            try
            {
                result = await ExecuteDataTable(sql, CommandType.Text, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }

            return result;
        }


        /// <summary>
        /// 执行sql返回指定类型的List
        /// </summary>
        /// <typeparam name="T">需要返回的类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="parameters">sql参数</param>
        /// <returns></returns>
        public virtual async Task<List<T>> ExecuteList<T>(string sql, CommandType commandType, params DbParameter[] parameters)
        {
            List<T> resultList = new List<T>();
            try
            {
                resultList = await fsql.Ado.QueryAsync<T>(commandType, sql, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }

            return resultList;
        }

        /// <summary>
        /// 执行sql返回指定类型的List
        /// </summary>
        /// <typeparam name="T">需要返回的类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数</param>
        /// <returns></returns>
        public virtual async Task<List<T>> ExecuteList<T>(string sql, params DbParameter[] parameters) 
        {
            List<T> resultList = new List<T>();
            try
            {
                resultList = await ExecuteList<T>(sql, CommandType.Text, parameters);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }

            return resultList;

        }

        /// <summary>
        /// DataTable分页;注：传入的sql请自己增加排序条件
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="pageindex">页码</param>
        /// <param name="pagesize">每页条数</param>
        /// <param name="parameters">sql参数</param>
        /// <returns>返回总条数和分页后数据</returns>
        public virtual async Task<(ulong, DataTable)> ExecuteDataTableByPagination(string sql, int pageindex, int pagesize, params DbParameter[] parameters)
        {
            DataTable result;
            ulong totalCount = 0;
            try
            {
                (string countsql, string pagesql) = GetCountAndPageSql(sql, pageindex, pagesize);
                result = await ExecuteDataTable(pagesql, CommandType.Text, parameters);
                totalCount = await ExecuteScalar<ulong>(countsql);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }

            return (totalCount, result);
        }

        /// <summary>
        /// List分页;注：传入的sql请自己增加排序条件
        /// </summary>
        /// <typeparam name="T">需要返回的list类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="pageindex">页码</param>
        /// <param name="pagesize">每页条数</param>
        /// <param name="parameters">sql参数</param>
        /// <returns>返回总条数和分页后数据</returns>
        public virtual async Task<(ulong, List<T>)> ExecuteListByPagination<T>(string sql, int pageindex, int pagesize, params DbParameter[] parameters)
        {
            List<T> result;
            ulong totalCount = 0;
            try
            {
                (string countsql, string pagesql) = GetCountAndPageSql(sql, pageindex, pagesize);
                result = await ExecuteList<T>(pagesql, CommandType.Text, parameters);
                totalCount = await ExecuteScalar<ulong>(countsql);
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }

            return (totalCount, result);
        }

        /// <summary>
        /// 批量新增数据;注：单条增加请使用ExecuteNonQuery
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="sourceList">源数据</param>
        /// <param name="tbName">需要插入的表名;注：不填默认为类名</param>
        public virtual void BulkInsert(List<T> sourceList, string tbName = "") 
        {
            tbName = string.IsNullOrEmpty(tbName) ? typeof(T).Name : tbName;
            try
            {
                //string insertClickHouseSql = $"INSERT INTO {tbName} ({GetColumns<T>()}) VALUES @bulk;";
               
                fsql.Insert(sourceList).ExecuteAffrows();
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }
        }
        /// <summary>
        /// 单个插入
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="source">源数据</param>
        /// <param name="tbName">需要插入的表名;注：不填默认为类名</param>
        public virtual void SignleInsert(T source, string tbName = "")
        {
            tbName = string.IsNullOrEmpty(tbName) ? typeof(T).Name : tbName;
            try
            {
                fsql.Insert(source).ExecuteAffrows();
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }
        }


        #region private

        private List<dynamic[]> List2AList<T>(List<T> sourceList)
        {
            List<dynamic[]> result = new List<dynamic[]>();
            sourceList.ForEach(u =>
            {
                var dic = GetColumnsAndValue(u);
                result.Add(dic.Select(i => i.Value).ToArray());
            });
            return result;
        }

        private string GetColumns<T>()
        {
            try
            {
                var dic = GetColumnsAndValue<T>(default(T));
                return string.Join(",", dic.Select(u => u.Key).ToArray());
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }
        }

        private Dictionary<string, object> GetColumnsAndValue<T>(T u)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                Type t = typeof(T);
                if (u != null)
                {
                    t = u.GetType();
                }
                var columns = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var item in columns)
                {
                    object v = null;
                    if (u != null)
                    {
                        v = item.GetValue(u);
                    }
                    dic.TryAdd(item.Name, v);
                }

                return dic;
            }
            catch (Exception e)
            {
                this.Dispose();
                throw new BusinessException(innerException: e);
            }
        }

        //private void AttachParameters(ClickHouseParameterCollection parametersCollection, ClickHouseParameter[] parameters)
        //{
        //    foreach (var item in parameters)
        //    {
        //        parametersCollection.Add(item);
        //    }
        //}

        /// <summary>
        ///  将IDataReader转换为DataTable
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static DataTable DataReaderToDataTable(IDataReader reader)
        {
            DataTable objDataTable = new DataTable("Table");
            int intFieldCount = reader.FieldCount;
            for (int intCounter = 0; intCounter < intFieldCount; ++intCounter)
            {
                objDataTable.Columns.Add(reader.GetName(intCounter).ToUpper(), reader.GetFieldType(intCounter));
            }
            objDataTable.BeginLoadData();
            object[] objValues = new object[intFieldCount];
            while (reader.NextResult())
            {
                while (reader.Read())
                {
                    reader.GetValues(objValues);
                    objDataTable.LoadDataRow(objValues, true);
                }
            }
            reader.Close();
            objDataTable.EndLoadData();
            return objDataTable;
        }

        private static T ReaderToModel<T>(IDataReader dr)
        {
            try
            {
                using (dr)
                {
                    if (dr.Read())
                    {
                        List<string> list = new List<string>(dr.FieldCount);
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            list.Add(dr.GetName(i).ToLower());
                        }
                        T model = Activator.CreateInstance<T>();
                        foreach (PropertyInfo pi in model.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance))
                        {
                            if (list.Contains(pi.Name.ToLower()))
                            {
                                if (!IsNullOrDBNull(dr[pi.Name]))
                                {
                                    pi.SetValue(model, HackType(dr[pi.Name], pi.PropertyType), null);
                                }
                            }
                        }
                        return model;
                    }
                }
                return default(T);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }

        private static List<T> ReaderToList<T>(IDataReader dr)
        {
            using (dr)
            {
                List<string> field = new List<string>(dr.FieldCount);
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    field.Add(dr.GetName(i).ToLower());
                }
                List<T> list = new List<T>();
                while (dr.NextResult())
                {
                    while (dr.Read())
                    {
                        T model = Activator.CreateInstance<T>();
                        foreach (PropertyInfo property in model.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance))
                        {
                            if (field.Contains(property.Name.ToLower()))
                            {
                                if (!IsNullOrDBNull(dr[property.Name]))
                                {
                                    if (property.PropertyType == typeof(Boolean))
                                    {
                                        property.SetValue(model, HackType(Convert.ToInt32(dr[property.Name]) == 0 ? false : true, property.PropertyType), null);
                                    }
                                    else
                                    {
                                        property.SetValue(model, HackType(dr[property.Name], property.PropertyType), null);
                                    }

                                }
                            }
                        }
                        list.Add(model);
                    }
                }
                return list;
            }
        }

        //这个类对可空类型进行判断转换，要不然会报错
        private static object HackType(object value, Type conversionType)
        {
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                    return null;

                System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            }
            return Convert.ChangeType(value, conversionType);
        }

        private static bool IsNullOrDBNull(object obj)
        {
            if (obj != null)
            {
                return ((obj is DBNull) || string.IsNullOrEmpty(obj.ToString())) ? true : false;
            }
            else
            {
                return false;
            }
        }

        private (string, string) GetCountAndPageSql(string sql, int pageindex, int pagesize)
        {
            string countSql = $"SELECT COUNT(1) count FROM ({sql}) A";

            string pageSql = $"select * from ({sql}) LIMIT {pagesize} OFFSET {(pageindex - 1) * pagesize}";

            return (countSql, pageSql);
        }


        public void Dispose()
        {
            fsql?.Dispose();
            GC.Collect();
        }
    }
    #endregion
}
