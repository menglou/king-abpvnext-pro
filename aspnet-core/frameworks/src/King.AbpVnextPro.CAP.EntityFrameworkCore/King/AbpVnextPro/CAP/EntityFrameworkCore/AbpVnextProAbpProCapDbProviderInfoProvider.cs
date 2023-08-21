

namespace King.AbpVnextPro.CAP.EntityFrameworkCore;


public class AbpVnextProAbpProCapDbProviderInfoProvider : IAbpVnextProCapDbProviderInfoProvider, ITransientDependency
{
    protected ConcurrentDictionary<string, AbpVnextProCapDbProviderInfo> CapDbProviderInfos { get; set; } = new();

    public virtual AbpVnextProCapDbProviderInfo GetOrNull(string dbProviderName)
    {
        return CapDbProviderInfos.GetOrAdd(dbProviderName, InternalGetOrNull);
    }
    
    protected virtual AbpVnextProCapDbProviderInfo InternalGetOrNull(string databaseProviderName)
    {
        switch (databaseProviderName)
        {
            case "Microsoft.EntityFrameworkCore.SqlServer":
                return new AbpVnextProCapDbProviderInfo(
                    "DotNetCore.CAP.SqlServerCapTransaction, DotNetCore.CAP.SqlServer",
                    "Microsoft.EntityFrameworkCore.Storage.CapEFDbTransaction, DotNetCore.CAP.SqlServer");
            case "Npgsql.EntityFrameworkCore.PostgreSQL":
                return new AbpVnextProCapDbProviderInfo(
                    "DotNetCore.CAP.PostgreSqlCapTransaction, DotNetCore.CAP.PostgreSql",
                    "Microsoft.EntityFrameworkCore.Storage.CapEFDbTransaction, DotNetCore.CAP.PostgreSQL");
            case "Pomelo.EntityFrameworkCore.MySql":
                return new AbpVnextProCapDbProviderInfo(
                    "DotNetCore.CAP.MySqlCapTransaction, DotNetCore.CAP.MySql",
                    "Microsoft.EntityFrameworkCore.Storage.CapEFDbTransaction, DotNetCore.CAP.MySql");
            case "Oracle.EntityFrameworkCore":
            case "Devart.Data.Oracle.Entity.EFCore":
                return new AbpVnextProCapDbProviderInfo(
                    "DotNetCore.CAP.OracleCapTransaction, DotNetCore.CAP.Oracle",
                    "Microsoft.EntityFrameworkCore.Storage.CapEFDbTransaction, DotNetCore.CAP.Oracle");
            case "Microsoft.EntityFrameworkCore.Sqlite":
                return new AbpVnextProCapDbProviderInfo(
                    "DotNetCore.CAP.SqliteCapTransaction, DotNetCore.CAP.Sqlite",
                    "Microsoft.EntityFrameworkCore.Storage.CapEFDbTransaction, DotNetCore.CAP.Sqlite");
            case "Microsoft.EntityFrameworkCore.InMemory":
                return new AbpVnextProCapDbProviderInfo(
                    "DotNetCore.CAP.InMemoryCapTransaction, DotNetCore.CAP.InMemoryStorage",
                    "Microsoft.EntityFrameworkCore.Storage.CapEFDbTransaction, DotNetCore.CAP.InMemoryStorage");
            default:
                return null;
        }
    }
}