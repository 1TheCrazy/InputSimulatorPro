using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The <see cref="INPUT"/> structure used for simulating inputs.
    /// </summary>
    internal struct INPUT
    {
        /// <summary>
        /// The <see cref="InputType"/> for this <see cref="INPUT"/> instance. Defines what the input can simulate.
        /// </summary>
        public InputType Type;
        /// <summary>
        /// The <see cref="InputGroup"/> for this <see cref="INPUT"/> instance. Defines the <see cref="MOUSEINPUT"/>, <see cref="KEYBDINPUT"/> and the <see cref="HARDWAREINPUT"/>.
        /// </summary>
        public InputGroup Group;
        /// <summary>
        /// The size of the <see cref="INPUT"/> struct. Used in the <see cref="NativeMethods.SendInput"/> method.
        /// </summary>
        public static int Size { get { return Marshal.SizeOf(typeof(INPUT)); } }
    }
}
