using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace GoF.CasinoCraps
{
    public class DiceRoll
    {
        private static readonly Random random = new Random();

        public DiceRoll()
        {
            FirstDie = GetRandomDieValue();
            SecondDie = GetRandomDieValue();
        }

        public DiceRoll(int firstDie, int secondDie)
        {
            Contract.Requires(0 < firstDie && firstDie < 7);
            Contract.Requires(0 < secondDie && secondDie < 7);

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

        private int GetRandomDieValue()
        {
            return random.Next(1, 7);
        }
    }
}
