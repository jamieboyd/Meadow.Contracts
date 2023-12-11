using Meadow.Units;
using System;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Speakers;

/// <summary>
/// Audio tones generator that plays tones at a given frequency
/// </summary>
public interface IToneGenerator
{
    /// <summary>
    /// Plays the tone with a specified frequency and duration
    /// </summary>
    /// <param name="frequency">The tone frequency</param>
    /// <param name="duration">The duration to play the tone</param>
    Task PlayTone(Frequency frequency, TimeSpan duration);

    /// <summary>
    /// Stops the tone playing
    /// </summary>
    void StopTone();

    /// <summary>
    /// Set the playback volume
    /// </summary>
    /// <param name="volume">The volume from 0 (off) to 1 (max volume)</param>
    void SetVolume(float volume);
}