// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Contains the entry point of the application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;
using static System.Text.Encoding;

/// <summary>
/// Contains the entry point of the application.
/// </summary>
public static class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The number of characters in the next line is larger
    /// than <see cref="int.MaxValue" />.</exception>
    /// <exception cref="ObjectDisposedException">The text reader has been disposed.</exception>
    /// <exception cref="InvalidOperationException">The reader is currently in use by a previous read
    /// operation.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    public static async Task Main()
    {
        TextWriter writer = TextWriter.Null; ////Out;
        TextReader reader = TextReader.Null; ////In;

        using CancellationTokenSource cts = new();
        cts.Token.ThrowIfCancellationRequested();
        await ProcessAsync(writer, cts.Token).ConfigureAwait(true);
        cts.Token.ThrowIfCancellationRequested();
        await reader.ReadLineAsync(cts.Token).ConfigureAwait(true);
    }

    /// <summary>
    /// Processes test vectors.
    /// </summary>
    /// <param name="writer">The writer.</param>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    // ReSharper disable once MethodTooLong
    private static async Task ProcessAsync(TextWriter? writer = null, CancellationToken token = default)
    {
        writer ??= TextWriter.Null;

        ISet[] sets =
        [
            new Set0(writer),
            new Set1(writer),
            new Set2(writer),
            new Set3(writer),
            new Set4(writer),
            new Set5(writer),
            new Set6(writer),
            new Set7(writer),
            new Set8(writer),
            new Set9(writer),
            new Set10(writer),
            new Set11(writer),
            new Set12(writer),
            new Set13(writer),
            new Set14(writer),
            new Set15(writer),
        ];

        OutputEncoding = UTF8;
        for (int loop = 0; loop < 1000; loop++)
        {
            foreach (ISet set in sets)
            {
                // ReSharper disable once AsyncConverter.CanBeUseAsyncMethodHighlighting
                // ReSharper disable once MethodHasAsyncOverload
                // ReSharper disable once MethodHasAsyncOverloadWithCancellation
#pragma warning disable S6966 // Awaitable method should be used
                set.Perform();
#pragma warning restore S6966 // Awaitable method should be used
            }
        }

        for (int loop = 0; loop < 1000; loop++)
        {
            token.ThrowIfCancellationRequested();
            foreach (ISet set in sets)
            {
                token.ThrowIfCancellationRequested();
                await set.PerformAsync(token).ConfigureAwait(true);
            }
        }
    }
}
