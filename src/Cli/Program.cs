using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Encodings.Web; // Додано для налаштування кодування

Console.OutputEncoding = System.Text.Encoding.UTF8;

if (args.Contains("--json"))
{
    var info = new
    {
        Student = "Перепелиця Устим-Олег Анатолійович, ФЕІ-35",
        OSDescription = RuntimeInformation.OSDescription,
        Environment = Environment.OSVersion.ToString(),
        ProcessArchitecture = RuntimeInformation.ProcessArchitecture.ToString(),
        DotNetVersion = Environment.Version.ToString(),
        Runtime = RuntimeInformation.FrameworkDescription,
        BaseDirectory = AppContext.BaseDirectory,
        CurrentDirectory = Environment.CurrentDirectory,
        Domain = "Склад (товари, партії, залишки, переміщення)"
    };
    
    // Налаштування для читабельної кирилиці та гарного форматування
    var options = new JsonSerializerOptions 
    { 
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true // Робить JSON багаторядковим і читабельним
    };
    
    Console.WriteLine(JsonSerializer.Serialize(info, options));
}
else
{
    // Стандартний вивід таблицею
    Console.WriteLine("CrossApp - практикум з крос-платформного програмування");
    Console.WriteLine("Студент: Перепелиця Устим-Олег Анатолійович, група ФЕІ-35");
    Console.WriteLine(new string('-', 52));
    Console.WriteLine($"OC (OSDescription): {RuntimeInformation.OSDescription}");
    Console.WriteLine($"OC (Environment)  : {Environment.OSVersion}");
    Console.WriteLine($"Архітектура процесу: {RuntimeInformation.ProcessArchitecture}");
    Console.WriteLine($"Версія .NET (CLR): {Environment.Version}");
    Console.WriteLine($"Runtime           : {RuntimeInformation.FrameworkDescription}");
    Console.WriteLine($"Каталог застосунку: {AppContext.BaseDirectory}");
    Console.WriteLine($"Поточний каталог  : {Environment.CurrentDirectory}");
    Console.WriteLine(new string('-', 52));
    Console.WriteLine("Предметна область: Склад (товари, партії, залишки, переміщення)");
}