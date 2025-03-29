using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal interface IGlyph
    {
        List<IGlyph> Children { get; }
        string Value { get; }
    }
}
