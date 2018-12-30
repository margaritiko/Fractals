using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public static int PictureBoxWidth;
        public static int PictureBoxHeight;

        // Variables for saving information for using it when one fractal changing to another one.
        // Default value for color is black.
        Color _valueStartColor = Color.Black, _valueEndColor = Color.Black;
        int _valueMaxRecursionLevel = 1;

        // Properties for access to class fields that store information about the current fractal.
        /// <summary>
        ///  Property to store and record start color of current fractal.
        /// </summary>
        Color ValueStartColor
        {
            get
            {
                return _valueStartColor;
            }
            set
            {
                _valueStartColor = value;
                fractal.StartColor = value;
            }
        }

        /// <summary>
        ///  Property to store and record end color of current fractal.
        /// </summary>
        Color ValueEndColor
        {
            get
            {
                return _valueEndColor;
            }
            set
            {
                _valueEndColor = value;
                fractal.EndColor = value;
            }
        }

        /// <summary>
        /// Property to store and record maximum recursion level of current fractal.
        /// </summary>
        int ValueMaxRecursionLevel
        {
            get
            {
                return _valueMaxRecursionLevel;
            }
            set
            {
                _valueMaxRecursionLevel = value;
                try
                {
                    fractal.MaxRecursionLevel = value;
                }
                catch (NullReferenceException)
                {
                    // It occurs when the user started changing recursion depth, but hasn't yet selected a fractal. 
                    // In this case, this behavior is considered correct, so nothing happens.
                }
                catch { }
            }
        }

        /// <summary>
        /// Property to store and record timeout of current fractal.
        /// </summary>
        public static int WaitingTime { get; set; }

        /// <summary>
        /// Current fractal.
        /// </summary>
        static Fractal fractal;

        /// <summary>
        /// Main place for drawing fractal.
        /// </summary>
        public static Graphics DrawingPanel;

        /// <summary>
        /// Main bitmap.
        /// </summary>
        Bitmap bitmap;

        // Below are the variables needed to implement drag and drop.
        /// <summary>
        /// Variable for position of mouse when was left button click.
        /// </summary>
        Point positionWhereWasMouseLeftClick;

        // Position of drawing when was left button click.
        int positionStartMovingX = 0;
        int positionStartMovingY = 0;

        // Start position of drawing.
        public static int positionOfDrawingX = 100;
        public static int positionOfDrawingY = 100;

        // True when left mouse button is pressed
        bool isMousePressed = false;
       
        // Variable for zoom value.
        float zoom = 1;
        /// <summary>
        /// Property to store and record current zoom value.
        /// </summary>
        float Zoom
        {
            get
            {
                return zoom;
            }
            set
            {
                zoom = value;
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Set default values for comboboxes.
            comboBoxForZoom.SelectedIndex = 0;
            timerComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Called during form loading. 
        /// Set the maximum and minimum form size.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Some arguments.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // The maximum window size corresponds to the maximum screen size
            this.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
            // Sets the minimum window size - half screen size
            this.MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Size.Width / 2, Screen.PrimaryScreen.Bounds.Size.Height / 2);
        }

        /// <summary>
        /// Writes to the fields of the current fractal values of the previous or default values.
        /// </summary>
        /// <param name="fractal">New empty fractal to init.</param>
        void InitNewFractalWithCurrentValues(Fractal fractal)
        {
            fractal.MaxRecursionLevel = ValueMaxRecursionLevel;
            fractal.StartColor = ValueStartColor == null ? Color.White : ValueStartColor;
            fractal.EndColor = ValueEndColor == null ? Color.White : ValueEndColor;
        }

        /// <summary>
        /// Called after the "Timed out" error has occurred. 
        /// Sets the current value of the fractal recursion depth to 1 and redraws the image.
        /// </summary>
        public void ClearAfterTimeoutExceeded()
        {
            try
            {

                DrawingPanel.FillRectangle(new SolidBrush(this.BackColor), new RectangleF(Form1.positionOfDrawingX, Form1.positionOfDrawingY, PictureBoxWidth, PictureBoxHeight));
                ValueMaxRecursionLevel = 1;
                fractal.MaxRecursionLevel = 1;
                recursionTextBox.Text = "1";
                drawingPictureBox.Refresh();
            }
            catch (NullReferenceException e)
            {
                // It is legal, so all is ok.
            }
        }

        /// <summary>
        /// Updates the current fractal after choosing another one from list.
        /// </summary>
        /// <param name="sender">Sender object - combobox with list of fractals' names.</param>
        /// <param name="e">Some arguments.</param>
        private void ListWithFractals_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Getting the string with name of new fractal.
            string selectedState = listWithFractals.SelectedItem.ToString();

            switch (selectedState)
            {
                case "The Sierpinski carpet":
                    fractal = new SierpinskiCarpet();
                    break;
                case "T-square":
                    fractal = new TSquare();
                    break;
                case "The Lévy C curve":
                    fractal = new LevyCCurve();
                    break;
            }

            InitNewFractalWithCurrentValues(fractal);
            drawingPictureBox.Refresh();
        }


        /// <summary>
        /// Processing the recursion depth value from the form when the "OK" button is pressed
        /// </summary>
        private void NewRecursionDepthButton_Click(object sender, EventArgs e)
        {
            CheckCurrentValueInTextBox();
        }

        /// <summary>
        /// Checks if current value in text box is correct (if it is not empty) and redraws fractal.
        /// </summary>
        private void CheckCurrentValueInTextBox()
        {
            int newDepthValue;
            if (!int.TryParse(recursionTextBox.Text, out newDepthValue) || newDepthValue == 0)
            {
                DrawingPanel.FillRectangle(new SolidBrush(this.BackColor), new RectangleF(Form1.positionOfDrawingX, Form1.positionOfDrawingY, PictureBoxWidth, PictureBoxHeight));
                ValueMaxRecursionLevel = 1;
                recursionTextBox.Text = "1";
                MessageBox.Show("Input is incorrect. It must be positive integer.");
                return;
            }

            ValueMaxRecursionLevel = newDepthValue;
            drawingPictureBox.Refresh();
        }

        /// <summary>
        /// Updates start color and set a new value for current fractal if it is possible.
        /// </summary>
        /// <param name="sender">Sender object - button responsible for setting a new start color.</param>
        /// <param name="e">Some arguments.</param>
        private void StartColorButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // startColor field of current fractal to the color the user chose.
            try
            {
                if (startColorDialog.ShowDialog() == DialogResult.OK)
                {
                    ValueStartColor = startColorDialog.Color;
                    drawingPictureBox.Refresh();
                }
            }
            catch (NullReferenceException)
            {
                // It occurs when the user started changing colors, but hasn't yet selected a fractal. 
                // In this case, this behavior is considered correct, so nothing happens.
            }
            catch
            {
                // It occurs when something went wrong with dialog element.
                // It can be ignored.
            }
            finally
            {
                startColorPanelForShowing.BackColor = startColorDialog.Color;
            }

        }

        /// <summary>
        /// Updates end color and set a new value for current fractal if it is possible.
        /// </summary>
        /// <param name="sender">Sender object - button responsible for setting a new end color.</param>
        /// <param name="e">Some arguments.</param>
        private void EndColorButton_Click(object sender, EventArgs e)
        {
            /// Show the color dialog box. If the user clicks OK, change the
            // endColor field of current fractal to the color the user chose.
            try
            {
                if (endColorDialog.ShowDialog() == DialogResult.OK)
                {
                    ValueEndColor = endColorDialog.Color;
                    drawingPictureBox.Refresh();
                }
            }
            catch (NullReferenceException)
            {
                // It occurs when the user started changing colors, but hasn't yet selected a fractal. 
                // In this case, this behavior is considered correct, so nothing happens.
            }
            catch
            {
                // It occurs when something went wrong with dialog element.
                // It can be ignored.
            }
            finally
            {
                endColorPanelForShowing.BackColor = endColorDialog.Color;
            }
        }


        /// <summary>
        /// Main place for drawing current fractal. 
        /// Called when the first drawing is taking place, as well as all the next redraw.
        /// </summary>
        /// <param name="sender">Sender object - the picturebox on which the drawing will take place.</param>
        /// <param name="e">Some arguments.</param>
        private void DrawingPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Getting current drawing PictureBox object
            PictureBox drawingPictureBoxDesk = (PictureBox)sender;

            // Update current width and height of drawing panel.
            PictureBoxWidth = drawingPictureBoxDesk.Width;
            PictureBoxHeight = drawingPictureBoxDesk.Height;

            // Update current bitmap.
            bitmap = new Bitmap(PictureBoxWidth, PictureBoxHeight);

            // Update graphics with new bitmap.
            DrawingPanel = Graphics.FromImage(bitmap);
            DrawingPanel.FillRectangle(new SolidBrush(Color.FromArgb(220, 220, 220)), new RectangleF(0, 0, PictureBoxWidth, PictureBoxHeight));

            DrawingPanel.InterpolationMode = InterpolationMode.HighQualityBicubic;
            DrawingPanel.ScaleTransform(Zoom, Zoom);

            if (DrawingPanel == null)
                return;
            try
            {
                fractal.Draw();
            }
            catch (NullReferenceException)
            {
                // It occurs when the user starts changing colors or changing the size of form and fractal need to redraw,
                // but there is no one current fractal, because user hasn't yet selected it from a list. 
                // In this case, this behavior is considered correct, so nothing happens.
            }
            catch (TimeoutException)
            {
                // After throwing timeout error from fractal's drawing method.
                ClearAfterTimeoutExceeded();
            }
            catch { }
            
            e.Graphics.Clear(this.BackColor);
            e.Graphics.DrawImage(bitmap, 0, 0);
            base.OnPaint(e);
        }

        /// <summary>
        /// Redrawing all when the size of form was changed.
        /// </summary>
        /// <param name="sender">In current context sender is drawingPictureBox.</param>
        /// <param name="e">Some arguments of event.</param>
        private void DrawingPictureBox_Resize(object sender, EventArgs e)
        {
            drawingPictureBox.Refresh();
        }

        /// <summary>
        /// Calling when the mouse button is down. 
        /// Checking if it was left click.
        /// Remembering the coordinates of the click and the location of the drawing panel.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Some arguments.</param>
        private void DrawingPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            // Checks if it was left button click.
            if (mouse.Button == MouseButtons.Left)
            {
                if (!isMousePressed)
                {
                    isMousePressed = true;
                    positionWhereWasMouseLeftClick = mouse.Location;
                    positionStartMovingX = positionOfDrawingX;
                    positionStartMovingY = positionOfDrawingY;
                }
            }
        }

        /// <summary>
        /// Calling when the mouse is moving. 
        /// Checking if it was left click.
        /// Recalculates the coordinates of the drawing panel.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Some arguments.</param>
        private void DrawingPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left)
            {
                Point currentMousePosition = mouse.Location;

                // Calculate the distance between first remembered position (when mouse button was clicked) and current
                int deltaPositionX = currentMousePosition.X - positionWhereWasMouseLeftClick.X;
                int deltaPositionY = currentMousePosition.Y - positionWhereWasMouseLeftClick.Y;

                // Calculate new position position for drawing based on zoom value
                positionOfDrawingX = (int)(positionStartMovingX + (deltaPositionX / Zoom));
                positionOfDrawingY = (int)(positionStartMovingY + (deltaPositionY / Zoom));

                drawingPictureBox.Refresh();
            }
        }

        /// <summary>
        /// Calling when the mouse button is up after click. 
        /// Setting that there is no click anymore.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Some arguments.</param>
        private void DrawingPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
        }

        /// <summary>
        /// Called after clicking on the "Save" button.
        /// Handles a save request.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Some arguments.</param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            drawingPictureBox.Image = bitmap;

            try
            {
                // Init a SaveFileDialog where user can choose location for saving.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png",
                    Title = "Save an Image File"
                };

                // Showing a SaveFileDialog.
                saveFileDialog1.ShowDialog();

                // Open file for saving if the file name isn't empty.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.  
                    System.IO.FileStream path =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();

                    // Saves the image according to the type selected by the user. 
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            drawingPictureBox.Image.Save(path, ImageFormat.Jpeg);
                            break;

                        case 2:
                            drawingPictureBox.Image.Save(path, ImageFormat.Bmp);
                            break;

                        case 3:
                            drawingPictureBox.Image.Save(path, ImageFormat.Png);
                            break;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // The error occurs when the user does not have permission to write to a specific location.
                MessageBox.Show("Please, choose another location.");
            }
            catch
            {
                // The error occurs when something other went wrong while saving.
                MessageBox.Show("Please, choose another location.");
            }

        }

        /// <summary>
        /// Called after the user selects a new value for the timeout.
        /// </summary>
        /// <param name="sender">Sender object - combobox with list of timeouts' values.</param>
        /// <param name="e">Some arguments.</param>
        private void TimerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            switch (comboBox.SelectedIndex)
            {
                case 0:
                    WaitingTime = 5;
                    break;
                case 1:
                    WaitingTime = 10;
                    break;
                case 2:
                    WaitingTime = 15;
                    break;
            }

        }

        /// <summary>
        /// Shows information about author.
        /// </summary>
        /// <param name="sender">Sender object - button "About".</param>
        /// <param name="e">Some arguments.</param>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Developer: Konnova Margarita
