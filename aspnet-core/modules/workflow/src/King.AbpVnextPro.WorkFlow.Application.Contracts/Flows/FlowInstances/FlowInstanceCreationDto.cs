using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.WorkFlow.Flows.FlowInstances
{
    internal class FlowInstanceCreationDto
    {
        /// <summary>
        /// 流程名称 (自定义)
        /// </summary>
        public string CustomName { get; set; }
        /// <summary>
        /// 流程模板id
        /// </summary>
        public string DesignId { get; set; }
        /// <summary>
        /// 流程类型
        /// </summary>
        public int DesignType { get; set; } = 0;

        /// <summary>
        /// 当前节点id
        /// </summary>
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 节点类型 1一般节点 2 会签节点,3开始节点,4流程运行结束
        /// </summary>
        public int ActivityType { get; set; } = 0;

        /// <summary>
        /// 节点名称
        /// </summary>
        public string ActivityName { get; set; } = string.Empty;

        /// <summary>
        /// 前一节点id
        /// </summary>
        public string PreviousId { get; set; } = string.Empty;
        /// <summary>
        /// 流程模板内容
        /// </summary>
        public string DesignContent { get; set; } = string.Empty;

        /// <summary>
        /// 表单模板内容
        /// </summary>
        public string FormContent { get; set; } = string.Empty;

        /// <summary>
        /// 实例数据
        /// </summary>
        public string FormData { get; set; } = string.Empty;
        /// <summary>
        /// 对应表单id
        /// </summary>
        public string FormId { get; set; } = string.Empty;

        /// <summary>
        ///状态 	1草稿 2 流转中3 结束
        /// </summary>
        public int Status { get; set; } = 0;
        /// <summary>
        /// 流程结果 1运行中 2完成 3撤回 4不同意 5 退回
        /// </summary>
        public int InstanceResult { get; set; } = 0;
        public string UnitId { get; set; } = string.Empty;

        /// <summary>
        /// 实例备注
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// 当前节点执行人
        /// </summary>
        public string MakerList { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public List<string> Verifier { get; set; } = new List<string>();
    }
}
