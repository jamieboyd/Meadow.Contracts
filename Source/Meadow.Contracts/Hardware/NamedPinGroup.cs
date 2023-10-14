namespace Meadow.Hardware
{
    /// <summary>
    /// NamedPinGroup class
    /// </summary>
    public class NamedPinGroup
    {
        /// <summary>
        /// The name property of the <see cref="NamedPinGroup"/> class.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The Pins array property of the <see cref="NamedPinGroup"/> class.
        /// </summary>
        public IPin[] Pins { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedPinGroup"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pins"></param>
        public NamedPinGroup(string name, IPin[] pins)
        {
            this.Name = name;
            this.Pins = pins;
        }

        /// <summary>
        /// Returns the Name of the <see cref="NamedPinGroup"/> object.
        /// </summary>
        /// <returns>The Name of the <see cref="NamedPinGroup"/> object.</returns>
        public override string ToString() => Name;

        /// <summary>
        /// => operator overload for the IPin[] array.
        /// </summary>
        public static implicit operator IPin[](NamedPinGroup namedPinGroup) => namedPinGroup.Pins;
    }
}
