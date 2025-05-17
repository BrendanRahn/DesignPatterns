

using Iterator;
using Iterator.Glyphs;

namespace IteratorTests
{
    [TestClass]
    public sealed class IteratorTests
    {
        [TestMethod]
        public void ArrayIterator_IteratesAllChildren()
        {
            var glyphs = new List<IGlyph>
            {
                new CharacterGlyph('H'),
                new CharacterGlyph('e'),
                new CharacterGlyph('l'),
                new CharacterGlyph('l'),
                new CharacterGlyph('o')
            };
            var word = new ArrayGlyph(glyphs);

            var i = word.CreateIterator();

            i.First();
            Assert.AreEqual("H", i.GetCurrent().Display());

            i.Next();
            Assert.AreEqual("e", i.GetCurrent().Display());

            i.Next();
            Assert.AreEqual("l", i.GetCurrent().Display());

            i.Next();
            Assert.AreEqual("l", i.GetCurrent().Display());

            i.Next();
            Assert.AreEqual("o", i.GetCurrent().Display());

        }

        [TestMethod]
        public void ArrayIterator_InsertsGlyph()
        {
            var glyphs = new List<IGlyph>
            {
                new CharacterGlyph('A'),
                new CharacterGlyph('B'),
            };

            var word = new ArrayGlyph(glyphs);
            var i = word.CreateIterator();

            i.First();
            Assert.AreEqual("A", i.GetCurrent().Display());

            i.Insert(new CharacterGlyph('C'));
            Assert.AreEqual("C", i.GetCurrent().Display());

            i.Next();
            Assert.AreEqual("B", i.GetCurrent().Display());
        }
    }
}
