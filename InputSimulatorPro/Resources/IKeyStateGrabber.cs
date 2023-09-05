using InputSimulatorPro.Resources.Natives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources
{
    /// <summary>
    /// The contract for <see cref="KeyStateGrabber"/>. Used to get key states.
    /// </summary>
    public interface IKeyStateGrabber
    {
        /// <summary>
        /// Is true if a virtual key is down.
        /// </summary>
        public bool IsVirtualKeyDown(VirtualKeyShort key);
        /// <summary>
        /// Is true if a physical key is down.
        /// </summary>
        public bool IsHardwareKeyDown(VirtualKeyShort key);
        /// <summary>
        /// Is true if a virtual key is up.
        /// </summary>
        public bool IsVirtualKeyUp(VirtualKeyShort key);
        /// <summary>
        /// Is true if a physical key is up.
        /// </summary>
        public bool IsHardwareKeyUp(VirtualKeyShort key);
        /// <summary>
        /// Is true if a modifier key is like CTRL or SHIFTLOCK is in effect.
        /// </summary>
        public bool IsToggleKeyInEffect(VirtualKeyShort key); 
    }
}
