using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    public class LinkedListIterator : IIterator
    {
        private LinkedList<IGlyph> _children;
        private LinkedListNode<IGlyph> _current;
        public LinkedListIterator(LinkedList<IGlyph> children)
        {
            _children = children;
        }
        public void First()
        {
            _current = _children.First;
        }
        public void Next()
        {
            _current = _current.Next;
        }
        public bool IsDone()
        {
            return _current == null;
        }
        public IGlyph GetCurrent()
        {
            return _current.Value;
        }
        public void Insert(IGlyph glyph)
        {
            _children.AddAfter(_current, glyph);
        }
    }
}
