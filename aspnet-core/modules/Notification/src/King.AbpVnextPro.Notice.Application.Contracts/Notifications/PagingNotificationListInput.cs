using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Notice.Notifications
{
    public class PagingNotificationListInput : PagedAndSortedResultRequestDto
    {
        //0 代表正常 1 代表关闭
        public int Status { get; set; }

        public string Title { get; set; }
    }
}
