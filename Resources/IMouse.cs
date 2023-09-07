using InputSimulatorPro.Resources.Natives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InputSimulatorPro.Resources
{
    /// <summary>
    /// The contract for <see cref="Mouse"/>. Used for simulating mouse-related inputs.
    /// </summary>
    public interface IMouse
    {
        /// <summary>
        /// Interpolates the cursors position relative to the last recorded position.
        /// </summary>
        /// <param name="coordinates">A <see cref="Vector2"/> that holds the enpoints of the cursor</param>
        /// <param name="t">A <see cref="float"/> that holds the time in seconds over with the cursors position should be interpolated</param>
        public void InterpolateCursorPositionRelative(Vector2 coordinates, float t);
        /// <summary>
        /// Interpolates the cursors position in absolute coordinates.
        /// </summary>
        /// <param name="startCoordinates">A <see cref="Vector2"/> that holds the startpoints of the cursor</param>
        /// <param name="endCoordinates">A <see cref="Vector2"/> that holds the endpoints of the cursor</param>
        /// <param name="t">A <see cref="float"/> that holds the time in seconds over with the cursors position should be interpolated</param>
        /// <param name="useNormalizedCoordinates">A <see cref="bool"/> that defines wether the given coordinates should be normalized to the main screens size. If false the coordinates should be in a range of 65535 to 0</param>
        /// <param name="virtualDesktop">A <see cref="bool"/> that defines wether the given coordinates should be mapped to the entire virtual desktop. Used for multi-monitor setups</param>
        public void InterpolateCursorPositionAbsolute(Vector2 startCoordinates, Vector2 endCoordinates, float t, bool useNormalizedCoordinates = true, bool virtualDesktop = false);
        /// <summary>
        /// Sets the cursors position to absolute coordinates.
        /// </summary>
        /// <param name="coordinates">A <see cref="float"/> that holds the coordinates the cursors position should be set to</param>
        /// <param name="useNormalizedCoordinates">A <see cref="bool"/> that defines wether the given coordinates should be normalized to the main screens size. If false the coordinates should be in a range of 65535 to 0</param>
        /// <param name="virtualDesktop">A <see cref="bool"/> that defines wether the given coordinates should be mapped to the entire virtual desktop. Used for multi-monitor setups</param>
        public void SetCursorPositionAbsolute(Vector2 coordinates, bool useNormalizedCoordinates, bool virtualDesktop = false);
        /// <summary>
        /// Sets the cursors position to relative coordinates.
        /// </summary>
        /// <param name="coordinates">A <see cref="Vector2"/> that holds the coordinates the cursors position should be set to in pixels</param>
        public void SetCursorPositionRelative(Vector2 coordinates);
        /// <summary>
        /// Simulates the down input for a given <see cref="MouseButton"/>
        /// </summary>
        /// <param name="button">The <see cref="MouseButton"/> that sould be used for this input simulation</param>
        public void KeyDown(MouseButton button);
        /// <summary>
        /// Simulates the up input for a given <see cref="MouseButton"/>
        /// </summary>
        /// <param name="button">The <see cref="MouseButton"/> that sould be used for this input simulation</param>
        public void KeyUp(MouseButton button);
        /// <summary>
        /// Simulates the press input for a given <see cref="MouseButton"/>
        /// </summary>
        /// <param name="button">The <see cref="MouseButton"/> that sould be used for this input simulation</param>
        public void KeyPress(MouseButton button);
        /// <summary>
        /// Simukates a horizontsl wheel scroll.
        /// </summary>
        /// <param name="scroll">The amount of scroll</param>
        public void HorizontalWheel(int scroll);
        /// <summary>
        /// Simukates a horizontsl wheel scroll.
        /// </summary>
        /// <param name="scroll">The amount of scroll</param>
        public void VerticalWheel(int scroll);
        /// <summary>
        /// Pause the Thread
        /// </summary>
        /// <param name="milliseconds">A <see cref="int"/> that holds the timeout of theThread in milliseconds</param>
        public void Sleep(int milliseconds);
        /// <summary>
        /// Pause the Thread
        /// </summary>
        /// <param name="timeSpan">A <see cref="TimeSpan"/> that holds the span of the timeout</param>
        public void Sleep(TimeSpan timeSpan);
    }
}
