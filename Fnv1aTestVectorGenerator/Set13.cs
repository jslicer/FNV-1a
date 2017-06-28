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

    /// <summary>
    /// Provides an implementation for performing test vector set 13 generation.
    /// </summary>
    /// <seealso cref="ISet" />
    internal sealed class Set13 : ISet
    {
        /// <summary>
        /// The writer.
        /// </summary>
        private readonly TextWriter _Writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Set13"/> class.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public Set13(TextWriter writer = null)
        {
            this._Writer = writer ?? TextWriter.Null;
        }

        /// <summary>
        /// Performs the test vector set 13 generation.
        /// </summary>
        public void Perform()
        {
            this._Writer.WriteLine("http://antwrp.gsfc.nasa.gov/apod/astropix.html".Test());
            this._Writer.WriteLine("http://en.wikipedia.org/wiki/Fowler_Noll_Vo_hash".Test());
            this._Writer.WriteLine("http://epod.usra.edu/".Test());
            this._Writer.WriteLine("http://exoplanet.eu/".Test());
            this._Writer.WriteLine("http://hvo.wr.usgs.gov/cam3/".Test());
            this._Writer.WriteLine("http://hvo.wr.usgs.gov/cams/HMcam/".Test());
            this._Writer.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/deformation.html".Test());
            this._Writer.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/images.html".Test());
            this._Writer.WriteLine("http://hvo.wr.usgs.gov/kilauea/update/maps.html".Test());
            this._Writer.WriteLine("http://hvo.wr.usgs.gov/volcanowatch/current_issue.html".Test());
            this._Writer.WriteLine("http://neo.jpl.nasa.gov/risk/".Test());
            this._Writer.WriteLine("http://norvig.com/21-days.html".Test());
            this._Writer.WriteLine("http://primes.utm.edu/curios/home.php".Test());
            this._Writer.WriteLine("http://slashdot.org/".Test());
            this._Writer.WriteLine("http://tux.wr.usgs.gov/Maps/155.25-19.5.html".Test());
            this._Writer.WriteLine("http://volcano.wr.usgs.gov/kilaueastatus.php".Test());
            this._Writer.WriteLine("http://www.avo.alaska.edu/activity/Redoubt.php".Test());
            this._Writer.WriteLine("http://www.dilbert.com/fast/".Test());
            this._Writer.WriteLine("http://www.fourmilab.ch/gravitation/orbits/".Test());
            this._Writer.WriteLine("http://www.fpoa.net/".Test());
            this._Writer.WriteLine("http://www.ioccc.org/index.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/cgi-bin/number.cgi".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/bio.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/index.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/src/calc/lucas-calc".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/astro/venus2004.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/astro/vita.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/comp/c/expert.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/comp/calc/index.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/comp/fnv/index.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/math/number/howhigh.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/math/number/number.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html".Test());
            this._Writer.WriteLine("http://www.isthe.com/chongo/tech/math/prime/mersenne.html#largest".Test());
            this._Writer.WriteLine("http://www.lavarnd.org/cgi-bin/corpspeak.cgi".Test());
            this._Writer.WriteLine("http://www.lavarnd.org/cgi-bin/haiku.cgi".Test());
            this._Writer.WriteLine("http://www.lavarnd.org/cgi-bin/rand-none.cgi".Test());
            this._Writer.WriteLine("http://www.lavarnd.org/cgi-bin/randdist.cgi".Test());
            this._Writer.WriteLine("http://www.lavarnd.org/index.html".Test());
            this._Writer.WriteLine("http://www.lavarnd.org/what/nist-test.html".Test());
            this._Writer.WriteLine("http://www.macosxhints.com/".Test());
            this._Writer.WriteLine("http://www.mellis.com/".Test());
            this._Writer.WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/havoalert.cfm".Test());
            this._Writer.WriteLine("http://www.nature.nps.gov/air/webcams/parks/havoso2alert/timelines_24.cfm".Test());
            this._Writer.WriteLine("http://www.paulnoll.com/".Test());
            this._Writer.WriteLine("http://www.pepysdiary.com/".Test());
            this._Writer.WriteLine("http://www.sciencenews.org/index/home/activity/view".Test());
            this._Writer.WriteLine("http://www.skyandtelescope.com/".Test());
            this._Writer.WriteLine("http://www.sput.nl/~rob/sirius.html".Test());
            this._Writer.WriteLine("http://www.systemexperts.com/".Test());
            this._Writer.WriteLine("http://www.tq-international.com/phpBB3/index.php".Test());
            this._Writer.WriteLine("http://www.travelquesttours.com/index.htm".Test());
            this._Writer.WriteLine("http://www.wunderground.com/global/stations/89606.html".Test());
        }
    }
}
