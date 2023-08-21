namespace King.AbpVnextPro.Cli;
public class AbpCliOptions
{
    public Dictionary<string, Type> Commands { get; }

    /// <summary>
    /// Default value: "king.abp".
    /// </summary>
    public string ToolName { get; set; } = "king.abp";

    public AbpCliOptions()
    {
        Commands = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
    }
}