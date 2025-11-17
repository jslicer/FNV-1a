// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BenchmarkConfig.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Overrides the default BenchmarkDotNet configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aBenchmarks;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;

/// <summary>
/// Overrides the default BenchmarkDotNet configuration.
/// </summary>
/// <seealso cref="BenchmarkDotNet.Configs.ManualConfig" />
#pragma warning disable CA1515 // Consider making public types internal
public sealed class BenchmarkConfig : ManualConfig
#pragma warning restore CA1515 // Consider making public types internal
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BenchmarkConfig" /> class.
    /// </summary>
    public BenchmarkConfig()
    {
        AddLogger(ConsoleLogger.Default);

        // produces GitHub-ready markdown
        AddExporter(MarkdownExporter.GitHub);

        // write result files to repo root
        WithArtifactsPath(".");
    }
}