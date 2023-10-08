// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set13.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright (c) Always Elucidated Solution Pioneers, LLC. All rights reserved.
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 13 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// Ignore Spelling: Fnv
namespace Fnv1aTestVectorGenerator
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    /// <inheritdoc cref="SetBase" />
    /// <summary>
    /// Provides an implementation for performing test vector set 13 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set13 : SetBase
    {
        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set13" /> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set13(TextWriter writer = null)
            : base(writer)
        {
            // Intentionally empty.
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Performs the test vector set 13 generation.
        /// </summary>
        /// <exception cref="IOException">An I/O error occurs.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        // ReSharper disable once MethodTooLong
        public override void Perform()
        {
            this.WriteLine("http://antwrp.gsfc.nasa.gov/apod/astropix.html".Test());
            this.WriteLine("http://en.wikipedia.org/wiki/Fowler_Noll_Vo_hash".Test());
            this.WriteLine("http://epod.usra.edu/".Test());
            this.WriteLine("http://exoplanet.eu/".Test());
            this.WriteLine("http://hvo.wr.usgs.gov/cam3/".Test());
            this.WriteLine("http://hvo.wr.usgs.gov/cams/HMcam/".Test());
            this.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/deformation.html".Test());
            this.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/images.html".Test());
            this.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/maps.html".Test());
            this.WriteLine("http://hvo.wr.usgs.gov/volcanowatch/current_issue.html".Test());
            this.WriteLine("http://neo.jpl.nasa.gov/risk/".Test());
            this.WriteLine("http://norvig.com/21-days.html".Test());
            this.WriteLine("http://primes.utm.edu/curios/home.php".Test());
            this.WriteLine("http://slashdot.org/".Test());
            this.WriteLine("http://tux.wr.usgs.gov/Maps/155.25-19.5.html".Test());
            this.WriteLine("http://volcano.wr.usgs.gov/kilaueastatus.php".Test());
            this.WriteLine("http://www.avo.alaska.edu/activity/Redoubt.php".Test());
            this.WriteLine("http://www.dilbert.com/fast/".Test());
            this.WriteLine("http://www.fourmilab.ch/gravitation/orbits/".Test());
            this.WriteLine("http://www.fpoa.net/".Test());
            this.WriteLine("http://www.ioccc.org/index.html".Test());
            this.WriteLine("http://www.isthe.com/cgi-bin/number.cgi".Test());
            this.WriteLine("http://www.isthe.com/chongo/bio.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/index.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/src/calc/lucas-calc".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/astro/venus2004.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/astro/vita.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/comp/c/expert.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/comp/calc/index.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/comp/fnv/index.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/math/number/howhigh.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/math/number/number.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html".Test());
            this.WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html#largest".Test());
            this.WriteLine("http://www.lavarnd.org/cgi-bin/corpspeak.cgi".Test());
            this.WriteLine("http://www.lavarnd.org/cgi-bin/haiku.cgi".Test());
            this.WriteLine("http://www.lavarnd.org/cgi-bin/rand-none.cgi".Test());
            this.WriteLine("http://www.lavarnd.org/cgi-bin/randdist.cgi".Test());
            this.WriteLine("http://www.lavarnd.org/index.html".Test());
            this.WriteLine("http://www.lavarnd.org/what/nist-test.html".Test());
            this.WriteLine("http://www.macosxhints.com/".Test());
            this.WriteLine("http://www.mellis.com/".Test());
            this.WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/havoalert.cfm".Test());
            this.WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/timelines_24.cfm".Test());
            this.WriteLine("http://www.paulnoll.com/".Test());
            this.WriteLine("http://www.pepysdiary.com/".Test());
            this.WriteLine("http://www.sciencenews.org/index/home/activity/view".Test());
            this.WriteLine("http://www.skyandtelescope.com/".Test());
            this.WriteLine("http://www.sput.nl/~rob/sirius.html".Test());
            this.WriteLine("http://www.systemexperts.com/".Test());
            this.WriteLine("http://www.tq-international.com/phpBB3/index.php".Test());
            this.WriteLine("http://www.travelquesttours.com/index.htm".Test());
            this.WriteLine("http://www.wunderground.com/global/stations/89606.html".Test());
        }

        /// <inheritdoc cref="SetBase" />
        /// <summary>
        /// Asynchronously performs the test vector set 13 generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        /// <exception cref="InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        /// <exception cref="ObjectDisposedException">The <see cref="TextWriter" /> is closed.</exception>
        // ReSharper disable once MethodTooLong
        public override async Task PerformAsync()
        {
            await this.WriteLineAsync(await "http://antwrp.gsfc.nasa.gov/apod/astropix.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://en.wikipedia.org/wiki/Fowler_Noll_Vo_hash".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://epod.usra.edu/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://exoplanet.eu/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://hvo.wr.usgs.gov/cam3/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://hvo.wr.usgs.gov/cams/HMcam/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://hvo.wr.usgs.gov/kilauea/update/deformation.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://hvo.wr.usgs.gov/kilauea/update/images.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://hvo.wr.usgs.gov/kilauea/update/maps.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://hvo.wr.usgs.gov/volcanowatch/current_issue.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://neo.jpl.nasa.gov/risk/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://norvig.com/21-days.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://primes.utm.edu/curios/home.php".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://slashdot.org/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://tux.wr.usgs.gov/Maps/155.25-19.5.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://volcano.wr.usgs.gov/kilaueastatus.php".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.avo.alaska.edu/activity/Redoubt.php".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.dilbert.com/fast/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.fourmilab.ch/gravitation/orbits/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.fpoa.net/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.ioccc.org/index.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/cgi-bin/number.cgi".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/bio.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/index.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/src/calc/lucas-calc".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/astro/venus2004.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/astro/vita.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/comp/c/expert.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/comp/calc/index.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/comp/fnv/index.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/number/howhigh.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/number/number.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/prime/mersenne.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.isthe.com/chongo/tech/math/prime/mersenne.html#largest".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/corpspeak.cgi".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/haiku.cgi".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/rand-none.cgi".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.lavarnd.org/cgi-bin/randdist.cgi".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.lavarnd.org/index.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.lavarnd.org/what/nist-test.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.macosxhints.com/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.mellis.com/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.nature.nps.gov/air/webcams/parks/havoso2alert/havoalert.cfm".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.nature.nps.gov/air/webcams/parks/havoso2alert/timelines_24.cfm".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.paulnoll.com/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.pepysdiary.com/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.sciencenews.org/index/home/activity/view".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.skyandtelescope.com/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.sput.nl/~rob/sirius.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.systemexperts.com/".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.tq-international.com/phpBB3/index.php".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.travelquesttours.com/index.htm".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
            await this.WriteLineAsync(await "http://www.wunderground.com/global/stations/89606.html".TestAsync().ConfigureAwait(false)).ConfigureAwait(false);
        }
    }
}
