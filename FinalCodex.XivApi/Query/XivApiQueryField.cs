using System.Text;
using FinalCodex.XivApi.Query.Clauses;

namespace FinalCodex.XivApi.Query;

public class XivApiQueryField(string _path, string? _lang, string? _arrayIndex)
{
    public XivApiQueryField Dot(string child) =>
        new ($"{_path}.{child}", _lang, _arrayIndex);

    public XivApiQueryField WithLanguage(string lang) =>
        new (_path, lang, _arrayIndex);

    public XivApiQueryField AsArray() =>
        new (_path, _lang, "");

    public XivApiQueryField AtIndex(int index) =>
        new (_path, _lang, index.ToString());

    public override string ToString()
    {
        StringBuilder builder = new(_path);
        if (_lang is not null) builder.Append($"{_lang}");
        if (_arrayIndex is not null) builder.Append($"{_arrayIndex}");
        
        return builder.ToString();
    }

    public XivApiClause PartiallyMatches(string value) =>
        new SimpleClause(this, "~", $"\"{value}\"");

    public XivApiClause EqualTo(string value) =>
        new SimpleClause(this, "=", $"\"{value}\"");

    public XivApiClause EqualTo(double value) =>
        new SimpleClause(this, "=", value.ToString());
    
    public XivApiClause EqualTo(bool value) =>
        new SimpleClause(this, "=", value ? "true" : "false");

    public XivApiClause GreaterThan(double value) =>
        new SimpleClause(this, ">", value.ToString());

    public XivApiClause GreaterThanOrEqualTo(double value) =>
        new SimpleClause(this, ">=", value.ToString());

    public XivApiClause LessThan(double value) =>
        new SimpleClause(this, "<", value.ToString());

    public XivApiClause LessThanOrEqualTo(double value) =>
        new SimpleClause(this, "<=", value.ToString());
}