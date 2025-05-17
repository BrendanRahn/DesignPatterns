using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterators
{
    public interface IIterator
    {
        void First();
        void Next();
        bool IsDone();
        IGlyph GetCurrent();
        void Insert(IGlyph glyph);

    }
}
