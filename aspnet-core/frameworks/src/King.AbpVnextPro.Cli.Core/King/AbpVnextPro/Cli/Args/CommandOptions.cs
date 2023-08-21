﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.Cli.Args;

public class CommandOptions
{
    /// <summary>
    /// 模板
    /// </summary>
    public static class Template
    {
        public const string Short = "t";
        public const string Long = "template";
    }

    /// <summary>
    ///  公司名称
    /// </summary>
    public static class Company
    {
        public const string Short = "c";
        public const string Long = "company";
    }


    /// <summary>
    /// 项目名称
    /// </summary>
    public static class Project
    {
        public const string Short = "p";
        public const string Long = "project";
    }

    /// <summary>
    /// 模块名称
    /// </summary>
    public static class Module
    {
        public const string Short = "m";
        public const string Long = "modulle";
    }

    /// <summary>
    /// 输出目录
    /// </summary>
    public static class OutputFolder
    {
        public const string Short = "o";
        public const string Long = "output";
    }

    /// <summary>
    /// 版本
    /// </summary>
    public static class Version
    {
        public const string Short = "v";
        public const string Long = "version";
    }
}