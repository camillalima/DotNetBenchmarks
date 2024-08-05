using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows;

namespace DotNetBenchmarks;

public class CustomConfig : ManualConfig
{
    public CustomConfig()
    {
        AddLogger(DefaultConfig.Instance.GetLoggers().ToArray());
        AddExporter(DefaultConfig.Instance.GetExporters().ToArray());
        AddColumnProvider(DefaultConfig.Instance.GetColumnProviders().ToArray());
        AddDiagnoser(MemoryDiagnoser.Default);
        AddDiagnoser(new InliningDiagnoser());
        AddDiagnoser(ExceptionDiagnoser.Default);
    }
}