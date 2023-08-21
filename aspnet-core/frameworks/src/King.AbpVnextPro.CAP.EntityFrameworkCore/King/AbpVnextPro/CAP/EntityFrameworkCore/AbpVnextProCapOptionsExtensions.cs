


namespace King.AbpVnextPro.CAP.EntityFrameworkCore;
public static class AbpVnextProCapOptionsExtensions
{
    public static CapOptions SetCapDbConnectionString(this CapOptions options, string dbConnectionString)
    {
        options.RegisterExtension(new AbpVnextProEfCoreDbContextCapOptionsExtension
        {
            CapUsingDbConnectionString = dbConnectionString
        });

        return options;
    }
}
