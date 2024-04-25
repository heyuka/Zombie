using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie
{
    internal class SevenSegment
    {
        private readonly Image[] Images =
        [
            Properties.Resources.Zero,
            Properties.Resources.One,
            Properties.Resources.Two,
            Properties.Resources.Three,
            Properties.Resources.Four,
            Properties.Resources.Five,
            Properties.Resources.Six,
            Properties.Resources.Seven,
            Properties.Resources.Eight,
            Properties.Resources.Nine,
            Properties.Resources.Colon
        ];

        public enum DisplayCharacter
        {
            Zero = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Colon = 10
        }

        private DisplayCharacter character;

        public Image SetCharacter(DisplayCharacter displayCharacter)
        {
            character = displayCharacter;
            return GetImage();
        }

        public SevenSegment()
        {
            character = DisplayCharacter.Zero;
        }

        public SevenSegment(DisplayCharacter displayCharacter)
        {
            character = displayCharacter;
        }

        public Image GetImage()
        {
            return Images[(int)character];
        }
    }
}
