using System.Runtime.InteropServices;

namespace InputSimulatorPro.Resources.Natives
{
    /// <summary>
    /// The class that holds all the methods used in this library, that are native to the Windows-API.
    /// </summary>
    public class NativeMethods
    {
#pragma warning disable CA1401
        /// <summary>
        /// Gets the size of the main monitor. Used for normalized coordinates in <see cref="IMouse.SetCursorPositionAbsolute"/> and <see cref="IMouse.InterpolateCursorPositionAbsolute"/>.
        /// </summary>
        /// <param name="nIndex">0 returns the X-Axis (Width). 1 returns the Y-Axis (Height).</param>
        /// <returns>Returns an <see cref="int"/> that holds the specified axis of the main monitor</returns>
        [DllImport("user32.dll")]internal static extern int GetSystemMetrics(int nIndex);
        /// <summary>
        /// Send inputs to the input-stream of the device.
        /// </summary>
        /// <param name="nInputs">The number of inputs that should be inserted into the input-stream</param>
        /// <param name="pInputs">The <see cref="INPUT"/> array that should be insered into the input-stream</param>
        /// <param name="cbSize">The size of the <see cref="INPUT"/> array (see <see cref="INPUT.Size"/></param>
        /// <returns></returns>
        [DllImport("user32.dll")]internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);
        /// <summary>
        /// Sets a specified window(<see cref="IntPtr"/>) to the foreground window.
        /// </summary>
        /// <param name="hWnd">A <see cref="IntPtr"/> that holds the window that should be set to the foreground window</param>
        /// <returns>A bool that indicates wether the given <see cref="IntPtr"/> could be set to the foreground window or not</returns>
        [DllImport("user32.DLL")] public static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// Finds a window by the given class name and window name.
        /// </summary>
        /// <param name="lpClassName">The class name of the window</param>
        /// <param name="lpWindowName">The window name</param>
        /// <returns>Returns an <see cref="IntPtr"/> that points to the found window</returns>
        [DllImport("user32.DLL", CharSet = CharSet.Unicode)] public static extern IntPtr FindWindow(string? lpClassName, string lpWindowName);
        /// <summary>
        /// Used to get wther a virtual key is down or not.
        /// </summary>
        /// <param name="VirtualKey">A <see cref="int"/> representing the <see cref="VirtualKeyShort"/> you want to check</param>
        /// <returns></returns>
        [DllImport("user32.dll")] public static extern short GetAsyncKeyState(int VirtualKey);
        /// <summary>
        /// Used to get wether a physical key is down or not.
        /// </summary>
        /// <param name="VirtualKey"></param>
        /// <returns>A <see cref="int"/> representing the <see cref="VirtualKeyShort"/> you want to check</returns>
        [DllImport("user32.dll")] public static extern short GetKeyState(int VirtualKey);
#pragma warning restore
    }
}
