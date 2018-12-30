using System;
using System.Drawing;

namespace Fractals
{
    public abstract class Fractal
    {
        Color _startColor, _endColor;
        int _maxRecursionLevel, _currentRecursionLevel;

        /// <summary>
        /// Property that helps understand if drawing finished correct (without timeout exception).
        /// </summary>
        static public int TypeOfResult = 0;

        /// <summary>
        /// Property with the value of length of elements.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Property with the value of start color for the first iteration.
        /// </summary>
        public Color StartColor
        {
            get
            {
                return _startColor;
            }
            set
            {
                _startColor = value;
                UpdateColorsList();
            }

        }

        /// <summary>
        /// Property with the value of end color for the last iteration.
        /// </summary>
        public Color EndColor
        {
            get
            {
                return _endColor;
            }
            set
            {
                _endColor = value;
                UpdateColorsList();
            }
        }

        /// <summary>
        /// Property with the value of maximum recursion level.
        /// </summary>
        public int MaxRecursionLevel
        {
            get
            {
                return _maxRecursionLevel;
            }
            set
            {
                _maxRecursionLevel = value;
                UpdateColorsList();
            }
        }

        /// <summary>
        /// Property with the value of current recursion level.
        /// </summary>
        public int CurrentRecursionLevel {
            get
            {
                return _currentRecursionLevel;
            }
            set
            {
                _currentRecursionLevel = value;
            }
        }

        /// <summary>
        /// Property with the value of list with colors.
        /// </summary>
        public Color[] ColorsList { get; set; }

        /// <summary>
        /// Remember time when drawing started.
        /// </summary>
        public DateTime TimeWhenDrawingStarted { get; set; }

        /// <summary>
        /// Property for getting size of list with colors.
        /// </summary>
        public int SizeOfColorList => ColorsList.Length;

        /// <summary>
        /// Returns color value for current iteration.
        /// </summary>
        /// <param name="index">Number of iteration.</param>
        /// <returns>Color for current iteration.</returns>
        public Color this[int index]
        {
            get
            {
                return ColorsList[index];
            }
        }

        // Definition of the method responsible for drawing the fractal.
        public abstract void Draw();

        /// <summary>
        /// Gets a list with colors.
        /// </summary>
        public void UpdateColorsList()
        {
            // Creating new list for changing.
            Color[] newListForColors = new Color[this.MaxRecursionLevel];
            newListForColors[0] = StartColor;

            if (this.MaxRecursionLevel == 1)
            {
                ColorsList = newListForColors;
                return;
            }

            // For 'RED' component.
            int rMinColor = StartColor.R;
            int rMaxColor = EndColor.R;
            // For 'GREEN' component.
            int gMinColor = StartColor.G;
            int gMaxColor = EndColor.G;
            // For 'BLUE' component.
            int bMinColor = StartColor.B;
            int bMaxColor = EndColor.B;

            for (int i = 0; i < newListForColors.Length; i++)
            {
                // Calculating new value for each component.
                var rAverageColor = rMinColor + (int)((rMaxColor - rMinColor) * i / (newListForColors.Length - 1));
                var gAverageColor = gMinColor + (int)((gMaxColor - gMinColor) * i / (newListForColors.Length - 1));
                var bAverageColor = bMinColor + (int)((bMaxColor - bMinColor) * i / (newListForColors.Length - 1));
                // Creating new Color from new values for components.
                newListForColors[i] = Color.FromArgb(rAverageColor, gAverageColor, bAverageColor);
            }

            // Rewrite main value with new one.
            ColorsList = newListForColors;
        }
    }
}
