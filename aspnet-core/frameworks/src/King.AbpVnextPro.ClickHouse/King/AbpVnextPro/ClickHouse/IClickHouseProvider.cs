﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ClickHouse.King.AbpVnextPro.ClickHouse
{
    public  interface IClickHouseProvider
    {
        IFreeSql GetClient();
    }
}
