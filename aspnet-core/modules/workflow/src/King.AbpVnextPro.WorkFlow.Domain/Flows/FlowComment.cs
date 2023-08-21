using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    /// <summary>
    /// 评论
    /// </summary>
    public class FlowComment : FullAuditedEntity<Guid>, IMultiTenant
    {
        /// <summary>
        /// 实例id
        /// </summary>
        public Guid InstanceId { get; set; }
        /// <summary>
        /// 评论人姓名  方便读取
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// 评论节点id
        /// </summary>
        public string CommentNodeId { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 附件 json串
        /// </summary>
        public string Attachment { get; set; }
        /// <summary>
        /// 被@人  [{id:"xxxx",name:"xxxxx"}]
        /// </summary>
        public string Users { get; set; }
        public Guid? TenantId { get; set; }
    }
}
