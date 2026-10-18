using System.Globalization;
using KpiTracker.Models;

namespace KpiTracker.Helpers;

/// <summary>Перетворює статус KPI на колір індикатора.</summary>
public class KpiStatusToColorConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        value switch
        {
            KpiStatus.Achieved => Color.FromArgb("#2E7D32"),
            KpiStatus.AtRisk => Color.FromArgb("#F9A825"),
            KpiStatus.Failed => Color.FromArgb("#C62828"),
            _ => Colors.Gray
        };

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}

/// <summary>Перетворює статус KPI на текстову мітку українською.</summary>
public class KpiStatusToTextConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        value switch
        {
            KpiStatus.Achieved => "Виконано",
            KpiStatus.AtRisk => "Під загрозою",
            KpiStatus.Failed => "Не виконано",
            _ => string.Empty
        };

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
