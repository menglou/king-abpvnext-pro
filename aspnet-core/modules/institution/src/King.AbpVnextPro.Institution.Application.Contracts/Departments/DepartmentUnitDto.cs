﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace King.AbpVnextPro.Institution.Departments
{
    public class DepartmentUnitDto: ExtensibleFullAuditedEntityDto<Guid>, IMultiTenant, IHasConcurrencyStamp
    {
        public DepartmentUnitDto()
        {
            Children = new List<DepartmentUnitDto>();
        }

        public Guid? TenantId { get; set; }

        public string ConcurrencyStamp { get; set; }

        public virtual Guid? ParentId { get; set; }

        public virtual string Code { get; set; }

        public virtual string DisplayName { get; set; }

        public int Level => GetLevel(Code);

        public virtual bool IsLeaf { get; set; }

        public List<DepartmentUnitDto> Children { get; set; }

        private int GetLevel(string code)
        {
            return Code.Split('.').Length;
        }

        public void SetLeaf()
        {
            IsLeaf = true;
        }
    }
}