Group: БПИ184-1");
        }

        /// <summary>
        /// The restriction on the type of characters: entered is only numbers and character "Backspace".
        /// If key "Enter" is pressed, checks the current value of recursion depth.
        /// </summary>
        /// <param name="sender">Sender object - textbox, where user can write the value of recursion depth.</param>
        /// <param name="e">Some arguments.</param>
        private void RecursionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                CheckCurrentValueInTextBox();
            }
        }

        /// <summary>
        /// Delete all old input from textBox before new input.
        /// </summary>
        /// <param name="sender">Sender object - TextBox.</param>
        /// <param name="e">Some arguments.</param>
        private void RecursionTextBox_Click(object sender, EventArgs e)
        {
            recursionTextBox.Text = "";
        }


        /// <summary>
        /// Called after the user selects a new value for the zoom.
        /// </summary>
        /// <param name="sender">Sender object - combobox with list of zoom' values.</param>
        /// <param name="e">Some arguments.</param>
        private void ComboBoxForZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            switch (comboBox.SelectedIndex)
            {
                case 0:
                    Zoom = 1;
                    break;
                case 1:
                    Zoom = 2;
                    break;
                case 2:
                    Zoom = 3;
                    break;
                case 3:
                    Zoom = 5;
                    break;
            }

            // Position before zooming.
            int oldDrawingX = PictureBoxWidth / 2;
            int oldDrawingY = PictureBoxHeight / 2;

            // Position after zooming.
            int newDrawingX = (int)(oldDrawingX / zoom);
            int newDrawingY = (int)(oldDrawingY / zoom);

            // Creating right position after zooming.
            positionOfDrawingX = newDrawingX - oldDrawingX + positionOfDrawingX;
            positionOfDrawingY = newDrawingY - oldDrawingY + positionOfDrawingY;

            // Redraw.
            drawingPictureBox.Refresh();
        }
    }
}
