namespace Iterator.Iterators
{
    public class  ArrayIterator : IIterator
    {
        private List<IGlyph> _children { get; set; }
        private int _index = 0;
        public ArrayIterator(List<IGlyph> children)
        {
            _children = children;
        }
        public void First()
        {
            _index = 0;
        }
        public void Next()
        {
            _index++;
        }
        public bool IsDone()
        {
            return _index >= _children.Count;
        }
        public IGlyph GetCurrent()
        {
            return _children[_index];
        }
        public void Insert(IGlyph glyph)
        {
            _children.Insert(_index, glyph);
        }
    }
}