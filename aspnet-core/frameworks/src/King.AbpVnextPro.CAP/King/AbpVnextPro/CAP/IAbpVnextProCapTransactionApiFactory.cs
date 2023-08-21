namespace King.AbpVnextPro.CAP;

public interface IAbpVnextProCapTransactionApiFactory
{
    Type TransactionApiType { get; }
    
    ITransactionApi Create(ITransactionApi originalApi);
}