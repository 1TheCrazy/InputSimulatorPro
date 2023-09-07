using System;
using InputSimulatorPro.Resources.Natives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace InputSimulatorPro.Resources
{
    /// <summary>
    /// A class used for dispatching and sending inputs to the native SendInput method.
    /// </summary>
    public class InputDispatcher
    {
        /// <summary>
        /// Dispatches the inputs.
        /// </summary>
        /// <param name="inputs"> An <see cref="INPUT"/> array that holds the inputs that should be simulated</param>
        /// <returns> 
        /// A <see cref="bool"/> that indicates wether all inputs were inserted correctly into the input stream of the device
        /// A <see cref="int"/> that indicates how many inputs were successfully inserted into the input stream of the device
        /// A <see cref="int"/> that indicates how many inputs should've been inserted into the input stream of the device
        /// A <see cref="string"/> that holds a message with extra info.
        /// </returns>
        public static (bool?, int?, int?, string?) DispatchInput(INPUT[] inputs)
        {
            var creativeName = NativeMethods.SendInput((uint)inputs.Length, inputs, INPUT.Size);

            if(creativeName == 0) {
                InputSimulator.Debugger.Log($"At {new StackTrace().GetFrame(1)?.GetMethod()}:\nNone of the inputs were inserted correctly into the Input-Stream of the device.");

                return (false, (int)creativeName, inputs.Length, $"At {new StackTrace().GetFrame(1)?.GetMethod()}:\nNone of the inputs were inserted correctly into the Input-Stream of the device."); 
            }
            
            if(creativeName < inputs.Length) {
                InputSimulator.Debugger.Log($"At {new StackTrace().GetFrame(1)?.GetMethod()}:\nSome of the inputs were inserted correctly into the Input-Stream of the device.");

                return (false, (int)creativeName, inputs.Length, $"At {new StackTrace().GetFrame(1)?.GetMethod()}:\nSome of the inputs were not inserted correctly into the Input-Stream of the device."); 
            }
            
            if(creativeName == inputs.Length) {
                InputSimulator.Debugger.Log($"At {new StackTrace().GetFrame(1)?.GetMethod()}:\nAll of the inputs were inserted correctly into the Input-Stream of the device. At");

                return (true, (int)creativeName, inputs.Length, $"At {new StackTrace().GetFrame(1)?.GetMethod()}:\nAll of he inputs were inserted correctly into the Input-Stram of the device."); 
            }

            return (null, null, null, null);
        }
    }
}
