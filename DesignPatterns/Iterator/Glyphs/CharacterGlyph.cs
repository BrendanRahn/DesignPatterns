using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterators;

namespace Iterator.Glyphs
{
    public class CharacterGlyph : IGlyph
    {
        public char Value { get; set; }

        public CharacterGlyph(char value)
        {
            Value = value;
        }
        public IIterator CreateIterator()
        {
            return new NullIterator();
        }

        public string Display()
        {
            return Value.ToString();
        }
    }
}
