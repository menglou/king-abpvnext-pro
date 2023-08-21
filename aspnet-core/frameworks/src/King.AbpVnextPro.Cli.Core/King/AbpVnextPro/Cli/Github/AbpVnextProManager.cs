

namespace King.AbpVnextPro.Cli.Github;

public class AbpVnextProManager : ITransientDependency, IAbpVnextProManager
{
    private readonly AbpVnextProCliOptions _cliOptions;
    private readonly IHttpClientFactory _httpClientFactory;

    public AbpVnextProManager(IOptions<AbpVnextProCliOptions> options, IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _cliOptions = options.Value;
    }

    /// <summary>
    /// 获取最后一个版本
    /// </summary>
    public async Task<string> GetLatestSourceCodeVersionAsync()
    {
        var github = new GitHubClient(new ProductHeaderValue(_cliOptions.RepositoryId))
        {
            // 匿名访问，api会限流，所以需要设置访问令牌
            Credentials = new Credentials(_cliOptions.DecryptToken)
        };

        var release = await github.Repository.Release.GetLatest(_cliOptions.Owner, _cliOptions.RepositoryId);
        return release?.TagName;
    }

    /// <summary>
    /// 检查版本是否存在
    /// </summary>
    public async Task<bool> CheckSourceCodeVersionAsync(string version)
    {
        try
        {
            var github = new GitHubClient(new ProductHeaderValue(_cliOptions.RepositoryId))
            {
                // 匿名访问，api会限流，所以需要设置访问令牌
                Credentials = new Credentials(_cliOptions.DecryptToken)
            };

            var release = await github.Repository.Release.Get(_cliOptions.Owner, _cliOptions.RepositoryId, version);
            return release != null;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 下载源码
    /// </summary>
    public async Task<byte[]> DownloadAsync(string version, string outputPath)
    {
        var httpClient = _httpClientFactory.CreateClient();
        //设置超时时间5分钟
        httpClient.Timeout = new TimeSpan(0, 5, 0);
        var uri = new Uri($"https://github.com/{_cliOptions.Owner}/{_cliOptions.RepositoryId}/archive/refs/tags/{version}.zip");
        //var uri = new Uri($"https://gitee.com/zljlm/{_cliOptions.RepositoryId}/archive/refs/tags/{version}.zip");
        var response = await httpClient.GetAsync(uri);
        DirectoryHelper.CreateIfNotExists(CliPaths.TemplateCache);
        var content = await response.Content.ReadAsByteArrayAsync();
        response.Dispose();
        File.Delete(outputPath);
        await File.WriteAllBytesAsync(outputPath, content);
        return content;
    }
}