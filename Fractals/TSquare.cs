using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    public class TSquare : Fractal
    {
        /// <summary>
        /// The constructor sets the new length and recalculates position.
        /// </summary>
        public TSquare()
        {
            TypeOfResult = 0;
            this.Length = Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 2 - Math.Min(Form1.PictureBoxWidth, Form1.PictureBoxHeight) / 10;
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
            // Upper left corner of square.
            PointF LeftUpper = new PointF(Form1.positionOfDrawingX, Form1.positionOfDrawingY);

            // Updating length of drawing.
            this.Length = Form1.PictureBoxHeight / 2 - Form1.PictureBoxHeight / 10;

            // Fill current form with rectangle.
            Form1.DrawingPanel.FillRectangle(Brushes.White, Form1.positionOfDrawingX - (float)this.Length / 2, Form1.positionOfDrawingY - (float)this.Length / 2, (float)this.Length * 2, (float)this.Length * 2);

            // Remembering time when drawing started to check if there is timeout.
            TimeWhenDrawingStarted = DateTime.Now;

            // Calling a method for recursive drawing.
            DrawTSquare(LeftUpper, (float)this.Length, this.MaxRecursionLevel - 1);

            // Checking type of result and fixing timeout error if any.
            if (TypeOfResult == 1)
            {
                MessageBox.Show("Timeout exceeded");
                throw new TimeoutException("Timeout exceeded");
            }
        }

        /// <summary>
        /// The method responsible for the recursive rendering of the T-Square fractal.
        /// </summary>
        /// <param name="LeftUpper">Upper left corner point.</param>
        /// <param name="CurrentSize">Size of current square.</param>
        /// <param name="level">Current recursion depth.</param>
        /// <returns></returns>
        public void DrawTSquare(PointF LeftUpper, float CurrentSize, int level)
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
                Form1.DrawingPanel.FillRectangle(new SolidBrush(this[SizeOfColorList - level - 1]), LeftUpper.X, LeftUpper.Y, CurrentSize, CurrentSize);
            }
            else
            {
                // One fourth of the current square length.
                float OneFourthOfTheLength = CurrentSize / 4;
                PointF[] AllSmallerSquares = new PointF[4];

                for (int i = 0; i < 4; i++)
                {
                    AllSmallerSquares[i] = new PointF();
                }

                // Upper right square.
                AllSmallerSquares[2].X = LeftUpper.X + CurrentSize - OneFourthOfTheLength;
                AllSmallerSquares[2].Y = LeftUpper.Y - OneFourthOfTheLength;

                // Upper left square.
                AllSmallerSquares[0].X = LeftUpper.X - OneFourthOfTheLength;
                AllSmallerSquares[0].Y = LeftUpper.Y - OneFourthOfTheLength;

                // Bottom right square.
                AllSmallerSquares[3].X = LeftUpper.X + CurrentSize - OneFourthOfTheLength;
                AllSmallerSquares[3].Y = LeftUpper.Y + CurrentSize - OneFourthOfTheLength;

                // Bottom left square.
                AllSmallerSquares[1].X = LeftUpper.X - OneFourthOfTheLength;
                AllSmallerSquares[1].Y = LeftUpper.Y + CurrentSize - OneFourthOfTheLength;

                // Draw the main square.
                Form1.DrawingPanel.FillRectangle(new SolidBrush(this[SizeOfColorList - level - 1]), LeftUpper.X, LeftUpper.Y, CurrentSize, CurrentSize);

                // Draw all smaller squares.
                for (int index = 0; index < 4; index++)
                {
                    DrawTSquare(AllSmallerSquares[index], CurrentSize / 2, level - 1);
                }

                
            }
        }

    }
}
