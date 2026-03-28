using FinalCodex.XivApi.Query.Clauses;

namespace FinalCodex.XivApi.Query;

/// <summary>
/// Query builder that contains an ordered list of clauses joined by whitespace.
/// </summary>
/// <remarks>
/// Multiple clauses default to OR semantics (match at least one). This can be
/// overridden per clause with Must()/MustNot().
/// </remarks>
public class XivApiQueryBuilder
{
    private readonly List<XivApiClause> _clauses = [];

    public XivApiQueryBuilder Add(XivApiClause clause)
    {
        _clauses.Add(clause);
        return this;
    }

    public override string ToString() => string.Join(" ", _clauses);
}