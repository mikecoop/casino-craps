namespace GoF.CasinoCraps
{
    /// <summary>
    /// Specifies the name of a roll in craps.
    /// </summary>
    public enum RollName
    {
        /// <summary>
        /// No name.
        /// </summary>
        None = 0,

        /// <summary>
        /// A one and one.
        /// </summary>
        SnakeEyes = 1,

        /// <summary>
        /// A one and a two.
        /// </summary>
        AceDeuce = 2,

        /// <summary>
        /// Any combination that adds to four other than two and two.
        /// </summary>
        EasyFour = 3,

        /// <summary>
        /// Two and two.
        /// </summary>
        HardFour = 4,

        /// <summary>
        /// Any combination that adds to five.
        /// </summary>
        Five = 5,

        /// <summary>
        /// Any combination that adds to six other than three and three.
        /// </summary>
        EasySix = 6,

        /// <summary>
        /// Three and three.
        /// </summary>
        HardSix = 7,

        /// <summary>
        /// Any combination that adds to seven.
        /// </summary>
        NaturalOrSevenOut = 8,

        /// <summary>
        /// Any combination that adds to eight other than four and four.
        /// </summary>
        EasyEight = 9,

        /// <summary>
        /// Four and four.
        /// </summary>
        HardEight = 10,

        /// <summary>
        /// Any combination that adds to nine.
        /// </summary>
        Nine = 11,

        /// <summary>
        /// Any combination that adds to ten other than five and five.
        /// </summary>
        EasyTen = 12,

        /// <summary>
        /// Five and five.
        /// </summary>
        HardTen = 13,

        /// <summary>
        /// Any combination that adds to eleven.
        /// </summary>
        Yo = 14,

        /// <summary>
        /// Six and six.
        /// </summary>
        Boxcars = 15
    }
}
