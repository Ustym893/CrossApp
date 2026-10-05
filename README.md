# CrossApp

Наскрізний проєкт з крос-платформного програмування.

## Предметна область: Склад

Сутності: Product (товар), StockBatch (партія), Warehouse (склад), Movement (переміщення).

Призначення: облік залишків товарів по партіях.

## Запуск

```bash
dotnet build
dotnet run --project src/Cli
```

Вивід у форматі JSON (додаткове завдання):

```bash
dotnet run --project src/Cli -- --json
```

## Середовище

.NET SDK 10.0.401, macOS (Apple M3), RID: osx-arm64, Visual Studio Code