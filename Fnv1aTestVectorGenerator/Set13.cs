// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Set13.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an implementation for performing test vector set 13 generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.IO;

    /// <inheritdoc />
    /// <summary>
    /// Provides an implementation for performing test vector set 13 generation.
    /// </summary>
    /// <seealso cref="T:Fnv1aTestVectorGenerator.ISet" />
    internal sealed class Set13 : SetBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="Set13"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set13(TextWriter writer = null) : base(writer)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs the test vector set 13 generation.
        /// </summary>
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
    }
}
