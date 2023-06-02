namespace WinForms_Wordpad_Killer_Homework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            FontLabel = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SizeLabel = new Label();
            FontStyleLabel = new Label();
            BoldButton = new Button();
            UnderlineButton = new Button();
            ItalicButton = new Button();
            LeftAlignmentButton = new Button();
            AlignmentLabel = new Label();
            CenterAlignmentButton = new Button();
            RightAlignmentButton = new Button();
            ColorLabel = new Label();
            LoadBox = new TextBox();
            SaveBox = new TextBox();
            LoadButton = new Button();
            SaveButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ColorButton = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-3, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(905, 409);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // FontLabel
            // 
            FontLabel.AutoSize = true;
            FontLabel.Location = new Point(57, 9);
            FontLabel.Name = "FontLabel";
            FontLabel.Size = new Size(31, 15);
            FontLabel.TabIndex = 1;
            FontLabel.Text = "Font";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(144, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(60, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "9";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Location = new Point(159, 9);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(27, 15);
            SizeLabel.TabIndex = 4;
            SizeLabel.Text = "Size";
            // 
            // FontStyleLabel
            // 
            FontStyleLabel.AutoSize = true;
            FontStyleLabel.Location = new Point(242, 9);
            FontStyleLabel.Name = "FontStyleLabel";
            FontStyleLabel.Size = new Size(59, 15);
            FontStyleLabel.TabIndex = 5;
            FontStyleLabel.Text = "Font Style";
            // 
            // BoldButton
            // 
            BoldButton.BackColor = Color.Transparent;
            BoldButton.FlatStyle = FlatStyle.Flat;
            BoldButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BoldButton.Location = new Point(223, 27);
            BoldButton.Name = "BoldButton";
            BoldButton.Size = new Size(27, 23);
            BoldButton.TabIndex = 6;
            BoldButton.Text = "B";
            BoldButton.UseVisualStyleBackColor = false;
            BoldButton.Click += BoldButton_Click;
            // 
            // UnderlineButton
            // 
            UnderlineButton.BackColor = Color.Transparent;
            UnderlineButton.FlatStyle = FlatStyle.Flat;
            UnderlineButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            UnderlineButton.Location = new Point(256, 27);
            UnderlineButton.Name = "UnderlineButton";
            UnderlineButton.Size = new Size(27, 23);
            UnderlineButton.TabIndex = 7;
            UnderlineButton.Text = "U";
            UnderlineButton.UseVisualStyleBackColor = false;
            UnderlineButton.Click += UnderlineButton_Click;
            // 
            // ItalicButton
            // 
            ItalicButton.BackColor = Color.Transparent;
            ItalicButton.FlatStyle = FlatStyle.Flat;
            ItalicButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ItalicButton.Location = new Point(289, 27);
            ItalicButton.Name = "ItalicButton";
            ItalicButton.Size = new Size(27, 23);
            ItalicButton.TabIndex = 8;
            ItalicButton.Text = "I";
            ItalicButton.UseVisualStyleBackColor = false;
            ItalicButton.Click += ItalicButton_Click;
            // 
            // LeftAlignmentButton
            // 
            LeftAlignmentButton.BackColor = Color.Transparent;
            LeftAlignmentButton.FlatStyle = FlatStyle.Flat;
            LeftAlignmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LeftAlignmentButton.Location = new Point(337, 26);
            LeftAlignmentButton.Name = "LeftAlignmentButton";
            LeftAlignmentButton.Size = new Size(27, 23);
            LeftAlignmentButton.TabIndex = 9;
            LeftAlignmentButton.Text = "L";
            LeftAlignmentButton.UseVisualStyleBackColor = false;
            LeftAlignmentButton.Click += LeftAlignmentButton_Click;
            // 
            // AlignmentLabel
            // 
            AlignmentLabel.AutoSize = true;
            AlignmentLabel.Location = new Point(356, 9);
            AlignmentLabel.Name = "AlignmentLabel";
            AlignmentLabel.Size = new Size(63, 15);
            AlignmentLabel.TabIndex = 10;
            AlignmentLabel.Text = "Alignment";
            // 
            // CenterAlignmentButton
            // 
            CenterAlignmentButton.BackColor = Color.Transparent;
            CenterAlignmentButton.FlatStyle = FlatStyle.Flat;
            CenterAlignmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CenterAlignmentButton.Location = new Point(370, 26);
            CenterAlignmentButton.Name = "CenterAlignmentButton";
            CenterAlignmentButton.Size = new Size(27, 23);
            CenterAlignmentButton.TabIndex = 11;
            CenterAlignmentButton.Text = "C";
            CenterAlignmentButton.UseVisualStyleBackColor = false;
            CenterAlignmentButton.Click += CenterAlignmentButton_Click;
            // 
            // RightAlignmentButton
            // 
            RightAlignmentButton.BackColor = Color.Transparent;
            RightAlignmentButton.FlatStyle = FlatStyle.Flat;
            RightAlignmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RightAlignmentButton.Location = new Point(403, 26);
            RightAlignmentButton.Name = "RightAlignmentButton";
            RightAlignmentButton.Size = new Size(27, 23);
            RightAlignmentButton.TabIndex = 12;
            RightAlignmentButton.Text = "R";
            RightAlignmentButton.UseVisualStyleBackColor = false;
            RightAlignmentButton.Click += RightAlignmentButton_Click;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(497, 9);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(36, 15);
            ColorLabel.TabIndex = 13;
            ColorLabel.Text = "Color";
            // 
            // LoadBox
            // 
            LoadBox.Location = new Point(602, 8);
            LoadBox.Name = "LoadBox";
            LoadBox.PlaceholderText = "Tap to load button to load file.";
            LoadBox.ReadOnly = true;
            LoadBox.Size = new Size(207, 23);
            LoadBox.TabIndex = 15;
            // 
            // SaveBox
            // 
            SaveBox.Location = new Point(602, 37);
            SaveBox.Name = "SaveBox";
            SaveBox.PlaceholderText = "Tap to enter and save file.";
            SaveBox.Size = new Size(207, 23);
            SaveBox.TabIndex = 16;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(815, 8);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 17;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(815, 38);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ColorButton
            // 
            ColorButton.Location = new Point(456, 26);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(124, 23);
            ColorButton.TabIndex = 19;
            ColorButton.Text = "Choose Color";
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 473);
            Controls.Add(ColorButton);
            Controls.Add(SaveButton);
            Controls.Add(LoadButton);
            Controls.Add(SaveBox);
            Controls.Add(LoadBox);
            Controls.Add(ColorLabel);
            Controls.Add(RightAlignmentButton);
            Controls.Add(CenterAlignmentButton);
            Controls.Add(AlignmentLabel);
            Controls.Add(LeftAlignmentButton);
            Controls.Add(ItalicButton);
            Controls.Add(UnderlineButton);
            Controls.Add(BoldButton);
            Controls.Add(FontStyleLabel);
            Controls.Add(SizeLabel);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(FontLabel);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "WordPadd";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label FontLabel;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label SizeLabel;
        private Label FontStyleLabel;
        private Button BoldButton;
        private Button UnderlineButton;
        private Button ItalicButton;
        private Button LeftAlignmentButton;
        private Label AlignmentLabel;
        private Button CenterAlignmentButton;
        private Button RightAlignmentButton;
        private Label ColorLabel;
        private TextBox LoadBox;
        private TextBox SaveBox;
        private Button LoadButton;
        private Button SaveButton;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button ColorButton;
        private ColorDialog colorDialog1;
    }
}