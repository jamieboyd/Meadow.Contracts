namespace Meadow;

using Meadow.Hardware;
using System.Collections.Generic;

public sealed class PinMapping : List<PinMapping.PinAlias>
{
    public class PinAlias
    {
        public PinAlias(string name, IPin connectsTo)
        {
            PinName = name;
            ConnectsTo = connectsTo;
        }

        public string PinName { get; set; }
        public IPin ConnectsTo { get; set; }
    }
}
