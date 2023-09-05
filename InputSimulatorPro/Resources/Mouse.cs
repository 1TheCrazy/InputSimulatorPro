using InputSimulatorPro.Resources.Natives;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources
{
    internal class Mouse : IMouse
    {
        public void InterpolateCursorPositionRelative(Vector2 coordinates, float t)
        {
            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Mouse;
            input[0].Group.Mouse.Flags = MouseFlags.Move;

            float passedTime = 0.0f;
            float deltaTime = 0.0f;

            float __x = 0;
            float __y = 0;

            var watch = new Stopwatch();
            
            while (passedTime <= t)
            {
                watch.Restart();
                __x += ((int)coordinates.X / t) * deltaTime - (int)(((int)coordinates.X / t) * deltaTime) - (int)__x;
                __y += ((int)coordinates.Y / t) * deltaTime - (int)(((int)coordinates.Y / t) * deltaTime) - (int)__y;

                float _x = ((int)coordinates.X / t) * deltaTime + (int)__x;
                float _y = ((int)coordinates.Y / t) * deltaTime + (int)__y;

                input[0].Group.Mouse.x = (int)_x;
                input[0].Group.Mouse.y = (int)_y;

                InputDispatcher.DispatchInput(input);

                passedTime += deltaTime;
                deltaTime = (float)watch.Elapsed.TotalMilliseconds / 1000f;
            }
        }
        
        public void InterpolateCursorPositionAbsolute(Vector2 startCoordinates, Vector2 endCoordinates, float t, bool useNormalizedCoordinates = true, bool virtualDesktop = false)
        {
            if (virtualDesktop && useNormalizedCoordinates) throw new ArgumentException("'NormalizedCoordinates can't be used together with 'VirtualDesktop'.");

            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Mouse;

            if (virtualDesktop) input[0].Group.Mouse.Flags = MouseFlags.Move | MouseFlags.Absolute | MouseFlags.VirtualDesk;
            else input[0].Group.Mouse.Flags = MouseFlags.Move | MouseFlags.Absolute;

            input[0].Group.Mouse.x = (int)startCoordinates.X;
            input[0].Group.Mouse.y = (int)startCoordinates.Y;

            InputDispatcher.DispatchInput(input);

            float passedTime = 0.0f;
            float deltaTime = 0.0f;

            var watch = new Stopwatch();

            while (passedTime <= t)
            {
                watch.Restart();

                float _x = (endCoordinates.X / t) * passedTime + startCoordinates.X;
                float _y = (endCoordinates.Y / t) * passedTime + startCoordinates.Y;

                if (useNormalizedCoordinates)
                {
                    Console.WriteLine((int)_x);
                    Console.WriteLine((int)((65535.0 / NativeMethods.GetSystemMetrics(0)) * (int)_x));
                    input[0].Group.Mouse.x = (int)((65535.0 / NativeMethods.GetSystemMetrics(0)) * (int)_x);
                    input[0].Group.Mouse.y = (int)((65535.0 / NativeMethods.GetSystemMetrics(1)) * (int)_y);
                }
                else
                {
                    input[0].Group.Mouse.x = (int)_x;
                    input[0].Group.Mouse.y = (int)_y;
                }

                InputDispatcher.DispatchInput(input);

                passedTime += deltaTime;
                deltaTime = (float)watch.Elapsed.TotalMilliseconds / 1000f;
            }
        }

        public void SetCursorPositionAbsolute(Vector2 coordinates, bool useNormalizedCoordinates = true, bool virtualDesktop = false)
        {
            if (virtualDesktop && useNormalizedCoordinates) throw new ArgumentException("'NormalizedCoordinates can't be used together with 'VirtualDesktop'.");
            
            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Mouse;
            
            if (virtualDesktop) input[0].Group.Mouse.Flags = MouseFlags.Move | MouseFlags.Absolute | MouseFlags.VirtualDesk;
            else input[0].Group.Mouse.Flags = MouseFlags.Move | MouseFlags.Absolute;

            if (useNormalizedCoordinates) { input[0].Group.Mouse.x = (int)((65535.0 / NativeMethods.GetSystemMetrics(0)) * (int)coordinates.X); input[0].Group.Mouse.y = (int)((65535.0 / NativeMethods.GetSystemMetrics(1)) * (int)coordinates.Y); }
            else { input[0].Group.Mouse.x = (int)coordinates.X; input[0].Group.Mouse.y = (int)coordinates.X; }

            InputDispatcher.DispatchInput(input);        
        }

        public void SetCursorPositionRelative(Vector2 coordinates)
        {
            INPUT[] input = new INPUT[1];

            input[0].Type = InputType.Mouse;
            input[0].Group.Mouse.x = (int)coordinates.X;
            input[0].Group.Mouse.y = (int)coordinates.Y;
            input[0].Group.Mouse.Flags = MouseFlags.Move;

            InputDispatcher.DispatchInput(input);
        }

        public void KeyDown(MouseButton button)
        {
            INPUT[] input = new INPUT[1];

            input[0].Type = InputType.Mouse;
            
            switch (button)
            {
                case MouseButton.left:
                    input[0].Group.Mouse.Flags = MouseFlags.LeftDown;
                    break;
                
                case MouseButton.right:
                    input[0].Group.Mouse.Flags = MouseFlags.RightDown;
                    break;
                
                case MouseButton.middle:
                    input[0].Group.Mouse.Flags = MouseFlags.MiddleDown;
                    break;
                
                case MouseButton.fourth:
                    input[0].Group.Mouse.MouseData = (uint)MouseData.XButton1;
                    input[0].Group.Mouse.Flags = MouseFlags.XDown;
                    break;
                
                case MouseButton.fifth:
                    input[0].Group.Mouse.MouseData = (uint)MouseData.XButton2;
                    input[0].Group.Mouse.Flags = MouseFlags.XDown;
                    break;
            }

            InputDispatcher.DispatchInput(input);
        }

        public void KeyUp(MouseButton button)
        {
            INPUT[] input = new INPUT[1];

            input[0].Type = InputType.Mouse;

            switch (button)
            {
                case MouseButton.left:
                    input[0].Group.Mouse.Flags = MouseFlags.LeftUp;
                    break;

                case MouseButton.right:
                    input[0].Group.Mouse.Flags = MouseFlags.RightUp;
                    break;

                case MouseButton.middle:
                    input[0].Group.Mouse.Flags = MouseFlags.MiddleUp;
                    break;

                case MouseButton.fourth:
                    input[0].Group.Mouse.MouseData = (uint)MouseData.XButton1;
                    input[0].Group.Mouse.Flags = MouseFlags.XUp;
                    break;

                case MouseButton.fifth:
                    input[0].Group.Mouse.MouseData = (uint)MouseData.XButton2;
                    input[0].Group.Mouse.Flags = MouseFlags.XUp;
                    break;
            }

            InputDispatcher.DispatchInput(input);
        }

        public void KeyPress(MouseButton button)
        {
            INPUT[] input = new INPUT[1];

            input[0].Type = InputType.Mouse;
            var up = MouseFlags.Null;
            switch (button)
            {
                case MouseButton.left:
                    input[0].Group.Mouse.Flags = MouseFlags.LeftDown;
                    
                    up = MouseFlags.LeftUp;
                    break;

                case MouseButton.right:
                    input[0].Group.Mouse.Flags = MouseFlags.RightDown;
                    
                    up = MouseFlags.RightUp;
                    break;

                case MouseButton.middle:
                    input[0].Group.Mouse.Flags = MouseFlags.MiddleDown;
                    
                    up = MouseFlags.MiddleUp;
                    break;

                case MouseButton.fourth:
                    input[0].Group.Mouse.MouseData = (uint)MouseData.XButton1;
                    input[0].Group.Mouse.Flags = MouseFlags.XDown;

                    up = MouseFlags.XUp;
                    break;

                case MouseButton.fifth:
                    input[0].Group.Mouse.MouseData = (uint)MouseData.XButton2;
                    input[0].Group.Mouse.Flags = MouseFlags.XDown;

                    up = MouseFlags.XUp;
                    break;
            }

            InputDispatcher.DispatchInput(input);
            input[0].Group.Mouse.Flags = up;
            InputDispatcher.DispatchInput(input);
        }

        public void VerticalWheel(int scroll)
        {
            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Mouse;
            input[0].Group.Mouse.MouseData = (uint)((int)MouseData.DefaultScroll * scroll);
            input[0].Group.Mouse.Flags = MouseFlags.HorizontalWheel;

            InputDispatcher.DispatchInput(input);
        }

        public void HorizontalWheel(int scroll)
        {
            INPUT[] input = new INPUT[1];
            input[0].Type = InputType.Mouse;
            input[0].Group.Mouse.MouseData = (uint)((int)MouseData.DefaultScroll * scroll);
            input[0].Group.Mouse.Flags = MouseFlags.HorizontalWheel;

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
