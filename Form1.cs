using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.XFeatures2D;
using Emgu.CV.Util;
using Emgu.CV.Features2D;


namespace EMT_Mini_Project
{
    public partial class Video : Form
    {
        // Declaring Global Variables
        //================================================================
        VideoCapture capture = null;
        bool _captureInProgress;

        static Size originalImageSize = new Size(326, 326);
        Size funcImageSize = new Size(150, 150);

        string colorFocus = "Yellow";
        string answerColor = "NG | G";
        int numberOfCircles = 0;
        int pixelCount = 0;
        string lengthAcceptance = "NG | G";
        string overallResults = "NG | G";
        VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
        static int fps = 30;
        string chosenImage;
        string percentageBrokenString = "";

        bool freezeFrame = false;



        VideoWriter VideoW = new VideoWriter(@"C:\EMT\Image\EMT_MiniProject\Screenshots and Video\capturedVideo.mp4", -1, fps, originalImageSize, true);

        // Video Capture Functions
        //================================================================
        public Video()
        {
            InitializeComponent();
            try
            {
                capture = new VideoCapture(1);
                capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        private void StartCaptureBtn_Click(object sender, EventArgs e)
        {
            if (_captureInProgress)
            {  //stop the capture
                StartCaptureBtn.Text = "Start Capturing";
                capture.Pause();
            }
            else
            {//start the capture
                StartCaptureBtn.Text = "Stop Capturing";
                capture.Start();
            }
            _captureInProgress = !_captureInProgress;
        }
        //================================================================

        // Video Processing Main Code
        //================================================================
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                Mat frame = new Mat();
                Mat dst = new Mat();
                capture.Retrieve(frame);

                // Configuring Original Image into Original Image Box Size
                // Check if using Image or using Video
                //=========================================================================================
                if (usePictureBtn.Text == "Use Picture")
                {
                    dst = new Mat(frame.Rows, frame.Cols, frame.Depth, frame.NumberOfChannels);
                    CvInvoke.Resize(frame, dst, originalImageSize);
                }
                else if (usePictureBtn.Text == "Use Video")
                {
                    dst = CvInvoke.Imread(chosenImage, ImreadModes.Color);
                    CvInvoke.Resize(dst, dst, originalImageSize);
                }
                //=========================================================================================

                //Pre-processing
                //=========================================================================================
                denoising(dst, out dst);
                //=========================================================================================

                // 1. Detect Color Filter
                //=========================================================================================
                Mat detectedColor = new Mat(frame.Rows, frame.Cols, frame.Depth, frame.NumberOfChannels); // Mat for detected color
                detectColor(dst, out detectedColor, out answerColor);
                //=========================================================================================

                // 2. Detect White Dots Filter
                //=========================================================================================
                Mat whiteDotsImage = new Mat(dst.Rows, dst.Cols, dst.Depth, dst.NumberOfChannels);
                detectWhiteDots(dst, out whiteDotsImage, out numberOfCircles);
                //=========================================================================================

                // 3. Detect Edge Filter
                //=========================================================================================
                Mat edge = new Mat(dst.Rows, dst.Cols, dst.Depth, dst.NumberOfChannels);
                detectEdge(dst, out edge);
                //=========================================================================================

                // 4. Pixel detection
                //=========================================================================================
                pixelDetection(dst, out pixelCount, out lengthAcceptance, out percentageBrokenString);
                //=========================================================================================

                // 5. Contours detection
                //=========================================================================================
                contoursDetection(dst, out contours);
                //=========================================================================================

                // 6. Overall Results
                //=========================================================================================
                overallChecker(answerColor, numberOfCircles, lengthAcceptance, out overallResults);
                //=========================================================================================

                if (overlayCheckBox.Checked == false)
                { 
                    vidOriginal.Image = dst.ToImage<Bgr, byte>().Bitmap;

                }

                    // 7. Activate Overlay
                    //=========================================================================================
                    overlayActivater(dst, contours);
                //=========================================================================================

                // 8. Enable Recording
                //=========================================================================================
                if (recordingCheckbox.Checked)
                { VideoW.Write(dst); }
                //=========================================================================================

                // 9. Take screenshot
                //=========================================================================================
                if (freezeFrame == true)
                {
                    dst.Save(@"C:\EMT\Image\EMT_MiniProject\Screenshots and Video\frozenFrame.jpg");
                    freezeFrame = !freezeFrame; // Make sure only takes one frame
                }
                //=========================================================================================

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Displays the perfect and correctly detected items
            Mat src = CvInvoke.Imread(@"C:\EMT\Image\EMT_MiniProject\yellow.jpg", ImreadModes.Color);
            Mat dst = new Mat(src.Rows, src.Cols, src.Depth, src.NumberOfChannels);
            Mat dst2 = new Mat(src.Rows, src.Cols, src.Depth, src.NumberOfChannels);
            CvInvoke.Resize(src, dst, originalImageSize);
            Mat edge = new Mat(dst.Rows, dst.Cols, dst.Depth, dst.NumberOfChannels);
            Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new System.Drawing.Size(3, 3), new System.Drawing.Point(-1, 1));
            CvInvoke.InRange(dst, new ScalarArray(new MCvScalar(10, 170, 170)), new ScalarArray(new MCvScalar(45, 245, 245)), dst2);

            CvInvoke.Dilate(dst2, dst2, element, new System.Drawing.Point(-1, 1), 1, BorderType.Default, new MCvScalar(1.0));
            CvInvoke.Canny(dst2, edge, 50, 255, 3, true);

            CvInvoke.CvtColor(edge, edge, ColorConversion.Gray2Bgr);
            CvInvoke.Dilate(edge, edge, element, new System.Drawing.Point(-1, 1), 1, BorderType.Default, new MCvScalar(1.0));

            dst.SetTo(new Bgr(0, 255, 0).MCvScalar, edge);

            // Set all image boxes except Original Box into null
            vidOriginal.Image = dst.Bitmap;
            vidRed.Image = null;
            vidGreen.Image = null;
            vidYellow.Image = null;
            vidEdge.Image = null;
            vidDots.Image = null;

            // Added a timer thread to refresh every interval to update labels
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        //================================================================

        // Video Processing Indivdual Functions
        //================================================================
        public void denoising(Mat srcImage, out Mat denoisedImg) // Denoising by eroding and dilating
        {
            denoisedImg = new Mat(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);

            Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new System.Drawing.Size(3, 3), new System.Drawing.Point(-1, 1));

            CvInvoke.Erode(srcImage, denoisedImg, element, new System.Drawing.Point(-1, -1), 3, BorderType.Default, new MCvScalar(1.0));
            CvInvoke.Dilate(denoisedImg, denoisedImg, element, new System.Drawing.Point(-1, -1), 3, BorderType.Default, new MCvScalar(1.0));
        }
        public void detectWhiteDots(Mat srcImage, out Mat whiteDotsImage, out int numberOfCircles)// White Dot Detection Code
        {
            whiteDotsImage = new Mat(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);
            numberOfCircles = 0;

            if (whiteDotscheckBox.Checked == true)
            {
                CvInvoke.Resize(srcImage, whiteDotsImage, funcImageSize);
                Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new System.Drawing.Size(3, 3), new System.Drawing.Point(-1, 1));

                // Pick out the Ice Cream Stick
                CvInvoke.InRange(whiteDotsImage, new ScalarArray(new MCvScalar(180, 180, 140)), new ScalarArray(new MCvScalar(255, 255, 255)), whiteDotsImage);

                CvInvoke.Dilate(whiteDotsImage, whiteDotsImage, element, new System.Drawing.Point(-1, 1), 1, BorderType.Default, new MCvScalar(1.0));

                // Find locations of circle
                CircleF[] circles = CvInvoke.HoughCircles(whiteDotsImage, HoughType.Gradient, 2, 8, 100, 20, 0, 40); //takes in greyscale after denoising
                Image<Bgr, Byte> circleImg = whiteDotsImage.ToImage<Bgr, byte>(); //mat to img

                // Draw circle at points that detected circle
                foreach (CircleF circle in circles)
                {
                    circleImg.Draw(circle, new Bgr(Color.DarkRed), 2);
                    numberOfCircles++;
                }

                whiteDotsImage = circleImg.Mat;
                vidDots.Image = whiteDotsImage.ToImage<Bgr, byte>().Bitmap; // Putting video into picturebox
            }

