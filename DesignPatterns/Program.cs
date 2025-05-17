using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Glyphs;

namespace Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var word1 = new ArrayGlyph(new List<IGlyph>()
            {
                new CharacterGlyph('S'),
                new CharacterGlyph('t'),
                new CharacterGlyph('a'),
                new CharacterGlyph('r'),
                new CharacterGlyph('t'),
                new CharacterGlyph('\n'),
            });
            var rectangle = new RectangleGlyph();
            var circle = new CircleGlyph();
            var word2 = new ArrayGlyph(new List<IGlyph>()
            {
                new CharacterGlyph('E'),
                new CharacterGlyph('n'),
                new CharacterGlyph('d'),
                new CharacterGlyph('\n'),
            });


            var displayManyGlyphs = new ArrayGlyph(new List<IGlyph>()
            {
                word1,
                rectangle,
                circle,
                word2,
            });
            Console.Write(displayManyGlyphs.Display()); 


        }
    }
}
