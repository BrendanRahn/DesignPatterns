using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterators;

namespace Iterator.Glyphs
{
    public class LinkedListGlyph : IGlyph
    {
        private LinkedList<IGlyph> _children { get; set; }

        public LinkedListGlyph(LinkedList<IGlyph> children)
        {
            _children = children;
        }
        public IIterator CreateIterator()
        {
            return new LinkedListIterator(_children);
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
