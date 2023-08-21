namespace King.AbpVnextPro.ScheduleTask;

public static class ScheduleTaskDbProperties
{
    public static string DbTablePrefix { get; set; } = "ScheduleTask";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ScheduleTask";
}
