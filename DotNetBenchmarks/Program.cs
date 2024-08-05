using BenchmarkDotNet.Running;
using DotNetBenchmarks;

_ = BenchmarkRunner.Run<JSON>(new CustomConfig());

