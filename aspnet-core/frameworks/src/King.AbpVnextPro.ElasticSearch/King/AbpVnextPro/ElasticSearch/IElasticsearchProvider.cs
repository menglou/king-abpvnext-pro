
namespace  King.AbpVnextPro.ElasticSearch;


public interface IElasticsearchProvider
{
    IElasticClient GetClient();
}