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
        /// Rolls the d6, replaces the <see cref="CurrFaceValue"/> 
        /// with the newly generated number, 
        /// <br></br>
        /// and then returns the new number.
        /// </summary>
        /// <returns>The new <see cref="CurrFaceValue"/></returns>
        public byte RollD6()
        {
            // Setup random
            Random rand = new();

            // Generate random number 1 - 6
            byte newValue = (byte) rand.Next(1, 7);

            // Set generated number as current face value
            CurrFaceValue = newValue;

            return CurrFaceValue;
        }
    }
}
