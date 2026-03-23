using System.Numerics;
using Microsoft.AspNetCore.Components;

namespace FinalCodex.WebApp.Components.Filters;

public partial class MinMaxFilter<T> where T : struct, INumber<T>
{
    /// <summary>The value for the input</summary>
    [Parameter] public required T MinBind { get; set; }
    
    /// <summary>The value for the input</summary>
    [Parameter] public required T MaxBind { get; set; }

    /// <summary>The minimum allowed input value.</summary>
    /// <remarks>Defaults to 0.</remarks>
    [Parameter] public T Min { get; set; } = T.Zero;

    /// <summary>The maximum allowed input value.</summary>
    /// <remarks>Defaults to 100.</remarks>
    [Parameter] public T Max { get; set; } = (T)(object)100;
    
    /// <summary>The text to display above the inputs.</summary>
    [Parameter] public string? Label { get; set; }

    /// <summary>
    /// A number representing how much the value changes on each move of the
    /// slider.
    /// </summary>
    /// <remarks>Defaults to 1.</remarks>
    [Parameter] public T Step { get; set; } = (T)(object)1;
}