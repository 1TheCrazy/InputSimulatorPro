using InputSimulatorPro.Resources.Natives;

namespace InputSimulatorPro.Resources
{
    internal class KeyStateGrabber : IKeyStateGrabber
    {
        public bool IsVirtualKeyDown(VirtualKeyShort key)
        {
            return (NativeMethods.GetAsyncKeyState((int)key) & 0x8000) != 0;
        }

        public bool IsHardwareKeyDown(VirtualKeyShort key)
        {
            return (NativeMethods.GetKeyState((int)key) & 0x8000) != 0;
        }

        public bool IsVirtualKeyUp(VirtualKeyShort key)
        {
            return !((NativeMethods.GetAsyncKeyState((int)key) & 0x8000) != 0);
        }

        public bool IsHardwareKeyUp(VirtualKeyShort key)
        {
            return !((NativeMethods.GetKeyState((int)key) & 0x8000) != 0);
        }

        public bool IsToggleKeyInEffect(VirtualKeyShort key)
        {
            return (NativeMethods.GetKeyState((int)key) & 0x1000) != 0;
        }
    }
}
