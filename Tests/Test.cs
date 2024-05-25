using InputSimulatorPro;
using InputSimulatorPro.Resources.Natives;
using static InputSimulatorPro.Resources.Natives.VirtualKeyShort;
using static InputSimulatorPro.InputSimulator;


public class InputTests
{
    public static void SkyBlockFarmingMacro()
    {
        InputSimulator.Debugger.DoDebugInfo = true;

        Thread.Sleep(10000);


        NativeMethods.SetForegroundWindow(NativeMethods.FindWindow(null, "Minecraft 1.8.9"));
        Thread.Sleep(1000);

        InputSimulator.Keyboard.KeyPress(VirtualKeyShort.ESCAPE);
        Thread.Sleep(1000);

        InputSimulator.Mouse.KeyDown(MouseButton.left);


        while (true)
        {
            for (int i = 0; i < 9; i++)
            {
                InputSimulator.Keyboard.KeyDown(VirtualKeyShort.KEY_A);
                Thread.Sleep(84000);
                InputSimulator.Keyboard.KeyUp(VirtualKeyShort.KEY_A);
                InputSimulator.Keyboard.KeyDown(VirtualKeyShort.KEY_W);
                Thread.Sleep(1500);
                InputSimulator.Keyboard.KeyUp(VirtualKeyShort.KEY_W);
                InputSimulator.Keyboard.KeyDown(VirtualKeyShort.KEY_D);
                Thread.Sleep(84000);
                InputSimulator.Keyboard.KeyUp(VirtualKeyShort.KEY_D);
                InputSimulator.Keyboard.KeyDown(VirtualKeyShort.KEY_W);
                Thread.Sleep(1500);
                InputSimulator.Keyboard.KeyUp(VirtualKeyShort.KEY_W);

            }

            InputSimulator.Keyboard.KeyDown(VirtualKeyShort.SPACE);
            Thread.Sleep(50);
            InputSimulator.Keyboard.KeyUp(VirtualKeyShort.SPACE);
            Thread.Sleep(50);
            InputSimulator.Keyboard.KeyDown(VirtualKeyShort.SPACE);
            Thread.Sleep(50);
            InputSimulator.Keyboard.KeyUp(VirtualKeyShort.SPACE);
            Thread.Sleep(50);
            InputSimulator.Keyboard.KeyDown(VirtualKeyShort.SPACE);
            Thread.Sleep(80);
            InputSimulator.Keyboard.KeyUp(VirtualKeyShort.SPACE);

            InputSimulator.Keyboard.KeyDown(VirtualKeyShort.KEY_S);
            Thread.Sleep(9000);
            InputSimulator.Keyboard.KeyUp(VirtualKeyShort.KEY_S);

            InputSimulator.Keyboard.KeyDown(VirtualKeyShort.SPACE);
            Thread.Sleep(50);
            InputSimulator.Keyboard.KeyUp(VirtualKeyShort.SPACE);
            Thread.Sleep(50);
            InputSimulator.Keyboard.KeyDown(VirtualKeyShort.SPACE);
            Thread.Sleep(50);
            InputSimulator.Keyboard.KeyUp(VirtualKeyShort.SPACE);
        }
    }
    public static void WhyDidMyPcCrash()
    {
        Thread.Sleep(1000); // My laptop is verry laggy :/
        Keyboard.SimultaneousKeyPress(new VirtualKeyShort[] { RWIN, KEY_R});
        Keyboard.Sleep(1000);
        Keyboard.TextEntry("cmd");
        Keyboard.KeyPress(RETURN);
        Keyboard.Sleep(2000);
        Keyboard.TextEntry("shutdown /s");
        Keyboard.KeyPress(RETURN);
    }
    public static void MouseTest1()
    {
        Thread.Sleep(2000); // laggy laptop again :/
        Mouse.InterpolateCursorPositionAbsolute(new System.Numerics.Vector2(0, 0), new System.Numerics.Vector2(1920, 1080), 1f);
    }
    public static void MouseTest2()
    {
        Thread.Sleep(2000); // laggy laptop again :/
        Mouse.SetCursorPositionAbsolute(new System.Numerics.Vector2(1920, 0), true); //closes vs
        Mouse.KeyPress(MouseButton.left);
    }
}
