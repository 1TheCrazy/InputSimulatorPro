using InputSimulatorPro.Resources.Natives;

namespace InputSimulatorPro.Resources
{
    internal class Keyboard : IKeyboard
    {
        public void KeyDown(VirtualKeyShort keyShort)
        {
            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Keyboard;
            input[0].Group.Keyboard.VirtualKey = keyShort;
            input[0].Group.Keyboard.Flags = ((int)keyShort & 0x0100) == 0x0100 ? (KeyboardFlags.Extendedkey) : 0;

            InputDispatcher.DispatchInput(input);
        }

        public void KeyUp(VirtualKeyShort keyShort)
        {
            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Keyboard;
            input[0].Group.Keyboard.Flags = ((int)keyShort & 0x0100) == 0x0100 ? (KeyboardFlags.Keyup | KeyboardFlags.Extendedkey) : KeyboardFlags.Keyup;
            input[0].Group.Keyboard.VirtualKey = keyShort;

            InputDispatcher.DispatchInput(input);
        }

        public void TextEntry(string text)
        {
            foreach(char chr in text.ToCharArray())
            {
                INPUT[] input = new INPUT[1];
                input[0].Type = InputType.Keyboard;
                input[0].Group.Keyboard.ScanCodeShort = chr;
                input[0].Group.Keyboard.Flags = KeyboardFlags.Unicode;

                InputDispatcher.DispatchInput(input);

                input[0].Group.Keyboard.Flags = KeyboardFlags.Keyup | KeyboardFlags.Unicode;

                InputDispatcher.DispatchInput(input);
            }
        }

        public void SimultaneousKeyPress(VirtualKeyShort[] keyShorts)
        {
            INPUT[] inputs = new INPUT[keyShorts.Length];
            
            for(int i = 0; i < inputs.Length; i++)
            {
                inputs[i].Type = InputType.Keyboard;
                inputs[i].Group.Keyboard.VirtualKey = keyShorts[i];
                inputs[i].Group.Keyboard.Flags = ((int)keyShorts[i] & 0x0100) == 0x0100 ? (KeyboardFlags.Extendedkey) : 0;
            }

            InputDispatcher.DispatchInput(inputs);

            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i].Type = InputType.Keyboard;
                inputs[i].Group.Keyboard.VirtualKey = keyShorts[i];
                inputs[i].Group.Keyboard.Flags = ((int)keyShorts[i] & 0x0100) == 0x0100 ? (KeyboardFlags.Keyup | KeyboardFlags.Extendedkey) : KeyboardFlags.Keyup;
            }

            InputDispatcher.DispatchInput(inputs);
        }
        
        public void SimultaneousKeyDown(VirtualKeyShort[] keyShorts)
        {
            INPUT[] inputs = new INPUT[keyShorts.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i].Type = InputType.Keyboard;
                inputs[i].Group.Keyboard.VirtualKey = keyShorts[i];
                inputs[i].Group.Keyboard.Flags = ((int)keyShorts[i] & 0x0100) == 0x0100 ? (KeyboardFlags.Extendedkey) : 0;
            }

            InputDispatcher.DispatchInput(inputs);
        }

        public void SimultaneousKeyUp(VirtualKeyShort[] keyShorts)
        {
            INPUT[] inputs = new INPUT[keyShorts.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i].Type = InputType.Keyboard;
                inputs[i].Group.Keyboard.VirtualKey = keyShorts[i];
                inputs[i].Group.Keyboard.Flags = ((int)keyShorts[i] & 0x0100) == 0x0100 ? (KeyboardFlags.Keyup | KeyboardFlags.Extendedkey) : KeyboardFlags.Keyup;
            }

            InputDispatcher.DispatchInput(inputs);
        }

        public void KeyPress(VirtualKeyShort keyShort)
        {
            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Keyboard;
            input[0].Group.Keyboard.Flags = ((int)keyShort & 0x0100) == 0x0100 ? (KeyboardFlags.Extendedkey) : 0;
            input[0].Group.Keyboard.VirtualKey = keyShort;

            InputDispatcher.DispatchInput(input);

            input[0].Group.Keyboard.Flags = ((int)keyShort & 0x0100) == 0x0100 ? (KeyboardFlags.Keyup | KeyboardFlags.Extendedkey): KeyboardFlags.Keyup;

            InputDispatcher.DispatchInput(input);
        }

        public void Sleep(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        public void Sleep(TimeSpan timeSpan)
        {
            Thread.Sleep(timeSpan);
        }
    }
}
