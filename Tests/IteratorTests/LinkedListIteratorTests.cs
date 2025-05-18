using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator;
using Iterator.Glyphs;
using Iterator.Iterators;

namespace IteratorTests
{
    [TestClass]
    public class LinkedListIteratorTests
    {
        [TestMethod]
        public void LinkedListIterator_IteratesAllChildren()
        {
            var glyphs = new LinkedList<IGlyph>(new[]
            {
                new CharacterGlyph('H'),
                new CharacterGlyph('e'),
                new CharacterGlyph('l'),
                new CharacterGlyph('l'),
                new CharacterGlyph('o')
            });
            var iterator = new LinkedListIterator(glyphs);

            iterator.First();
            Assert.AreEqual("H", iterator.GetCurrent().Display());

            iterator.Next();
            Assert.AreEqual("e", iterator.GetCurrent().Display());

            iterator.Next();
            Assert.AreEqual("l", iterator.GetCurrent().Display());

            iterator.Next();
            Assert.AreEqual("l", iterator.GetCurrent().Display());

            iterator.Next();
            Assert.AreEqual("o", iterator.GetCurrent().Display());
        }

        [TestMethod]
        public void LinkedListIterator_InsertsGlyph()
        {
            var glyphs = new LinkedList<IGlyph>(new[]
            {
                new CharacterGlyph('A'),
                new CharacterGlyph('B'),
            });
            var iterator = new LinkedListIterator(glyphs);

            iterator.First();
            Assert.AreEqual("A", iterator.GetCurrent().Display());

            iterator.Insert(new CharacterGlyph('C'));
            iterator.Next();
            Assert.AreEqual("C", iterator.GetCurrent().Display());

            iterator.Next();
            Assert.AreEqual("B", iterator.GetCurrent().Display());
        }

        [TestMethod]
        public void LinkedListIterator_SignalsIsDone()
        {
            var glyphs = new LinkedList<IGlyph>(new[]
            {
                new CharacterGlyph('H'),
                new CharacterGlyph('e'),
                new CharacterGlyph('l'),
                new CharacterGlyph('l'),
                new CharacterGlyph('o')
            });
            var iterator = new LinkedListIterator(glyphs);

            while (!iterator.IsDone())
            {
                iterator.GetCurrent().Display();
                iterator.Next();
            }

            Assert.IsTrue(iterator.IsDone());
        }
    }
}
