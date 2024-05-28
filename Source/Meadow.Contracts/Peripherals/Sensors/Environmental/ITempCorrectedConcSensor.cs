using System;
using System.Threading.Tasks;
using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Environmental;


/// <summary>
/// Interface for concentration sensor with associated temperature sensor for temperature correction
/// </summary>
public interface ITempCorrectedConcSensor : ISensor<Temperature>, ISamplingSensor<Temperature>, ISensor<ConcentrationInWater>, ISamplingSensor<ConcentrationInWater>
{
    /// <summary>
    /// Last Oxygen concentration read by sensor
    /// </summary>
    public ConcentrationInWater Concentration {get; set;}

    /// <summary>
    /// Last water temperature read by sensor
    /// </summary>
    public Temperature WaterTemperature { get; set; }

    /// <summary>
    /// Event handlder for changes in temperature
    /// </summary>
    public event EventHandler<Temperature> TemperatureChanged;

    /// <summary>
    /// Event handlder for changes in dissolved oxygen
    /// </summary>
    public event EventHandler<ConcentrationInWater> ConcentrationChanged;

    /// <summary>
    /// Reads both temperature and concentration sensors
    /// </summary>
    /// <param name="sampleCount">Number of samples to average and return</param>
    /// <param name="sampleInterval">A TimeSpan that specifies how long to
    /// wait between readings</param>
    /// <returns>a tuple of temperature and concentration</returns>
    public Task<(Temperature, ConcentrationInWater)> Read(int sampleCount = 10, int sampleInterval = 40);

    /// <summary>
    /// Starts updating both temperature and concentration sensors
    /// </summary>
    /// <param name="sampleCount">Number of samples to average</param>
    /// <param name="sampleIntervalDuration">Time between taking samples</param>
    /// <param name="sampleSleepDuration"></param>
    public void StartUpdating(
        int sampleCount = 10,
        int sampleIntervalDuration = 40,
        int sampleSleepDuration = 0);

}

