namespace Prototype.ShallowClone
{
    /// <summary>
    /// Reference class.
    /// </summary>
    public class GuitarInfo
    {
        /// <summary>
        /// Number of strings.
        /// </summary>
        public int NumberOfString { get; set; }

        /// <summary>
        /// Color.
        /// </summary>
        public string Color { get; set; }

        public GuitarInfo(int numberOfString, string color)
        {
            NumberOfString = numberOfString;
            Color = color;
        }
    }
}