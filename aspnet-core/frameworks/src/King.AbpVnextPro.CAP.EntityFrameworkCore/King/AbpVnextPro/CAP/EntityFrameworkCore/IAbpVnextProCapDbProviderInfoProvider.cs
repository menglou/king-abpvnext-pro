
namespace King.AbpVnextPro.CAP.EntityFrameworkCore;
public interface IAbpVnextProCapDbProviderInfoProvider
{
    AbpVnextProCapDbProviderInfo GetOrNull(string dbProviderName);
}