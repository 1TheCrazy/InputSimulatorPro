using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
#pragma warning disable CS0649
    /// <summary>
    /// The <see cref="KEYBDINPUT"/> of an <see cref="INPUT"/> instance.
    /// </summary>
    public struct KEYBDINPUT
    {
        /// <summary>
        /// The <see cref="VirtualKeyShort"/> for this <see cref="KEYBDINPUT"/>. Defines what virtual key should be used for simulated inputs of this <see cref="KEYBDINPUT"/>.
        /// </summary>
        public VirtualKeyShort VirtualKey;
        /// <summary>
        /// A <see cref="UInt16"/> that holds a ScanCodeShort. Defines what physical key should be used for simulated inputs of this <see cref="KEYBDINPUT"/>.
        /// </summary>
        public UInt16 ScanCodeShort;
        /// <summary>
        /// The <see cref="KeyboardFlags"/> for this <see cref="KEYBDINPUT"/>. Defines what input action should be simulated.
        /// </summary>
        public KeyboardFlags Flags;
        /// <summary>
        /// A <see cref="int"/> that holds the time when the input should be proccessed. If set to 0, the OS will provide it's own time.
        /// </summary>
        public int time;
        /// <summary>
        /// A <see cref="UIntPtr"/> that holds extra info about the simulated input.
        /// </summary>
        public UIntPtr ExtraInfo;
    }
#pragma warning restore
}
