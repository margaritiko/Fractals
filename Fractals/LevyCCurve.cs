using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals {
    class LevyCCurve: Fractal
    { 
        /// <summary>
        /// Updates the value and makes a call to a specific drawing method. 
        /// Checks the duration of the drawing.
        /// </summary>
        public override void Draw()
        {
            TypeOfResult = 0;

            // Assigns the best length value for the fractal to fit on the screen.
            this.Length = Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 2 - Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 18;

            // Remembering time when drawing started to check if there is timeout.
            TimeWhenDrawingStarted = DateTime.Now;

            // Updating colors list exactly for this fractal.
            UpdateColorsList();

            // Calling a method for recursive drawing.
            DrawLevyCCurve(new PointF(Form1.positionOfDrawingX + Form1.PictureBoxWidth / 4, (float)(Form1.positionOfDrawingY + this.Length / 2.0) + Form1.PictureBoxHeight / 4), new PointF(Form1.positionOfDrawingX + Form1.PictureBoxWidth / 4, (float)(Form1.positionOfDrawingY - this.Length / 2.0) + Form1.PictureBoxHeight / 4), this.MaxRecursionLevel); //вызов функции вырисовки

            // Checking type of result and fixing timeout error if any.
            if (TypeOfResult == 1)
            {
                MessageBox.Show("Timeout exceeded");
                throw new TimeoutException("Timeout exceeded");
            }
        }

        // <summary>
        /// A method that calls itself recursively to draw a Levy C Curve fractal.
        /// </summary>
        /// <param name="A">First point.</param>
        /// <param name="B">Second point.</param>
        /// <param name="level">Current recursion depth.</param>
        public void DrawLevyCCurve(PointF A, PointF B, int level)
        {
            // Firstly checks the difference between the current time and the start time of the drawing.
            if ((DateTime.Now - TimeWhenDrawingStarted).Seconds >= Form1.WaitingTime)
            {
                TypeOfResult = 1;
                return;
            }
            // Checking current level value.
            if (level == 0)
            {
                Form1.DrawingPanel.DrawLine(new Pen(this[SizeOfColorList - level - 1]), A, B);
            }
            else
            {
                // Drawing a fractal at the current recursion value.
                // It is necessary in order to apply color changes depending on the iteration.
                Form1.DrawingPanel.DrawLine(new Pen(this[SizeOfColorList - level - 1]), A, B);

                // Calculating coordinates for new point.
                float x = (A.X + B.X) / 2 + (B.Y - A.Y) / 2; 
                float y = (A.Y + B.Y) / 2 - (B.X - A.X) / 2;
                DrawLevyCCurve(A, new PointF(x, y), level - 1);
                DrawLevyCCurve(new PointF(x, y), B, level - 1);
            }
        }

        /// <summary>
        /// Gets a list with colors one unit larger than the recursion depth.
        /// </summary>
        new public void UpdateColorsList()
        {
            // Creating new list for changing.
            Color[] newListForColors = new Color[this.MaxRecursionLevel + 1];
            newListForColors[0] = StartColor;

            if (this.MaxRecursionLevel == 1)
            {
                newListForColors[1] = EndColor;
                this.ColorsList = newListForColors;
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
