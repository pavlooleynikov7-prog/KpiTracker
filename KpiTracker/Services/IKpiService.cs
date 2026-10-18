using KpiTracker.Models;

namespace KpiTracker.Services;

/// <summary>
/// Абстракція джерела даних KPI. У ЛР №1 — реалізація в пам'яті,
/// у ЛР №3 її буде замінено реалізацією з базою даних без змін у ViewModel.
/// </summary>
public interface IKpiService
{
    IReadOnlyList<KpiRecord> GetAll();
    void Add(KpiRecord record);
    bool Remove(Guid id);
}
