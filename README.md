# KPI Tracker — трекер виконання KPI співробітників відділу

Лабораторна робота №1 з дисципліни «Технології розробки мобільних додатків на C#».
Варіант 8: **Трекер виконання KPI співробітників відділу**.

Кросплатформний застосунок на **.NET MAUI (.NET 8)**, побудований за патерном **MVVM**
з використанням **CommunityToolkit.Mvvm**. Дані зберігаються в пам'яті
(збереження в БД з'явиться в ЛР №3).

## Можливості

- список показників KPI (співробітник, показник, план, факт, % виконання, статус);
- кольорова індикація: ≥ 100 % — виконано, 70–99 % — під загрозою, < 70 % — не виконано;
- форма додавання показника з валідацією (кнопка неактивна, доки поля не заповнені);
- видалення показника, очищення форми;
- підсумки по відділу: кількість показників, кількість виконаних, середній % виконання.

## Структура

```
KpiTracker/
├── Models/          KpiRecord, KpiStatus — сутність предметної області
├── ViewModels/      MainViewModel (ObservableObject, RelayCommand)
├── Views/           MainPage.xaml — головний екран
├── Services/        IKpiService, InMemoryKpiService — джерело даних
├── Helpers/         NumberParser, конвертери статусу у колір/текст
├── Resources/       стилі, кольори, іконка, splash
├── Platforms/       Android, iOS, MacCatalyst, Windows
├── MauiProgram.cs   реєстрація Service, ViewModel і View у DI
└── AppShell.xaml    навігація (Shell)
```

## Запуск

Потрібно: .NET 8 SDK, робоче навантаження MAUI, Android SDK / емулятор.

```bash
dotnet workload install maui
dotnet build KpiTracker/KpiTracker.csproj -f net8.0-android
dotnet build KpiTracker/KpiTracker.csproj -t:Run -f net8.0-android   # запуск на емуляторі
```

Або відкрийте `KpiTracker.sln` у Visual Studio 2022 (17.8+) / Rider і запустіть на Android Emulator.

## Журнал взаємодії з LLM

Див. [PROMPTS.md](PROMPTS.md).
