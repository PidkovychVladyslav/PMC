using System;

namespace PMC
{
    /// <summary>
    /// Class to create a collection of containers
    /// </summary>
    public class Creator
    {
        /// <summary>
        /// Method to create a collection
        /// </summary>
        /// <typeparam name="TCreation">The type of collection.</typeparam>
        /// <returns></returns>
        public TCreation Create<TCreation>() where TCreation : class, new()
        {
            return new TCreation();
        }
    }
}
