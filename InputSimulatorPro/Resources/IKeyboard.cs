using InputSimulatorPro.Resources.Natives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources
{
    /// <summary>
    /// The contract for <see cref="Keyboard"/>. Used for simulating keyboard-related inputs.
    /// </summary>
    public interface IKeyboard
    {
        /// <summary>
        /// Simulates a key down input.
        /// </summary>
        /// <param name="keyShort">The <see cref="VirtualKeyShort"/> that should be used of this input simulation</param>
        public void KeyDown(VirtualKeyShort keyShort);
        /// <summary>
        /// Simulates a key up input.
        /// </summary>
        /// <param name="keyShort">The <see cref="VirtualKeyShort"/> that should be used of this input simulation</param>
        public void KeyUp(VirtualKeyShort keyShort);
        /// <summary>
        /// Simulates a text entry (a keypress for every character in the string).
        /// </summary>
        /// <param name="text">The <see cref="string"/> that holds the text that should be simulated</param>
        public void TextEntry(string text);
        /// <summary>
        /// Simualtes a simultaneous press of multiple keys.
        /// </summary>
        /// <param name="keyShorts">The <see cref="VirtualKeyShort"/> array that holds the keys that should be simulated</param>
        public void SimultaneousKeyPress(VirtualKeyShort[] keyShorts);
        /// <summary>
        /// Simualtes a simultaneous down input of multiple keys.
        /// </summary>
        /// <param name="keyShorts">The <see cref="VirtualKeyShort"/> array that holds the keys that should be simulated</param>
        public void SimultaneousKeyDown(VirtualKeyShort[] keyShorts);
        /// <summary>
        /// Simualtes a simultaneous up input of multiple keys.
        /// </summary>
        /// <param name="keyShorts">The <see cref="VirtualKeyShort"/> array that holds the keys that should be simulated</param>
        public void SimultaneousKeyUp(VirtualKeyShort[] keyShorts);

        /// <summary>
        /// Simulates a keypress.
        /// </summary>
        /// <param name="keyShort">The <see cref="VirtualKeyShort"/> that should be pressed</param>
        public void KeyPress(VirtualKeyShort keyShort);
        /// <summary>
        /// Pause the Thread
        /// </summary>
        /// <param name="milliseconds">A <see cref="int"/> that holds the timeout of the Thread in milliseconds</param>
        public void Sleep(int milliseconds);
        /// <summary>
        /// Pause the Thread
        /// </summary>
        /// <param name="timeSpan">A <see cref="TimeSpan"/> that holds the span of the timeout</param>
        public void Sleep(TimeSpan timeSpan);
    }
}
