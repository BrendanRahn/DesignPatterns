using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterators;

namespace Iterator.Glyphs
{
    public class CircleGlyph : IGlyph
    {
        private string _circleDisplay;
        public CircleGlyph()
        {
            var builder = new StringBuilder();
            builder.Append("    __\n");
            builder.Append("  |    |\n");
            builder.Append("|        |\n");
            builder.Append("|        |\n");
            builder.Append("  | __ |\n");
            _circleDisplay = builder.ToString();
        }

        public IIterator CreateIterator()
        {
            return new NullIterator();
        }

        public string Display()
        {
            return _circleDisplay;
        }
    }
}
