using AutoMapper;
using King.AbpVnextPro.Dictionary.DataDictionarys;
using King.AbpVnextPro.Dictionary.DataDictionarys.Dto;

namespace King.AbpVnextPro.Dictionary;

public class DictionaryApplicationAutoMapperProfile : Profile
{
    public DictionaryApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<DataDictionary, DictionaryDto>()
           .MapExtraProperties();

        CreateMap<DataDictionaryDetail, DictionaryDetailDto>()
            .MapExtraProperties();
    }
}
