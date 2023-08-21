namespace King.AbpVnextPro.CAP;

public static class AbpVnextProCapPublisherExtension
{
    public static IDisposable UseTransaction(this ICapPublisher capPublisher, ICapTransaction capTransaction)
    {
        var previousValue = capPublisher.Transaction.Value;
        capPublisher.Transaction.Value = capTransaction;
        return new DisposeAction(() => capPublisher.Transaction.Value = previousValue);
    }
}