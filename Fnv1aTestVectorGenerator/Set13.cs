// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set13.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 13 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

/// <inheritdoc cref="SetBase" />
/// <summary>
/// Provides an implementation for performing test vector set 13 generation.
/// </summary>
/// <param name="writer">The writer.</param>
/// <seealso cref="ISet" />
internal sealed class Set13(TextWriter? writer = null) : SetBase(writer)
{
    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Performs the test vector set 13 generation.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    // ReSharper disable once MethodTooLong
    public override void Perform()
    {
        WriteLine("http://antwrp.gsfc.nasa.gov/apod/astropix.html".Test());
        WriteLine("http://en.wikipedia.org/wiki/Fowler_Noll_Vo_hash".Test());
        WriteLine("http://epod.usra.edu/".Test());
        WriteLine("http://exoplanet.eu/".Test());
        WriteLine("http://hvo.wr.usgs.gov/cam3/".Test());
        WriteLine("http://hvo.wr.usgs.gov/cams/HMcam/".Test());
        WriteLine("http://hvo.wr.usgs.gov/kilauea/update/deformation.html".Test());
        WriteLine("http://hvo.wr.usgs.gov/kilauea/update/images.html".Test());
        WriteLine("http://hvo.wr.usgs.gov/kilauea/update/maps.html".Test());
        WriteLine("http://hvo.wr.usgs.gov/volcanowatch/current_issue.html".Test());
        WriteLine("http://neo.jpl.nasa.gov/risk/".Test());
        WriteLine("http://norvig.com/21-days.html".Test());
        WriteLine("http://primes.utm.edu/curios/home.php".Test());
        WriteLine("http://slashdot.org/".Test());
        WriteLine("http://tux.wr.usgs.gov/Maps/155.25-19.5.html".Test());
        WriteLine("http://volcano.wr.usgs.gov/kilaueastatus.php".Test());
        WriteLine("http://www.avo.alaska.edu/activity/Redoubt.php".Test());
        WriteLine("http://www.dilbert.com/fast/".Test());
        WriteLine("http://www.fourmilab.ch/gravitation/orbits/".Test());
        WriteLine("http://www.fpoa.net/".Test());
        WriteLine("http://www.ioccc.org/index.html".Test());
        WriteLine("http://www.isthe.com/cgi-bin/number.cgi".Test());
        WriteLine("http://www.isthe.com/chongo/bio.html".Test());
        WriteLine("http://www.isthe.com/chongo/index.html".Test());
        WriteLine("http://www.isthe.com/chongo/src/calc/lucas-calc".Test());
        WriteLine("http://www.isthe.com/chongo/tech/astro/venus2004.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/astro/vita.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/comp/c/expert.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/comp/calc/index.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/comp/fnv/index.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/math/number/howhigh.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/math/number/number.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html".Test());
        WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html#largest".Test());
        WriteLine("http://www.lavarnd.org/cgi-bin/corpspeak.cgi".Test());
        WriteLine("http://www.lavarnd.org/cgi-bin/haiku.cgi".Test());
        WriteLine("http://www.lavarnd.org/cgi-bin/rand-none.cgi".Test());
        WriteLine("http://www.lavarnd.org/cgi-bin/randdist.cgi".Test());
        WriteLine("http://www.lavarnd.org/index.html".Test());
        WriteLine("http://www.lavarnd.org/what/nist-test.html".Test());
        WriteLine("http://www.macosxhints.com/".Test());
        WriteLine("http://www.mellis.com/".Test());
        WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/havoalert.cfm".Test());
        WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/timelines_24.cfm".Test());
        WriteLine("http://www.paulnoll.com/".Test());
        WriteLine("http://www.pepysdiary.com/".Test());
        WriteLine("http://www.sciencenews.org/index/home/activity/view".Test());
        WriteLine("http://www.skyandtelescope.com/".Test());
        WriteLine("http://www.sput.nl/~rob/sirius.html".Test());
        WriteLine("http://www.systemexperts.com/".Test());
        WriteLine("http://www.tq-international.com/phpBB3/index.php".Test());
        WriteLine("http://www.travelquesttours.com/index.htm".Test());
        WriteLine("http://www.wunderground.com/global/stations/89606.html".Test());
    }

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Asynchronously performs the test vector set 13 generation.
    /// </summary>
    /// <param name="token">The optional cancellation token.</param>
    /// <returns>An asynchronous <see cref="Task" />.</returns>
    /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
    /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
    /// <exception cref="OperationCanceledException">The operation was canceled.</exception>
    // ReSharper disable once MethodTooLong
    public override async Task PerformAsync(CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://antwrp.gsfc.nasa.gov/apod/astropix.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://en.wikipedia.org/wiki/Fowler_Noll_Vo_hash".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://epod.usra.edu/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://exoplanet.eu/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://hvo.wr.usgs.gov/cam3/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://hvo.wr.usgs.gov/cams/HMcam/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://hvo.wr.usgs.gov/kilauea/update/deformation.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://hvo.wr.usgs.gov/kilauea/update/images.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://hvo.wr.usgs.gov/kilauea/update/maps.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://hvo.wr.usgs.gov/volcanowatch/current_issue.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://neo.jpl.nasa.gov/risk/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://norvig.com/21-days.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://primes.utm.edu/curios/home.php".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://slashdot.org/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://tux.wr.usgs.gov/Maps/155.25-19.5.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://volcano.wr.usgs.gov/kilaueastatus.php".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.avo.alaska.edu/activity/Redoubt.php".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.dilbert.com/fast/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.fourmilab.ch/gravitation/orbits/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.fpoa.net/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.ioccc.org/index.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/cgi-bin/number.cgi".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/bio.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/index.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/src/calc/lucas-calc".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/astro/venus2004.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/astro/vita.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/comp/c/expert.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/comp/calc/index.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/comp/fnv/index.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/number/howhigh.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/number/number.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/prime/mersenne.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/prime/mersenne.html#largest".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/corpspeak.cgi".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/haiku.cgi".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/rand-none.cgi".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/randdist.cgi".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.lavarnd.org/index.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.lavarnd.org/what/nist-test.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.macosxhints.com/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.mellis.com/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.nature.nps.gov/air/webcams/parks/havoso2alert/havoalert.cfm".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.nature.nps.gov/air/webcams/parks/havoso2alert/timelines_24.cfm".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.paulnoll.com/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.pepysdiary.com/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.sciencenews.org/index/home/activity/view".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.skyandtelescope.com/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.sput.nl/~rob/sirius.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.systemexperts.com/".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.tq-international.com/phpBB3/index.php".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.travelquesttours.com/index.htm".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
        token.ThrowIfCancellationRequested();
        await WriteLineAsync(await "http://www.wunderground.com/global/stations/89606.html".TestAsync(token).ConfigureAwait(false), token).ConfigureAwait(true);
    }
}
