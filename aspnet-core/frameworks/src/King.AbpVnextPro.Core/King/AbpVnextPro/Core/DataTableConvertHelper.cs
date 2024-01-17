using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace King.AbpVnextPro.Core.King.AbpVnextPro.Core
{
    public class DataTableConvertHelper<T> where T : new()
    {

        /// <summary>
        ///  IEnumerable 集合转 DataTable
        /// </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="varlist"> </param>
        /// <returns> </returns>
        public static DataTable ToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            // column names
            PropertyInfo[] oProps = null;
            if (varlist == null)
                return dtReturn;
            foreach (T rec in varlist)
            {
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;
                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                             == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }
                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }
                DataRow dr = dtReturn.NewRow();
                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }
                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        /// <summary>
        /// DataTable 转 List
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static IList<T> ConvertToModel(DataTable dt)
        {
            // 定义集合    
            IList<T> ts = new List<T>();

            // 获得此模型的类型   
            Type type = typeof(T);
            string tempName = "";

            //过滤空行
            RemoveEmpty(dt);

            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                // 获得此模型的公共属性      
                PropertyInfo[] propertys = t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    tempName = pi.Name;  // 检查DataTable是否包含此列    


                    if (dt.Columns.Contains(tempName))
                    {
                        // 判断此属性是否有Setter      
                        if (!pi.CanWrite) continue;

                        object value = dr[tempName];

                        if (value != DBNull.Value)
                        {
                            if (pi.PropertyType.Name == typeof(Guid).Name)
                            {
                                pi.SetValue(t, new Guid(value.ToString()), null);
                            }
                            else if (pi.PropertyType.Name == typeof(Int32).Name)
                            {
                                int i = -1;
                                int.TryParse(value.ToString(), out i);
                                pi.SetValue(t, i == -1 ? 0 : i, null);
                            }
                            else if (pi.PropertyType.Name.Contains(typeof(Nullable).Name))
                            {
                                var propType = pi.PropertyType;

                                if (Nullable.GetUnderlyingType(propType) != null)
                                {
                                    // It's nullable
                                    propType = Nullable.GetUnderlyingType(propType);
                                }
                                if (propType.Name == typeof(Int32).Name)
                                {
                                    if (value != DBNull.Value)
                                    {
                                        int i = -1;
                                        int? writedint = null;
                                        if (int.TryParse(value.ToString(), out i) == true)
                                        {
                                            writedint = i;
                                        }
                                        else
                                        {
                                            writedint = 0;
                                        }
                                        pi.SetValue(t, writedint, null);
                                    }
                                    else
                                    {
                                        pi.SetValue(t, 0, null);
                                    }

                                }
                                else if (propType.Name == typeof(decimal).Name)
                                {
                                    if (value != DBNull.Value)
                                    {
                                        decimal i = -1;
                                        decimal? writedint = null;
                                        if (decimal.TryParse(value.ToString(), out i) == true)
                                        {
                                            writedint = i;
                                        }
                                        else
                                        {
                                            writedint = 0;
                                        }
                                        pi.SetValue(t, writedint, null);
                                    }
                                    else
                                    {
                                        pi.SetValue(t, 0, null);
                                    }

                                }
                                else if (propType.Name == typeof(DateTime).Name)
                                {
                                    if (value != DBNull.Value)
                                    {
                                        DateTime i = DateTime.Now;
                                        DateTime? writedate = null;
                                        if (DateTime.TryParse(value.ToString(), out i) == true)
                                        {
                                            writedate = i;
                                        }
                                        else
                                        {
                                            writedate = null;
                                        }

                                        pi.SetValue(t, writedate, null);
                                    }
                                    else
                                    {
                                        pi.SetValue(t, null, null);
                                    }

                                }
                                else if (propType.Name == typeof(Boolean).Name)
                                {
                                    if (value != DBNull.Value)
                                    {
                                        bool i = false;
                                        bool? writedate = null;
                                        if (Boolean.TryParse(value.ToString(), out i) == true)
                                        {
                                            writedate = i;
                                        }
                                        else
                                        {
                                            writedate = null;
                                        }

                                        pi.SetValue(t, writedate, null);
                                    }
                                    else
                                    {
                                        pi.SetValue(t, null, null);
                                    }

                                }

                            }

                            else
                            {
                                pi.SetValue(t, value, null);
                            }
                        }
                    }
                }
                ts.Add(t);
            }
            return ts;
        }

        /// <summary>
        /// 过滤空行
        /// </summary>
        /// <param name="dt"></param>
        public static void RemoveEmpty(DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool rowdataisnull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {

                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {

                        rowdataisnull = false;
                    }

                }
                if (rowdataisnull)
                {
                    removelist.Add(dt.Rows[i]);
                }

            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
        }
    }
}
