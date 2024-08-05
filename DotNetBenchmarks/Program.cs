using BenchmarkDotNet.Running;
using DotNetBenchmarks;

_ = BenchmarkRunner.Run<JsonBenchmark>(new CustomConfig());