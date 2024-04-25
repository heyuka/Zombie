using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zombie.SevenSegment;

namespace Zombie
{
    internal class Clock
    {
        private SevenSegment[] Time;

        public Clock()
        {
            Time = CreateBlank();
        }

        public Image[] SetTime(DateTime time)
        {
            return
            [
                Time[0].SetCharacter((DisplayCharacter)(time.Hour / 10)),
                Time[1].SetCharacter((DisplayCharacter)(time.Hour % 10)),
                Time[2].SetCharacter((DisplayCharacter)(time.Minute / 10)),
                Time[3].SetCharacter((DisplayCharacter)(time.Minute % 10)),
                Time[4].SetCharacter((DisplayCharacter)(time.Second / 10)),
                Time[5].SetCharacter((DisplayCharacter)(time.Second % 10)),
            ];
        }

        public Image[] SetTime(TimeSpan timeSpan)
        {
            return SetTime(new DateTime(1, 1, 1, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds));
        }

        private SevenSegment[] CreateBlank()
        {
            Time = new SevenSegment[6];
            for (int i = 0; i < 6; i++)
            {
                Time[i] = new SevenSegment(DisplayCharacter.Zero);
            }
            return Time;
        }
    }
}
