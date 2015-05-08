namespace GoF.CasinoCraps
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    /// <summary>
    /// Represents a single roll in a game of casino craps.
    /// (Requirement 1.0.0)
    /// (Requirement 4.0.0)
    /// </summary>
    public class Roll
    {
        /// <summary>
        /// Random for generating random dice rolls.
        /// (Requirement 4.1.0)
        /// </summary>
        private static readonly Random Random = new Random();

        /// <summary>
        /// A list of the craps roll values.
        /// </summary>
        private readonly List<int> crapsRolls = new List<int> { 2, 3, 12 };

        /// <summary>
        /// A list of the natural roll values.
        /// </summary>
        private readonly List<int> naturalRolls = new List<int> { 7, 11 };

        /// <summary>
        /// A list of the point roll values.
        /// </summary>
        private readonly List<int> pointRolls = new List<int> { 4, 5, 6, 8, 9, 10 };

        /// <summary>
        /// A dictionary of possible rolls with their associated roll names.
        /// </summary>
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
            { Tuple.Create(1, 6), RollName.NaturalOrSevenOut },
            { Tuple.Create(2, 5), RollName.NaturalOrSevenOut },
            { Tuple.Create(3, 4), RollName.NaturalOrSevenOut },
            { Tuple.Create(4, 3), RollName.NaturalOrSevenOut },
            { Tuple.Create(5, 2), RollName.NaturalOrSevenOut },
            { Tuple.Create(6, 1), RollName.NaturalOrSevenOut },
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Roll"/> class.
        /// </summary>
        public Roll()
        {
            FirstDie = GetRandomDieValue();
            SecondDie = GetRandomDieValue();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Roll"/> class.
        /// </summary>
        /// <param name="firstDie">The first die value.</param>
        /// <param name="secondDie">The second die value.</param>
        public Roll(int firstDie, int secondDie)
        {
            Contract.Requires(1 <= firstDie && firstDie <= 6);
            Contract.Requires(1 <= secondDie && secondDie <= 6);

            FirstDie = firstDie;
            SecondDie = secondDie;
        }

        /// <summary>
        /// Gets the first die value.
        /// </summary>
        public int FirstDie { get; private set; }

        /// <summary>
        /// Gets the second die value.
        /// </summary>
        public int SecondDie { get; private set; }

        /// <summary>
        /// Gets the total value of the two dice.
        /// </summary>
        public int DiceTotal
        {
            get
            {
                return FirstDie + SecondDie;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current roll is a craps value.
        /// </summary>
        public bool IsCraps
        {
            get
            {
                return crapsRolls.Contains(DiceTotal);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current roll is a natural value.
        /// </summary>
        public bool IsNatural
        {
            get
            {
                return naturalRolls.Contains(DiceTotal);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current roll is a point value.
        /// </summary>
        public bool IsPoint
        {
            get
            {
                return pointRolls.Contains(DiceTotal);
            }
        }

        /// <summary>
        /// Gets the craps slang name of the current roll.
        /// </summary>
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

        /// <summary>
        /// Gets a random die value from one to six.
        /// </summary>
        /// <returns>A random die value.</returns>
        private int GetRandomDieValue()
        {
            return Random.Next(1, 7);
        }
    }
}
