using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    public class SierpinskiCarpet : Fractal
    {
        // The biggest main square.
        RectangleF carpet;

        /// <summary>
        /// The constructor sets the new length and recalculates position.
        /// </summary>
        public SierpinskiCarpet()
        {
            TypeOfResult = 0;
            this.Length = 2 * Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 2 - Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 10;
            Form1.positionOfDrawingX = (int)(Form1.PictureBoxWidth / 2 - (float)this.Length / 2);
            Form1.positionOfDrawingY = (int)(Form1.PictureBoxHeight / 2 - (float)this.Length / 2);
        }

        /// <summary>
        /// Updates the value and makes a call to a specific drawing method. 
        /// Checks the duration of the drawing.
        /// </summary>
        public override void Draw()
        {
            TypeOfResult = 0;
            this.Length = 2 *  Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 2 - Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 10;
            
            // Initializes main square with new value with using current position and length.
            carpet = new RectangleF(Form1.positionOfDrawingX, Form1.positionOfDrawingY, (float)this.Length, (float)this.Length);
            Form1.DrawingPanel.FillRectangle(new SolidBrush(Color.White), carpet);

            // Remembering time when drawing started to check if there is timeout.
            TimeWhenDrawingStarted = DateTime.Now;

            // Calling a method for recursive drawing.
            DrawSierpinskiCarpet(this.MaxRecursionLevel, carpet);

            // Checking type of result and fixing timeout error if any.
            if (TypeOfResult == 1)
            {
                MessageBox.Show("Timeout exceeded");
                throw new TimeoutException("Timeout exceeded");
            }
        }

        /// <summary>
        /// A method that calls itself recursively to draw a Sierpinski carpet fractal.
        /// </summary>
        /// <param name="level">Current recursion depth.</param>
        /// <param name="carpet">Current square.</param>
        private void DrawSierpinskiCarpet(int level, RectangleF carpet)
        {
            // Firstly checks the difference between the current time and the start time of the drawing.
            if ((DateTime.Now - TimeWhenDrawingStarted).Seconds >= Form1.WaitingTime)
            {
                TypeOfResult = 1;
                return;
            }
            // Go into just if drawing hasn't yet finished.
            if (level > 0)
            {
                // Gets 9 parts of current carpet
                float WidthOfSmallerSquare = carpet.Width / 3f;
                float HeightOfSmallerSquare = carpet.Height / 3f;
                
                // Calculate all smaller squares on the diagonals.
                float LeftUpperX = carpet.Left;
                float LeftUpperY = carpet.Top;

                float MiddleX = LeftUpperX + WidthOfSmallerSquare;
                float MiddleY = LeftUpperY + HeightOfSmallerSquare;

                float RightDownX = LeftUpperX + 2f * WidthOfSmallerSquare;
                float RightDownY = LeftUpperY + 2f * HeightOfSmallerSquare;

                // Draw small colorful square in the middle of current.
                Form1.DrawingPanel.FillRectangle(new SolidBrush(this[SizeOfColorList - level]), new RectangleF(MiddleX, MiddleY, WidthOfSmallerSquare, HeightOfSmallerSquare));

                // Then go to others.
                DrawSierpinskiCarpet(level - 1, new RectangleF(LeftUpperX, LeftUpperY, WidthOfSmallerSquare, HeightOfSmallerSquare)); 
                DrawSierpinskiCarpet(level - 1, new RectangleF(MiddleX, LeftUpperY, WidthOfSmallerSquare, HeightOfSmallerSquare));
                DrawSierpinskiCarpet(level - 1, new RectangleF(RightDownX, LeftUpperY, WidthOfSmallerSquare, HeightOfSmallerSquare));
                DrawSierpinskiCarpet(level - 1, new RectangleF(LeftUpperX, MiddleY, WidthOfSmallerSquare, HeightOfSmallerSquare)); 
                DrawSierpinskiCarpet(level - 1, new RectangleF(RightDownX, MiddleY, WidthOfSmallerSquare, HeightOfSmallerSquare)); 
                DrawSierpinskiCarpet(level - 1, new RectangleF(LeftUpperX, RightDownY, WidthOfSmallerSquare, HeightOfSmallerSquare));
                DrawSierpinskiCarpet(level - 1, new RectangleF(MiddleX, RightDownY, WidthOfSmallerSquare, HeightOfSmallerSquare)); 
                DrawSierpinskiCarpet(level - 1, new RectangleF(RightDownX, RightDownY, WidthOfSmallerSquare, HeightOfSmallerSquare));
                
            }
        }
    }
}