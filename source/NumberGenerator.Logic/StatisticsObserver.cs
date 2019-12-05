using System;

namespace NumberGenerator.Logic
{
    /// <summary>
    /// Beobachter, welcher einfache Statistiken bereit stellt (Min, Max, Sum, Avg).
    /// </summary>
    public class StatisticsObserver : BaseObserver
    {
        #region Fields

        #endregion

        #region Properties

        /// <summary>
        /// Enthält das Minimum der generierten Zahlen.
        /// </summary>
        public int Min 
        {
            get
            {
                return Min;
            }
            private set
            {
                Min = 999;
            } 
        }

        /// <summary>
        /// Enthält das Maximum der generierten Zahlen.
        /// </summary>
        public int Max { get; private set; }

        /// <summary>
        /// Enthält die Summe der generierten Zahlen.
        /// </summary>
        public int Sum { get; private set; }

        /// <summary>
        /// Enthält den Durchschnitt der generierten Zahlen.
        /// </summary>
        public int Avg
        {
            get
            {
                if (Count != 0)
                {
                    return Sum / Count;
                }
                return 0;
            }
        }
        private int Count { get; set; }

        #endregion

        #region Constructors

        public StatisticsObserver(IObservable numberGenerator, int countOfNumbersToWaitFor) : base(numberGenerator, countOfNumbersToWaitFor)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override void OnNextNumber(int number)
        {
            Count++;

            Sum += number;
            if (number < Min)
            {
                Min = number;
            }
            if (number > Max)
            {
                Max = number;
            }
        }

        #endregion
    }
}
