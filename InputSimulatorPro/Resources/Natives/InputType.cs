namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The <see cref="InputType"/> enum. Defines what type of input an <see cref="INPUT"/> instance holds.
    /// </summary>
    public enum InputType : uint
    {
        /// <summary>
        /// Defines that an <see cref="INPUT"/> instance holds an mouse-related input.
        /// </summary>
        Mouse = 0,
        /// <summary>
        /// Defines that an <see cref="INPUT"/> instance holds an keyboard-related input.
        /// </summary>
        Keyboard = 1,
        /// <summary>
        /// Defines that an <see cref="INPUT"/> instance holds an hardware-related input (an external device, besides from a mouse or keyboard).
        /// </summary>
        Hardware = 2
    }
}
