using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie
{
    internal class SevenSegment
    {
        private readonly string[] rasters =
        [
            "0.png",
            "1.png",
            "2.png",
            "3.png",
            "4.png",
            "5.png",
            "6.png",
            "7.png",
            "8.png",
            "9.png",
            "colon.png"
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

        public enum Height
        {
            Sixteen = 16,
            ThirtyTwo = 32,
            SixtyFour = 64
        }

        private Height height;

        public void SetHeight(Height height)
        {
            this.height = height;
        }

        private DisplayCharacter character;

        public string SetCharacter(DisplayCharacter character)
        {
            this.character = character;
            return GetRaster();
        }

        public SevenSegment()
        {
            height = Height.ThirtyTwo;
        }

        public SevenSegment(Height height)
        {
            this.height = height;
        }

        public SevenSegment(Height height, DisplayCharacter character)
        {
            this.height = height;
            this.character = character;
        }

        public string GetRaster()
        {
            return $"res/{height}/{rasters[(int)character]}";
        }
    }
}
