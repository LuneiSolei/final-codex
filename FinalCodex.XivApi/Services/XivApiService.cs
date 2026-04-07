using FinalCodex.XivApi.Core.Options;
using FinalCodex.XivApi.Infrastructure.Request;
using FinalCodex.XivApi.Infrastructure.Request.Clause;
using FinalCodex.XivApi.Infrastructure.Request.Clause.Steps;
using Microsoft.Extensions.Options;

namespace FinalCodex.XivApi.Services;

public class XivApiService(IOptions<XivApiOptions> opts, HttpClient _client)
{
    private readonly XivApiOptions _opts = opts.Value;

    public RequestBuilder NewRequestBuilder()
    {
        return new RequestBuilder(_opts);
    }

    public static IInitialClauseBuilderStep NewClause()
    {
        return new ClauseBuilder();
    }
}

/*
 * XivApiService.CreateSearchRequest(_opts) <- Returns a RequestBuilder()
 * internal abstract class RequestBuilder(Options opts) { <- Inherited by, for example, SearchSheet class
 *      SubQuery? SubQuery <- UrlEncoded XIV API query clauses.
 * 
 *      public override string ToString() {
 *          
 *      }
 * }
 *
 * internal sealed class ClauseBuilder {
 *      List<Clause> _clauses = [];
 *      public SubQuery Add(Clause clause) {
 *          _clauses.Add(clause)
 *          return this;
 *      }
 * }
 *
 * public sealed class SearchSheet(Options opts) : RequestBuilder(Options opts) {
 *      public override string ToString() {
 *          return $"{opts.Scheme}://{opts.BaseUrl}/{opts.Endpoints.Search}" +
 *                 $"?{SubQuery}";
 *      }
 * }
 */