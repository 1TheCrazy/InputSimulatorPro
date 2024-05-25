# InputSimulatorPro

A wrapper for the User32.SendInput method that provides features unique to this package.

## [NuGet](https://www.nuget.org/packages/InputSimulatorPro/)

[![NuGet](https://img.shields.io/nuget/dt/InputSimulatorPro.svg?style=flat&label=InputSimulatorPro&logo=nuget&color=#6A994E)](https://www.nuget.org/packages/InputSimulatorPro/)

__How to install:__ (Visual Studio) 
1. Right-click your project in the Solution Explorer
2. Click 'Manage NuGet Packages...'
3. Select the 'Browse' tab
4. Enter 'InputSimulatorPro' in the search bar
5. Select the result, click 'Install' and 'OK'
6. Add a `using` statement at the top of your code

## [Dll](./.dll/InputSimulatorPro.dll)

__How to install:__ (Visual Studio)
1. Download the [InputSimulatorPro.dll](./.dll/InputSimulatorPro)-file
2. In the solution explorer of your project, right-click the 'Dependencies'-Tab and click on 'Add Project Reference'
3. Click on 'Browse' and locate the file
4. Click 'OK'
5. Add a `using` statement at tthe top of your code

   *If you can, use the NuGet package for automated updates!*
   
## Changelog
v1.0.0 : Initial Release

v1.0.1 : Hotfix, structs and enums used for creating the INPUT struct were not public.

v1.0.2 : Removed unnecessary WriteLine-statements and fixed not working Mouse.VerticalWheel.

v1.0.3 : General Updates

v1.0.4 : Fixed Keyboard.SimultaneousKeyPress

## Docs

<details>
  <summary>Introduction</summary>
  
  The main class of this package is `InputSimulator`. It holds references to `IKeyboard`,`IMouse`,`IKeyStateGrabber` and `IDebugger`. Those hold the main features of the package.
</details>

<details>
  <summary>IKeyboard</summary>
  
  `IKeyboard` (or in the `InputSimulator`-class a `Keyboard`-instance) holds methods for keyboard related input simulations;

  
  __KeyDown:__
  ```
  public void KeyDown(VirtualKeyShort keyShort)
  ```

  Takes in a `VirtualKeyShort` representing the key you want to simulate the KeyDown input for.

  __KeyUp:__
  ```
  public void KeyUp(VirtualKeyShort keyShort)
  ```
  Takes in a `VirtualKeyShort` representing the key you want to simulate the KeyUp input for.


  __KeyPress:__
  ```
  public void KeyPress(VirtualKeyShort keyShort)
  ```
  Takes in a `VirtualKeyShort` representing the key you want to simulate a keypress (down and up input) for.

  
  __TextEntry:__
  ```
  public void TextEntry(string text)
  ```
  Takes in a `string` representing the Text you want to enter. The method simulates the KeyDown and KeyUp input for every char in the string by mapping it to the corresponding `VirtualKeyCode`. 


  __SimultaneousKeyPress:__
  ```
  public void SimultaneousKeyPress(VirtualKeyShort[] keyShorts)
  ```
  Takes in an array of `VirtualKeyShort` representing the keys you want to simulate a keypress for at the same time. This can be used to simulate inputs that use the CTRL-key as a modifyer key.


  __SimultaneousKeyDown__
  ```
  public void SimultaneousKeyDown(VirtualKeyShort[] keyShorts)
  ```
  Takes in an array of `VirtualKeyShort` representing the keys you want to simulate a key down input  for at the same time. This can be used to simulate inputs that use the CTRL-key as a modifyer key.


  __SimultaneousKeyUp__
  ```
  public void SimultaneousKeyDown(VirtualKeyShort[] keyShorts)
  ```
  Takes in an array of `VirtualKeyShort` representing the keys you want to simulate a key up input for at the same time. This can be used to simulate inputs that use the CTRL-key as a modifyer key.


  __Sleep__
  ```
  public void Sleep(int milliseconds)
  ```
  Takes in an `int` that represents the timeout of the Thread in milliseconds. It utilizes `Thread.Sleep` and is just here for practical purposes. This method also has an overload which takes in a `TimeSpan`
  representing the timeout.
</details>

<details>
  <summary>IMouse</summary>

  `IMouse` (or in the `InputSimulator`-class a `Mouse`-instance) holds methods for mouse related input simulations;


  __KeyDown__
  ```
  public void KeyDown(MouseButton button)
  ```
  Takes in a `MouseButton` representing the button you want simulate a down input for.


  __KeyUp__
  ```
  public void KeyUp(MouseButton button)
  ```
  Takes in a `MouseButton` representing the button you want simulate an up input for.


  __KeyPress__
  ```
  public void KeyPress(MouseButton button)
  ```
  Takes in a `MouseButton` representing the button you want to simulate a press input for (down and up input).


  __SetCursorPositionRelative__
  ```
  public void SetCursorPositionRelative(Vector2 coordinates)
  ```
  Takes in a `Vector2` representing the relative pixels amount you want to set the cursor position to. The (0,0) coordinate is always at the cursors current position (thats why it's relative movement).


  __SetCursorPositionAbsolute__
  ```
  public void SetCursorPositionAbsolute(Vector2 coordinates, bool useNormalizedCoordinates, bool virtualDesktop = false);
  ```
  Takes in a `Vector2` coordinates, `bool` useNormalizedCoordinates, `bool` virtualDesktop.

  The coordinates represent the coordinates you want to set the cursors position to. If useNormaliedCoordinates is true, the coordinates are represented in pixels, if not the coordinates should be given in a 
  range of 65535.0 to 0. useNormalizedCoordinates utilizes the `GetSystemMetrics`-method from the Windows-API and normalizes the coordinates in the scale of the MAIN monitor.

  If virtualDesktop is true, it maps the coordinates to the whole virtual desktop. This is used for multi-monitor setups.

  useNormalizedCoordinates and virtualDesktop can't be used together.

  useNormalizedCoordinates may not be pixel-perfect due to floating point errors and how deltaTime is calculated. (ca. 8p out of 10.000p, no guarantee on that)


  __InterpolateCursorPositionRelative__
  ```
  public void InterpolateCursorPositionRelative(Vector2 coordinates, float t);
  ```
  Takes in a `Vector2` representing the coordinates you want interpolate the mouse position to, over a given period of time `t` in seconds. The start position is always the cursor (0,0). 
  The coordinates are in pixels.


  __InterpolateCursorPositionAbsolute__
  ```
  public void InterpolateCursorPositionAbsolute(Vector2 startCoordinates, Vector2 endCoordinates, float t, bool useNormalizedCoordinates = true, bool virtualDesktop = false);
  ```
  Takes in a `Vector2` startCoordinates, `Vector2` endCoordinates, `float` t, `bool` useNormalizedCoordinates, `bool` virtualDekstop.

  The `Vector2` startCoordinate represents the coordinates where the cursor position interpolation should be started, the endCoordinates the end. `t`represents the time you want to interpolate the
  cursor position over in seconds.

  If useNormalizedCoordinates is true, the coordinates are normalized to the MAIN monitor using the `GetSystemMetrics`-method from the Windows-API. If not, the coordinates should be given in a range of 
  65535.0 to 0.

  If virtualDesktop is true the coordinates are mapped to the whole virtual desktop. This is used for multi-monitor setups.

  useNormalizedCoordinates and virtualDesktop can't be used together.

  useNormalizedCoordinates may not be pixel-perfect due to floating point errors and how deltaTime is calculated. (ca. 8p out of 10.000p, no guarantee on that)


  __VerticalWheel__
  ```
  public void VerticalWheel(int scroll)
  ```
  Takes in a `int` representing the amount of vertical scroll. The scroll amount is multiplied by the default amount it takes to scroll one notch on a mouse (120)


  
  __HorizontalWheel__
  ```
  public void HorizontalWheel(int scroll)
  ```
  Takes in a `int` representing the amount of horizontal scroll. The scroll amount is multiplied by the default amount it takes to scroll one notch on a mouse (120)


  __Sleep__
  ```
  public void Sleep(int milliseconds)
  ```
  Takes in an `int` that represents the timeout of the Thread in milliseconds. It utilizes `Thread.Sleep` and is just here for practical purposes. This mthod also has an overload which takes in a `TimeSpan`
  representing the timeout.
</details>

<details>
  <summary>IKeyStateGrabber</summary>
  
  `IKeyStateGrabber` (or in the `InputSimulator`-class a `KeyStateGrabber`-instance) holds methods for checking the state of different keys;


  __IsVirtualKeyDown__
  ```
  public bool IsVirtualKeyDown(VirtualKeyShort key)
  ```
  Takes in a `VirtualKeyShort` representing the key you want to check if the virtual key is down. Returns true if it is.


  __IsVirtualKeyUp__
  ```
  public bool IsVirtualKeyUp(VirtualKeyShort key)
  ```
  Takes in a `VirtualKeyShort` representing the key you want to check if the virtual key is up. Returns true if it is.


  __IsHardwareKeyDown__
  ```
  public bool IsVirtualKeyDown(VirtualKeyShort key)
  ```
  Takes in a `VirtualKeyShort` representing the key you want to check if the physical key is down. Returns true if it is.


  __IsHardwareKeyUp__
  ```
  public bool IsVirtualKeyUp(VirtualKeyShort key)
  ```
  Takes in a `VirtualKeyShort` representing the key you want to check if the physical key is up. Returns true if it is.


  __IsToggleKeyInEffect__
  ```
  public bool IsToggleKeyInEffect(VirtualKeyShort key)
  ```
  Takes in a `VirtualKeyShort` representing the key want to checck if it is in effect. This can be used to check wether a CTRL or SHIFTLOCK key is in effect. This can also be used to check if a 
  regular key is in effect.

</details>

<details>
  <summary>IDebugger</summary>

  `IDebugger` (or in the `InputSimulator`-class a `Debugger`-instance) holds debug-related infos;


  __DoDebugInfo__
  ```
  public bool DoDebugInfo
  ```
  The `bool` defines wether debug info should be printed to the console.


  __Version__
  ```
  public string Version
  ```
  Returns the current Version you are using


  __Author__
  ```
  public string Author
  ```
  Returns my GitHub name.


  __Log__
  ```
  public void Log(string message)
  ```
  Logs a message to the console if DoDebugInfo is true.
</details>

<details>
  <summary>NativeMethods</summary>
  
  The `NativeMethods`-class holds all the methods from the Windows-API used in this package, but also a few methods that can be useful while working with makros;


  __SetForegroundWindow__
  ```
  [DllImport("user32.DLL")] public static extern bool SetForegroundWindow(IntPtr hWnd)
  ```
  Takes in a `IntPtr` representing the window you want to set the foreground (focus) to.


  __FindWindows__
  ```
  [DllImport("user32.DLL", CharSet = CharSet.Unicode)] public static extern IntPtr FindWindow(string? lpClassName, string lpWindowName)
  ```
  Takes in two string, `lpClassName` representing the class name of the window you want to find and `lpWindowName` representing the exact window name of the window you want to find.

  In my use-case `lpClassName` doesn't work too well, so I just pass in a null and the exact window name.
  
  Returns an `IntPtr` representing the window.

  __Usage__
  
  You can use `FindWindow` and pass it into `SetForegroundWindow` to change the focus

  ### Example
  ```
  using InputSimulatorPro.Resources.Natives;

  NativeMethods.SetForegroundWindow(NativeMethods.FindWindow(null , "Minecraft 1.8.9"));
  ```
</details>

<details>
  <summary>Remarks</summary>
  
  The `SendInput` works by inserting inputs into the input stream of the device. These inputs are then executed like they are from a physical input and react with app-events, e.g. closes a tab in a 
  browser when you press CTRL-W.

  This also brings security flaws that are prevented like this:

  >This function is subject to UIPI. Applications are permitted to inject input only into applications that are at an equal or lesser integrity level.

  This means that the code you are running has low or medium integrity and is not permitted to send inputs to higher integrity application (e.g. system).

  Because any inputs from the user or this application are put into an Input-Buffer that holds all inputs, user inputs can mess with the inputs sent from the application.
</details>
