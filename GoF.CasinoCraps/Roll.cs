using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace GoF.CasinoCraps
{
    public class Roll
    {
        private static readonly Random random = new Random();

        private readonly Dictionary<Tuple<int, int>, RollName> rollNames = new Dictionary<Tuple<int, int>, RollName>
        {
            { Tuple.Create(1, 1), RollName.SnakeEyes },
            { Tuple.Create(1, 2), RollName.AceDeuce },
            { Tuple.Create(2, 1), RollName.AceDeuce },
            { Tuple.Create(3, 1), RollName.EasyFour },
            { Tuple.Create(1, 3), RollName.EasyFour },
            { Tuple.Create(2, 2), RollName.HardFour },
            { Tuple.Create(1, 4), RollName.Five },
            { Tuple.Create(2, 3), RollName.Five },
            { Tuple.Create(3, 2), RollName.Five },
            { Tuple.Create(4, 1), RollName.Five },
            { Tuple.Create(1, 5), RollName.EasySix },
            { Tuple.Create(2, 4), RollName.EasySix },
            { Tuple.Create(4, 2), RollName.EasySix },
            { Tuple.Create(5, 1), RollName.EasySix },
            { Tuple.Create(3, 3), RollName.HardSix },
            { Tuple.Create(1, 6), RollName.Natural },
            { Tuple.Create(2, 5), RollName.Natural },
            { Tuple.Create(3, 4), RollName.Natural },
            { Tuple.Create(4, 3), RollName.Natural },
            { Tuple.Create(5, 2), RollName.Natural },
            { Tuple.Create(6, 1), RollName.Natural },
            { Tuple.Create(2, 6), RollName.EasyEight },
            { Tuple.Create(3, 5), RollName.EasyEight },
            { Tuple.Create(5, 3), RollName.EasyEight },
            { Tuple.Create(6, 2), RollName.EasyEight },
            { Tuple.Create(4, 4), RollName.HardEight },
            { Tuple.Create(3, 6), RollName.Nine },
            { Tuple.Create(4, 5), RollName.Nine },
            { Tuple.Create(5, 4), RollName.Nine },
            { Tuple.Create(6, 3), RollName.Nine },
            { Tuple.Create(4, 6), RollName.EasyTen },
            { Tuple.Create(6, 4), RollName.EasyTen },
            { Tuple.Create(5, 5), RollName.HardTen },
            { Tuple.Create(5, 6), RollName.Yo },
            { Tuple.Create(6, 5), RollName.Yo },
            { Tuple.Create(6, 6), RollName.Boxcars },
        };

        public Roll()
        {
            FirstDie = GetRandomDieValue();
            SecondDie = GetRandomDieValue();
        }

        public Roll(int firstDie, int secondDie)
        {
            Contract.Requires(1 <= firstDie && firstDie <= 6);
            Contract.Requires(1 <= secondDie && secondDie <= 6);

            FirstDie = firstDie;
            SecondDie = secondDie;
        }

        public int FirstDie { get; private set; }

        public int SecondDie { get; private set; }

        public int DiceTotal
        {
            get
            {
                return FirstDie + SecondDie;
            }
        }

        public RollName Name
        {
            get
            {
                var tuple = Tuple.Create(FirstDie, SecondDie);
                if (rollNames.ContainsKey(tuple))
                {
                    return rollNames[tuple];
                }

                return RollName.None;
            }
        }

        private int GetRandomDieValue()
        {
            return random.Next(1, 7);
        }
    }
}
