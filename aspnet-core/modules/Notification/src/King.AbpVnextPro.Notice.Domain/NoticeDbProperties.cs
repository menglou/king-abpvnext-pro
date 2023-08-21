namespace King.AbpVnextPro.Notice;

public static class NoticeDbProperties
{
    public static string DbTablePrefix { get; set; } = "Notice";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Notice";
}
