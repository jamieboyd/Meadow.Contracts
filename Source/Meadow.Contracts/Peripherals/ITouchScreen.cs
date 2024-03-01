using Meadow.Peripherals.Displays;
using System;

namespace Meadow.Hardware;

public struct CalibrationPoint(int rawX, int screenX, int rawY, int screenY)
{
    public int ScreenX => screenX;
    public int ScreenY => screenY;
    public int RawX => rawX;
    public int RawY => rawY;
}

/// <summary>
/// Represents data for touchscreen events
/// </summary>
/// <param name="x">The X position of the touch event</param>
/// <param name="y">The Y position of the touch event</param>
/// <param name="z">The Z position (if supported) of the touch event</param>
public struct TouchPoint(int x, int y, int? z = 0)
    : IEquatable<TouchPoint?>, IEquatable<TouchPoint>
{
    /// <summary>
    /// Gets the X position of the touch point
    /// </summary>
    public int X => x;
    /// <summary>
    /// Gets the Y position of the touch point
    /// </summary>
    public int Y => y;
    /// <summary>
    /// Gets the Z position of the touch point
    /// </summary>
    public int? Z => z;

    /// <inheritdoc/>
    public bool Equals(TouchPoint other)
    {
        if (x != other.X) return false;
        if (y != other.Y) return false;
        return true;
    }

    /// <inheritdoc/>
    public bool Equals(TouchPoint? other)
    {
        if (other == null) return false;
        return Equals(this, other.Value);
    }
}

/// <summary>
/// An event delegate for touchscreen events
/// </summary>
public delegate void TouchEventHandler(ITouchScreen sender, TouchPoint point);

public interface ICalibratableTouchscreen : ITouchScreen
{
    public bool IsCalibrated { get; }

    public void SetCalibrationData(CalibrationPoint p1, CalibrationPoint p2);
}

/// <summary>
/// Represents a touch screen device
/// </summary>
public interface ITouchScreen
{
    /// <summary>
    /// Event raised when the touchscreen is pressed
    /// </summary>
    public event TouchEventHandler TouchDown;
    /// <summary>
    /// Event raised when the touchscreen is released
    /// </summary>
    public event TouchEventHandler TouchUp;
    /// <summary>
    /// Event raised when a cycle of press and release has occurred
    /// </summary>
    public event TouchEventHandler TouchClick;
    /// <summary>
    /// Event raised when a cycle of press and release has occurred
    /// </summary>
    public event TouchEventHandler TouchMoved;

    /// <summary>
    /// Returns <b>true</b> if the touchscreen is currently being touched, otherwise <b>false</b>
    /// </summary>
    public bool IsTouched { get; }

    public RotationType Rotation { get; }
}