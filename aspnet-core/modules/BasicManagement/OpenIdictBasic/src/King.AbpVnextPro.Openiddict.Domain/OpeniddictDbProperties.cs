namespace King.AbpVnextPro.Openiddict;

public static class OpeniddictDbProperties
{
    public static string DbTablePrefix { get; set; } = "Openiddict";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Openiddict";
}
