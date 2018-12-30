namespace Fractals
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.drawingPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.chooseFractalLabel = new System.Windows.Forms.Label();
            this.listWithFractals = new System.Windows.Forms.ComboBox();
            this.writeTheRecursionDepthLabel = new System.Windows.Forms.Label();
            this.recursionTextBox = new System.Windows.Forms.TextBox();
            this.chooseColorsLabel = new System.Windows.Forms.Label();
            this.startColorButton = new System.Windows.Forms.Button();
            this.endColorButton = new System.Windows.Forms.Button();
            this.newRecursionDepthButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.saveLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.startColorPanelForShowing = new System.Windows.Forms.Panel();
            this.endColorPanelForShowing = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxForZoom = new System.Windows.Forms.ComboBox();
            this.timerComboBox = new System.Windows.Forms.ComboBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.startColorDialog = new System.Windows.Forms.ColorDialog();
            this.endColorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.drawingPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AboutButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1444, 588);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // drawingPictureBox
            // 
            this.drawingPictureBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.drawingPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPictureBox.Location = new System.Drawing.Point(365, 4);
            this.drawingPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.drawingPictureBox.Name = "drawingPictureBox";
            this.drawingPictureBox.Size = new System.Drawing.Size(1075, 521);
            this.drawingPictureBox.TabIndex = 3;
            this.drawingPictureBox.TabStop = false;
            this.drawingPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPictureBox_Paint);
            this.drawingPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPictureBox_MouseDown);
            this.drawingPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPictureBox_MouseMove);
            this.drawingPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPictureBox_MouseUp);
            this.drawingPictureBox.Resize += new System.EventHandler(this.DrawingPictureBox_Resize);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.saveButton, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.chooseFractalLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listWithFractals, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.writeTheRecursionDepthLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.recursionTextBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.chooseColorsLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.startColorButton, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.endColorButton, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.newRecursionDepthButton, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(353, 521);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.saveButton, 2);
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(4, 459);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(345, 58);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // chooseFractalLabel
            // 
            this.chooseFractalLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chooseFractalLabel, 2);
            this.chooseFractalLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chooseFractalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFractalLabel.Location = new System.Drawing.Point(4, 34);
            this.chooseFractalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseFractalLabel.Name = "chooseFractalLabel";
            this.chooseFractalLabel.Size = new System.Drawing.Size(345, 31);
            this.chooseFractalLabel.TabIndex = 6;
            this.chooseFractalLabel.Text = "Choose fractal";
            // 
            // listWithFractals
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.listWithFractals, 2);
            this.listWithFractals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWithFractals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listWithFractals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listWithFractals.FormattingEnabled = true;
            this.listWithFractals.Items.AddRange(new object[] {
            "The Sierpinski carpet",
            "T-square",
            "The Lévy C curve"});
            this.listWithFractals.Location = new System.Drawing.Point(4, 69);
            this.listWithFractals.Margin = new System.Windows.Forms.Padding(4);
            this.listWithFractals.Name = "listWithFractals";
            this.listWithFractals.Size = new System.Drawing.Size(345, 38);
            this.listWithFractals.TabIndex = 7;
            this.listWithFractals.SelectedIndexChanged += new System.EventHandler(this.ListWithFractals_SelectedIndexChanged);
            // 
            // writeTheRecursionDepthLabel
            // 
            this.writeTheRecursionDepthLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.writeTheRecursionDepthLabel, 2);
            this.writeTheRecursionDepthLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.writeTheRecursionDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeTheRecursionDepthLabel.Location = new System.Drawing.Point(4, 133);
            this.writeTheRecursionDepthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.writeTheRecursionDepthLabel.Name = "writeTheRecursionDepthLabel";
            this.writeTheRecursionDepthLabel.Size = new System.Drawing.Size(345, 62);
            this.writeTheRecursionDepthLabel.TabIndex = 8;
            this.writeTheRecursionDepthLabel.Text = "Write the recursion depth - positive integer";
            // 
            // recursionTextBox
            // 
            this.recursionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recursionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursionTextBox.Location = new System.Drawing.Point(4, 199);
            this.recursionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.recursionTextBox.Name = "recursionTextBox";
            this.recursionTextBox.Size = new System.Drawing.Size(168, 37);
            this.recursionTextBox.TabIndex = 9;
            this.recursionTextBox.Text = "1";
            this.recursionTextBox.Click += new System.EventHandler(this.RecursionTextBox_Click);
            this.recursionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecursionTextBox_KeyPress);
            // 
            // chooseColorsLabel
            // 
            this.chooseColorsLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chooseColorsLabel, 2);
            this.chooseColorsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chooseColorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseColorsLabel.Location = new System.Drawing.Point(4, 294);
            this.chooseColorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseColorsLabel.Name = "chooseColorsLabel";
            this.chooseColorsLabel.Size = new System.Drawing.Size(345, 31);
            this.chooseColorsLabel.TabIndex = 10;
            this.chooseColorsLabel.Text = "Choose start / finish colors";
            // 
            // startColorButton
            // 
            this.startColorButton.AutoSize = true;
            this.startColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startColorButton.Location = new System.Drawing.Point(4, 329);
            this.startColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.startColorButton.Name = "startColorButton";
            this.startColorButton.Size = new System.Drawing.Size(168, 57);
            this.startColorButton.TabIndex = 11;
            this.startColorButton.Text = "Start color";
            this.startColorButton.UseVisualStyleBackColor = true;
            this.startColorButton.Click += new System.EventHandler(this.StartColorButton_Click);
            // 
            // endColorButton
            // 
            this.endColorButton.AutoSize = true;
            this.endColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endColorButton.Location = new System.Drawing.Point(180, 329);
            this.endColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.endColorButton.Name = "endColorButton";
            this.endColorButton.Size = new System.Drawing.Size(169, 57);
            this.endColorButton.TabIndex = 12;
            this.endColorButton.Text = "End color";
            this.endColorButton.UseVisualStyleBackColor = true;
            this.endColorButton.Click += new System.EventHandler(this.EndColorButton_Click);
            // 
            // newRecursionDepthButton
            // 
            this.newRecursionDepthButton.AutoSize = true;
            this.newRecursionDepthButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newRecursionDepthButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newRecursionDepthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRecursionDepthButton.Location = new System.Drawing.Point(180, 199);
            this.newRecursionDepthButton.Margin = new System.Windows.Forms.Padding(4);
            this.newRecursionDepthButton.Name = "newRecursionDepthButton";
            this.newRecursionDepthButton.Size = new System.Drawing.Size(169, 56);
            this.newRecursionDepthButton.TabIndex = 14;
            this.newRecursionDepthButton.Text = "OK";
            this.newRecursionDepthButton.UseVisualStyleBackColor = false;
            this.newRecursionDepthButton.Click += new System.EventHandler(this.NewRecursionDepthButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.saveLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 394);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(345, 57);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.saveLabel, 2);
            this.saveLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.Location = new System.Drawing.Point(4, 28);
            this.saveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(337, 29);
            this.saveLabel.TabIndex = 14;
            this.saveLabel.Text = "Save fractal ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.startColorPanelForShowing, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.endColorPanelForShowing, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(337, 20);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // startColorPanelForShowing
            // 
            this.startColorPanelForShowing.BackColor = System.Drawing.Color.Black;
            this.startColorPanelForShowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startColorPanelForShowing.Location = new System.Drawing.Point(4, 4);
            this.startColorPanelForShowing.Margin = new System.Windows.Forms.Padding(4);
            this.startColorPanelForShowing.Name = "startColorPanelForShowing";
            this.startColorPanelForShowing.Size = new System.Drawing.Size(160, 12);
            this.startColorPanelForShowing.TabIndex = 0;
            // 
            // endColorPanelForShowing
            // 
            this.endColorPanelForShowing.BackColor = System.Drawing.Color.Black;
            this.endColorPanelForShowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endColorPanelForShowing.Location = new System.Drawing.Point(172, 4);
            this.endColorPanelForShowing.Margin = new System.Windows.Forms.Padding(4);
            this.endColorPanelForShowing.Name = "endColorPanelForShowing";
            this.endColorPanelForShowing.Size = new System.Drawing.Size(161, 12);
            this.endColorPanelForShowing.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(365, 533);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1075, 51);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.comboBoxForZoom, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.timerComboBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1063, 39);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // comboBoxForZoom
            // 
            this.comboBoxForZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxForZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxForZoom.FormattingEnabled = true;
            this.comboBoxForZoom.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "5x"});
            this.comboBoxForZoom.Location = new System.Drawing.Point(535, 4);
            this.comboBoxForZoom.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxForZoom.Name = "comboBoxForZoom";
            this.comboBoxForZoom.Size = new System.Drawing.Size(524, 52);
            this.comboBoxForZoom.TabIndex = 3;
            this.comboBoxForZoom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxForZoom_SelectedIndexChanged);
            // 
            // timerComboBox
            // 
            this.timerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerComboBox.FormattingEnabled = true;
            this.timerComboBox.Items.AddRange(new object[] {
            "5 sec",
            "10 sec",
            "15 sec"});
            this.timerComboBox.Location = new System.Drawing.Point(6, 6);
            this.timerComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.timerComboBox.Name = "timerComboBox";
            this.timerComboBox.Size = new System.Drawing.Size(519, 52);
            this.timerComboBox.TabIndex = 0;
            this.timerComboBox.SelectedIndexChanged += new System.EventHandler(this.TimerComboBox_SelectedIndexChanged);
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(3, 532);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(355, 53);
            this.AboutButton.TabIndex = 5;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1444, 588);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRACTALS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label chooseFractalLabel;
        private System.Windows.Forms.ComboBox listWithFractals;
        private System.Windows.Forms.Label writeTheRecursionDepthLabel;
        private System.Windows.Forms.TextBox recursionTextBox;
        private System.Windows.Forms.Label chooseColorsLabel;
        private System.Windows.Forms.Button startColorButton;
        private System.Windows.Forms.Button endColorButton;
        private System.Windows.Forms.Button newRecursionDepthButton;
        private System.Windows.Forms.ColorDialog startColorDialog;
        private System.Windows.Forms.ColorDialog endColorDialog;
        private System.Windows.Forms.PictureBox drawingPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel startColorPanelForShowing;
        private System.Windows.Forms.Panel endColorPanelForShowing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox comboBoxForZoom;
        private System.Windows.Forms.ComboBox timerComboBox;
        private System.Windows.Forms.Button AboutButton;
    }
}

