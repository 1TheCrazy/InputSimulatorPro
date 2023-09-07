using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The <see cref="MouseData"/> for this input. Defines extra data, like what side button should be used for simulating in this input, if <see cref="MOUSEINPUT.Flags"/> is set to <see cref="MouseFlags.XUp"/> or <see cref="MouseFlags.XDown"/>, or how much should be scrolled.
    /// </summary>
    public enum MouseData : uint
    {
        /// <summary>
        /// Nothing.
        /// </summary>
        Nothing = 0x0,
        /// <summary>
        /// The first side button.
        /// </summary>
        XButton1 = 0x1,
        /// <summary>
        /// The second side button.
        /// </summary>
        XButton2 = 0x2,
        /// <summary>
        /// The default amount of scroll for a notch.
        /// </summary>
        DefaultScroll = 120,
    }
}
