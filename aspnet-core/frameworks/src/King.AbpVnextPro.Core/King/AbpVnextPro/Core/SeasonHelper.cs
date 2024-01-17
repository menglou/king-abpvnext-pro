using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.Core.King.AbpVnextPro.Core
{
    public class SeasonHelper
    {
        /// <summary>
        /// C#获取指定日期时间是当前年度的第几个季度
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetQuarterNum(DateTime dt)
        {
            int year = dt.Year;
            string jd;
            DateTime dt0 = new DateTime(year, 1, 1);
            DateTime dt1 = new DateTime(year, 4, 1);
            DateTime dt2 = new DateTime(year, 7, 1);
            DateTime dt3 = new DateTime(year, 10, 1);
            if (dt.CompareTo(dt1) < 0)
                jd = year.ToString() + "FirstSeason";
            else if (dt.CompareTo(dt2) < 0)
                jd = year.ToString() + "SecondSeason";
            else if (dt.CompareTo(dt3) < 0)
                jd = year.ToString() + "ThirdSeason";
            else
                jd = year.ToString() + "FourthSeason";
            return jd;
        }

        public static string GetQuarterDateTime(string jd)
        {
            int year = Convert.ToInt32(Regex.Replace(jd, "[a-z]", "", RegexOptions.IgnoreCase));
            if (jd.Contains("FirstSeason"))
            {
                return new DateTime(year, 1, 1).ToString("yyyyMMdd");
            }
            else if (jd.Contains("SecondSeason"))
            {
                return new DateTime(year, 4, 1).ToString("yyyyMMdd");
            }
            else if (jd.Contains("ThirdSeason"))
            {
                return new DateTime(year, 7, 1).ToString("yyyyMMdd");
            }
            else
            {
                return new DateTime(year, 10, 1).ToString("yyyyMMdd");
            }
        }
    }
}
