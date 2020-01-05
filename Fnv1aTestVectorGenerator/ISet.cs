// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISet.cs" company="Always Elucidated Solution Pioneers, LLC">
//   Copyright © Always Elucidated Solution Pioneers, LLC 2017
// </copyright>
// <summary>
//   Provides an definition for performing test vector set generation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fnv1aTestVectorGenerator
{
    using System.Threading.Tasks;

    /// <summary>
    /// Provides an definition for performing test vector set generation.
    /// </summary>
    internal interface ISet
    {
        /// <summary>
        /// Performs the test vector set generation.
        /// </summary>
        void Perform();

        /// <summary>
        /// Asynchronously performs the test vector set generation.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/>.</returns>
        Task PerformAsync();
    }
}
