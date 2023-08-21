using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    public enum Opinion
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 0,
        /// <summary>
        /// 同意
        /// </summary>
        [Description("同意")]
        Agree = 1,

        [Description("不同意")]
        DisAgree = 2
    }
}
