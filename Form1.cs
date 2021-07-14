using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Management;
using System.Configuration;
using System.Diagnostics;
using ImageResizer;
using xiApi.NET;
using System.Drawing.Drawing2D;
using System.IO;

namespace CrateInfoScan
{
    public partial class Form1 : Form
    {
        string failureMessage = "";
        string scaleSendCode;//scale 2:"SGW"
        string DOPLabelsFilePath,strScanStringTemp,crateImagesFolder,strErpConn,strCustConn;
        string orderID, crateType, dimensions;
        Decimal coverWeight = 0;
        DateTime shipDate;
        int crateNumberBase, crateNumberScanned;
        Decimal crateWeight;
        Control focused;//set focus back after message box.
        bool err = false,C1Open=false,C2Open=false;
        bool enableOperatorLabels;
        //camera settings
        xiCam xiCam1,xiCam2;
        float C1Red,C1Green,C1Blue,C1GainDB,C2Red,C2Green,C2Blue,C2GainDB;
        int C1ExposureMM, C1WidthPX, C1HeightPX, C1TopPX, C1LeftPX, C2ExposureMM, C2WidthPX, C2HeightPX, C2TopPX,C2LeftPX;
        String C1SN, C2SN;

        //image zooming
        bool emptyScale = false;
        bool mouseDown = false;
        static int zoom = 50;
        static Image sourceImage;
        static Bitmap destImage;
        static int centerX, centerY, newWidth, newHeight;

        public Form1()
        {
            InitializeComponent();
        }

        //UI Event Handlers,Scan String logic
        private void Form1_Load(object sender, EventArgs e)
        {
            arrangeUI();
            this.Show();

            btnOK.Visible = false;
            MsgBox("Initializing...");
            Application.DoEvents();

           // System.Threading.Thread.Sleep(2000);

            loadAppGlobals();
            initCameras();
            openSerialPort();
            if (!err)
            {
                pnlDlgOK.Hide();
                enableInputs();
            } 
            btnOK.Visible = true;
            err = false;
        }

