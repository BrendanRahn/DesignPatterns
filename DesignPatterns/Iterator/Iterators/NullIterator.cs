using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    public class NullIterator : IIterator
    {
        public void First()
        {
        }
        public void Next()
        {
        }
        public bool IsDone()
        {
            return true;
        }
        public IGlyph GetCurrent()
        {
            return null;
        }
        public void Insert(IGlyph glyph)
        {
        }
    }
}
