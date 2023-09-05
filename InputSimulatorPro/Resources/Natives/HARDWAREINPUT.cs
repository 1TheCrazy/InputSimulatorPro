using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The <see cref="HARDWAREINPUT"/> of an <see cref="INPUT"/> instance. Used for simulating inputs from an external input-devide, other than a mouse or keyboard
    /// </summary>
    public struct HARDWAREINPUT
    {
        /// <summary>
        /// Message specified from the input hardware
        /// </summary>
        public int Message;
        /// <summary>
        /// Defines the low-order word for the <see cref="Message"/>.
        /// </summary>
        public short LParam;
        /// <summary>
        /// Defines the high-order word for the <see cref="Message"/>.
        /// </summary>
        public short HParam;
    }
}
