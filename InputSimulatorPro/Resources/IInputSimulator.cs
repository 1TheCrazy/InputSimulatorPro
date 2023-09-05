using InputSimulatorPro.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources
{
    /// <summary>
    /// The contract for <see cref="InputSimulator"/>. Holds references to the interface that provide the functions of this library.
    /// </summary>
    internal interface IInputSimulator
    {
        /// <summary>
        /// The <see cref="IKeyboard"/> instance used for simulating keyboard-related inputs.
        /// </summary>
        public static IKeyboard Keyboard { get; } = new Keyboard();
        /// <summary>
        /// The <see cref="IMouse"/> instance used for simulating mouse-related inputs.
        /// </summary>
        public static IMouse Mouse { get; } = new Mouse();
        /// <summary>
        /// The <see cref="IDebugger"/> instance used for debugging.
        /// </summary>
        public static IDebugger Debugger { get; } = new Debugger();
        /// <summary>
        /// The <see cref="IKeyStateGrabber"/> instance used for debugging.
        /// </summary>
        public static IKeyStateGrabber KeyStateGrabber { get; } = new KeyStateGrabber();
    }
}
