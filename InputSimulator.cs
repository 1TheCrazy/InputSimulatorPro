using InputSimulatorPro.Resources;
using InputSimulatorPro.Resources.Natives;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro
{
    /// <summary>
    /// The class that holds references to features 
    /// </summary>
    public class InputSimulator : IInputSimulator
    {
        private static readonly IKeyboard keyboard = new Keyboard();

        private static readonly IMouse mouse = new Mouse();

        private static readonly IDebugger debugger = new Debugger();

        private static readonly IKeyStateGrabber keyStateGrabber = new KeyStateGrabber();

        /// <summary>
        /// The <see cref="IKeyboard"/> instance used for simulating keyboard-related inputs.
        /// </summary>
        public static IKeyboard Keyboard { get { return keyboard; } }
        /// <summary>
        /// The <see cref="IMouse"/> instance used for simulating keyboard-related inputs.
        /// </summary>
        public static IMouse Mouse { get { return mouse;} }
        /// <summary>
        /// The <see cref="IDebugger"/> instance used for simulating keyboard-related inputs.
        /// </summary>
        public static IDebugger Debugger { get { return debugger; } }
        /// <summary>
        /// The <see cref="IKeyStateGrabber"/> instance used for debugging.
        /// </summary>
        public static IKeyStateGrabber KeyStateGrabber { get { return keyStateGrabber; } }
    }
}