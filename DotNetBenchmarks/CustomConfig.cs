using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;

namespace DotNetBenchmarks;

public class CustomConfig : ManualConfig
{
    public CustomConfig()
    {
        Add(DefaultConfig.Instance.GetLoggers().ToArray());
        Add(DefaultConfig.Instance.GetExporters().ToArray());
        Add(DefaultConfig.Instance.GetColumnProviders().ToArray());
        Add(MemoryDiagnoser.Default);
        Add(new InliningDiagnoser());
        //Add(ThreadingDiagnoser.Default);
        Add(ExceptionDiagnoser.Default);
    }
}