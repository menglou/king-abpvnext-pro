using King.AbpVnextPro.Institution.Departments;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace King.AbpVnextPro.Institution.Posters
{
    public interface IPosterRepository: IBasicRepository<Poster, Guid>
    {
    }
}
