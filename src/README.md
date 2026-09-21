# CrossApp
Наскрізний проєкт з крос-платформного програмування.

Предметна область: Склад. Сутності: Product (товар), StockBatch (партія), Warehouse (склад), Movement (переміщення).
Призначення: облік залишків товарів по партіях.

## Запуск
Стандартний вивід:
dotnet build
dotnet run --project src/Cli

Вивід у форматі JSON (додаткове завдання):
dotnet run --project src/Cli -- --json

## Середовище
.NET SDK 10.0, macOS, Visual Studio Code