using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The <see cref="InputGroup"/>.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal struct InputGroup
    {
        /// <summary>
        /// The <see cref="MOUSEINPUT"/> for this <see cref="InputGroup"/>. Defines all the mouse-related inputs.
        /// </summary>
        [FieldOffset(0)]
        public MOUSEINPUT Mouse;
        /// <summary>
        /// The <see cref="KEYBDINPUT"/> for this <see cref="InputGroup"/>. Defines all the keyboard-related inputs.
        /// </summary>
        [FieldOffset(0)]
        public KEYBDINPUT Keyboard;
        /// <summary>
        /// The <see cref="HARDWAREINPUT"/> for this <see cref="InputGroup"/>. Defines inputs other than keyboard or mousse inputs.
        /// </summary>
        [FieldOffset(0)]
        public HARDWAREINPUT Hardware;
    }
}
