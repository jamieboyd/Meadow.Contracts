using System;

namespace Meadow
{
    /// <summary>
    /// Provides a description of the Analog I/O capabilities of a platform
    /// </summary>
    public class AnalogCapabilities
    {
        protected int? _maxRawAdcVoltageValue;

        /// <summary>
        /// Creates an AnalogCapabilities instance
        /// </summary>
        /// <param name="hasAdc"></param>
        /// <param name="adcResolution"></param>
        public AnalogCapabilities(
            bool hasAdc,
            int? adcResolution
            )
        {
            this.HasAdc = hasAdc;
            this.AdcResolution = adcResolution;
        }

        /// <summary>
        /// Returns true if the platofm has an analog-to-digital converter
        /// </summary>
        public bool HasAdc { get; protected set; }
        /// <summary>
        /// Returns the bit-resolution of the ADC
        /// </summary>
        public int? AdcResolution { get; protected set; }
        /// <summary>
        /// Returns the maximum voltage the ADC supports
        /// </summary>
        public int? MaxRawAdcVoltageValue
        {
            get
            {
                if (_maxRawAdcVoltageValue != null)
                {
                    return _maxRawAdcVoltageValue;
                }
                else
                {
                    _maxRawAdcVoltageValue = (int?)Math.Pow(2, (double)(AdcResolution ?? 1));
                    return _maxRawAdcVoltageValue;
                }
            }
        }
    }
}

