namespace BlazingTrails.Client;

public static class CoreExtensions
{
    public static bool GreaterThanZero(this int value) => value > 0;

    public static bool Contains(this string str, string value, bool ignoreCase) =>
        str.Contains(value, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
}