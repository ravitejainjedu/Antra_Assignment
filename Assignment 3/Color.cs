using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // represents a color with red, green, blue, and alpha components
    public class Color
    {
        // properties for each component (0–255)
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        // constructor taking all components
        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;         // set red
            Green = green;     // set green
            Blue = blue;       // set blue
            Alpha = alpha;     // set transparency
        }

        // constructor defaulting alpha to 255 (opaque)
        public Color(int red, int green, int blue)
            : this(red, green, blue, 255) { }

        // returns average of red, green, blue
        public int GetGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
