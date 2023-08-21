namespace King.AbpVnextPro.File;

public static class FileDbProperties
{
    public static string DbTablePrefix { get; set; } = "File";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "File";
}
