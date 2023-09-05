using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// Defines what <see cref="MouseButton"/> should be simulated in the input.
    /// </summary>
    public enum MouseButton : uint
    {
        /// <summary>
        /// The <see cref="left"/> mouse button.
        /// </summary>
        left = 0,
        /// <summary>
        /// The <see cref="right"/> mouse button.
        /// </summary>
        right = 1,
        /// <summary>
        /// The <see cref="middle"/> mouse button (wheel).
        /// </summary>
        middle = 2,
        /// <summary>
        /// The <see cref="fourth"/> mouse button (1st side button).
        /// </summary>
        fourth = 3,
        /// <summary>
        /// The <see cref="fifth"/> mouse button (2nd side button).
        /// </summary>
        fifth = 4
    }
}
