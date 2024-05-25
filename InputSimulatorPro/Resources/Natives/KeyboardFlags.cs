namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The <see cref="KeyboardFlags"/> of an <see cref="KEYBDINPUT"/> instance. Defines the input action that should be simulated.
    /// </summary>
    [Flags]
    public enum KeyboardFlags : uint
    {
        /// <summary>
        /// Defines taht the simulated input holds an <see cref="Extendedkey"/> (e.g. function key or numpad key). This flag is needed for keys that require unique handling.
        /// </summary>
        Extendedkey = 0x0001,
        /// <summary>
        /// Defines that the simulated input is an <see cref="Keyup"/> action.
        /// </summary>
        Keyup = 0x0002,
        /// <summary>
        /// Defines the simulated input is an <see cref="Scancode"/> action (physical key). Then uses the provided <see cref="KEYBDINPUT.ScanCodeShort"/>.
        /// </summary>
        Scancode = 0x0008,
        /// <summary>
        /// Defines that the <see cref="KEYBDINPUT.ScanCodeShort"/> (in this use-case a char) should be translated to an <see cref="VirtualKeyShort"/>. 
        /// </summary>
        Unicode = 0x0004
    }
}
