using AutoMapper;
using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.Posters;

namespace King.AbpVnextPro.Institution;

public class InstitutionApplicationAutoMapperProfile : Profile
{
    public InstitutionApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<DepartmentUnit, DepartmentUnitDto>().MapExtraProperties();
        CreateMap<Poster, PosterDto>();
    }
}
