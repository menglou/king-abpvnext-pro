﻿namespace System.Text;

/// <summary>
/// StringBuilder 扩展方法类
/// </summary>
public static class StringBuilderExtensions
{
    /// <summary>
    /// 去除<seealso cref="StringBuilder"/>开头的空格
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <returns>返回修改后的StringBuilder，主要用于链式操作</returns>
    public static StringBuilder TrimStart(this StringBuilder stringBuilder)
    {
        if (stringBuilder is null) throw new ArgumentNullException();

        return stringBuilder.TrimStart(' ');
    }

    /// <summary>
    /// 去除<seealso cref="StringBuilder"/>开头的指定<seealso cref="char"/>
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <param name="c">要去掉的<seealso cref="char"/></param>
    /// <returns></returns>
    public static StringBuilder TrimStart(this StringBuilder stringBuilder, char c)
    {
        if (stringBuilder is null) throw new ArgumentNullException();

        if (stringBuilder.Length == 0)
        {
            return stringBuilder;
        }

        while (c.Equals(stringBuilder[0]))
        {
            stringBuilder.Remove(0, 1);
        }

        return stringBuilder;
    }

    /// <summary>
    /// 去除<seealso cref="StringBuilder"/>开头的指定字符数组
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <param name="chars">要去掉的字符数组</param>
    /// <returns></returns>
    public static StringBuilder TrimStart(this StringBuilder stringBuilder, char[] chars)
    {
        if (stringBuilder is null) throw new ArgumentNullException();

        return stringBuilder.TrimStart(new string(chars));
    }

    /// <summary>
    /// 去除<see cref="StringBuilder"/>开头的指定的<seealso cref="string"/>
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <param name="str">要去掉的<seealso cref="string"/></param>
    /// <returns></returns>
    public static StringBuilder TrimStart(this StringBuilder stringBuilder, string str)
    {
        if (stringBuilder is null) throw new ArgumentNullException();

        if (string.IsNullOrEmpty(str)
            || stringBuilder.Length == 0
            || str.Length > stringBuilder.Length)
        {
            return stringBuilder;
        }

        while (stringBuilder.SubString(0, str.Length).Equals(str))
        {
            stringBuilder.Remove(0, str.Length);
            if (str.Length > stringBuilder.Length)
            {
                break;
            }
        }

        return stringBuilder;
    }

    /// <summary>
    /// 去除StringBuilder结尾的空格
    /// </summary>
    /// <param name="stringBuilder">StringBuilder</param>
    /// <returns>返回修改后的StringBuilder，主要用于链式操作</returns>
    public static StringBuilder TrimEnd(this StringBuilder stringBuilder)
    {
        return stringBuilder.TrimEnd(' ');
    }

    /// <summary>
    /// 去除<see cref="StringBuilder"/>结尾指定字符
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <param name="c">要去掉的字符</param>
    /// <returns></returns>
    public static StringBuilder TrimEnd(this StringBuilder stringBuilder, char c)
    {
        if (stringBuilder is null) throw new ArgumentNullException();
        if (stringBuilder.Length == 0)
        {
            return stringBuilder;
        }

        while (c.Equals(stringBuilder[stringBuilder.Length - 1]))
        {
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
        }

        return stringBuilder;
    }

    /// <summary>
    /// 去除<see cref="StringBuilder"/>结尾指定字符数组
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <param name="chars">要去除的字符数组</param>
    /// <returns></returns>
    public static StringBuilder TrimEnd(this StringBuilder stringBuilder, char[] chars)
    {
        if (stringBuilder is null) throw new ArgumentNullException();

        return stringBuilder.TrimEnd(new string(chars));
    }

    /// <summary>
    /// 去除<see cref="StringBuilder"/>结尾指定字符串
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <param name="str">要去除的字符串</param>
    /// <returns></returns>
    public static StringBuilder TrimEnd(this StringBuilder stringBuilder, string str)
    {
        if (stringBuilder is null) throw new ArgumentNullException();
        if (string.IsNullOrEmpty(str)
            || stringBuilder.Length == 0
            || str!.Length > stringBuilder.Length)
        {
            return stringBuilder;
        }

        while (stringBuilder.SubString(stringBuilder.Length - str.Length, str.Length).Equals(str))
        {
            stringBuilder.Remove(stringBuilder.Length - str.Length, str.Length);
            if (stringBuilder.Length < str.Length)
            {
                break;
            }
        }

        return stringBuilder;
    }

    /// <summary>
    /// 去除StringBuilder两端的空格
    /// </summary>
    /// <param name="stringBuilder">StringBuilder</param>
    /// <returns>返回修改后的StringBuilder，主要用于链式操作</returns>
    public static StringBuilder Trim(this StringBuilder stringBuilder)
    {
        if (stringBuilder is null) throw new ArgumentNullException();

        if (stringBuilder.Length == 0)
        {
            return stringBuilder;
        }

        return stringBuilder.TrimEnd().TrimStart();
    }

    /// <summary>
    /// 返回<see cref="StringBuilder"/>从起始位置指定长度的字符串
    /// </summary>
    /// <param name="stringBuilder"></param>
    /// <param name="start">起始位置</param>
    /// <param name="length">长度</param>
    /// <returns>字符串</returns>
    /// <exception cref="IndexOutOfRangeException">超出字符串索引长度异常</exception>
    public static string SubString(this StringBuilder stringBuilder, int start, int length)
    {
        if (stringBuilder is null) throw new ArgumentNullException();

        if (start + length > stringBuilder.Length)
        {
            throw new ArgumentOutOfRangeException();
        }

        var cs = new char[length];
        for (var i = 0; i < length; i++)
        {
            cs[i] = stringBuilder[start + i];
        }

        return new string(cs);
    }
}