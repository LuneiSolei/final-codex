namespace FinalCodex.XivApi.Query.Clauses;

/// <summary>
/// Represents the clause(s) in an XivApi query.
///     - Simple: a direct field/op/value expression.
///     - Decorated: a clause prefixed with + or -.
///     - Group: a parenthesized collection of clauses.
/// </summary>
public abstract class XivApiClause
{
    /// <summary>
    /// Must match for a result to be returned.
    /// </summary>
    public XivApiClause Must() => new DecoratedClause(this, "+");

    /// <summary>
    /// Excludes any result matching this clause.
    /// </summary>
    public XivApiClause MustNot() => new DecoratedClause(this, "-");

    /// <summary>
    /// Groups multiple clauses in parentheses, e.g. +(Foo=1 Bar~2)
    /// </summary>
    /// <param name="clauses">List of clauses to be grouped.</param>
    public XivApiClause Group(params XivApiClause[] clauses) =>
        new GroupClause(clauses);
}