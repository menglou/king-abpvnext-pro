using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.Notice.Notifications
{
    public static class EfCoreNotificationQueryableExtensions
    {
        public static IQueryable<Notification> IncludeDetails(this IQueryable<Notification> queryable, bool include = true)
        {
            return !include ? queryable : queryable.Include(e => e.NotificationSubscriptions);
        }
    }
}
