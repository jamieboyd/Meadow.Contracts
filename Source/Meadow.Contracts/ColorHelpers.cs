using System;

namespace Meadow
{
    /// <summary>
    /// A static class with methods to help with Color convert operations
    /// </summary>
    public static class ColorHelpers
    {
        /// <summary>
        /// HSL to RGB 
        /// </summary>
        /// <param name="hue">Hue in degrees (0-359°)</param>
        /// <param name="saturation">Saturation</param>
        /// <param name="lightness">Brightness value</param>
        /// <param name="r">The red component (0-1)</param>
        /// <param name="g">The green component (0-1)</param>
        /// <param name="b">The blue component (0-1)</param>
        public static void HslToRgb(double hue, double saturation, double lightness, out double r, out double g, out double b)
        {
            double h = hue;
            double R, G, B;

            // hue parameter checking/fixing
            if (h < 0)
            {
                h = 0;
            }
            else if (h > 360)
            {
                h %= 360;
            }

            //default to gray
            R = G = B = lightness;

            var v = (lightness <= 0.5) ?
                (lightness * (1.0 + saturation)) :
                (lightness + saturation - lightness * saturation);

            if (v > 0)
            {
                double m;
                double l = lightness;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h /= 60.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;
                switch (sextant)
                {
                    case 0:
                        R = v;
                        G = mid1;
                        B = m;
                        break;
                    case 1:
                        R = mid2;
                        G = v;
                        B = m;
                        break;
                    case 2:
                        R = m;
                        G = v;
                        B = mid1;
                        break;
                    case 3:
                        R = m;
                        G = mid2;
                        B = v;
                        break;
                    case 4:
                        R = mid1;
                        G = m;
                        B = v;
                        break;
                    case 5:
                        R = v;
                        G = m;
                        B = mid2;
                        break;
                }
            }

            r = Clamp(R);
            g = Clamp(G);
            b = Clamp(B);
        }

        /// <summary>
        /// HSV to RGB 
        /// </summary>
        /// <param name="hue">Hue in degrees (0-359°)</param>
        /// <param name="saturation">Saturation</param>
        /// <param name="brightValue">Brightness value</param>
        /// <param name="r">The red component (0-1)</param>
        /// <param name="g">The green component (0-1)</param>
        /// <param name="b">The blue component (0-1)</param>
        public static void HsvToRgb(double hue, double saturation, double brightValue, out double r, out double g, out double b)
        {
            double H = hue;
            double R, G, B;

            // hue parameter checking/fixing
            if (H < 0)
            {
                H = 0;
            }
            else if (H > 360)
            {
                H %= 360;
            }

            // if Brightness is turned off, then everything is zero.
            if (brightValue <= 0)
            {
                R = G = B = 0;
            }

            // if saturation is turned off, then there is no color/hue. it's grayscale.
            else if (saturation <= 0)
            {
                R = G = B = brightValue;
            }
            else // if we got here, then there is a color to create.
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = brightValue * (1 - saturation);
                double qv = brightValue * (1 - saturation * f);
                double tv = brightValue * (1 - saturation * (1 - f));

                switch (i)
                {

                    // Red Dominant
                    case 0:
                        R = brightValue;
                        G = tv;
                        B = pv;
                        break;

                    // Green Dominant
                    case 1:
                        R = qv;
                        G = brightValue;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = brightValue;
                        B = tv;
                        break;

                    // Blue Dominant
                    case 3:
                        R = pv;
                        G = qv;
                        B = brightValue;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = brightValue;
                        break;

                    // Red Red Dominant
                    case 5:
                        R = brightValue;
                        G = pv;
                        B = qv;
                        break;

                    // In case the math is out of bounds, this is a fix.
                    case 6:
                        R = brightValue;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = brightValue;
                        G = pv;
                        B = qv;
                        break;

                    // If the color is not defined, go grayscale
                    default:
                        R = G = B = brightValue;
                        break;
                }
            }
            r = Clamp(R);
            g = Clamp(G);
            b = Clamp(B);
        }

        /// <summary>
        /// Clamp a value to 0 to 1
        /// </summary>
        static double Clamp(double i)
        {
            if (i < 0) return 0;
            if (i > 1) return 1;
            return i;
        }

        /// <summary>
        /// Takes Hue, Saturation and Value and returns a Color object
        /// </summary>
        /// <param name="color"></param>
        /// <param name="alpha"></param>
        /// <param name="hue"></param>
        /// <param name="saturation"></param>
        /// <param name="value"></param>
        /// <returns>A Color object</returns>
        public static Color FromAhsv(this Color color, double alpha, double hue, double saturation, double value)
        {
            ColorHelpers.HsvToRgb(hue, saturation, value, out double red, out double green, out double blue);

            return new Color((byte)(red * 255), (byte)(green * 255), (byte)(blue * 255), (byte)(alpha * 255));
        }

        /// <summary>
        /// Blend a new color with the current color
        /// </summary>
        /// <param name="color">The source color</param>
        /// <param name="blendColor">The color to blend</param>
        /// <param name="ratio">The ratio of the blend color to source color</param>
        /// <returns>The resulting blended color</returns>
        public static Color Blend(this Color color, Color blendColor, double ratio)
        {
            if (ratio == 0)
            {
                return color;
            }
            if (ratio == 1)
            {
                return blendColor;
            }

            byte r = (byte)(color.R * (1 - ratio) + blendColor.R * ratio);
            byte g = (byte)(color.G * (1 - ratio) + blendColor.G * ratio);
            byte b = (byte)(color.B * (1 - ratio) + blendColor.B * ratio);
            return Color.FromRgb(r, g, b);
        }
    }
}