namespace KpiTracker.Models;

/// <summary>
/// Сутність предметної області: показник KPI конкретного співробітника за період.
/// </summary>
public class KpiRecord
{
    public Guid Id { get; init; } = Guid.NewGuid();

    /// <summary>ПІБ співробітника.</summary>
    public string EmployeeName { get; set; } = string.Empty;

    /// <summary>Назва показника (наприклад, «Закриті угоди»).</summary>
    public string MetricName { get; set; } = string.Empty;

    /// <summary>Планове (цільове) значення показника.</summary>
    public double TargetValue { get; set; }

    /// <summary>Фактично досягнуте значення.</summary>
    public double ActualValue { get; set; }

    /// <summary>Перший день звітного періоду (місяця).</summary>
    public DateTime Period { get; set; } = new(DateTime.Today.Year, DateTime.Today.Month, 1);

    /// <summary>Відсоток виконання плану (0..∞).</summary>
    public double CompletionPercent =>
        TargetValue <= 0 ? 0 : Math.Round(ActualValue / TargetValue * 100, 1);

    /// <summary>Частка виконання для ProgressBar (обмежена 0..1).</summary>
    public double Progress => Math.Clamp(CompletionPercent / 100.0, 0, 1);

    /// <summary>Текстовий статус виконання.</summary>
    public KpiStatus Status => CompletionPercent switch
    {
        >= 100 => KpiStatus.Achieved,
        >= 70 => KpiStatus.AtRisk,
        _ => KpiStatus.Failed
    };
}

public enum KpiStatus
{
    Achieved,
    AtRisk,
    Failed
}
