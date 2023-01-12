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
        public byte CurrFaceValue { get; set; }

        /// <summary>
        /// True if the d6 is currently held; otherwise False
        /// </summary>
        public bool IsHeld { get; set; }
    }
}
