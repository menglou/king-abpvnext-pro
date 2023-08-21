using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.WorkFlow.Flows.FlowDesigns
{
    /// <summary>
    /// 流程实例模型
    /// </summary>
    public class FlowInstanceModel
    {

        /// <summary>
        /// 节点id
        /// </summary>
        public string PkId { get; set; }
        /// <summary>
        /// 节点名称 
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// 节点类型  0 开始 1审核 2 抄送 3 条件 4路由(条件节点父级) 5财务审核 6单据签收 7出纳支付 99 结束节点
        /// </summary>
        public int Type { get; set; } = 0;

        /// <summary>
        /// 优先级
        /// </summary>
        public string PriorityLevel { get; set; }

        /// <summary>
        /// 审核人类型 1 指定成员 2上级主管 4发起人自选 8项目负责人 9指定角色 10 来自单据
        /// </summary> 
        public int SetType { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int SelectMode { get; set; } = 0;
        /// <summary>
        /// 选择范围 1 全公司 2 指定成员 3 指定角色
        /// </summary>
        public int SelectRange { get; set; } = 0;

        /// <summary>
        /// 审批角色
        /// </summary>
        public string ExamineRoleId { get; set; }

        /// <summary>
        /// 主管级数
        /// </summary>
        public int DirectorLevel { get; set; } = 0;

        public string ReplaceByUp { get; set; }
        /// <summary>
        /// 多人审批时采用的审批方式  1或签 2会签 
        /// </summary>
        public int ExamineMode { get; set; } = 0;
        /// <summary>
        /// 找不到审批人时 1 转系统管理员 2 自动审批/不允许发起
        /// </summary>
        public int NoHanderAction { get; set; } = 0;
        /// <summary>
        /// 审批结束主管级数
        /// </summary>
        public int ExamineEndDirectorLevel { get; set; } = 0;

        /// <summary>
        /// 抄送配置
        /// </summary>
        public string ccSelfSelectFlag { get; set; }

        /// <summary>
        /// 选择的项目
        /// </summary>
        public string SelectProject { get; set; }
        /// <summary>
        /// 选择的票据中的人员
        /// </summary>
        public string SelectBill { get; set; }
        /// <summary>
        /// 1 满足条件 2 不满足其它条件
        /// </summary>
        public int ConditionModel { get; set; } = 0;
        /// <summary>
        /// 分工方案编码
        /// </summary>
        public string DivisionSchemeId { get; set; }

        /// <summary>
        /// 条件
        /// </summary>
        public List<ConditionGroup> ConditionList { get; set; } = new List<ConditionGroup>();
        /// <summary>
        /// 节点可操作用户
        /// </summary>
        public List<NodeUser> NodeUserList { get; set; } = new List<NodeUser>();

        /// <summary>
        /// 子节点
        /// </summary>
        public dynamic ChildNode { get; set; }
        /// <summary>
        /// 条件节点
        /// </summary>
        public dynamic ConditionNodes { get; set; }
        /// <summary>
        /// 自动审批通过
        /// </summary>
        public int AutoPass { get; set; } = 0;
        /// <summary>
        /// 每个节点字段的权限
        /// </summary>
        public List<ColnumPermission> ColnumPermissions { get; set; } = new List<ColnumPermission> { };


    }


    /// <summary>
    /// 流程节点
    /// </summary>
    public class FlowNodeDto
    {

        /// <summary>
        /// 节点id
        /// </summary>
        public string PkId { get; set; }
        /// <summary>
        /// 节点名称 
        /// </summary>
        public string NodeName { get; set; } = string.Empty;
        /// <summary>
        /// 节点类型  0 开始 1审核 2 抄送 3 条件 4路由(条件节点父级) 99 结束节点
        /// </summary>
        public int Type { get; set; } = 0;
        /// <summary>
        /// 父节点id
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        public string PriorityLevel { get; set; }

        /// <summary>
        /// 审核人类型 1 指定成员 2部门主管 4发起人自选 8项目负责人 9指定角色 10 来自单据 11 全部出纳 12 分工
        /// </summary> 
        public int SetType { get; set; } = 0;
        /// <summary>
        /// 选择模式 
        /// </summary>
        public int SelectMode { get; set; } = 0;
        /// <summary>
        /// 选择范围 1 全公司 2 指定成员 3 指定角色
        /// </summary>
        public int SelectRange { get; set; } = 0;

        /// <summary>
        /// 审批角色
        /// </summary>
        public string ExamineRoleId { get; set; }

        /// <summary>
        /// 主管级数
        /// </summary>
        public int DirectorLevel { get; set; } = 0;

        public string ReplaceByUp { get; set; }
        /// <summary>
        /// 多人审批时采用的审批方式  1或签 2会签 
        /// </summary>
        public int ExamineMode { get; set; } = 0;
        /// <summary>
        /// 找不到审批人时 1 转系统管理员 2 自动审批/不允许发起
        /// </summary>
        public int NoHanderAction { get; set; } = 0;
        /// <summary>
        /// 审批结束主管级数
        /// </summary>
        public int ExamineEndDirectorLevel { get; set; } = 0;

        /// <summary>
        /// 抄送配置
        /// </summary>
        public string CcSelfSelectFlag { get; set; }

        /// <summary>
        /// 选择的项目
        /// </summary>
        public string SelectProject { get; set; }
        /// <summary>
        /// 选择的票据中的人员
        /// </summary>
        public string SelectBill { get; set; }
        /// <summary>
        /// 1 满足条件 2 不满足其它条件
        /// </summary>
        public int ConditionModel { get; set; } = 0;

        /// <summary>
        /// 分工方案编码
        /// </summary>
        public string DivisionSchemeId { get; set; }

        /// <summary>
        /// 自动审批通过
        /// </summary>
        public int AutoPass { get; set; } = 0;
        /// <summary>
        /// 每个节点字段的权限
        /// </summary>
        public List<ColnumPermission> ColnumPermissions { get; set; } = new List<ColnumPermission> { };
        /// <summary>
        /// 条件
        /// </summary>
        public List<ConditionGroup> ConditionList { get; set; } = new List<ConditionGroup>();
        /// <summary>
        /// 节点可操作用户
        /// </summary>
        public List<NodeUser> NodeUserList { get; set; } = new List<NodeUser>();

    }

    /// <summary>
    /// 节点可操作
    /// </summary>
    public class NodeUser
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("targetid")]
        public string TargetId { get; set; }

        /// <summary>
        /// 类型 type: 1 指定部门  2 指定人员  3指定角色
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Relation
    {
        public const string And = "&";
        public const string Or = "|";
        public const string Larger = ">";
        public const string Less = "<";
        public const string LargerEqual = ">=";
        public const string LessEqual = "<=";
        public const string NotEqual = "!=";
        public const string Equal = "=";
        public const string Contains = "belong";
        public const string NotContains = "notbelong";

    }

    public class ConditionGroup
    {
        /// <summary>
        /// 1 普通条件  2 条件组
        /// </summary>
        public int ConditionType { get; set; }
        /// <summary>
        /// 1 满足条件 2 不满足其它条件
        /// </summary>
        public int Model { get; set; }

        /// <summary>操作类型比如大于/等于/小于</summary>
        public dynamic Relation { get; set; }

        /// <summary> form种的字段名称 </summary>
        public dynamic Field { get; set; }

        /// <summary> 字段类型："form"：为表单中的字段，后期扩展系统表等. </summary>
        public string ObjType { get; set; } = string.Empty;

        /// <summary>比较的值</summary>
        public dynamic Value { get; set; }

        public dynamic Children { get; set; }
    }

    public class ColnumPermission
    {

        public string Model { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Show { get; set; }
        /// <summary>
        /// 是否可编辑
        /// </summary>
        public bool Enabled { get; set; }
    }

    /// <summary>
    /// 条件
    /// </summary>
    public class Condition
    {

        /// <summary>
        /// 1 普通条件  2 条件组
        /// </summary>
        public int ConditionType { get; set; }

        /// <summary>
        /// 1 满足条件 2 不满足其它条件
        /// </summary>
        public int Model { get; set; }
        /// <summary>操作类型比如大于/等于/小于</summary>
        public dynamic Relation { get; set; }

        /// <summary> form种的字段名称 </summary>
        public dynamic Field { get; set; }

        /// <summary> 字段类型："form"：为表单中的字段，后期扩展系统表等. </summary>
        public string ObjType { get; set; }

        /// <summary>比较的值</summary>
        public dynamic Value { get; set; }
    }


    /// <summary>
    /// 节点执行结果标签
    /// </summary>
    public class Tag
    {
        /// <summary>
        ///  1: 通过
        ///  2：不通过
        ///  3：驳回
        /// </summary>
        public int Taged { get; set; }
        /// <summary>
        /// 审批节点id
        /// </summary>
        public string ActivityNodeId { get; set; }
        public string Description { get; set; }
        public string Attacth { get; set; }
    }

    /// <summary>
    /// 分工明细
    /// </summary>
    public class DivisionSchemDetail
    {

        public string Id { get; set; }

        public string Name { get; set; }

        public dynamic Conditions { get; set; }
        public dynamic Users { get; set; }
        public bool IsDefault { get; set; }


    }

    public class DivisionSchemUser
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }




    /// <summary>
    ///  1: 通过
    ///  2：不通过
    ///  3：驳回
    /// </summary>
    public enum TagState
    {
        Ok = 1,
        No,
        Reject
    }
}
