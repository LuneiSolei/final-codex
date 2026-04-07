using System.Numerics;

namespace FinalCodex.XivApi.Infrastructure.Request.Clause.Steps;

public interface IValueStep
{
    string Value(string value);
    string Value(bool value);
    string Value<T>(T value) where T : INumber<T>;
}