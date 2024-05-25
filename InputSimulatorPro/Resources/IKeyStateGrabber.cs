using InputSimulatorPro.Resources.Natives;

namespace InputSimulatorPro.Resources
{
    /// <summary>
    /// The contract for <see cref="KeyStateGrabber"/>. Used to get key states.
    /// </summary>
    public interface IKeyStateGrabber
    {
        /// <summary>
        /// Is true if a virtual key is down. Has the same value as <see cref="IsHardwareKeyDown(VirtualKeyShort)"/>
        /// </summary>
        public bool IsVirtualKeyDown(VirtualKeyShort key);
        /// <summary>
        /// Is true if a physical key is down. Has the same value as <see cref="IsVirtualKeyDown(VirtualKeyShort)"/>
        /// </summary>
        public bool IsHardwareKeyDown(VirtualKeyShort key);
        /// <summary>
        /// Is true if a virtual key is up. Has the same value as <see cref="IsHardwareKeyUp(VirtualKeyShort)"/>
        /// </summary>
        public bool IsVirtualKeyUp(VirtualKeyShort key);
        /// <summary>
        /// Is true if a physical key is up. Has the same value as <see cref="IsVirtualKeyUp(VirtualKeyShort)"/>
        /// </summary>
        public bool IsHardwareKeyUp(VirtualKeyShort key);
        /// <summary>
        /// Is true if a modifier key is like CTRL or SHIFTLOCK is in effect.
        /// </summary>
        public bool IsToggleKeyInEffect(VirtualKeyShort key); 
    }
}
