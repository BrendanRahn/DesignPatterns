using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Iterators;

namespace Iterator.Glyphs
{
    public class RectangleGlyph : IGlyph
    {
        private string _rectangleDisplay;
        public RectangleGlyph()
        {
            var builder = new StringBuilder();
            builder.Append("----\n");
            builder.Append("|  |\n");
            builder.Append("----\n");
            _rectangleDisplay = builder.ToString();
        }

        public IIterator CreateIterator()
        {
            return new NullIterator();
        }

        public string Display()
        {
            return _rectangleDisplay;
        }
    }
}
