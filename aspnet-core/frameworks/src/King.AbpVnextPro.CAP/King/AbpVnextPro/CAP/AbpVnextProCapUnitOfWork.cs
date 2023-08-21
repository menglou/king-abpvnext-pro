using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Uow;

namespace King.AbpVnextPro.CAP;

[Dependency(TryRegister = true)]
public class AbpVnextProCapUnitOfWork : UnitOfWork
{
    public ICapTransaction CapTransaction { get; protected set; }

    protected ICapPublisher CapPublisher { get; }

    public AbpVnextProCapUnitOfWork(
        IServiceProvider serviceProvider,
        IUnitOfWorkEventPublisher unitOfWorkEventPublisher,
        IOptions<AbpUnitOfWorkDefaultOptions> options,
        ICapPublisher capPublisher)
        : base(serviceProvider, unitOfWorkEventPublisher, options)
    {
        CapPublisher = capPublisher;
    }

    public override void AddTransactionApi(string key, ITransactionApi api)
    {
        var factories = ServiceProvider.GetServices<IAbpVnextProCapTransactionApiFactory>();

        var factory = factories.FirstOrDefault(x => x.TransactionApiType == api.GetType());

        if (factory is not null)
        {
            api = factory.Create(api);
            CapTransaction = CapPublisher.Transaction.Value;
        }
        
        base.AddTransactionApi(key, api);
    }

    public override ITransactionApi GetOrAddTransactionApi(string key, Func<ITransactionApi> factory)
    {
        Check.NotNull(key, nameof(key));
        Check.NotNull(factory, nameof(factory));

        var transactionApi = FindTransactionApi(key);

        if (transactionApi is not null)
        {
            return transactionApi;
        }
        
        AddTransactionApi(key, factory());

        return FindTransactionApi(key);
    }
}