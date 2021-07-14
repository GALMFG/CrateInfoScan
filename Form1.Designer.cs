namespace CrateInfoScan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnGetWeight = new System.Windows.Forms.Button();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlAdminData = new System.Windows.Forms.FlowLayoutPanel();
            this.lblScanData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateCrate = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.flpIDInputs = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShipDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCrateNo = new System.Windows.Forms.TextBox();
            this.btnLoadCrate = new System.Windows.Forms.Button();
            this.pnlDlgYesNo = new System.Windows.Forms.Panel();
            this.lblYesNoText = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.pnlDlgOK = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblOKText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC1Red = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC1Green = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtC1Blue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtC1Exposure = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtC1Gain = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtC1Height = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtC1Width = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtC1Top = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtC1Left = new System.Windows.Forms.TextBox();
            this.btnCameraSettings = new System.Windows.Forms.Button();
            this.btnZoomView = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtC2Red = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtC2Green = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtC2Blue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtC2Exposure = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtC2Gain = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtC2Height = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtC2Width = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtC2Top = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtC2Left = new System.Windows.Forms.TextBox();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTest = new System.Windows.Forms.Label();
            this.pnlAdminData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flpIDInputs.SuspendLayout();
            this.pnlDlgYesNo.SuspendLayout();
            this.pnlDlgOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
            // 
            // btnGetWeight
            // 
            this.btnGetWeight.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.btnGetWeight.Location = new System.Drawing.Point(254, 210);
            this.btnGetWeight.Name = "btnGetWeight";
            this.btnGetWeight.Size = new System.Drawing.Size(194, 114);
            this.btnGetWeight.TabIndex = 1;
            this.btnGetWeight.Text = "Get Scale Weight";
            this.btnGetWeight.UseVisualStyleBackColor = false;
            this.btnGetWeight.Click += new System.EventHandler(this.btnGetWeight_Click);
            // 
            // btnGetImage
            // 
            this.btnGetImage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.btnGetImage.Location = new System.Drawing.Point(10, 329);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(238, 115);
            this.btnGetImage.TabIndex = 9;
            this.btnGetImage.Text = "Get Camera Images";
            this.btnGetImage.UseVisualStyleBackColor = false;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(10, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(238, 103);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlAdminData
            // 
            this.pnlAdminData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdminData.BackColor = System.Drawing.Color.LightGray;
            this.pnlAdminData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdminData.Controls.Add(this.lblScanData);
            this.pnlAdminData.Controls.Add(this.label6);
            this.pnlAdminData.Controls.Add(this.dataGridView1);
            this.pnlAdminData.Location = new System.Drawing.Point(10, 450);
            this.pnlAdminData.Name = "pnlAdminData";
            this.pnlAdminData.Size = new System.Drawing.Size(438, 231);
            this.pnlAdminData.TabIndex = 4;
            this.pnlAdminData.Visible = false;
            // 
            // lblScanData
            // 
            this.lblScanData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanData.ForeColor = System.Drawing.Color.White;
            this.lblScanData.Location = new System.Drawing.Point(3, 0);
            this.lblScanData.Name = "lblScanData";
            this.lblScanData.Size = new System.Drawing.Size(420, 26);
            this.lblScanData.TabIndex = 18;
            this.lblScanData.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Crate Contents";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShutDown.Location = new System.Drawing.Point(10, 621);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(238, 60);
            this.btnShutDown.TabIndex = 11;
            this.btnShutDown.Text = "Shut Down";
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(454, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnUpdateCrate
            // 
            this.btnUpdateCrate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnUpdateCrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.btnUpdateCrate.Location = new System.Drawing.Point(254, 330);
            this.btnUpdateCrate.Name = "btnUpdateCrate";
            this.btnUpdateCrate.Size = new System.Drawing.Size(194, 114);
            this.btnUpdateCrate.TabIndex = 8;
            this.btnUpdateCrate.Text = "Set Crate Data";
            this.btnUpdateCrate.UseVisualStyleBackColor = false;
            this.btnUpdateCrate.Click += new System.EventHandler(this.btnUpdateCrate_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtWeight);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 157);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(438, 48);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Blue;
            this.txtWeight.Location = new System.Drawing.Point(181, 3);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(235, 40);
            this.txtWeight.TabIndex = 2;
            // 
            // flpIDInputs
            // 
            this.flpIDInputs.BackColor = System.Drawing.Color.LightGray;
            this.flpIDInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpIDInputs.Controls.Add(this.label3);
            this.flpIDInputs.Controls.Add(this.txtOrderID);
            this.flpIDInputs.Controls.Add(this.label5);
            this.flpIDInputs.Controls.Add(this.txtShipDate);
            this.flpIDInputs.Controls.Add(this.label7);
            this.flpIDInputs.Controls.Add(this.txtCrateNo);
            this.flpIDInputs.Location = new System.Drawing.Point(10, 7);
            this.flpIDInputs.Name = "flpIDInputs";
            this.flpIDInputs.Size = new System.Drawing.Size(438, 145);
            this.flpIDInputs.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(181, 3);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(235, 40);
            this.txtOrderID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ship Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtShipDate
            // 
            this.txtShipDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtShipDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipDate.Location = new System.Drawing.Point(181, 49);
            this.txtShipDate.Name = "txtShipDate";
            this.txtShipDate.Size = new System.Drawing.Size(235, 40);
            this.txtShipDate.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 41);
            this.label7.TabIndex = 8;
            this.label7.Text = "Crate #:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCrateNo
            // 
            this.txtCrateNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCrateNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrateNo.Location = new System.Drawing.Point(181, 95);
            this.txtCrateNo.Name = "txtCrateNo";
            this.txtCrateNo.Size = new System.Drawing.Size(235, 40);
            this.txtCrateNo.TabIndex = 5;
            // 
            // btnLoadCrate
            // 
            this.btnLoadCrate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadCrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.btnLoadCrate.Location = new System.Drawing.Point(10, 210);
            this.btnLoadCrate.Name = "btnLoadCrate";
            this.btnLoadCrate.Size = new System.Drawing.Size(238, 114);
            this.btnLoadCrate.TabIndex = 6;
            this.btnLoadCrate.Text = "Get Crate Data";
            this.btnLoadCrate.UseVisualStyleBackColor = false;
            this.btnLoadCrate.Click += new System.EventHandler(this.btnLoadCrate_Click);
            // 
            // pnlDlgYesNo
            // 
            this.pnlDlgYesNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDlgYesNo.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDlgYesNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDlgYesNo.Controls.Add(this.lblYesNoText);
            this.pnlDlgYesNo.Controls.Add(this.btnYes);
            this.pnlDlgYesNo.Controls.Add(this.btnNo);
            this.pnlDlgYesNo.Location = new System.Drawing.Point(12, 691);
            this.pnlDlgYesNo.Name = "pnlDlgYesNo";
            this.pnlDlgYesNo.Size = new System.Drawing.Size(488, 242);
            this.pnlDlgYesNo.TabIndex = 8;
            this.pnlDlgYesNo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDialog_Paint);
            // 
            // lblYesNoText
            // 
            this.lblYesNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesNoText.ForeColor = System.Drawing.Color.Black;
            this.lblYesNoText.Location = new System.Drawing.Point(3, 12);
            this.lblYesNoText.Name = "lblYesNoText";
            this.lblYesNoText.Size = new System.Drawing.Size(477, 113);
            this.lblYesNoText.TabIndex = 12;
            this.lblYesNoText.Text = "Reprint Door Operator Labels?";
            this.lblYesNoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYes.Location = new System.Drawing.Point(32, 128);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(207, 96);
            this.btnYes.TabIndex = 10;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNo.Location = new System.Drawing.Point(245, 128);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(207, 96);
            this.btnNo.TabIndex = 11;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // pnlDlgOK
            // 
            this.pnlDlgOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDlgOK.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDlgOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDlgOK.Controls.Add(this.btnOK);
            this.pnlDlgOK.Controls.Add(this.lblOKText);
            this.pnlDlgOK.Location = new System.Drawing.Point(454, 625);
            this.pnlDlgOK.Name = "pnlDlgOK";
            this.pnlDlgOK.Size = new System.Drawing.Size(488, 242);
            this.pnlDlgOK.TabIndex = 14;
            this.pnlDlgOK.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDialog_Paint);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Location = new System.Drawing.Point(139, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(207, 96);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblOKText
            // 
            this.lblOKText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOKText.ForeColor = System.Drawing.Color.Black;
            this.lblOKText.Location = new System.Drawing.Point(3, 4);
            this.lblOKText.Name = "lblOKText";
            this.lblOKText.Size = new System.Drawing.Size(463, 132);
            this.lblOKText.TabIndex = 12;
            this.lblOKText.Text = "Crate data is missing from system.";
            this.lblOKText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(454, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestart.Location = new System.Drawing.Point(11, 557);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(237, 59);
            this.btnRestart.TabIndex = 20;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Location = new System.Drawing.Point(254, 450);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(194, 231);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print Operator Labels";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.btnSaveSettings.Location = new System.Drawing.Point(351, 478);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(256, 55);
            this.btnSaveSettings.TabIndex = 25;
            this.btnSaveSettings.Text = "save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Red);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Green);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Blue);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Exposure);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Gain);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Height);
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Width);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Top);
            this.flowLayoutPanel1.Controls.Add(this.label15);
            this.flowLayoutPanel1.Controls.Add(this.txtC1Left);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 469);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(287, 41);
            this.label13.TabIndex = 21;
            this.label13.Text = "Label Camera";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Red:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Red
            // 
            this.txtC1Red.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Red.Location = new System.Drawing.Point(166, 48);
            this.txtC1Red.Name = "txtC1Red";
            this.txtC1Red.Size = new System.Drawing.Size(124, 40);
            this.txtC1Red.TabIndex = 6;
            this.txtC1Red.Text = "1.07";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Green:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Green
            // 
            this.txtC1Green.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Green.Location = new System.Drawing.Point(166, 94);
            this.txtC1Green.Name = "txtC1Green";
            this.txtC1Green.Size = new System.Drawing.Size(124, 40);
            this.txtC1Green.TabIndex = 8;
            this.txtC1Green.Text = "1";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 41);
            this.label8.TabIndex = 11;
            this.label8.Text = "Blue:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Blue
            // 
            this.txtC1Blue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Blue.Location = new System.Drawing.Point(166, 140);
            this.txtC1Blue.Name = "txtC1Blue";
            this.txtC1Blue.Size = new System.Drawing.Size(124, 40);
            this.txtC1Blue.TabIndex = 10;
            this.txtC1Blue.Text = "1.3";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 41);
            this.label9.TabIndex = 13;
            this.label9.Text = "Exposure:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Exposure
            // 
            this.txtC1Exposure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Exposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Exposure.Location = new System.Drawing.Point(166, 186);
            this.txtC1Exposure.Name = "txtC1Exposure";
            this.txtC1Exposure.Size = new System.Drawing.Size(124, 40);
            this.txtC1Exposure.TabIndex = 12;
            this.txtC1Exposure.Text = "199";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 41);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gain:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Gain
            // 
            this.txtC1Gain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Gain.Location = new System.Drawing.Point(166, 232);
            this.txtC1Gain.Name = "txtC1Gain";
            this.txtC1Gain.Size = new System.Drawing.Size(124, 40);
            this.txtC1Gain.TabIndex = 14;
            this.txtC1Gain.Text = "1";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 41);
            this.label12.TabIndex = 19;
            this.label12.Text = "Height:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Height
            // 
            this.txtC1Height.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Height.Location = new System.Drawing.Point(166, 278);
            this.txtC1Height.Name = "txtC1Height";
            this.txtC1Height.Size = new System.Drawing.Size(124, 40);
            this.txtC1Height.TabIndex = 16;
            this.txtC1Height.Text = "1080";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 41);
            this.label14.TabIndex = 27;
            this.label14.Text = "Width:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Width
            // 
            this.txtC1Width.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Width.Location = new System.Drawing.Point(166, 324);
            this.txtC1Width.Name = "txtC1Width";
            this.txtC1Width.Size = new System.Drawing.Size(124, 40);
            this.txtC1Width.TabIndex = 26;
            this.txtC1Width.Text = "1080";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 41);
            this.label11.TabIndex = 29;
            this.label11.Text = "Top:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Top
            // 
            this.txtC1Top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Top.Location = new System.Drawing.Point(166, 370);
            this.txtC1Top.Name = "txtC1Top";
            this.txtC1Top.Size = new System.Drawing.Size(124, 40);
            this.txtC1Top.TabIndex = 28;
            this.txtC1Top.Text = "0";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 41);
            this.label15.TabIndex = 31;
            this.label15.Text = "Left:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC1Left
            // 
            this.txtC1Left.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC1Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC1Left.Location = new System.Drawing.Point(166, 416);
            this.txtC1Left.Name = "txtC1Left";
            this.txtC1Left.Size = new System.Drawing.Size(124, 40);
            this.txtC1Left.TabIndex = 30;
            this.txtC1Left.Text = "0";
            // 
            // btnCameraSettings
            // 
            this.btnCameraSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraSettings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCameraSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.btnCameraSettings.Location = new System.Drawing.Point(674, 8);
            this.btnCameraSettings.Name = "btnCameraSettings";
            this.btnCameraSettings.Size = new System.Drawing.Size(304, 56);
            this.btnCameraSettings.TabIndex = 27;
            this.btnCameraSettings.Text = "Camera Settings";
            this.btnCameraSettings.UseVisualStyleBackColor = false;
            this.btnCameraSettings.Click += new System.EventHandler(this.btnCameraSettings_Click);
            // 
            // btnZoomView
            // 
            this.btnZoomView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomView.BackColor = System.Drawing.Color.SteelBlue;
            this.btnZoomView.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.btnZoomView.Location = new System.Drawing.Point(982, 8);
            this.btnZoomView.Name = "btnZoomView";
            this.btnZoomView.Size = new System.Drawing.Size(304, 56);
            this.btnZoomView.TabIndex = 28;
            this.btnZoomView.Text = "Zoom Viewer";
            this.btnZoomView.UseVisualStyleBackColor = false;
            this.btnZoomView.Click += new System.EventHandler(this.btnZoomView_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(454, 239);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 104);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label16);
            this.flowLayoutPanel3.Controls.Add(this.label17);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Red);
            this.flowLayoutPanel3.Controls.Add(this.label18);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Green);
            this.flowLayoutPanel3.Controls.Add(this.label19);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Blue);
            this.flowLayoutPanel3.Controls.Add(this.label20);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Exposure);
            this.flowLayoutPanel3.Controls.Add(this.label21);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Gain);
            this.flowLayoutPanel3.Controls.Add(this.label22);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Height);
            this.flowLayoutPanel3.Controls.Add(this.label23);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Width);
            this.flowLayoutPanel3.Controls.Add(this.label24);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Top);
            this.flowLayoutPanel3.Controls.Add(this.label25);
            this.flowLayoutPanel3.Controls.Add(this.txtC2Left);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(309, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(298, 469);
            this.flowLayoutPanel3.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(287, 41);
            this.label16.TabIndex = 21;
            this.label16.Text = "Top Camera";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 41);
            this.label17.TabIndex = 7;
            this.label17.Text = "Red:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Red
            // 
            this.txtC2Red.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Red.Location = new System.Drawing.Point(166, 48);
            this.txtC2Red.Name = "txtC2Red";
            this.txtC2Red.Size = new System.Drawing.Size(124, 40);
            this.txtC2Red.TabIndex = 6;
            this.txtC2Red.Text = "1.07";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 41);
            this.label18.TabIndex = 9;
            this.label18.Text = "Green:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Green
            // 
            this.txtC2Green.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Green.Location = new System.Drawing.Point(166, 94);
            this.txtC2Green.Name = "txtC2Green";
            this.txtC2Green.Size = new System.Drawing.Size(124, 40);
            this.txtC2Green.TabIndex = 8;
            this.txtC2Green.Text = "1";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 41);
            this.label19.TabIndex = 11;
            this.label19.Text = "Blue:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Blue
            // 
            this.txtC2Blue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Blue.Location = new System.Drawing.Point(166, 140);
            this.txtC2Blue.Name = "txtC2Blue";
            this.txtC2Blue.Size = new System.Drawing.Size(124, 40);
            this.txtC2Blue.TabIndex = 10;
            this.txtC2Blue.Text = "1.3";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(3, 183);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 41);
            this.label20.TabIndex = 13;
            this.label20.Text = "Exposure:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Exposure
            // 
            this.txtC2Exposure.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Exposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Exposure.Location = new System.Drawing.Point(166, 186);
            this.txtC2Exposure.Name = "txtC2Exposure";
            this.txtC2Exposure.Size = new System.Drawing.Size(124, 40);
            this.txtC2Exposure.TabIndex = 12;
            this.txtC2Exposure.Text = "199";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(3, 229);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 41);
            this.label21.TabIndex = 15;
            this.label21.Text = "Gain:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Gain
            // 
            this.txtC2Gain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Gain.Location = new System.Drawing.Point(166, 232);
            this.txtC2Gain.Name = "txtC2Gain";
            this.txtC2Gain.Size = new System.Drawing.Size(124, 40);
            this.txtC2Gain.TabIndex = 14;
            this.txtC2Gain.Text = "1";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(3, 275);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 41);
            this.label22.TabIndex = 19;
            this.label22.Text = "Height:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Height
            // 
            this.txtC2Height.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Height.Location = new System.Drawing.Point(166, 278);
            this.txtC2Height.Name = "txtC2Height";
            this.txtC2Height.Size = new System.Drawing.Size(124, 40);
            this.txtC2Height.TabIndex = 16;
            this.txtC2Height.Text = "1080";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(3, 321);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(157, 41);
            this.label23.TabIndex = 27;
            this.label23.Text = "Width:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Width
            // 
            this.txtC2Width.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Width.Location = new System.Drawing.Point(166, 324);
            this.txtC2Width.Name = "txtC2Width";
            this.txtC2Width.Size = new System.Drawing.Size(124, 40);
            this.txtC2Width.TabIndex = 26;
            this.txtC2Width.Text = "1080";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(3, 367);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(157, 41);
            this.label24.TabIndex = 29;
            this.label24.Text = "Top:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Top
            // 
            this.txtC2Top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Top.Location = new System.Drawing.Point(166, 370);
            this.txtC2Top.Name = "txtC2Top";
            this.txtC2Top.Size = new System.Drawing.Size(124, 40);
            this.txtC2Top.TabIndex = 28;
            this.txtC2Top.Text = "0";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(3, 413);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(157, 41);
            this.label25.TabIndex = 31;
            this.label25.Text = "Left:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC2Left
            // 
            this.txtC2Left.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtC2Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC2Left.Location = new System.Drawing.Point(166, 416);
            this.txtC2Left.Name = "txtC2Left";
            this.txtC2Left.Size = new System.Drawing.Size(124, 40);
            this.txtC2Left.TabIndex = 30;
            this.txtC2Left.Text = "0";
            // 
            // flpSettings
            // 
            this.flpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSettings.BackColor = System.Drawing.Color.DarkGray;
            this.flpSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSettings.Controls.Add(this.flowLayoutPanel3);
            this.flpSettings.Controls.Add(this.flowLayoutPanel1);
            this.flpSettings.Controls.Add(this.btnSaveSettings);
            this.flpSettings.Controls.Add(this.lblTest);
            this.flpSettings.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpSettings.Location = new System.Drawing.Point(674, 70);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(612, 540);
            this.flpSettings.TabIndex = 33;
            this.flpSettings.Visible = false;
            // 
            // lblTest
            // 
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.Black;
            this.lblTest.Location = new System.Drawing.Point(30, 475);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(315, 41);
            this.lblTest.TabIndex = 33;
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1294, 873);
            this.Controls.Add(this.pnlDlgYesNo);
            this.Controls.Add(this.pnlDlgOK);
            this.Controls.Add(this.btnCameraSettings);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnZoomView);
            this.Controls.Add(this.pnlAdminData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnUpdateCrate);
            this.Controls.Add(this.flpIDInputs);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnLoadCrate);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.btnGetImage);
            this.Controls.Add(this.btnGetWeight);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpSettings);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Crate Info Scan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnlAdminData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flpIDInputs.ResumeLayout(false);
            this.flpIDInputs.PerformLayout();
            this.pnlDlgYesNo.ResumeLayout(false);
            this.pnlDlgOK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flpSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnGetWeight;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel pnlAdminData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateCrate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpIDInputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShipDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCrateNo;
        private System.Windows.Forms.Panel pnlDlgYesNo;
        private System.Windows.Forms.Label lblYesNoText;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Panel pnlDlgOK;
        private System.Windows.Forms.Label lblOKText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadCrate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblScanData;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC1Red;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC1Green;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtC1Blue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtC1Exposure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtC1Gain;
        private System.Windows.Forms.Button btnCameraSettings;
        private System.Windows.Forms.Button btnZoomView;
        private System.Windows.Forms.TextBox txtC1Height;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtC1Width;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtC1Top;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtC1Left;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtC2Red;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtC2Green;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtC2Blue;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtC2Exposure;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtC2Gain;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtC2Height;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtC2Width;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtC2Top;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtC2Left;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private System.Windows.Forms.Label lblTest;
    }
}

