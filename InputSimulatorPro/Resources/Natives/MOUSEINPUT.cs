using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
#pragma warning disable CS0649
    /// <summary>
    /// The <see cref="MOUSEINPUT"/> for an <see cref="InputGroup"/> instance.
    /// </summary>
    internal struct MOUSEINPUT
    {
        /// <summary>
        /// Holds the <see cref="x"/> coordinate for a <see cref="MouseFlags.Move"/> action.
        /// </summary>
        public int x;
        /// <summary>
        /// Holds the <see cref="y"/> coordinate for a <see cref="MouseFlags.Move"/> action.
        /// </summary>
        public int y;
        /// <summary>
        /// Holds an <see cref="uint"/> represented by <see cref="Natives.MouseData"/> for a infos for scroll actions or side button actions.
        /// </summary>
        public uint MouseData;
        /// <summary>
        /// Holds the <see cref="MouseFlags"/> for this <see cref="MOUSEINPUT"/>.
        /// </summary>
        public MouseFlags Flags;
        /// <summary>
        /// A <see cref="int"/> that holds the time when the input should be proccessed. If set to 0, the OS will provide it's own time.
        /// </summary>
        public uint Time;
        /// <summary>
        /// A <see cref="UIntPtr"/> that holds extra info about the simulated input.
        /// </summary>
        public UIntPtr ExtraInfo; 
    }
#pragma warning restore
}
