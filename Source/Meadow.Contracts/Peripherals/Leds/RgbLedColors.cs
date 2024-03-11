namespace Meadow.Peripherals.Leds
{
    /// <summary>
    /// Extesnion methods for RgbLedColors
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Converts an RgbLedColor into a Color
        /// </summary>
        /// <param name="rgbLedColor"></param>
        /// <returns></returns>
        public static Color AsColor(this RgbLedColors rgbLedColor)
        {
            return rgbLedColor switch
            {
                RgbLedColors.Red => Color.Red,
                RgbLedColors.Green => Color.Green,
                RgbLedColors.Blue => Color.Blue,
                RgbLedColors.Yellow => Color.Yellow,
                RgbLedColors.Magenta => Color.Magenta,
                RgbLedColors.Cyan => Color.Cyan,
                _ => Color.White
            };
        }
    }

    /// <summary>
    /// Colors for RGB Led
    /// </summary>
    public enum RgbLedColors
    {
        /// <summary>
        /// Red (red LED only)
        /// </summary>
        Red,
        /// <summary>
        /// Green (green LED only)
        /// </summary>
        Green,
        /// <summary>
        /// Blue (blue LED only)
        /// </summary>
        Blue,
        /// <summary>
        /// Yellow (red and green LEDs)
        /// </summary>
        Yellow,
        /// <summary>
        /// Magenta (blue and red LEDs)
        /// </summary>
        Magenta,
        /// <summary>
        /// Cyan (blue and green LEDs)
        /// </summary>
        Cyan,
        /// <summary>
        /// White (red, green and blue LEDs)
        /// </summary>
        White,
        /// <summary>
        /// Count of colors
        /// </summary>
        count,
    }
}
