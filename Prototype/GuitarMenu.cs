using System.Collections.Generic;

namespace Prototype.ShallowClone
{
    /// <summary>
    /// Guitar menu.
    /// </summary>
    public class GuitarMenu
    {
        /// <summary>
        /// Collection of guitars.
        /// </summary>
        private readonly Dictionary<string, Guitar> _guitars = new Dictionary<string, Guitar>();

        /// <summary>
        /// Indexer.
        /// </summary>
        /// <param name="name"> Way to access elements. </param>
        public Guitar this[string name]
        {
            get => _guitars[name];
            set => _guitars.Add(name, value);
        }
    }
}