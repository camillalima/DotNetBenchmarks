using BenchmarkDotNet.Running;
using DotNetBenchmarks;

var summary = BenchmarkRunner.Run<JSON>(new CustomConfig());

