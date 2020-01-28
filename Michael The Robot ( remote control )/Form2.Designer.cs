namespace Michael_The_Robot___remote_control__
{
    partial class Form2
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
            this.lblComPort = new MaterialSkin.Controls.MaterialLabel();
            this.txtCOM = new System.Windows.Forms.TextBox();
            this.btnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDisconnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblConnectStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btnSensorsOff = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSensorResult = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSensorResult2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUltrasonic = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnColour = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grbSensorsMode = new System.Windows.Forms.GroupBox();
            this.grbManualDrive = new System.Windows.Forms.GroupBox();
            this.btnBrake = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRight = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLeft = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBackward = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnForward = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grpModes = new System.Windows.Forms.GroupBox();
            this.btnRecColour = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinadWay = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAttack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grbSensorsMode.SuspendLayout();
            this.grbManualDrive.SuspendLayout();
            this.grpModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Depth = 0;
            this.lblComPort.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblComPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblComPort.Location = new System.Drawing.Point(12, 135);
            this.lblComPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(127, 32);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port";
            // 
            // txtCOM
            // 
            this.txtCOM.Location = new System.Drawing.Point(159, 135);
            this.txtCOM.Multiline = true;
            this.txtCOM.Name = "txtCOM";
            this.txtCOM.Size = new System.Drawing.Size(84, 29);
            this.txtCOM.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Depth = 0;
            this.btnConnect.Location = new System.Drawing.Point(265, 130);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = true;
            this.btnConnect.Size = new System.Drawing.Size(158, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Depth = 0;
            this.btnDisconnect.Location = new System.Drawing.Point(443, 130);
            this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Primary = true;
            this.btnDisconnect.Size = new System.Drawing.Size(179, 37);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.AutoSize = true;
            this.lblConnectStatus.Depth = 0;
            this.lblConnectStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConnectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConnectStatus.Location = new System.Drawing.Point(12, 206);
            this.lblConnectStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(173, 32);
            this.lblConnectStatus.TabIndex = 4;
            this.lblConnectStatus.Text = "Disconnected";
            // 
            // btnSensorsOff
            // 
            this.btnSensorsOff.Depth = 0;
            this.btnSensorsOff.Location = new System.Drawing.Point(16, 79);
            this.btnSensorsOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSensorsOff.Name = "btnSensorsOff";
            this.btnSensorsOff.Primary = true;
            this.btnSensorsOff.Size = new System.Drawing.Size(143, 64);
            this.btnSensorsOff.TabIndex = 5;
            this.btnSensorsOff.Text = "Sensors Off";
            this.btnSensorsOff.UseVisualStyleBackColor = true;
            this.btnSensorsOff.Click += new System.EventHandler(this.btnSensorsOff_Click);
            // 
            // lblSensorResult
            // 
            this.lblSensorResult.AutoSize = true;
            this.lblSensorResult.Depth = 0;
            this.lblSensorResult.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSensorResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSensorResult.Location = new System.Drawing.Point(12, 599);
            this.lblSensorResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSensorResult.Name = "lblSensorResult";
            this.lblSensorResult.Size = new System.Drawing.Size(203, 32);
            this.lblSensorResult.TabIndex = 6;
            this.lblSensorResult.Text = "No sensor result";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSensorResult2
            // 
            this.lblSensorResult2.AutoSize = true;
            this.lblSensorResult2.Depth = 0;
            this.lblSensorResult2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSensorResult2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSensorResult2.Location = new System.Drawing.Point(12, 642);
            this.lblSensorResult2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSensorResult2.Name = "lblSensorResult2";
            this.lblSensorResult2.Size = new System.Drawing.Size(203, 32);
            this.lblSensorResult2.TabIndex = 7;
            this.lblSensorResult2.Text = "No sensor result";
            // 
            // btnUltrasonic
            // 
            this.btnUltrasonic.Depth = 0;
            this.btnUltrasonic.Location = new System.Drawing.Point(175, 79);
            this.btnUltrasonic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUltrasonic.Name = "btnUltrasonic";
            this.btnUltrasonic.Primary = true;
            this.btnUltrasonic.Size = new System.Drawing.Size(157, 64);
            this.btnUltrasonic.TabIndex = 8;
            this.btnUltrasonic.Text = "Ultrasonic/IR";
            this.btnUltrasonic.UseVisualStyleBackColor = true;
            this.btnUltrasonic.Click += new System.EventHandler(this.btnUltrasonic_Click);
            // 
            // btnColour
            // 
            this.btnColour.Depth = 0;
            this.btnColour.Location = new System.Drawing.Point(361, 79);
            this.btnColour.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnColour.Name = "btnColour";
            this.btnColour.Primary = true;
            this.btnColour.Size = new System.Drawing.Size(193, 64);
            this.btnColour.TabIndex = 9;
            this.btnColour.Text = "Light/Colour";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // grbSensorsMode
            // 
            this.grbSensorsMode.Controls.Add(this.btnSensorsOff);
            this.grbSensorsMode.Controls.Add(this.btnColour);
            this.grbSensorsMode.Controls.Add(this.btnUltrasonic);
            this.grbSensorsMode.Location = new System.Drawing.Point(18, 307);
            this.grbSensorsMode.Name = "grbSensorsMode";
            this.grbSensorsMode.Size = new System.Drawing.Size(578, 216);
            this.grbSensorsMode.TabIndex = 10;
            this.grbSensorsMode.TabStop = false;
            this.grbSensorsMode.Text = "Sensors Modes";
            // 
            // grbManualDrive
            // 
            this.grbManualDrive.Controls.Add(this.btnBrake);
            this.grbManualDrive.Controls.Add(this.btnRight);
            this.grbManualDrive.Controls.Add(this.btnLeft);
            this.grbManualDrive.Controls.Add(this.btnBackward);
            this.grbManualDrive.Controls.Add(this.btnForward);
            this.grbManualDrive.Location = new System.Drawing.Point(750, 307);
            this.grbManualDrive.Name = "grbManualDrive";
            this.grbManualDrive.Size = new System.Drawing.Size(569, 385);
            this.grbManualDrive.TabIndex = 10;
            this.grbManualDrive.TabStop = false;
            this.grbManualDrive.Text = "Manual Drive";
            // 
            // btnBrake
            // 
            this.btnBrake.Depth = 0;
            this.btnBrake.Location = new System.Drawing.Point(233, 269);
            this.btnBrake.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Primary = true;
            this.btnBrake.Size = new System.Drawing.Size(142, 42);
            this.btnBrake.TabIndex = 11;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnRight
            // 
            this.btnRight.Depth = 0;
            this.btnRight.Location = new System.Drawing.Point(403, 128);
            this.btnRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRight.Name = "btnRight";
            this.btnRight.Primary = true;
            this.btnRight.Size = new System.Drawing.Size(142, 52);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Depth = 0;
            this.btnLeft.Location = new System.Drawing.Point(65, 128);
            this.btnLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Primary = true;
            this.btnLeft.Size = new System.Drawing.Size(142, 52);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnBackward
            // 
            this.btnBackward.Depth = 0;
            this.btnBackward.Location = new System.Drawing.Point(233, 169);
            this.btnBackward.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Primary = true;
            this.btnBackward.Size = new System.Drawing.Size(142, 52);
            this.btnBackward.TabIndex = 12;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            this.btnBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBackward_MouseDown);
            this.btnBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBackward_MouseUp);
            // 
            // btnForward
            // 
            this.btnForward.Depth = 0;
            this.btnForward.Location = new System.Drawing.Point(233, 77);
            this.btnForward.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnForward.Name = "btnForward";
            this.btnForward.Primary = true;
            this.btnForward.Size = new System.Drawing.Size(142, 52);
            this.btnForward.TabIndex = 11;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            this.btnForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseUp);
            // 
            // grpModes
            // 
            this.grpModes.Controls.Add(this.btnRecColour);
            this.grpModes.Controls.Add(this.btnFinadWay);
            this.grpModes.Controls.Add(this.btnAttack);
            this.grpModes.Location = new System.Drawing.Point(767, 135);
            this.grpModes.Name = "grpModes";
            this.grpModes.Size = new System.Drawing.Size(552, 103);
            this.grpModes.TabIndex = 13;
            this.grpModes.TabStop = false;
            this.grpModes.Text = "Modes";
            // 
            // btnRecColour
            // 
            this.btnRecColour.Depth = 0;
            this.btnRecColour.Location = new System.Drawing.Point(377, 39);
            this.btnRecColour.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecColour.Name = "btnRecColour";
            this.btnRecColour.Primary = true;
            this.btnRecColour.Size = new System.Drawing.Size(169, 48);
            this.btnRecColour.TabIndex = 16;
            this.btnRecColour.Text = "Follow Line";
            this.btnRecColour.UseVisualStyleBackColor = true;
            this.btnRecColour.Click += new System.EventHandler(this.btnRecColour_Click);
            // 
            // btnFinadWay
            // 
            this.btnFinadWay.Depth = 0;
            this.btnFinadWay.Location = new System.Drawing.Point(207, 39);
            this.btnFinadWay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinadWay.Name = "btnFinadWay";
            this.btnFinadWay.Primary = true;
            this.btnFinadWay.Size = new System.Drawing.Size(151, 48);
            this.btnFinadWay.TabIndex = 15;
            this.btnFinadWay.Text = "Find Way";
            this.btnFinadWay.UseVisualStyleBackColor = true;
            this.btnFinadWay.Click += new System.EventHandler(this.btnFinadWay_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Depth = 0;
            this.btnAttack.Location = new System.Drawing.Point(19, 39);
            this.btnAttack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Primary = true;
            this.btnAttack.Size = new System.Drawing.Size(151, 48);
            this.btnAttack.TabIndex = 14;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 780);
            this.Controls.Add(this.grpModes);
            this.Controls.Add(this.grbManualDrive);
            this.Controls.Add(this.grbSensorsMode);
            this.Controls.Add(this.lblSensorResult2);
            this.Controls.Add(this.lblSensorResult);
            this.Controls.Add(this.lblConnectStatus);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtCOM);
            this.Controls.Add(this.lblComPort);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Welcome to Michael\'s Remote Control";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.grbSensorsMode.ResumeLayout(false);
            this.grbManualDrive.ResumeLayout(false);
            this.grpModes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblComPort;
        private System.Windows.Forms.TextBox txtCOM;
        private MaterialSkin.Controls.MaterialRaisedButton btnConnect;
        private MaterialSkin.Controls.MaterialRaisedButton btnDisconnect;
        private MaterialSkin.Controls.MaterialLabel lblConnectStatus;
        private MaterialSkin.Controls.MaterialRaisedButton btnSensorsOff;
        private MaterialSkin.Controls.MaterialLabel lblSensorResult;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialLabel lblSensorResult2;
        private MaterialSkin.Controls.MaterialRaisedButton btnUltrasonic;
        private MaterialSkin.Controls.MaterialRaisedButton btnColour;
        private System.Windows.Forms.GroupBox grbSensorsMode;
        private System.Windows.Forms.GroupBox grbManualDrive;
        private MaterialSkin.Controls.MaterialRaisedButton btnForward;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrake;
        private MaterialSkin.Controls.MaterialRaisedButton btnRight;
        private MaterialSkin.Controls.MaterialRaisedButton btnLeft;
        private MaterialSkin.Controls.MaterialRaisedButton btnBackward;
        private System.Windows.Forms.GroupBox grpModes;
        private MaterialSkin.Controls.MaterialRaisedButton btnAttack;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinadWay;
        private MaterialSkin.Controls.MaterialRaisedButton btnRecColour;
    }
}