            else if(whiteDotscheckBox.Checked == false) // turn off white dot picture box if white dot filter is not checked
            {
                vidDots.Image = null;
            }
        }
        public void detectColor(Mat srcImage, out Mat detectedColor, out string answerColor) // Color Detection Code
        {
            detectedColor = new Mat();
            answerColor = "NG | G";

            if (colorDetectioncheckBox.Checked == true)
            {
                CvInvoke.Resize(srcImage, detectedColor, funcImageSize);

                Mat detectedColorRed = new Mat(detectedColor.Rows, detectedColor.Cols, detectedColor.Depth, detectedColor.NumberOfChannels);
                Mat detectedColorGreen = new Mat(detectedColor.Rows, detectedColor.Cols, detectedColor.Depth, detectedColor.NumberOfChannels);
                Mat detectedColorYellow = new Mat(detectedColor.Rows, detectedColor.Cols, detectedColor.Depth, detectedColor.NumberOfChannels);
                double colorDetectedPixels = 0;

                Matrix<float> Kernel = new Matrix<float>(3, 3); 
                Kernel.Data = new float[3, 3] { { 1 / 9f, 1 / 9f, 1 / 9f }, { 1 / 9f, 1 / 9f, 1 / 9f }, { 1 / 9f, 1 / 9f, 1 / 9f } };

                // Denoising of image to allow easier color detection
                CvInvoke.Filter2D(detectedColor, detectedColor, Kernel, new System.Drawing.Point(-1, -1)); 

                // Yellow Detected
                CvInvoke.InRange(detectedColor, new ScalarArray(new MCvScalar(10, 150, 150)), new ScalarArray(new MCvScalar(45, 255, 255)), detectedColorYellow);

                // Red Detected (Range not complete)
                CvInvoke.InRange(detectedColor, new ScalarArray(new MCvScalar(10, 10, 115)), new ScalarArray(new MCvScalar(70, 95, 225)), detectedColorRed);

                // Green Detected (Range not complete)
                CvInvoke.InRange(detectedColor, new ScalarArray(new MCvScalar(10, 50, 10)), new ScalarArray(new MCvScalar(115, 225, 80)), detectedColorGreen);

                // Count Pixel for all images to detect if there is any extra colours
                double colorExtraYellowPixels = CvInvoke.CountNonZero(detectedColorYellow.ToImage<Gray, byte>());
                double colorExtraRedPixels = CvInvoke.CountNonZero(detectedColorRed.ToImage<Gray, byte>());
                double colorExtraGreenPixels = CvInvoke.CountNonZero(detectedColorGreen.ToImage<Gray, byte>());

                // Setting detectedColor as wanted output color
                if (colorFocus == "Yellow")
                {
                    detectedColor = detectedColorYellow;
                    colorExtraYellowPixels = 0; // Set to 0 as it is not unwanted
                }
                else if (colorFocus == "Red")
                {
                    detectedColor = detectedColorRed;
                    colorExtraRedPixels = 0;    // Set to 0 as it is not unwanted
                }
                else if (colorFocus == "Green")
                {
                    detectedColor = detectedColorGreen;
                    colorExtraGreenPixels = 0;  // Set to 0 as it is not unwanted
                }

                // Counting number of pixels in the detectedColor Image to see if the color has been detected
                colorDetectedPixels = CvInvoke.CountNonZero(detectedColor.ToImage<Gray, byte>());
                double colorNotWantedPixels = colorExtraYellowPixels + colorExtraRedPixels + colorExtraGreenPixels;

                if (colorDetectedPixels >= 500 && colorNotWantedPixels <= 100) // Detect if it is only 1 color
                {
                    answerColor = "Yes";
                }
                else if(colorDetectedPixels >= 500 && colorNotWantedPixels >= 100) // Detect if it is correct colour but there is extra colours
                {
                    answerColor = "Extra";
                }
                else // Correct color not present
                {
                    answerColor = "No";
                }
                
                // Setting each detected image into its respective picture box
                vidRed.Image = detectedColorRed.ToImage<Gray, byte>().Bitmap;
                vidGreen.Image = detectedColorGreen.ToImage<Gray, byte>().Bitmap;
                vidYellow.Image = detectedColorYellow.ToImage<Gray, byte>().Bitmap;
            }
            else if (colorDetectioncheckBox.Checked == false) // turn off color picture box if color detection filter is not checked
            {
                vidRed.Image = null;
                vidGreen.Image = null;
                vidYellow.Image = null;

                answerColor = "-";
            }
        }
        private void colorFocusComboBox_SelectedIndexChanged(object sender, EventArgs e) // For choosing which color to detect
        {
            colorFocus = colorFocusComboBox.Text;
        }
        public void detectEdge(Mat srcImage, out Mat edge) // Edge Detection Code
        {
            edge = new Mat(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);
            Mat denoisedImg = new Mat(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);

            if (edgeDetectioncheckBox.Checked == true)
            {
                CvInvoke.Resize(srcImage, edge, funcImageSize);
                CvInvoke.Resize(srcImage, denoisedImg, funcImageSize);

                Mat element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new System.Drawing.Size(3, 3), new System.Drawing.Point(-1, 1));

                CvInvoke.Dilate(denoisedImg, denoisedImg, element, new System.Drawing.Point(-1, 1), 1, BorderType.Default, new MCvScalar(1.0));
                CvInvoke.Canny(denoisedImg, edge, 50, 255, 3, true);

                CvInvoke.CvtColor(edge, edge, ColorConversion.Gray2Bgr, 0);
                CvInvoke.Dilate(edge, edge, element, new System.Drawing.Point(-1, 1), 1, BorderType.Default, new MCvScalar(1.0));

                //dst.SetTo(new Bgr(0, 255, 0).MCvScalar, edge);

                vidEdge.Image = edge.ToImage<Gray, byte>().Bitmap;
            }
            else if(edgeDetectioncheckBox.Checked == false)
            {
                vidEdge.Image = null;
            }
        }
        public void pixelDetection(Mat srcImage, out int pixelCount, out string lengthAcceptance, out string percentageBrokenString) // Length Detection Code
        {
            pixelCount = 0;
            lengthAcceptance = "-";
            double percentageBroken = 0;
            percentageBrokenString = "";
            int stickLengthUpperLimit = 1400;
            int stickLengthLowerLimit = 1000;

            if (lengthDetectioncheckBox.Checked == true)
            {
                // Normal color detection detection
                //===================================================================================================================================
                Mat resizedSrc= new Mat(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);
                CvInvoke.Resize(srcImage, resizedSrc, funcImageSize);
                Mat stickIsolation = new Mat(resizedSrc.Rows, resizedSrc.Cols, resizedSrc.Depth, resizedSrc.NumberOfChannels);

                CvInvoke.InRange(resizedSrc, new ScalarArray(new MCvScalar(8, 8, 8)), new ScalarArray(new MCvScalar(255, 255, 255)), stickIsolation); // Get Ice Cream Sticks

                // Counting number of pixels in the stickIsolation Image to see if the correct length has been detected
                pixelCount = CvInvoke.CountNonZero(stickIsolation.ToImage<Gray, byte>());

                if (pixelCount >= stickLengthLowerLimit && pixelCount <= stickLengthUpperLimit) // ~1500 was a full length Ice Cream Stick
                {
                    lengthAcceptance = "Yes";
                }
                else if (pixelCount >= stickLengthUpperLimit)
                {
                    lengthAcceptance = "Too Many Objects Present";
                }
                else { lengthAcceptance = "No"; }
                //===================================================================================================================================

                // Percentage broken - For color detection of single stick only
                //===================================================================================================================================
                if (contoursCheckBox.Checked == true)
                {
                    if (contours.Size == 1)
                    {
                        int sth = contours.Size;
                        if (pixelCount >= stickLengthLowerLimit && pixelCount <= stickLengthUpperLimit) // ~1500 was a full length Ice Cream Stick
                        {
                            lengthAcceptance = "Yes";
                        }
                        else if(pixelCount <= stickLengthUpperLimit)
                        {
                            float pixelCountFloat = pixelCount;
                            percentageBroken = (1 - (pixelCountFloat / stickLengthUpperLimit)) * 100;
                            percentageBroken = Math.Round(percentageBroken,0);
                            percentageBrokenString = percentageBroken + "% Broken";
                            lengthAcceptance = percentageBrokenString;
                        }
                        else
                        {
                            lengthAcceptance = "No";
                        }
                    }
                    else
                    {
                        percentageBrokenString = "";
                    }
                }
                //===================================================================================================================================
            }
            else if (lengthDetectioncheckBox.Checked == false)
            {
            }
        }
        public void contoursDetection(Mat srcImage, out VectorOfVectorOfPoint contours) // Contours Detection Code
        {
            contours = new Emgu.CV.Util.VectorOfVectorOfPoint();

            if (contoursCheckBox.Checked == true)
            {
                Mat resizedSegment = new Mat(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);

                Mat segment = new Mat(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);
                Mat contpts = new Mat();
                Mat hier = new Mat();
                CvInvoke.InRange(srcImage, new ScalarArray(new MCvScalar(8, 8, 8)), new ScalarArray(new MCvScalar(255, 255, 255)), segment); //denoised image input + stick identification
                CvInvoke.FindContours(segment, contours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                if (contours.Size > 0)
                {
                    for (int i = 0; i < contours.Size; i++)
                    {
                        Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                        CvInvoke.Rectangle(segment,rect, new MCvScalar(255, 255, 255), 2);   //draw rectangle add any i
                    }

                }

                CvInvoke.Resize(segment, resizedSegment, funcImageSize);
                vidContours.Image = resizedSegment.ToImage<Bgr, byte>().Bitmap;
            }
            else if (contoursCheckBox.Checked == false)
            {
                vidContours.Image = null;
            }
        }
        public void overallChecker(string answerColor,int numberOfCircles,string lengthAcceptance, out string overallResults) // Check overall good or no good
        {
            string correctColor = "No";
            string correctLength = "No";
            string correctCircle = "No";
            overallResults = "NG | G";

            // Check if all the filters are applied
            if (colorDetectioncheckBox.Checked && lengthDetectioncheckBox.Checked && whiteDotscheckBox.Checked == true )
            {
                // Convert answers to string "Yes" and "No"
                if(answerColor == "Yes")
                { correctColor = "Yes";   }
                if(lengthAcceptance == "Yes")
                { correctLength = "Yes";  }
                if (numberOfCircles == 0)
                { correctCircle = "Yes";  }

                if(correctColor == "Yes" && correctLength == "Yes" && correctCircle == "Yes")
                {
                    overallResults = "Good";
                }
                else
                {
                    // Detecting which is the wrong content
                    int countWrong = 0;
                    overallResults = "No Good : ";

                    if (answerColor == "Extra") // This is used to detect if there is more than 1 color, it is placed above the correctColor detector because we need check this first as correctColor just detects if the answerColor is not "Yes"
                    {
                        overallResults += "More than 1 color detected";
                        countWrong++;
                    }
                    else if (correctColor == "No")
                    {
                        overallResults += "Wrong color";
                        countWrong++;
                    }
                    if (correctLength == "No" || correctLength == "Too Many Objects Present")
                    {
                        if (countWrong > 0)
                        { overallResults += ", Wrong Length"; }
                        else { overallResults += "Wrong Length"; }
                    }
                    if (correctCircle == "No")
                    {
                        if (countWrong > 0)
                        { overallResults += ", Contains circle"; }
                        else { overallResults += "Contains circle"; }
                    }
                }
            }
            else
            {
                overallResults = "Please turn on ";
                int countWrong = 0;
                if (colorDetectioncheckBox.Checked == false)
                {
                    overallResults += "Color";
                    countWrong++; }
                if(lengthDetectioncheckBox.Checked == false)
                {
                    if(countWrong > 0)
                    { overallResults += ", "; }
                    overallResults += "Length";
                    countWrong++;
                }
                if (whiteDotscheckBox.Checked == false)
                {
                    if (countWrong > 0)
                    { overallResults += " and "; }
                    overallResults += "White Dot";
                    countWrong++;
                }
                overallResults += " Detection";
            }
        }
        public void overlayActivater(Mat srcImage, VectorOfVectorOfPoint contours)
        {
            if(overlayCheckBox.Checked == true)
            {
                if (contours.Size > 0)
                {
                    for (int i = 0; i < contours.Size; i++)
                    {
                        Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);

                        if (overallResults == "Good")
                        { CvInvoke.Rectangle(srcImage, rect, new MCvScalar(0, 255, 0), 2);
                        }  //draw rectangle add any i
                        else
                            CvInvoke.Rectangle(srcImage, rect, new MCvScalar(0, 0, 255), 2);
                        }
                }

                vidOriginal.Image = srcImage.ToImage<Bgr, byte>().Bitmap;
            }
        }
        private void timer_Tick(object sender, EventArgs e) // Timer function to dynamically change text/label etc
        {
            // Labels to update when timer runs
            correctColorLabel.Text = answerColor; // Update color accuracy
            noOfWhiteDotsLabel.Text = numberOfCircles.ToString(); // Update white dots 
            noWhitePixelsLabel.Text = pixelCount.ToString(); // Update pixel count

            if(percentageBrokenString != "")
            {
                correctLengthLabel.Text = lengthAcceptance; // Update length accuracy
            }
            else
            {
                correctLengthLabel.Text = lengthAcceptance; // Update length accuracy
            }

            overallResultsLabel.Text = overallResults; // Update Overall Results
        }
        private void freezeFrameBtn_Click(object sender, EventArgs e) // Screenshot a frame
        {
            freezeFrame = !freezeFrame;
        }
        private void usePictureBtn_Click(object sender, EventArgs e) // Swap between video or image
        {
            if(usePictureBtn.Text == "Use Picture")
            {
                OpenFileDialog openImage = new OpenFileDialog();
                while(openImage.FileName == "")
                {
                    openImage.ShowDialog();
                }
                chosenImage = openImage.FileName;
                usePictureBtn.Text = "Use Video";
            }
            else if (usePictureBtn.Text == "Use Video")
            { usePictureBtn.Text = "Use Picture"; }
        }

    }
}