        private void loadAppGlobals()
        {
            enableOperatorLabels = Convert.ToBoolean(ConfigurationManager.AppSettings["enableOperatorLabels"].ToString());
            crateImagesFolder = ConfigurationManager.AppSettings["crateImagesFolder"].ToString();
            scaleSendCode = ConfigurationManager.AppSettings["ScaleSendCode"].ToString();
            DOPLabelsFilePath = ConfigurationManager.AppSettings["DOPLabelsFilePath"].ToString();
            strErpConn = ConfigurationManager.ConnectionStrings["ErpConn"].ConnectionString;
            strCustConn = ConfigurationManager.ConnectionStrings["CustConn"].ConnectionString;

            C1Red = Convert.ToSingle(ConfigurationManager.AppSettings["C1Red"].ToString());
            C1Green = Convert.ToSingle(ConfigurationManager.AppSettings["C1Green"].ToString());
            C1Blue = Convert.ToSingle(ConfigurationManager.AppSettings["C1Blue"].ToString());
            C1GainDB = Convert.ToSingle(ConfigurationManager.AppSettings["C1GainDB"].ToString());

            C2Red = Convert.ToSingle(ConfigurationManager.AppSettings["C2Red"].ToString());
            C2Green = Convert.ToSingle(ConfigurationManager.AppSettings["C2Green"].ToString());
            C2Blue = Convert.ToSingle(ConfigurationManager.AppSettings["C2Blue"].ToString());
            C2GainDB = Convert.ToSingle(ConfigurationManager.AppSettings["C2GainDB"].ToString());

            C1ExposureMM = Convert.ToInt32(ConfigurationManager.AppSettings["C1ExposureMM"].ToString());
            C1WidthPX = Convert.ToInt32(ConfigurationManager.AppSettings["C1WidthPX"].ToString());
            C1HeightPX = Convert.ToInt32(ConfigurationManager.AppSettings["C1HeightPX"].ToString());
            C1TopPX = Convert.ToInt32(ConfigurationManager.AppSettings["C1TopPX"].ToString());
            C1LeftPX = Convert.ToInt32(ConfigurationManager.AppSettings["C1LeftPX"].ToString());

            C2ExposureMM = Convert.ToInt32(ConfigurationManager.AppSettings["C2ExposureMM"].ToString());
            C2WidthPX = Convert.ToInt32(ConfigurationManager.AppSettings["C2WidthPX"].ToString());
            C2HeightPX = Convert.ToInt32(ConfigurationManager.AppSettings["C2HeightPX"].ToString());
            C2TopPX = Convert.ToInt32(ConfigurationManager.AppSettings["C2TopPX"].ToString());
            C2LeftPX = Convert.ToInt32(ConfigurationManager.AppSettings["C2LeftPX"].ToString());
            
            C1SN = ConfigurationManager.AppSettings["C1SN"].ToString();
            C2SN = ConfigurationManager.AppSettings["C2SN"].ToString();

            txtC1Red.Text = ConfigurationManager.AppSettings["C1Red"].ToString();
            txtC1Green.Text = ConfigurationManager.AppSettings["C1Green"].ToString();
            txtC1Blue.Text = ConfigurationManager.AppSettings["C1Blue"].ToString();
            txtC1Gain.Text = ConfigurationManager.AppSettings["C1GainDB"].ToString();

            txtC2Red.Text = ConfigurationManager.AppSettings["C2Red"].ToString();
            txtC2Green.Text = ConfigurationManager.AppSettings["C2Green"].ToString();
            txtC2Blue.Text = ConfigurationManager.AppSettings["C2Blue"].ToString();
            txtC2Gain.Text = ConfigurationManager.AppSettings["C2GainDB"].ToString();

            txtC1Exposure.Text = ConfigurationManager.AppSettings["C1ExposureMM"].ToString();
            txtC1Width.Text = ConfigurationManager.AppSettings["C1WidthPX"].ToString();
            txtC1Height.Text = ConfigurationManager.AppSettings["C1HeightPX"].ToString();
            txtC1Top.Text = ConfigurationManager.AppSettings["C1TopPX"].ToString();
            txtC1Left.Text = ConfigurationManager.AppSettings["C1LeftPX"].ToString();

            txtC2Exposure.Text = ConfigurationManager.AppSettings["C2ExposureMM"].ToString();
            txtC2Width.Text = ConfigurationManager.AppSettings["C2WidthPX"].ToString();
            txtC2Height.Text = ConfigurationManager.AppSettings["C2HeightPX"].ToString();
            txtC2Top.Text = ConfigurationManager.AppSettings["C2TopPX"].ToString();
            txtC2Left.Text = ConfigurationManager.AppSettings["C2LeftPX"].ToString();

        }
        private void setAppGlobals()
        {
            try
            {
                C1Red = Convert.ToSingle(txtC1Red.Text);
                C1Green = Convert.ToSingle(txtC1Green.Text);
                C1Blue = Convert.ToSingle(txtC1Blue.Text);
                C1GainDB = Convert.ToSingle(txtC1Gain.Text);

                C2Red = Convert.ToSingle(txtC2Red.Text);
                C2Green = Convert.ToSingle(txtC2Green.Text);
                C2Blue = Convert.ToSingle(txtC2Blue.Text);
                C2GainDB = Convert.ToSingle(txtC2Gain.Text);

                C1ExposureMM = Convert.ToInt32(txtC1Exposure.Text);
                C1WidthPX = Convert.ToInt32(txtC1Width.Text);
                C1HeightPX = Convert.ToInt32(txtC1Height.Text);
                C1TopPX = Convert.ToInt32(txtC1Top.Text);
                C1LeftPX = Convert.ToInt32(txtC1Left.Text);

                C2ExposureMM = Convert.ToInt32(txtC2Exposure.Text);
                C2WidthPX = Convert.ToInt32(txtC2Width.Text);
                C2HeightPX = Convert.ToInt32(txtC2Height.Text);
                C2TopPX = Convert.ToInt32(txtC2Top.Text);
                C2LeftPX = Convert.ToInt32(txtC2Left.Text);
            }
            catch (Exception e) { MsgBox(e.Message); }
        }
        private void saveAppGlobals()
        {
            // Open App.Config of executable
            System.Configuration.Configuration config =
              ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["C1Red"].Value = txtC1Red.Text;
            config.AppSettings.Settings["C1Green"].Value = txtC1Green.Text;
            config.AppSettings.Settings["C1Blue"].Value = txtC1Blue.Text;
            config.AppSettings.Settings["C1GainDB"].Value = txtC1Gain.Text;

            config.AppSettings.Settings["C2Red"].Value = txtC2Red.Text;
            config.AppSettings.Settings["C2Green"].Value = txtC2Green.Text;
            config.AppSettings.Settings["C2Blue"].Value = txtC2Blue.Text;
            config.AppSettings.Settings["C2GainDB"].Value = txtC2Gain.Text;

            config.AppSettings.Settings["C1ExposureMM"].Value = txtC1Exposure.Text;
            config.AppSettings.Settings["C1WidthPX"].Value = txtC1Width.Text;
            config.AppSettings.Settings["C1HeightPX"].Value = txtC1Height.Text;
            config.AppSettings.Settings["C1TopPX"].Value = txtC1Top.Text;
            config.AppSettings.Settings["C1LeftPX"].Value = txtC1Left.Text;

            config.AppSettings.Settings["C2ExposureMM"].Value = txtC2Exposure.Text;
            config.AppSettings.Settings["C2WidthPX"].Value = txtC2Width.Text;
            config.AppSettings.Settings["C2HeightPX"].Value = txtC2Height.Text;
            config.AppSettings.Settings["C2TopPX"].Value = txtC2Top.Text;
            config.AppSettings.Settings["C2LeftPX"].Value = txtC2Left.Text;
            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);
        }
        private void setCameraSettings()
        {
            try
            {
                if (C1Open)
                {
                    
                    xiCam1.SetParam(PRM.IMAGE_DATA_FORMAT, IMG_FORMAT.RGB24);
                    xiCam1.SetParam(PRM.EXPOSURE, C1ExposureMM * 1000);
                    xiCam1.SetParam(PRM.GAIN, C1GainDB);
                    xiCam1.SetParam(PRM.WB_KR, C1Red);
                    xiCam1.SetParam(PRM.WB_KG, C1Green);
                    xiCam1.SetParam(PRM.WB_KB, C1Blue);
                    xiCam1.SetParam(PRM.HEIGHT, C1HeightPX);
                    xiCam1.SetParam(PRM.OFFSET_Y, C1TopPX);
                    xiCam1.SetParam(PRM.WIDTH, C1WidthPX);
                    xiCam1.SetParam(PRM.OFFSET_X, C1LeftPX);
                }
                if (C2Open)
                {
                    xiCam2.SetParam(PRM.IMAGE_DATA_FORMAT, IMG_FORMAT.RGB24);
                    xiCam2.SetParam(PRM.EXPOSURE, C2ExposureMM * 1000);
                    xiCam2.SetParam(PRM.GAIN, C2GainDB);
                    xiCam2.SetParam(PRM.WB_KR, C2Red);
                    xiCam2.SetParam(PRM.WB_KG, C2Green);
                    xiCam2.SetParam(PRM.WB_KB, C2Blue);
                    xiCam2.SetParam(PRM.HEIGHT, C2HeightPX);
                    xiCam2.SetParam(PRM.OFFSET_Y, C2TopPX);
                    xiCam2.SetParam(PRM.WIDTH, C2WidthPX);
                    xiCam2.SetParam(PRM.OFFSET_X, C2LeftPX);
                }
            }
            catch (Exception e) { MsgBox(e.Message); }
        }

