using System.Numerics;
using System.Runtime.CompilerServices;
using System.Web;
using FinalCodex.XivApi.Core;
using FinalCodex.XivApi.Core.Enums;
using FinalCodex.XivApi.Infrastructure.Request.Clause.Steps;

[assembly: InternalsVisibleTo(assemblyName: "FinalCodex.Tests")]
namespace FinalCodex.XivApi.Infrastructure.Request.Clause;

/// <summary>
/// Builds the specific query parameter used by XIV API in the url string.
/// This does <b>NOT</b> represent the actual query of the url. This query
/// string contains an ordered list of clauses and parameters, in which both
/// have operators, joined by an ampersand (&).
/// </summary>
/// <remarks>
/// <b>Parameter (param)</b> - Single key-value pair.
/// <b>Clause</b> - Logical grouping/condition built from one or more
/// parameters.
/// <b>Operator (op)</b> - Symbol representing a specific operation
/// (=, ~, +, -, etc.)
/// </remarks>
public class ClauseBuilder : IInitialClauseBuilderStep, IConditionStep, IOperatorStep, 
    IValueStep
{
    private string _name = string.Empty;
    private ClauseConditionals _conditionals;
    private ClauseOperators _operator;
    private string? _strValue;
    private bool? _boolValue;

    // WhereField Step
    public IConditionStep WhereField(string name)
    {
        _name = name;
        
        return this;
    }
    
    // Condition Step
    public IOperatorStep Is()
    {
        _conditionals = ClauseConditionals.Is; 
        
        return this;
    }

    public IOperatorStep IsNot()
    {
        _conditionals = ClauseConditionals.IsNot; 
        
        return this;
    }

    // Operator Step
    public IValueStep PartiallyEqualTo()
    {
        _operator = ClauseOperators.PartiallyEqualTo; 
        
        return this;
    }

    public IValueStep EqualTo()
    {
        _operator = ClauseOperators.EqualTo;
        
        return this;
    }

    public IValueStep GreaterThan()
    {
        _operator = ClauseOperators.GreaterThan;
        
        return this;
    }

    public IValueStep GreaterThanOrEqualTo()
    {
        _operator = ClauseOperators.GreaterThanOrEqualTo;
        
        return this;
    }

    public IValueStep LessThan()
    {
        _operator = ClauseOperators.LessThan;
        
        return this;
    }

    public IValueStep LessThanOrEqualTo()
    {
        _operator = ClauseOperators.LessThanOrEqualTo;
        
        return this;
    }
    
    // Value Step
    public string Value(string value)
    {
        _strValue = value;

        return ToString();
    }

    public string Value(bool value)
    {
        _boolValue = value;
        
        return ToString();
    }
    
    public string Value<T>(T value) where T : INumber<T>
    {
        return ToString(value);
    }

    private string CreateBase()
    {
        // Start with conditional
        string result = _conditionals == ClauseConditionals.Is 
            ? string.Empty 
            : "-";
        
        // Add specifier
        result += $"{_name}";

        // Add operator
        result += Utilities.ToOperatorSign(_operator);

        return result;
    }

    private string ToString<T>(T value) where T : INumber<T>
    {
        // Create common base
        string result = CreateBase();
        
        // Add value
        result += value.ToString();

        // Encode result
        return HttpUtility.UrlEncode(result);
    }

    public override string ToString()
    {
        // Create common base
        string result = CreateBase();

        result += (_strValue, _boolValue) switch
        {
            (not null, _) => _strValue.Replace(' ', '+'),
            (null, not null) => _boolValue.ToString(),
            _ => string.Empty
        };
        
        // Encode result

        return result;
    }
}