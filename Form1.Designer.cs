namespace EMT_Mini_Project
{
    partial class Video
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.usePictureBtn = new System.Windows.Forms.Button();
            this.freezeFrameBtn = new System.Windows.Forms.Button();
            this.StartCaptureBtn = new System.Windows.Forms.Button();
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.recordingCheckbox = new System.Windows.Forms.CheckBox();
            this.overlayCheckBox = new System.Windows.Forms.CheckBox();
            this.contoursCheckBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.colorFocusComboBox = new System.Windows.Forms.ComboBox();
            this.edgeDetectioncheckBox = new System.Windows.Forms.CheckBox();
            this.whiteDotscheckBox = new System.Windows.Forms.CheckBox();
            this.lengthDetectioncheckBox = new System.Windows.Forms.CheckBox();
            this.colorDetectioncheckBox = new System.Windows.Forms.CheckBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.overallResultsLabel = new System.Windows.Forms.Label();
            this.noOfWhiteDotsLabel = new System.Windows.Forms.Label();
            this.correctLengthLabel = new System.Windows.Forms.Label();
            this.noWhitePixelsLabel = new System.Windows.Forms.Label();
            this.correctColorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vidContours = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vidDots = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vidEdge = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vidYellow = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vidGreen = new System.Windows.Forms.PictureBox();
            this.vidRed = new System.Windows.Forms.PictureBox();
            this.vidOriginal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.menuGroupBox.SuspendLayout();
            this.configGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.imageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidContours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidDots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuGroupBox);
            this.panel1.Controls.Add(this.configGroupBox);
            this.panel1.Controls.Add(this.resultGroupBox);
            this.panel1.Controls.Add(this.imageGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 647);
            this.panel1.TabIndex = 0;
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.usePictureBtn);
            this.menuGroupBox.Controls.Add(this.freezeFrameBtn);
            this.menuGroupBox.Controls.Add(this.StartCaptureBtn);
            this.menuGroupBox.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.menuGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuGroupBox.Location = new System.Drawing.Point(891, 460);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(415, 182);
            this.menuGroupBox.TabIndex = 10;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu";
            // 
            // usePictureBtn
            // 
            this.usePictureBtn.FlatAppearance.BorderSize = 0;
            this.usePictureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usePictureBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usePictureBtn.Location = new System.Drawing.Point(6, 128);
            this.usePictureBtn.Name = "usePictureBtn";
            this.usePictureBtn.Size = new System.Drawing.Size(403, 40);
            this.usePictureBtn.TabIndex = 12;
            this.usePictureBtn.Text = "Use Picture";
            this.usePictureBtn.UseVisualStyleBackColor = true;
            this.usePictureBtn.Click += new System.EventHandler(this.usePictureBtn_Click);
            // 
            // freezeFrameBtn
            // 
            this.freezeFrameBtn.FlatAppearance.BorderSize = 0;
            this.freezeFrameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freezeFrameBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.freezeFrameBtn.Location = new System.Drawing.Point(6, 82);
            this.freezeFrameBtn.Name = "freezeFrameBtn";
            this.freezeFrameBtn.Size = new System.Drawing.Size(403, 40);
            this.freezeFrameBtn.TabIndex = 11;
            this.freezeFrameBtn.Text = "Screen Shot";
            this.freezeFrameBtn.UseVisualStyleBackColor = true;
            this.freezeFrameBtn.Click += new System.EventHandler(this.freezeFrameBtn_Click);
            // 
            // StartCaptureBtn
            // 
            this.StartCaptureBtn.FlatAppearance.BorderSize = 0;
            this.StartCaptureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartCaptureBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartCaptureBtn.Location = new System.Drawing.Point(6, 36);
            this.StartCaptureBtn.Name = "StartCaptureBtn";
            this.StartCaptureBtn.Size = new System.Drawing.Size(403, 40);
            this.StartCaptureBtn.TabIndex = 0;
            this.StartCaptureBtn.Text = "Start Video Capture";
            this.StartCaptureBtn.UseVisualStyleBackColor = true;
            this.StartCaptureBtn.Click += new System.EventHandler(this.StartCaptureBtn_Click);
            // 
            // configGroupBox
            // 
            this.configGroupBox.Controls.Add(this.recordingCheckbox);
            this.configGroupBox.Controls.Add(this.overlayCheckBox);
            this.configGroupBox.Controls.Add(this.contoursCheckBox);
            this.configGroupBox.Controls.Add(this.whiteDotscheckBox);
            this.configGroupBox.Controls.Add(this.label17);
            this.configGroupBox.Controls.Add(this.colorFocusComboBox);
            this.configGroupBox.Controls.Add(this.edgeDetectioncheckBox);
            this.configGroupBox.Controls.Add(this.lengthDetectioncheckBox);
            this.configGroupBox.Controls.Add(this.colorDetectioncheckBox);
            this.configGroupBox.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.configGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.configGroupBox.Location = new System.Drawing.Point(891, 230);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(415, 224);
            this.configGroupBox.TabIndex = 9;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Configurations";
            // 
            // recordingCheckbox
            // 
            this.recordingCheckbox.AutoSize = true;
            this.recordingCheckbox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.recordingCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.recordingCheckbox.Location = new System.Drawing.Point(276, 180);
            this.recordingCheckbox.Name = "recordingCheckbox";
            this.recordingCheckbox.Size = new System.Drawing.Size(114, 24);
            this.recordingCheckbox.TabIndex = 25;
            this.recordingCheckbox.Text = "Enable Recording";
            this.recordingCheckbox.UseVisualStyleBackColor = true;
            // 
            // overlayCheckBox
            // 
            this.overlayCheckBox.AutoSize = true;
            this.overlayCheckBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.overlayCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.overlayCheckBox.Location = new System.Drawing.Point(276, 146);
            this.overlayCheckBox.Name = "overlayCheckBox";
            this.overlayCheckBox.Size = new System.Drawing.Size(111, 24);
            this.overlayCheckBox.TabIndex = 24;
            this.overlayCheckBox.Text = "Overlay Original";
            this.overlayCheckBox.UseVisualStyleBackColor = true;
            // 
            // contoursCheckBox
            // 
            this.contoursCheckBox.AutoSize = true;
            this.contoursCheckBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.contoursCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contoursCheckBox.Location = new System.Drawing.Point(130, 180);
            this.contoursCheckBox.Name = "contoursCheckBox";
            this.contoursCheckBox.Size = new System.Drawing.Size(122, 24);
            this.contoursCheckBox.TabIndex = 23;
            this.contoursCheckBox.Text = "Contours Detection";
            this.contoursCheckBox.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(6, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 22;
            this.label17.Text = "Color Focus";
            // 
            // colorFocusComboBox
            // 
            this.colorFocusComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.colorFocusComboBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.colorFocusComboBox.FormattingEnabled = true;
            this.colorFocusComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Yellow"});
            this.colorFocusComboBox.Location = new System.Drawing.Point(6, 99);
            this.colorFocusComboBox.Name = "colorFocusComboBox";
            this.colorFocusComboBox.Size = new System.Drawing.Size(273, 28);
            this.colorFocusComboBox.TabIndex = 4;
            this.colorFocusComboBox.Text = "Yellow";
            this.colorFocusComboBox.SelectedIndexChanged += new System.EventHandler(this.colorFocusComboBox_SelectedIndexChanged);
            // 
            // edgeDetectioncheckBox
            // 
            this.edgeDetectioncheckBox.AutoSize = true;
            this.edgeDetectioncheckBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.edgeDetectioncheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edgeDetectioncheckBox.Location = new System.Drawing.Point(6, 180);
            this.edgeDetectioncheckBox.Name = "edgeDetectioncheckBox";
            this.edgeDetectioncheckBox.Size = new System.Drawing.Size(100, 24);
            this.edgeDetectioncheckBox.TabIndex = 3;
            this.edgeDetectioncheckBox.Text = "Edge Detection";
            this.edgeDetectioncheckBox.UseVisualStyleBackColor = true;
            // 
            // whiteDotscheckBox
            // 
            this.whiteDotscheckBox.AutoSize = true;
            this.whiteDotscheckBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.whiteDotscheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.whiteDotscheckBox.Location = new System.Drawing.Point(130, 146);
            this.whiteDotscheckBox.Name = "whiteDotscheckBox";
            this.whiteDotscheckBox.Size = new System.Drawing.Size(131, 24);
            this.whiteDotscheckBox.TabIndex = 2;
            this.whiteDotscheckBox.Text = "White Dots Detection";
            this.whiteDotscheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthDetectioncheckBox
            // 
            this.lengthDetectioncheckBox.AutoSize = true;
            this.lengthDetectioncheckBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.lengthDetectioncheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lengthDetectioncheckBox.Location = new System.Drawing.Point(6, 146);
            this.lengthDetectioncheckBox.Name = "lengthDetectioncheckBox";
            this.lengthDetectioncheckBox.Size = new System.Drawing.Size(109, 24);
            this.lengthDetectioncheckBox.TabIndex = 1;
            this.lengthDetectioncheckBox.Text = "Length Detection";
            this.lengthDetectioncheckBox.UseVisualStyleBackColor = true;
            // 
            // colorDetectioncheckBox
            // 
            this.colorDetectioncheckBox.AutoSize = true;
            this.colorDetectioncheckBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.colorDetectioncheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorDetectioncheckBox.Location = new System.Drawing.Point(6, 36);
            this.colorDetectioncheckBox.Name = "colorDetectioncheckBox";
            this.colorDetectioncheckBox.Size = new System.Drawing.Size(104, 24);
            this.colorDetectioncheckBox.TabIndex = 0;
            this.colorDetectioncheckBox.Text = "Color Detection";
            this.colorDetectioncheckBox.UseVisualStyleBackColor = true;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.overallResultsLabel);
            this.resultGroupBox.Controls.Add(this.noOfWhiteDotsLabel);
            this.resultGroupBox.Controls.Add(this.correctLengthLabel);
            this.resultGroupBox.Controls.Add(this.noWhitePixelsLabel);
            this.resultGroupBox.Controls.Add(this.correctColorLabel);
            this.resultGroupBox.Controls.Add(this.label11);
            this.resultGroupBox.Controls.Add(this.label10);
            this.resultGroupBox.Controls.Add(this.label9);
            this.resultGroupBox.Controls.Add(this.label8);
            this.resultGroupBox.Controls.Add(this.label7);
            this.resultGroupBox.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.resultGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resultGroupBox.Location = new System.Drawing.Point(891, 12);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(415, 210);
            this.resultGroupBox.TabIndex = 8;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Results";
            // 
            // overallResultsLabel
            // 
            this.overallResultsLabel.AutoSize = true;
            this.overallResultsLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallResultsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.overallResultsLabel.Location = new System.Drawing.Point(6, 180);
            this.overallResultsLabel.Name = "overallResultsLabel";
            this.overallResultsLabel.Size = new System.Drawing.Size(39, 20);
            this.overallResultsLabel.TabIndex = 21;
            this.overallResultsLabel.Text = "NG | G";
            this.overallResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noOfWhiteDotsLabel
            // 
            this.noOfWhiteDotsLabel.AutoSize = true;
            this.noOfWhiteDotsLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfWhiteDotsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noOfWhiteDotsLabel.Location = new System.Drawing.Point(200, 125);
            this.noOfWhiteDotsLabel.Name = "noOfWhiteDotsLabel";
            this.noOfWhiteDotsLabel.Size = new System.Drawing.Size(16, 20);
            this.noOfWhiteDotsLabel.TabIndex = 20;
            this.noOfWhiteDotsLabel.Text = "0";
            this.noOfWhiteDotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // correctLengthLabel
            // 
            this.correctLengthLabel.AutoSize = true;
            this.correctLengthLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLengthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correctLengthLabel.Location = new System.Drawing.Point(200, 100);
            this.correctLengthLabel.Name = "correctLengthLabel";
            this.correctLengthLabel.Size = new System.Drawing.Size(39, 20);
            this.correctLengthLabel.TabIndex = 19;
            this.correctLengthLabel.Text = "NG | G";
            this.correctLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noWhitePixelsLabel
            // 
            this.noWhitePixelsLabel.AutoSize = true;
            this.noWhitePixelsLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noWhitePixelsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noWhitePixelsLabel.Location = new System.Drawing.Point(200, 75);
            this.noWhitePixelsLabel.Name = "noWhitePixelsLabel";
            this.noWhitePixelsLabel.Size = new System.Drawing.Size(16, 20);
            this.noWhitePixelsLabel.TabIndex = 18;
            this.noWhitePixelsLabel.Text = "0";
            this.noWhitePixelsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // correctColorLabel
            // 
            this.correctColorLabel.AutoSize = true;
            this.correctColorLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctColorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correctColorLabel.Location = new System.Drawing.Point(200, 50);
            this.correctColorLabel.Name = "correctColorLabel";
            this.correctColorLabel.Size = new System.Drawing.Size(39, 20);
            this.correctColorLabel.TabIndex = 17;
            this.correctColorLabel.Text = "NG | G";
            this.correctColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Overall Results Conclusion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Correct length detected";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Wanted color detected";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Number of white dots";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of white pixels detected";
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.label12);
            this.imageGroupBox.Controls.Add(this.vidContours);
            this.imageGroupBox.Controls.Add(this.label6);
            this.imageGroupBox.Controls.Add(this.vidDots);
            this.imageGroupBox.Controls.Add(this.label5);
            this.imageGroupBox.Controls.Add(this.vidEdge);
            this.imageGroupBox.Controls.Add(this.label4);
            this.imageGroupBox.Controls.Add(this.vidYellow);
            this.imageGroupBox.Controls.Add(this.label3);
            this.imageGroupBox.Controls.Add(this.vidGreen);
            this.imageGroupBox.Controls.Add(this.vidRed);
            this.imageGroupBox.Controls.Add(this.vidOriginal);
            this.imageGroupBox.Controls.Add(this.label1);
            this.imageGroupBox.Controls.Add(this.label2);
            this.imageGroupBox.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.imageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(873, 630);
            this.imageGroupBox.TabIndex = 7;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "Images";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(684, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Contours Detection";
            // 
            // vidContours
            // 
            this.vidContours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vidContours.Location = new System.Drawing.Point(650, 226);
            this.vidContours.Name = "vidContours";
            this.vidContours.Size = new System.Drawing.Size(150, 150);
            this.vidContours.TabIndex = 12;
            this.vidContours.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(529, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dot Detection";
            // 
            // vidDots
            // 
            this.vidDots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vidDots.Location = new System.Drawing.Point(494, 226);
            this.vidDots.Name = "vidDots";
            this.vidDots.Size = new System.Drawing.Size(150, 150);
            this.vidDots.TabIndex = 10;
            this.vidDots.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(378, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edge Detection";
            // 
            // vidEdge
            // 
            this.vidEdge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vidEdge.Location = new System.Drawing.Point(338, 226);
            this.vidEdge.Name = "vidEdge";
            this.vidEdge.Size = new System.Drawing.Size(150, 150);
            this.vidEdge.TabIndex = 8;
            this.vidEdge.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(511, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color Detection - Green";
            // 
            // vidYellow
            // 
            this.vidYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vidYellow.Location = new System.Drawing.Point(650, 50);
            this.vidYellow.Name = "vidYellow";
            this.vidYellow.Size = new System.Drawing.Size(150, 150);
            this.vidYellow.TabIndex = 6;
            this.vidYellow.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(673, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color Detection - Yellow";
            // 
            // vidGreen
            // 
            this.vidGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vidGreen.Location = new System.Drawing.Point(494, 50);
            this.vidGreen.Name = "vidGreen";
            this.vidGreen.Size = new System.Drawing.Size(150, 150);
            this.vidGreen.TabIndex = 4;
            this.vidGreen.TabStop = false;
            // 
            // vidRed
            // 
            this.vidRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vidRed.Location = new System.Drawing.Point(338, 50);
            this.vidRed.Name = "vidRed";
            this.vidRed.Size = new System.Drawing.Size(150, 150);
            this.vidRed.TabIndex = 1;
            this.vidRed.TabStop = false;
            // 
            // vidOriginal
            // 
            this.vidOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vidOriginal.Location = new System.Drawing.Point(6, 50);
            this.vidOriginal.Name = "vidOriginal";
            this.vidOriginal.Size = new System.Drawing.Size(326, 326);
            this.vidOriginal.TabIndex = 0;
            this.vidOriginal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(363, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color Detection - Red";
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 647);
            this.Controls.Add(this.panel1);
            this.Name = "Video";
            this.Text = "Video Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuGroupBox.ResumeLayout(false);
            this.configGroupBox.ResumeLayout(false);
            this.configGroupBox.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.imageGroupBox.ResumeLayout(false);
            this.imageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidContours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidDots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox vidRed;
        private System.Windows.Forms.PictureBox vidOriginal;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Label correctColorLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox vidDots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox vidEdge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox vidYellow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox vidGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label overallResultsLabel;
        private System.Windows.Forms.Label noOfWhiteDotsLabel;
        private System.Windows.Forms.Label correctLengthLabel;
        private System.Windows.Forms.Label noWhitePixelsLabel;
        private System.Windows.Forms.GroupBox configGroupBox;
        private System.Windows.Forms.CheckBox lengthDetectioncheckBox;
        private System.Windows.Forms.CheckBox colorDetectioncheckBox;
        private System.Windows.Forms.CheckBox whiteDotscheckBox;
        private System.Windows.Forms.CheckBox edgeDetectioncheckBox;
        private System.Windows.Forms.ComboBox colorFocusComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Button StartCaptureBtn;
        private System.Windows.Forms.Button freezeFrameBtn;
        private System.Windows.Forms.CheckBox overlayCheckBox;
        private System.Windows.Forms.CheckBox contoursCheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox vidContours;
        private System.Windows.Forms.CheckBox recordingCheckbox;
        private System.Windows.Forms.Button usePictureBtn;
    }
}

