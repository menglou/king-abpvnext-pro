

namespace King.AbpVnextPro.CAP;
public static class AbpVnextProCapServiceCollectionExtensions
{
    public static ServiceConfigurationContext AddAbpCap(this ServiceConfigurationContext context, Action<CapOptions> capAction)
    {
        context.Services.Replace(ServiceDescriptor.Transient<IUnitOfWork, AbpVnextProCapUnitOfWork>());
        context.Services.Replace(ServiceDescriptor.Transient<UnitOfWork, AbpVnextProCapUnitOfWork>());
        context.Services.AddTransient<AbpVnextProCapUnitOfWork>();
        context.Services.AddCap(capAction);
        return context;
    }
}