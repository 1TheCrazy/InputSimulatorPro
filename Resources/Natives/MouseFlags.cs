using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The <see cref="MouseFlags"/> for an <see cref="MOUSEINPUT"/> instance.
    /// </summary>
    [Flags]
    public enum MouseFlags : uint
    {
        /// <summary>
        /// Null.
        /// </summary>
        Null = 0,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="Move"/> action.
        /// </summary>
        Move = 0x0001,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="LeftDown"/> action. 
        /// </summary>
        LeftDown = 0x0002,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="LeftUp"/> action.
        /// </summary>
        LeftUp = 0x0004,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="RightDown"/> action.
        /// </summary>
        RightDown = 0x0008,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="RightUp"/> action.
        /// </summary>
        RightUp = 0x0010,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="MiddleDown"/> action.
        /// </summary>
        MiddleDown = 0x0020,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="MiddleUp"/> action.
        /// </summary>
        MiddleUp = 0x0040,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="XDown"/> action, (then utilises the info specified in <see cref="MouseData"/>.
        /// </summary>
        XDown = 0x0080,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="XDown"/> action, (then utilises the info specified in <see cref="MouseData"/>.
        /// </summary>
        XUp = 0x0100,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="VerticalWheel"/> action.
        /// </summary>
        VerticalWheel = 0x0800,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="HorizontalWheel"/> action.
        /// </summary>
        HorizontalWheel = 0x1000,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="Move"/> action that is mapped to the entire <see cref="VirtualDesk"/> (used for multi-monitor setups).
        /// </summary>
        VirtualDesk = 0x4000,
        /// <summary>
        /// Defines that the <see cref="MOUSEINPUT"/> holds a <see cref="Move"/> action that is <see cref="Absolute"/> (ranges from 65535 to 0 in non-normalized coordinates) 
        /// </summary>
        Absolute = 0x8000,
    }
}
