using System;

namespace Prototype.ShallowClone
{
    /// <summary>
    /// Parent class.
    /// </summary>
    public class Guitar : ICloneable
    {
        /// <summary>
        /// Guitar name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Guitar price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Reference to class GuitarInfo.
        /// </summary>
        public GuitarInfo GuitarInfo { get; set; }

        public Guitar(string name, int price, GuitarInfo guitarInfo)
        {
            Name = name;
            Price = price;
            GuitarInfo = guitarInfo;
        }

        /// <summary>
        /// A shallow copy copies all reference types or value types,
        /// but it does not copy the objects that the references refer to.
        /// The references in the new object point to the same objects that the references in the original object points to.
        /// </summary>
        /// <returns> Only Parent Object is cloned here. </returns>
        public object Clone() => MemberwiseClone();

        /// <summary>
        /// In contrast, a deep copy of an object copies the elements
        /// and everything directly or indirectly referenced by the elements.
        /// </summary>
        /// <returns> Parent Object is cloned along with the containing objects. </returns>
        public object DeepCopy()
        {
            // Shallow copy.
            Guitar clone = MemberwiseClone() as Guitar;

            // Copy reference type.
            clone.GuitarInfo = new GuitarInfo(GuitarInfo.NumberOfString, GuitarInfo.Color);

            return clone;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nColor: {GuitarInfo.Color}\nStrings: {GuitarInfo.NumberOfString}";
        }
    }
}