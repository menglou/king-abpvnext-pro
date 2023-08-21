﻿namespace System;

/// <summary>
/// 时间扩展操作类
/// </summary>
public static class DateTimeExtensions
{
    /// <summary>
    /// 当前时间是否周末
    /// </summary>
    /// <param name="dateTime">时间点</param>
    /// <returns></returns>
    public static bool IsWeekend(this DateTime dateTime)
    {
        DayOfWeek[] weeks =
        {
            DayOfWeek.Saturday,
            DayOfWeek.Sunday
        };
        return weeks.Contains(dateTime.DayOfWeek);
    }

    /// <summary>
    /// 当前时间是否工作日
    /// </summary>
    /// <param name="dateTime">时间点</param>
    /// <returns></returns>
    public static bool IsWeekday(this DateTime dateTime)
    {
        DayOfWeek[] weeks =
        {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday
        };
        return weeks.Contains(dateTime.DayOfWeek);
    }
    
    /// <summary>
    /// 将时间类型转成int类型. 例如 2021-09-01 => 20210901
    /// </summary>
    public static int ToYyyyMmDd(this DateTime dateTime)
    {
        // 2021-09-01 => 2021*10000 + 09*100 + 1
        return dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day;
    }

    /// <summary>
    /// 将时间类型转成int类型. 例如 2021-09-01 => 202109
    /// </summary>
    public static int ToYyyyMm(this DateTime dateTime)
    {
        // 2021-09-06 => 2021*100+09
        return dateTime.Year * 100 + dateTime.Month;
    }

    /// <summary>
    /// 获取指定日期 当天的最大时间
    /// 例如 2021-09-10 11:22:33.123 转换后 2021-09-10 23:59:59.999
    /// </summary>
    public static DateTime? ToCurrentDateMaxDateTime(this DateTime? dateTime)
    {
        return dateTime?.Date.AddDays(1).AddTicks(-1);
    }

    /// <summary>
    /// 获取指定日期 当天的最大时间
    /// 例如 2021-09-10 11:22:33.123 转换后 2021-09-10 23:59:59.999
    /// </summary>
    public static DateTime ToCurrentDateMaxDateTime(this DateTime dateTime)
    {
        return dateTime.Date.AddDays(1).AddMilliseconds(-1);
    }

    /// <summary>
    /// 获取指定日期 当天的最小时间
    /// </summary>
    public static DateTime? ToCurrentDateMinDateTime(this DateTime? dateTime)
    {
        return dateTime?.Date;
    }

    /// <summary>
    /// 获取指定日期 当天的最小时间
    /// </summary>
    public static DateTime ToCurrentDateMinDateTime(this DateTime dateTime)
    {
        return dateTime.Date;
    }

    /// <summary>
    /// 获取指定时间的下一秒
    /// 例如 2021-09-10 11:11:11.1234567 转换后 2021-09-10 11:11:12.0000000
    /// </summary>
    public static DateTime? ToNextSecondDateTime(this DateTime? dateTime)
    {
        if (!dateTime.HasValue)
        {
            return null;
        }

        return new DateTime(dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day, dateTime.Value.Hour, dateTime.Value.Minute, dateTime.Value.Second).AddSeconds(1);
    }

    /// <summary>
    /// 转为秒级时间戳
    /// <param name="dateTime">时间</param>
    /// <remarks>
    ///时间戳实际就是当前时间距离1970年1月1日0点0时0分0秒（转换成北京时间是1970年1月1日8点0时0分0秒）距离你要计算的时间的秒数或者毫秒数 一般来说：我们用的时间戳到秒的话是10位，到毫秒的话是13位
    /// </remarks>
    /// </summary>
    public static long ToUnixTimeSeconds(this DateTime dateTime)
    {
        return (new DateTimeOffset(dateTime)).ToUnixTimeSeconds();
    }

    /// <summary>
    /// 转为秒级时间戳
    /// <param name="dateTime">时间</param>
    /// </summary>
    public static long? ToUnixTimeSeconds(this DateTime? dateTime)
    {
        if (!dateTime.HasValue) return null;
        return (new DateTimeOffset(dateTime.Value)).ToUnixTimeSeconds();
    }

    /// <summary>
    /// 转为毫秒级时间戳
    /// <param name="dateTime">时间</param>
    /// </summary>
    public static long? ToUnixTimeMilliseconds(this DateTime dateTime)
    {
        return (new DateTimeOffset(dateTime)).ToUnixTimeMilliseconds();
    }

    /// <summary>
    /// 转为毫秒级时间戳
    /// <param name="dateTime">时间</param>
    /// </summary>
    public static long? ToUnixTimeMilliseconds(this DateTime? dateTime)
    {
        if (!dateTime.HasValue) return null;
        return (new DateTimeOffset(dateTime.Value)).ToUnixTimeMilliseconds();
    }

    /// <summary>
    /// 秒级时间戳转为时间
    /// <param name="timestamp">时间</param>
    /// <param name="timeZoneInfo">默认 TimeZoneInfo.Utc</param>
    /// </summary>
    public static DateTime ToDateTimeBySecondTimeStamp(this long timestamp, TimeZoneInfo timeZoneInfo = null)
    {
        timeZoneInfo ??= TimeZoneInfo.Utc;
        var dtStart = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1, 0, 0, 0), timeZoneInfo);
        var time = dtStart.AddSeconds(timestamp);
        return time;
    }

    /// <summary>
    /// 秒级时间戳转为时间
    /// <param name="timestamp">时间戳</param>
    /// <param name="timeZoneInfo">默认 TimeZoneInfo.Utc</param>
    /// </summary>
    public static DateTime? ToDateTimeBySecondTimeStamp(this long? timestamp, TimeZoneInfo timeZoneInfo = null)
    {
        if (!timestamp.HasValue) return null;
        timeZoneInfo ??= TimeZoneInfo.Utc;
        var dtStart = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1, 0, 0, 0), timeZoneInfo);
        var time = dtStart.AddSeconds(timestamp.Value);
        return time;
    }

    /// <summary>
    /// 毫秒级时间戳转为时间
    /// <param name="timestamp">时间戳</param>
    /// <param name="timeZoneInfo">默认 TimeZoneInfo.Utc</param>
    /// </summary>
    public static DateTime ToDateTimeByMilliSecondTimeStamp(this long timestamp, TimeZoneInfo timeZoneInfo = null)
    {
        timeZoneInfo ??= TimeZoneInfo.Utc;
        var dtStart = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1, 0, 0, 0), timeZoneInfo);
        var time = dtStart.AddMilliseconds(timestamp);
        return time;
    }

    /// <summary>
    /// 毫秒级时间戳转为时间
    /// <param name="timestamp">时间戳</param>
    /// <param name="timeZoneInfo">默认 TimeZoneInfo.Utc</param>
    /// </summary>
    public static DateTime? ToDateTimeByMilliSecondTimeStamp(this long? timestamp, TimeZoneInfo timeZoneInfo = null)
    {
        if (!timestamp.HasValue) return null;
        timeZoneInfo ??= TimeZoneInfo.Utc;
        var dtStart = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1, 0, 0, 0), timeZoneInfo);
        var time = dtStart.AddMilliseconds(timestamp.Value);
        return time;
    }
}