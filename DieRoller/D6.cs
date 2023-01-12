using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six-sided die (1 - 6)
    /// </summary>
    public class D6
    {
        /// <summary>
        /// An instance of the random class
        /// </summary>
        private static Random _random;

        static D6()
        {
            _random = new Random();
        }

        /// <summary>
        /// The current face-up value of the d6
        /// </summary>
        public byte CurrFaceValue { get; private set; }

        /// <summary>
        /// True if the d6 is currently held; otherwise False
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Creates a d6 and sets it's current face-up value 
        /// to a random number (1 - 6)
        /// </summary>
        public D6()
        {
            RollD6();
        }

        /// <summary>
        /// As long as the d6 is not held-
        /// Rolls the d6, replaces the <see cref="CurrFaceValue"/> 
        /// <br></br>
        /// with the newly generated number, 
        /// and then returns the <see cref="CurrFaceValue"/> 
        /// </summary>
        /// <returns>The <see cref="CurrFaceValue"/></returns>
        public byte RollD6()
        {
            // If d6 is not held
            if(!IsHeld)
            {
                // Generate random number 1 - 6
                byte newValue = (byte) _random.Next(1, 7);

                // Set generated number as current face value
                CurrFaceValue = newValue;
            }

            // Return the current face-up value
            return CurrFaceValue;
        }
    }
}
