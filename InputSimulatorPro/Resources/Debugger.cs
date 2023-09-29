using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources
{
    /// <summary>
    /// the class that holds info and options for debugging
    /// </summary>
    public class Debugger : IDebugger
    {
        /// <summary>
        /// A <see cref="bool"/> that tells wether debug info should be printed to the console. Default false.
        /// </summary>
        public bool DoDebugInfo { get; set; } = false;
        /// <summary>
        /// A <see cref="string"/> that holds the current version of <see cref="InputSimulatorPro"/>.
        /// </summary>
        public string Version { get { return "1.0.0.2"; } }
        /// <summary>
        /// A <see cref="string"/> that holds the author of this code.
        /// </summary>
        public string Author { get { return "1TheCrazy"; } }
        /// <summary>
        /// A method used for logging the info. Depends on <see cref="DoDebugInfo"/>.
        /// </summary>
        /// <param name="message">The message that should be logged to the console</param>
        public void Log(string message)
        {
            if (DoDebugInfo) { Console.WriteLine($"{message}"); }
        }
    }
}