        private void initCameras()
        {
            MessageBox.Show("initCameras");

            try
            {
                int numDevices = 0;
                string dev1SN = "";

                xiCam1 = new xiCam();
                xiCam2 = new xiCam();
                xiCam1.GetNumberDevices(out numDevices);

                if (numDevices == 0)
                {
                    err = true;
                    MsgBox("No Connected Cameras.");
                }
                else if (numDevices==1)
                {
                    err = true;
                    xiCam1.OpenDevice(0);
                    xiCam1.GetParam(PRM.DEVICE_SN, out dev1SN);
                    if (dev1SN == C1SN)
                    {
                        xiCam1.StartAcquisition();
                        C1Open = true;
                        MsgBox("Crate Contents Camera not Connected.");
                    }
                    else
                    {
                        xiCam1.CloseDevice();
                        xiCam2.OpenDevice(0); 
                        xiCam2.StartAcquisition();
                        C2Open = true;
                        MsgBox("Label Camera not Connected.");
                    }
                    
                }
                else if (numDevices==2)
                {
                    xiCam1.OpenDevice(0);
                    xiCam1.GetParam(PRM.DEVICE_SN, out dev1SN);

                    if (dev1SN == C1SN)
                    {
                        xiCam1.StartAcquisition();
                        C1Open = true;

                        xiCam2.OpenDevice(1); 
                        xiCam2.StartAcquisition();
                        C2Open = true;
                    }
                    else
                    {
                        xiCam1.CloseDevice();
                        xiCam1.OpenDevice(1); 
                        xiCam1.StartAcquisition();
                        C1Open = true;

                        xiCam2.OpenDevice(0); 
                        xiCam2.StartAcquisition();
                        C2Open = true;
                    }
                }
                setCameraSettings();
            }
            catch (Exception ex)
            {
                err = true;
                MsgBox(ex.Message);
            }
        }
        private void openSerialPort()
        {
            try 
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
               
                serialPort1.Open();
                serialPort1.ReadTimeout = 1000;
                serialPort1.WriteTimeout = 500;
            }
            catch (Exception ex) 
            {
                err = true;
                MsgBox(ex.GetType() + ex.Message + ex.StackTrace); 
            }
        }
       
        //barcode scan handlers
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            setInvisibleText(true);
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            lblScanData.Text += e.KeyChar;
            //if (timer1.Enabled)
            //    e.Handled = true;

            //start timer on first keystroke.
            //check for change in text every 100 milliseconds.
            //if change, continue getting changes.
            //else (no change)
            //  stop timer.
            //  if $ in string
            //   if current focus is text input, remove scan string text from input.
            //   if scan like +*+*$ or scan = ADMIN$.
            //    fire automation/go into admin mode.
            //  clear scan string, temp scan string.
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (strScanStringTemp != lblScanData.Text)
                strScanStringTemp = lblScanData.Text;
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                setInvisibleText(false);
                
                if (lblScanData.Text.Split('$').Count() > 1)
                {
                    var focusedTextBox = FindFocusedControl(this) as TextBox;
                    failureMessage = "";
                    emptyScale = false;
                    if (focusedTextBox != null)
                    {
                        focusedTextBox.Text = focusedTextBox.Text.Replace(strScanStringTemp, "");
                    }
                    if (lblScanData.Text.ToUpper() == "ADMIN$")
                    {
                        pnlAdminData.Visible = !pnlAdminData.Visible;
                    }
                    else if (lblScanData.Text.Split('$').Count() == 2 && lblScanData.Text.Split('+').Count() == 3)
                    {
                        disableInputs();
                        clearScreen();
                        //sample scan string: 153822-07+11/26/2007+1$
                        txtOrderID.Text = lblScanData.Text.Split('+')[0];
                        txtShipDate.Text = lblScanData.Text.Split('+')[1];
                        txtCrateNo.Text = lblScanData.Text.Split('+')[2].Split('$')[0];

                        if (validateIDInputs())
                        {
                            if (!identifyCrate())
                            {
                                failureMessage = "Crate not found.";
                            }
                            else
                            {
                                txtWeight.Text = getScaleWeight();
                                if (failureMessage == "")
                                {
                                    if (txtWeight.Text != "")
                                    {
                                        try
                                        {
                                            crateWeight = Convert.ToDecimal(txtWeight.Text);
                                            bool saveOK = saveCrateData();
                                            txtWeight.ForeColor = Color.Black;
                                            if (!saveOK)
                                            {
                                                failureMessage = "Error Saving Crate Data.";
                                            }
                                        }
                                        catch
                                        {
                                            failureMessage = "Invalid weight.";
                                        }
                                    }
                                    else
                                    {
                                        failureMessage = "Invalid weight.";
                                    }
                                }

                                if (!emptyScale)
                                {
                                    if (!getCameraImages())
                                    {
                                        failureMessage = "Error Retrieving Camera Images.";
                                    }
                                    else
                                    {
                                        bool imagesOK = saveCrateImages();
                                        if (!imagesOK)
                                        {
                                            failureMessage = "Error Saving Crate Images.";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        failureMessage = "invalid Scan.";
                    }

                    if (failureMessage == "")
                    {
                        pnlDlgOK.Hide();
                        enableInputs();
                    }
                    else
                    {
                        MsgBox(failureMessage);
                        failureMessage = "";
                    }
                }

                lblScanData.Text = "";
                strScanStringTemp = "";
            }
        }

        private void setInvisibleText(bool invisible)
        {
            Color textColor = new Color();
            textColor = Color.Black;
            if (invisible)
                textColor = Color.WhiteSmoke;
            txtCrateNo.ForeColor = textColor;
            txtOrderID.ForeColor = textColor;
            txtShipDate.ForeColor = textColor;
            txtWeight.ForeColor = textColor;
        }

        private bool validateIDInputs()
        {
            bool retval = true;
            try 
            { 
                shipDate = Convert.ToDateTime(txtShipDate.Text);
            }
            catch 
            { 
                MsgBox("Invalid Ship Date.");
                retval=false;
            }
            try 
            {
                crateNumberScanned = Convert.ToInt32(txtCrateNo.Text);
            }
            catch 
            {  
                MsgBox("Invalid Crate Number.");
                retval=false;
            }
            orderID = txtOrderID.Text;
            if (txtOrderID.Text=="")
            {
                MsgBox("Order ID Missing.");
                retval=false;
            }
            return retval;
        }

        private void btnLoadCrate_Click(object sender, EventArgs e)
        {
            if (!validateIDInputs())
                return;
            if (!getCrateData())
                MsgBox("Crate data not found.");
            if (!getCrateImages())
                MsgBox("Crate images not found.");
        }
        private void btnGetImage_Click(object sender, EventArgs e)
        {
            if (!getCameraImages())
            {
               // MsgBox("Error Retrieving Camera Images.");
            }
        }
        private void btnGetWeight_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "Retrieving...";
            Application.DoEvents();
            txtWeight.Text = getScaleWeight();
            txtWeight.ForeColor = Color.Blue;
        }
        private void btnUpdateCrate_Click(object sender, EventArgs e)
        {
            if (!validateIDInputs())
                return;
            try { 
                crateWeight = Convert.ToDecimal(txtWeight.Text);
                if (!identifyCrate())
                    MsgBox("Crate not found.");
                else
                {
                    if (!saveCrateImages())
                    {
                        MsgBox("Error Saving Crate Images.");
                    }
                    saveCrateData();
                    txtWeight.ForeColor = Color.Black;
                }
            }
            catch
            {
                MsgBox("Invalid weight.");
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            questionBox("Print operator labels?");
        }

        //UI
        private void arrangeUI()
        {
            //this.TopMost = true;//DONT USE.  HIDES TASK MANAGER...
            this.FormBorderStyle = FormBorderStyle.None;

            this.Bounds = Screen.AllScreens[0].Bounds;
            this.WindowState = FormWindowState.Maximized;

            pnlDlgOK.Left = this.Width / 2 - (pnlDlgOK.Width / 2);
            pnlDlgOK.Top = this.Height / 2 - (pnlDlgOK.Height / 2);
            pnlDlgYesNo.Left = this.Width / 2 - (pnlDlgYesNo.Width / 2);
            pnlDlgYesNo.Top = this.Height / 2 - (pnlDlgYesNo.Height / 2);
            pnlDlgOK.Visible = false;
            pnlDlgYesNo.Visible = false;

            pictureBox1.Left = 20 + flpIDInputs.Width; 
            pictureBox1.Top = 10;
            pictureBox1.Width = 838;// this.Width - (2 * (25 + flpIDInputs.Width));
            pictureBox1.Height = this.Height - (380 + 30);

            pictureBox2.Left = 10;
            pictureBox2.Width = this.Width - 20;

            pictureBox2.Top = this.Height - 390;
            pictureBox2.Height = 380;

            pictureBox3.Width = 610;
            pictureBox3.Height = 610;
            pictureBox3.Left = 25 + flpIDInputs.Width + pictureBox1.Width;
            pictureBox3.Top = 70;
            newWidth = pictureBox3.Width;
            newHeight = pictureBox3.Height;
            destImage = new Bitmap(newWidth, newHeight);
            System.Reflection.PropertyInfo aProp =
         typeof(System.Windows.Forms.Control).GetProperty(
               "DoubleBuffered",
               System.Reflection.BindingFlags.NonPublic |
               System.Reflection.BindingFlags.Instance);

            aProp.SetValue(pictureBox3, true, null); 
        }
        private void clearScreen()
        {
            clearLabels();
            clearImages();
        }
        private void clearLabels()
        {
            txtOrderID.Text = "";
            txtShipDate.Text = "";
            txtCrateNo.Text = "";
            txtWeight.Text = "";
        }
        private void clearImages()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }
        private void enableInputs()
        {
            txtOrderID.Enabled = true;
            txtShipDate.Enabled = true;
            txtCrateNo.Enabled = true;
            txtWeight.Enabled = true;

            btnGetWeight.Enabled = true;
            btnUpdateCrate.Enabled = true;
            btnLoadCrate.Enabled = true;
            btnGetImage.Enabled = true; 
            btnPrint.Enabled = true;

            btnShutDown.Enabled = true;
            btnExit.Enabled = true;
            btnRestart.Enabled = true;

            btnSaveSettings.Enabled = true;
            btnZoomView.Enabled = true;
            btnCameraSettings.Enabled = true;
            btnZoomView.Focus();
                        
        }
        private void disableInputs()
        {
            txtOrderID.Enabled = false;
            txtShipDate.Enabled = false;
            txtCrateNo.Enabled = false;
            txtWeight.Enabled = false;

            btnGetWeight.Enabled = false;
            btnUpdateCrate.Enabled = false;
            btnLoadCrate.Enabled = false;
            btnGetImage.Enabled = false;
            btnPrint.Enabled = false;

            btnShutDown.Enabled = false;
            btnExit.Enabled = false;
            btnRestart.Enabled = false;

            btnSaveSettings.Enabled = false;
            btnZoomView.Enabled = false;
            btnCameraSettings.Enabled = false;
        }
        private void pnlDialog_Paint(object sender, PaintEventArgs e)
        {
            Panel pnlDialog = sender as Panel;
            if (pnlDialog.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 4;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.LightGray, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlDialog.ClientSize.Width - thickness,
                                                              pnlDialog.ClientSize.Height - thickness));
                }
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { 
            PictureBox pb = sender as PictureBox;
            Color penColor = Color.Black;
            if (pb.BorderStyle == BorderStyle.FixedSingle)
                penColor = Color.Blue;
            int thickness = 2;//it's up to you
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(penColor, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                            halfThickness,
                                                            pb.ClientSize.Width - thickness,
                                                            pb.ClientSize.Height - thickness));
            }
        }
        
        //exit/shut down/restart, message box
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            questionBox("Exit?");
        }
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            questionBox("Shut Down?");
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            questionBox("Restart?");
        }

        private void questionBox(string question)
        {
            focused = this.ActiveControl; 
            disableInputs();
            lblYesNoText.Text = question;
            pnlDlgYesNo.Show();
            btnNo.Focus();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (lblYesNoText.Text == "Exit?")
                Application.Exit();
            else if (lblYesNoText.Text == "Shut Down?")
                Shutdown(false);
            else if (lblYesNoText.Text == "Restart?")
                Shutdown(true);
            else if (lblYesNoText.Text == "Reprint operator labels?" || lblYesNoText.Text == "Print operator labels?")
                printOperatorLabels();
            pnlDlgYesNo.Hide();
            this.ActiveControl = focused;
            enableInputs();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlDlgYesNo.Hide();
            enableInputs();
            this.ActiveControl = focused;
        }

        private void MsgBox(string Message)
        {
            failureMessage = Message;
            focused = this.ActiveControl;
            disableInputs();
            lblOKText.Text = Message;
            pnlDlgOK.Show();
            btnOK.Focus();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlDlgOK.Hide();
            enableInputs();
            this.ActiveControl = focused;
        }
        
        private bool getCameraImages()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null; 
            pictureBox3.Image = null;
            int timeout = 10000;
      
            try
            {
                if (C1Open)
                {
                    Bitmap safeImage1 = new Bitmap(C1WidthPX, C1HeightPX, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    xiCam1.SetParam(PRM.BUFFER_POLICY, BUFF_POLICY.SAFE);
                    xiCam1.GetImage(safeImage1, timeout);
                    pictureBox1.Image = safeImage1;

                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("safeImage1 == null");
                    }
       
                }
                else
                {
                    MessageBox.Show("C1 is not open");
                }

                if (C2Open)
                {
                    Bitmap safeImage2 = new Bitmap(C2WidthPX, C2HeightPX, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    xiCam2.SetParam(PRM.BUFFER_POLICY, BUFF_POLICY.SAFE);
                    xiCam2.GetImage(safeImage2, timeout);
                    pictureBox2.Image = safeImage2;
                }
                else
                {
                    MessageBox.Show("C2 is not open");
                }
            }
            catch (Exception ex)
            {
                MsgBox(ex.Message);
                return false;
            }
            return true;
        }

        private bool saveCrateImages()
        {
            try {
                string folderName = crateImagesFolder + orderID + "_" + shipDate.ToShortDateString().Replace("/", "-");

                if (!Directory.Exists(folderName))
                    Directory.CreateDirectory(folderName);

                string crateID = orderID + "_" + shipDate.ToShortDateString().Replace("/", "-") + "_" + crateNumberScanned; 

                string fName = folderName + "\\" + crateID + "_1";

                //MessageBox.Show($"Going to save to {fName}");

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("pictureBox1.Image is null");
                }

                pictureBox1.Image.Save(fName + ".bmp");

                convertToJpg(fName);

                fName = folderName + "\\" + crateID + "_2";

                pictureBox2.Image.Save(fName + ".bmp");

                convertToJpg(fName); 
            }
            catch { return false; }
            return true;
        }

        private void convertToJpg(string fullPath)
        {
            Image img = Image.FromFile(fullPath +".bmp");
            img.Save(fullPath+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            img.Dispose();
            System.IO.File.Delete(fullPath + ".bmp");
        }
        private bool getCrateImages()
        {
            string subFolderName = orderID + "_" + shipDate.ToShortDateString().Replace("/", "-");
            string crateID = orderID + "_" + shipDate.ToShortDateString().Replace("/", "-") + "_" + crateNumberScanned;
            pictureBox1.ImageLocation = crateImagesFolder + subFolderName + "\\" + crateID + "_1" + ".jpg";
            pictureBox2.ImageLocation = crateImagesFolder + subFolderName + "\\" + crateID + "_2" + ".jpg";
            pictureBox3.Image = null;
            return true;
        }
        
        //Scale Serial Port functions
        private string getScaleWeight()
        {
            string strInput = "";
            int scaleWeight = 0;
            try
            {
                serialPort1.Write(scaleSendCode);
                System.Threading.Thread.Sleep(300);
                strInput = Read();
                strInput = strInput.ToUpper().Replace("G", " ");
            }
            catch (Exception e)
            {
                MsgBox("Could not read scale weight\r\n" + e.Message);
                return "";
            }
            if (strInput == "")
            {
                MsgBox("Scale is in motion\r\nScan again.");
                return "";
            }
            //scale 1,3
            if (strInput.Length > 1)
                strInput = strInput.Substring(2).Split('L')[0].Trim();
            //scale 2, *not tested,not used.
            //if (strInput.Length>11)
            //    strInput = val(strInput.Substring(strInput.Length-11));
            try
            {
                scaleWeight = Convert.ToInt32(Math.Round(Convert.ToDecimal(strInput)));
                if (scaleWeight < 10)
                    emptyScale = true;

                scaleWeight = Convert.ToInt32(Math.Round(Convert.ToDecimal(scaleWeight+coverWeight) / 5) * 5);
                coverWeight = 0;
                //if (crateType == "D") not used.
                strInput = scaleWeight.ToString();
            }
            catch (Exception e)
            {
                MsgBox("Could not read scale weight\r\n" + e.Message);
                return "";
            }
            return strInput;
        }
        public String Read()
        {
            string readVal = "", retVal = "";
            try
            {
                do
                {
                    readVal = serialPort1.ReadExisting();
                    retVal += readVal;
                } while (readVal != "");
            }
            catch (Exception e) { retVal = e.Message; }
            return retVal;
        }

        //external process functions
        void Shutdown(bool restart)
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system. Use "2" to reboot.
            if (restart)
                mboShutdownParams["Flags"] = "2";
            else
                mboShutdownParams["Flags"] = "1";

            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }
        private void printOperatorLabels()
        {
            if (!enableOperatorLabels)
                return;
            MsgBox("Printing Door Operator Labels");
            pnlDlgYesNo.Hide();
            Application.DoEvents();
            Process p = new Process();
            p.StartInfo.FileName = DOPLabelsFilePath;
            p.StartInfo.Arguments = "O:"+orderID+":"+ shipDate.ToShortDateString();
            bool started = p.Start();
            if (!started)
            {
                MsgBox("Error Launching Operator Label Printing Program.");
            }
            p.WaitForExit();
            pnlDlgOK.Hide();
            enableInputs();
        }

        //helper functions
        private string val(string numberString)
        {
            string values = "";
            foreach (char value in numberString)
            {
                if (value >= '0' && value <= '9')
                    values += value;
            }
            return values;
        }
        public static Control FindFocusedControl(Control control)
        {
            var container = control as ContainerControl;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as ContainerControl;
            }
            return control;
        }
        
        //Database functions
        private bool identifyCrate()
        {
            bool found = false;
            crateNumberBase = crateNumberScanned;
            OracleConnection con = new OracleConnection(strCustConn);
            OracleCommand cmd;
            crateType = "";
            con.Open();
            //get type
            String sqlString = "select type,total_weight,dimensions from gal_crate where cust_order_id = :orderID and "
                + "trunc(ship_Date,'DD') = trunc(:shipDate,'DD') and crate_number = :crateNo";
            cmd = new OracleCommand(sqlString, con);
            cmd.Parameters.Add(":orderID", orderID);
            cmd.Parameters.Add(":shipDate", shipDate);
            cmd.Parameters.Add(":crateNo", crateNumberBase);
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    found = true;
                    while (reader.Read())
                    {
                        crateType = reader["type"].ToString();
                        dimensions = reader["dimensions"].ToString();
                        coverWeight = getCoverWeight(dimensions);
                    }
                }
                else  //handle operator multiCrates...
                {
                    //check for valid operator base number;
                    sqlString = "SELECT CRATE_NUMBER,QTY_PACKED,(CRATE_NUMBER+QTY_PACKED-1) MAX_CRATE_NUMBER FROM GAL_CRATE_LINE WHERE CRATE_NUMBER = ( "
                        + "SELECT MAX(GC.crate_number) "
                        + "FROM GAL_CRATE GC INNER JOIN GAL_CRATE_LINE GCL ON  "
                        + "GC.CRATE_NUMBER = GCL.CRATE_NUMBER AND  "
                        + "gc.ship_date = gcl.ship_date AND "
                        + "gc.cust_order_id = gcl.cust_order_id  "
                        + "WHERE GC.cust_order_id = :orderID "
                        + "AND trunc(gc.ship_Date,'DD') = trunc(:shipDate,'DD') "
                        + "AND GC.crate_number    < :crateNo "
                        + "and GC.type = 'O') AND cust_order_id = :orderID "
                        + "AND trunc(ship_Date,'DD') = trunc(:shipDate,'DD') ";
                    cmd = new OracleCommand(sqlString, con);
                    cmd.Parameters.Add(":orderID", orderID);
                    cmd.Parameters.Add(":shipDate", shipDate);
                    cmd.Parameters.Add(":crateNo", crateNumberScanned);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dtOLines = new DataTable();
                    adapter.Fill(dtOLines);
                    adapter.Dispose();
                    if (dtOLines.Rows.Count == 1)
                    {
                        if (Convert.ToDecimal(dtOLines.Rows[0]["MAX_CRATE_NUMBER"].ToString()) >= Convert.ToDecimal(txtCrateNo.Text))
                        {
                            found = true;
                            crateNumberBase = Convert.ToInt32(dtOLines.Rows[0]["CRATE_NUMBER"].ToString());
                            crateType = "O";
                            coverWeight = 0;
                        }
                    }
                }
            }
            return found;
        }

        private bool getCrateData() {
            bool found=false;
            crateNumberBase = crateNumberScanned;
            OracleConnection con = new OracleConnection(strCustConn);
            OracleCommand cmd;
            crateType = "";
            con.Open();
            //get type
            String sqlString = "select type,total_weight from gal_crate where cust_order_id = :orderID and "
                + "trunc(ship_Date,'DD') = trunc(:shipDate,'DD') and crate_number = :crateNo";
            cmd = new OracleCommand(sqlString, con);
            cmd.Parameters.Add(":orderID", orderID);
            cmd.Parameters.Add(":shipDate", shipDate);
            cmd.Parameters.Add(":crateNo", crateNumberBase);
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    found = true;
                    while (reader.Read())
                    {
                        crateType = reader["type"].ToString();
                        crateWeight = Convert.ToDecimal(reader["total_weight"].ToString());
                    }
                }
                else  //handle operator multiCrates...
                {
                    //check for valid operator base number;
                    sqlString = "SELECT CRATE_NUMBER,QTY_PACKED,(CRATE_NUMBER+QTY_PACKED-1) MAX_CRATE_NUMBER FROM GAL_CRATE_LINE WHERE CRATE_NUMBER = ( "
                        + "SELECT MAX(GC.crate_number) "
                        + "FROM GAL_CRATE GC INNER JOIN GAL_CRATE_LINE GCL ON  "
                        + "GC.CRATE_NUMBER = GCL.CRATE_NUMBER AND  "
                        + "gc.ship_date = gcl.ship_date AND "
                        + "gc.cust_order_id = gcl.cust_order_id  "
                        + "WHERE GC.cust_order_id = :orderID "
                        + "AND trunc(gc.ship_Date,'DD') = trunc(:shipDate,'DD') "
                        + "AND GC.crate_number    < :crateNo "
                        + "and GC.type = 'O') AND cust_order_id = :orderID "
                        + "AND trunc(ship_Date,'DD') = trunc(:shipDate,'DD') ";
                    cmd = new OracleCommand(sqlString, con);
                    cmd.Parameters.Add(":orderID", orderID);
                    cmd.Parameters.Add(":shipDate", shipDate);
                    cmd.Parameters.Add(":crateNo", crateNumberScanned);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dtOLines = new DataTable();
                    adapter.Fill(dtOLines);
                    adapter.Dispose();
                    if (dtOLines.Rows.Count == 1)
                    {
                        if (Convert.ToDecimal(dtOLines.Rows[0]["MAX_CRATE_NUMBER"].ToString()) >= Convert.ToDecimal(txtCrateNo.Text))
                        {
                            found = true;
                            crateNumberBase = Convert.ToInt32(dtOLines.Rows[0]["CRATE_NUMBER"].ToString());
                            crateType = "O";
                        
                            sqlString = "select total_weight from gal_crate where cust_order_id = :orderID and "
                                + "trunc(ship_Date,'DD') = trunc(:shipDate,'DD') and crate_number = :crateNo";
                            cmd = new OracleCommand(sqlString, con);
                            cmd.Parameters.Add(":orderID", orderID);
                            cmd.Parameters.Add(":shipDate", shipDate);
                            cmd.Parameters.Add(":crateNo", crateNumberBase);
                            using (OracleDataReader reader2 = cmd.ExecuteReader())
                            {
                                if (reader2.HasRows)
                                {
                                    while (reader2.Read())
                                    {
                                        crateWeight = Convert.ToDecimal(reader2["total_weight"].ToString());
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            if (found)
            {
                txtWeight.Text = crateWeight.ToString();
                txtWeight.ForeColor = Color.Black;
            }
            if (pnlAdminData.Visible)
            {
                //crate data
                sqlString = "select cust_order_line_no,part_id,qty_packed,weight,comments,type,description from gal_crate_line where cust_order_id = :orderID "
                    + " and trunc(ship_Date,'DD') = trunc(:shipDate,'DD')"
                    + " and crate_number = :crateNo order by type,cust_order_line_no";

                cmd = new OracleCommand(sqlString, con);
                cmd.Parameters.Add(":orderID", orderID);
                cmd.Parameters.Add(":shipDate", shipDate);
                cmd.Parameters.Add(":crateNo", crateNumberBase);
                cmd.ExecuteNonQuery();

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dsCrateContents = new DataTable();
                adapter.Fill(dsCrateContents);
                dataGridView1.DataSource = dsCrateContents;
                adapter.Dispose();
            }
            con.Dispose();
            return found;
        }
        private bool saveCrateData()
        {
            bool retval = true, alreadyScanned = false, completed = false, hasOperators = false;
            string sqlString = "";
            OracleConnection con = null;
            OracleCommand cmd;
            try
            {
                con = new OracleConnection(strCustConn);
                con.Open();
                //set Weight
                sqlString = "UPDATE GAL_CRATE SET TOTAL_WEIGHT = :weight where cust_order_id = :orderID and "
                    + "trunc(ship_Date,'DD') = trunc(:shipDate,'DD') and crate_number = :crateNo";
                cmd = new OracleCommand(sqlString, con);
                cmd.Parameters.Add(":weight", crateWeight);
                cmd.Parameters.Add(":orderID", orderID);
                cmd.Parameters.Add(":shipDate", shipDate);
                cmd.Parameters.Add(":crateNo", crateNumberBase);
                cmd.ExecuteNonQuery();

                //---------set completed status-------------

                //check if already scanned
                sqlString = "select scanned_date from gal_crate_completed where cust_order_id = :orderID and "
                    + "trunc(ship_Date,'DD') = trunc(:shipDate,'DD') and crate_number_scanned = :crateNo";
                cmd = new OracleCommand(sqlString, con);
                cmd.Parameters.Add(":orderID", orderID);
                cmd.Parameters.Add(":shipDate", shipDate);
                cmd.Parameters.Add(":crateNo", crateNumberScanned);
                object scDate = cmd.ExecuteScalar();
                if (scDate != null)
                    alreadyScanned = true;

                if (!alreadyScanned)//insert completed date record
                {
                    sqlString = "insert into gal_crate_completed "
                            + "(cust_order_id,ship_date,crate_number_base,crate_number_scanned,scanned_date,type) "
                            + "Values (:orderID,trunc(:shipDate,'DD'),:crateNoBase,:crateNoScanned,sysdate,:crateType)";
                    cmd = new OracleCommand(sqlString, con);
                    cmd.Parameters.Add(":crateNoBase", crateNumberBase);
                    cmd.Parameters.Add(":crateType", crateType);
                }
                else //update completed date
                {
                    sqlString = "update gal_crate_completed set scanned_date = sysdate where cust_order_id = :orderID and "
                    + "trunc(ship_Date,'DD') = trunc(:shipDate,'DD') and crate_number_scanned = :crateNoScanned";
                    cmd = new OracleCommand(sqlString, con);
                }
                cmd.Parameters.Add(":orderID", orderID);
                cmd.Parameters.Add(":shipDate", shipDate);
                cmd.Parameters.Add(":crateNoScanned", crateNumberScanned);
                cmd.ExecuteNonQuery();

                //check if all crates or operators are completed.
                //query works with operator crates (uses qty if 1 line in O type crate)
                sqlString = "select sum(qtyleft) from (SELECT decode(gc.type,'D',COUNT(crate_number),"
                    + "(select decode(count(qty_packed),1,sum(qty_PACKED),1) from gal_crate_line gcl "
                    + "Where "
                    + "gcl.cust_order_id = gc.cust_order_id and "
                    + "gcl.crate_number = gc.crate_number "
                    + "Group By "
                    + "gcl.crate_number , gc.cust_order_id "
                    + ")) - COUNT(crate_number_scanned) qtyLeft, "
                    + "count(crate_number), "
                    + "Count (crate_number_scanned) "
                    + "FROM gal_crate_completed gcc, "
                    + "  gal_crate gc "
                    + "WHERE gc.cust_order_id = gcc.cust_order_id(+) "
                    + "AND gc.ship_date       = gcc.ship_date(+) "
                    + "AND gc.crate_number    = gcc.crate_number_base(+) "
                    + "AND gc.type            = gcc.type(+) "
                    + "AND gc.cust_order_id   = :orderID "
                    + "AND gc.type            = :crateType "
                    + "AND trunc(gc.ship_date,'DD') = trunc(:shipDate,'DD') "
                    + "group by gc.type,gc.cust_order_id,gc.crate_number)";
                cmd = new OracleCommand(sqlString, con);
                cmd.Parameters.Add(":orderID", orderID);
                cmd.Parameters.Add(":shipDate", shipDate);
                cmd.Parameters.Add(":crateType", crateType);
                object qtyRemaining = cmd.ExecuteScalar();
                string status = "P";
                if (qtyRemaining != null)
                    if (Convert.ToDecimal(qtyRemaining) == 0)
                    {
                        completed = true;
                        status = "C";
                    }

                if (!alreadyScanned)
                {   //update crates / operators status.
                    if (crateType == "D")//crates
                        sqlString = "update gal_crate set crated = :status where cust_order_id = :orderID "
                            + " and trunc(ship_Date,'DD') = trunc(:shipDate,'DD')";
                    else//operators
                        sqlString = "update gal_crate set printed_ind = :status where cust_order_id = :orderID "
                            + " and trunc(ship_Date,'DD') = trunc(:shipDate,'DD')";
                    cmd = new OracleCommand(sqlString, con);
                    cmd.Parameters.Add(":orderID", orderID);
                    cmd.Parameters.Add(":shipDate", shipDate);
                    cmd.Parameters.Add(":status", status);
                    cmd.ExecuteNonQuery();
                }

                if (completed && !alreadyScanned)
                { //update crates / operators status.
                    OracleConnection con2 = new OracleConnection(strErpConn);
                    con2.Open();
                    //insert all completed note
                    string crateTypeText = "Operators";
                    if (crateType == "D")
                        crateTypeText = "Crates";
                    string note = crateTypeText + " status changed to COMPLETED for ship date: " + shipDate.ToString("d");

                    sqlString = "INSERT into NOTATION( type, owner_id, create_date, NOTE) "
                                + "values ('CO',:orderID,SYSDATE,:note)";
                    cmd = new OracleCommand(sqlString, con2);
                    cmd.Parameters.Add(":orderID", orderID);
                    cmd.Parameters.Add(":note", System.Text.Encoding.UTF8.GetBytes(note));


                    cmd.ExecuteNonQuery();
                    con2.Dispose();
                }

                if (completed && crateType == "D")
                {
                    sqlString = "select nvl(COUNT(*),0) operatorCount "
                    + "FROM gal_crate gc "
                    + "WHERE gc.cust_order_id   = :orderID "
                    + "AND gc.type            = 'O' "
                    + "AND trunc(gc.ship_date,'DD') = trunc(:shipDate,'DD') ";
                    cmd = new OracleCommand(sqlString, con);
                    cmd.Parameters.Add(":orderID", orderID);
                    cmd.Parameters.Add(":shipDate", shipDate);
                    object operatorCount = cmd.ExecuteScalar();
                    if (operatorCount != null)
                        if (Convert.ToInt32(operatorCount) > 0)
                            hasOperators = true;
                }
            }
            catch (Exception e){ 
                retval = false;
                logError(e, "SqlString: " + sqlString);
            }
            if (crateType == "D" && completed && hasOperators && enableOperatorLabels)
            {
                if (alreadyScanned)
                    questionBox("Reprint Operator labels?");
                else
                {
                    printOperatorLabels();
                }
            }
            con.Dispose();
            return retval;
        }

        private void logError(Exception e, string miscInfo)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("OrderID: " + orderID + "\r\n");
            builder.Append("ShipDate: " + shipDate + "\r\n");
            builder.Append("cratenumberbase: " + crateNumberBase + "\r\n");
            builder.Append("cratenumberscanned: " + crateNumberScanned + "\r\n");
            builder.Append("crateweight: " + crateWeight + "\r\n");
            builder.Append("cratetype: " + crateType + "\r\n\r\n");
            builder.Append("other info:\r\n" + miscInfo + "\r\n\r\n");
            builder.Append("error:\r\n" + e.Message + "\r\n");
            while (e.InnerException != null)
            {
                e = e.InnerException;
                if (e.Message != null)
                    builder.Append("inner Exception:\r\n" + e.Message+"\r\n");
                if (e.StackTrace != null)
                    builder.Append("stack trace:\r\n" + e.StackTrace+"\r\n");
            }
            System.IO.File.WriteAllText(DateTime.Now.Year.ToString() + "-"
                + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Day.ToString() + " "
                + DateTime.Now.Hour.ToString() + "-"
                + DateTime.Now.Minute.ToString() + "-"
                + DateTime.Now.Second.ToString() + " "
                + "error.log", builder.ToString());
        }

        private decimal getCoverWeight(string dimensions)
        {
            decimal cw = 0;
            switch (dimensions)
            {
                case ("96\" x 15\" x 8\""):
                    cw = 16;
                    break;
                case ("96\" x 17\" x 8\""):
                    cw = 18;
                    break;
                case ("96\" x 19\" x 8\""):
                    cw = 20;
                    break;
                case ("96\" x 21\" x 8\""):
                    cw = 22;
                    break;
                case ("96\" x 10\" x 8\""):
                    cw = 10;
                    break;
                case ("98\" x 15\" x 8\""):
                    cw = 16;
                    break;
                case ("98\" x 17\" x 8\""):
                    cw = 18;
                    break;
                case ("98\" x 19\" x 8\""):
                    cw = 20;
                    break;
                case ("116\" x 15\" x 8\""):
                    cw = 19;
                    break;
                case ("116\" x 17\" x 8\""):
                    cw = 21;
                    break;
                case ("116\" x 19\" x 8\""):
                    cw = 24;
                    break;
                case ("116\" x 21\" x 8\""):
                    cw = 27;
                    break;
            }
            if (cw == 0) //try custom dims calculator
            {
                try
                {
                    decimal length = Convert.ToDecimal(dimensions.Split('"')[0]);
                    decimal width = Convert.ToDecimal(dimensions.Split(' ')[2].Split('"')[0]);
                    cw = Math.Ceiling(length * width / 92);
                }
                catch { }
            }
            return cw;
        }
        
        //on exit
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
            if (C1Open)
                xiCam1.CloseDevice();
            if (C2Open)
                xiCam2.CloseDevice();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            arrangeUI();
        }

        private void btnCameraSettings_Click(object sender, EventArgs e)
        {
            flpSettings.Visible = true;
            pictureBox3.Visible = false;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            setAppGlobals();
            saveAppGlobals();
            setCameraSettings();
        }

        private void btnZoomView_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            flpSettings.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
       
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null && mouseDown)
            {
                sourceImage = pictureBox1.Image;
                int x = ( e.X * pictureBox1.Image.Width )/ pictureBox1.Width;
                int y = ( e.Y * pictureBox1.Image.Height )/ pictureBox1.Height;
                centerX = x < zoom ? zoom : x > pictureBox1.Image.Width - zoom ? pictureBox1.Image.Width - zoom : x;
                centerY = y < zoom ? zoom : y > pictureBox1.Image.Height - zoom ? pictureBox1.Image.Height - zoom : y;
                pictureBox3.Image = zoomImage();
                Application.DoEvents();
            }
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Image != null && mouseDown)
            {
                sourceImage = pictureBox2.Image;
                int x = (e.X * pictureBox2.Image.Width) / pictureBox2.Width;
                int y = (e.Y * pictureBox2.Image.Height) / pictureBox2.Height;
                centerX = x < zoom ? zoom : x > pictureBox2.Image.Width - zoom ? pictureBox2.Image.Width - zoom : x;
                centerY = y < zoom ? zoom : y > pictureBox2.Image.Height - zoom ? pictureBox2.Image.Height - zoom : y;
                pictureBox3.Image = zoomImage();
                Application.DoEvents();
            }
        }
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && sourceImage != null)
            {
                zoom = (e.Y>600?600:e.Y<0?0:e.Y)/10 + 50;
                pictureBox3.Image = zoomImage();
                Application.DoEvents();
            }
        }
        public static Bitmap zoomImage()
        {
            
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(centerX - zoom, centerY - zoom, zoom*2, zoom*2), GraphicsUnit.Pixel);
            }

            return destImage;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}