using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using DotNetBenchmarks;


var summary = BenchmarkRunner.Run<JSON>(new CustomConfig());

