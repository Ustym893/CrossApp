using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

const string student = "Перепелиця Устим-Олег Анатолійович, група ФЕІ-35";
const string domain = "Склад (товари, партії, залишки, переміщення)";

if (args.Contains("--json"))
{
    var info = new
    {
        App = "CrossApp",
        Student = student,
        OSDescription = RuntimeInformation.OSDescription,
        OSVersion = Environment.OSVersion.ToString(),
        ProcessArchitecture = RuntimeInformation.ProcessArchitecture.ToString(),
        ClrVersion = Environment.Version.ToString(),
        Runtime = RuntimeInformation.FrameworkDescription,
        BaseDirectory = AppContext.BaseDirectory,
        CurrentDirectory = Environment.CurrentDirectory,
        Domain = domain
    };

    var options = new JsonSerializerOptions
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping // читабельна кирилиця
    };

    Console.WriteLine(JsonSerializer.Serialize(info, options)); // один рядок
    return;
}

Console.WriteLine("CrossApp – практикум з крос-платформного програмування");
Console.WriteLine($"Студент: {student}");
Console.WriteLine(new string('-', 52));
Console.WriteLine($"ОС (OSDescription)  : {RuntimeInformation.OSDescription}");
Console.WriteLine($"ОС (Environment)    : {Environment.OSVersion}");
Console.WriteLine($"Архітектура процесу : {RuntimeInformation.ProcessArchitecture}");
Console.WriteLine($"Версія .NET (CLR)   : {Environment.Version}");
Console.WriteLine($"Runtime             : {RuntimeInformation.FrameworkDescription}");
Console.WriteLine($"Каталог застосунку  : {AppContext.BaseDirectory}");
Console.WriteLine($"Поточний каталог    : {Environment.CurrentDirectory}");
Console.WriteLine(new string('-', 52));
Console.WriteLine($"Предметна область: {domain}");