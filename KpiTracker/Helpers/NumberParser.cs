using System.Globalization;

namespace KpiTracker.Helpers;

/// <summary>
/// Розбір чисел, введених користувачем, незалежно від роздільника («,» або «.»).
/// </summary>
public static class NumberParser
{
    public static bool TryParseNonNegative(string? text, out double value)
    {
        value = 0;
        if (string.IsNullOrWhiteSpace(text))
            return false;

        var normalized = text.Trim().Replace(',', '.');
        return double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out value)
               && value >= 0
               && !double.IsInfinity(value);
    }
}
