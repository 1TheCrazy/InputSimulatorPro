# InputSimulatorPro

A wrapper for the User32.SendInput method that provides features unique to this package.

## NuGet

[![NuGet](https://img.shields.io/nuget/dt/InputSimulatorPro.svg?style=flat&label=InputSimulatorPro&logo=nuget&color=#6A994E)](https://www.nuget.org/packages/InputSimulatorPro/)

## Docs

<details>
  <summary>Introduction</summary>
  
  The main class of this package is `InputSimulator`. It holds references to `IKeyboard`,`IMouse`,`IDebugger` and `IKeyStateGrabber`. Those hold the main features of the package.
</details>

<details>
  <summary>IKeyboard</summary>
  
  `IKeyboard` (or int the `InputSimulator`-class a `Keyboard`-instance) holds methods for keyboard related input simulations;

  __KeyDown:__
  ```
  public void KeyDown(VirtualKeyShort keyShort)
  ```
  Takes in a `VirtualKeyShort` representing the key you want to simulate the KeyDown input for.
</details>
