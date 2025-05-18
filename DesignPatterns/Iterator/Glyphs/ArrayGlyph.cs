using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterators;

namespace Iterator.Glyphs
{
    public class ArrayGlyph : IGlyph
    {
        private List<IGlyph> _children { get; set; }

        public ArrayGlyph(List<IGlyph> children)
        {
            _children = children;
        }

        public IIterator CreateIterator()
        {
            return new ArrayIterator(_children);
        }
        public string Display()
        {
            var result = new StringBuilder();
            foreach (var child in _children)
            {
                result.Append(child.Display());
            }
            return result.ToString();
        }
    }
}
