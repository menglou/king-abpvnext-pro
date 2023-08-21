namespace King.AbpVnextPro.WorkFlow;

public static class WorkFlowDbProperties
{
    public static string DbTablePrefix { get; set; } = "WorkFlow";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "WorkFlow";
}
