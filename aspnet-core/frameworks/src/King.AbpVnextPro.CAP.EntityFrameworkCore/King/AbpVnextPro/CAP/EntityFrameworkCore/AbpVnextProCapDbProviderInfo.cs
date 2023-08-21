
namespace King.AbpVnextPro.CAP.EntityFrameworkCore;
public class AbpVnextProCapDbProviderInfo
{
    public Type CapTransactionType { get; }
    
    public Type CapEfDbTransactionType { get; }
    
    public AbpVnextProCapDbProviderInfo(string capTransactionTypeName, string capEfDbTransactionTypeName)
    {
        CapTransactionType = Type.GetType(capTransactionTypeName, false);
        CapEfDbTransactionType = Type.GetType(capEfDbTransactionTypeName, false);
    }
}