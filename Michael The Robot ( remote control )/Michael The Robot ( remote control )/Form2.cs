using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;
using MonoBrick.NXT;
using System.IO;

namespace Michael_The_Robot___remote_control__
{
    public partial class Form2 : MaterialForm
    {

        private String sensorType;

        private Brick<Sensor, Sensor, Sensor, Sensor> brick;

        private Sonar sensorDistance;

        private NXTLightSensor sensorLight;

       

        

        public Form2()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.Cyan900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set timer interval
            timer1.Interval = 100;
            sensorType = "None";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            String comPort = "COM" + txtCOM.Text;

            try
            {
                
                // if brick is already connected then disconnect it
                if (brick != null && brick.Connection.IsConnected)
                {
                    MessageBox.Show("Robot is already connected", "Connect error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // create brick object and connect it to robot
                brick = new Brick<Sensor, Sensor, Sensor, Sensor>(comPort);
                brick.Connection.Open();

                // light/colour sensor declaration and connect in port 3
                sensorLight = new NXTLightSensor();
                brick.Sensor3 = sensorLight;

                // distance sensor declaration and connect in port 4
                sensorDistance = new Sonar();
                brick.Sensor4 = sensorDistance;

                // update form with brick details
                lblConnectStatus.Text = "Connected to NXT Robot " + brick.GetBrickName();


                // Set ports for synchronised motor vehicle
                brick.Vehicle.LeftPort = MotorPort.OutC;
                brick.Vehicle.RightPort = MotorPort.OutA;


                // Update form buttons
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                enableSensors(true);

            }
            catch 
            {
                MessageBox.Show("Error connecting to robot on " + comPort, "Connect error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // call disconnect in case robot has already connected when error occured
                disconnect();
            }
        }

        private void disconnect()
        {
            // if brick is connected then disconnect it
            if (brick != null && brick.Connection.IsConnected)
            {
                // Turn timer off so polling does not happen
                timer1.Enabled = false;

                // disconnect
                brick.Connection.Close();
                brick = null;
            }

            
            enableSensors(false);
            btnDisconnect.Enabled = false;
            btnSensorsOff.Enabled = false;

            // wait for 5 seconds to give robot time to disconnect in case the user
            // presses connect again too quickly

            Thread.Sleep(5000);

            // update form
            lblConnectStatus.Text = "Disconnected";
            btnConnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnect();
        }

       

        

        private void enableSensors(bool pbMode)
        {
            btnUltrasonic.Enabled = pbMode;
            btnColour.Enabled = pbMode;
            btnDisconnect.Enabled = pbMode;
            btnSensorsOff.Enabled = !pbMode;
        }

        private void btnSensorsOff_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblSensorResult.Text = "No Sensor Data";
            sensorType = "None";
            enableSensors(true);
        }



        
        // methods for movements 

        private void circle()
        {
            brick.MotorA.On(80);
            brick.MotorC.On(20);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            forward();
        }

        private void forward()
        {
            brick.MotorA.On(70);
            brick.MotorC.On(70);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            backward();
        }

        private void backward()
        {
            brick.MotorA.On(-70);
            brick.MotorC.On(-70);
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            brake();
        }

        private void brake()
        {
            brick.MotorA.Off();
            brick.MotorC.Off();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            left();
        }

        private void left()
        {
            brick.MotorA.On(50);
            brick.MotorC.Off();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            right();
        }

        private void right()
        {
            brick.MotorA.Off();
            brick.MotorC.On(50);
        }

        private void Stop()
        {
            brick.MotorA.Off();
            brick.MotorC.Off();
        }

        private void findRight90()
        {
            brick.MotorC.On(100, 400);
            brick.MotorA.On(-100, 400);
        }

        private void findRight180()
        {
            brick.MotorC.On(100, 800);
            brick.MotorA.On(-100, 800);
        }

        private void findLeft90()
        {
            brick.MotorC.On(-100, 400);
            brick.MotorA.On(100, 400);
        }

        private void findLeft180()
        {
            brick.MotorA.On(100, 800);
            brick.MotorC.On(-100, 800);
        }

        private void lineObjectRight180()
        {
            brick.MotorA.On(-100, 700);
            brick.MotorC.On(100, 700);
        }

        // methods for mouse clicks
        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            forward();

        }

        private void btnForward_MouseUp(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            right();
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            left();
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void btnBackward_MouseDown(object sender, MouseEventArgs e)
        {
            backward();
        }

        private void btnBackward_MouseUp(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (sensorType)
            {
                case "DIST":
                    int iDistance;

                    iDistance = sensorDistance.ReadDistance();

                    Thread.Sleep(50);
                    lblSensorResult2.Text = "Closet object is " + iDistance + " cm";

                    break;

                case "ATTACK":

                    int iDistance1;
                    iDistance1 = sensorDistance.ReadDistance();

                    Thread.Sleep(50);
                    lblSensorResult2.Text = "Closest object is " + iDistance1 + " cm";

                    do
                    {

                        circle();

                        if (iDistance1 < 35)
                        {

                            forward();
                            Thread.Sleep(2000);
                            backward();
                            Thread.Sleep(2000);
                            circle();
                        }



                    } while (iDistance1 > 255);

                    break;


                case "LIGHT":


                    int value;

                    value = sensorLight.ReadLightLevel();

                    Thread.Sleep(50);
                    lblSensorResult.Text = "Colour light is " + value;

                    break;

            }

        }

        private void btnUltrasonic_Click(object sender, EventArgs e)
        {
            // activate Ultrasonic sensor
            if (brick != null && brick.Connection.IsConnected)
            {
                sensorType = "DIST";
                timer1.Enabled = true;
                enableSensors(false);
            }
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            // activate Light/Colour sensor
            if (brick != null && brick.Connection.IsConnected)
            {
                sensorType = "LIGHT";
                timer1.Enabled = true;
                enableSensors(false);
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            //enable sensor for distance
            sensorType = "ATTACK";
            timer1.Enabled = true;
            enableSensors(false);

            Thread.Sleep(50);

           
            int iDistance;

            iDistance = sensorDistance.ReadDistance();


            // do/while loop // mode start after do
            do
            {

                circle();
               

                if (iDistance < 25)
                {

                    forward();
                    Thread.Sleep(2000);
                    backward();
                    Thread.Sleep(1000);
                    circle();

                }
              
   
            } while (iDistance > 255);    // it's always running 
                                         // 255cm is the maximun that sensor reading 
                                        // if we set bigger number than 255 the robot will never attack
                                        
        }

        private void btnFinadWay_Click(object sender, EventArgs e)
        {
            int iDistance;
            int k;
          
            // enable distance sensor
            sensorType = "DIST";
            timer1.Enabled = true;
            enableSensors(false);

            brick.MotorA.On(20);
            brick.MotorC.On(20);

            iDistance = sensorDistance.ReadDistance();
            k = iDistance;
            Thread.Sleep(50);
            while (k != 1)          // while infinity loop to running always the mode
            {                       // to find and go on free way
                brick.MotorA.On(30);
                brick.MotorC.On(30);
                while (k < 20)      // while infinity loop to recognize always the closer distance
                {
                    brick.MotorA.Off();
                    brick.MotorC.Off();

                    Thread.Sleep(50);

                    findRight90();   // method to turn
                    Thread.Sleep(1000);


                    iDistance = sensorDistance.ReadDistance();
                    k = iDistance;
                    Thread.Sleep(1000);

                    // if statments to manage any situation about the objects

                    if (k <= 20)
                    {
                        findRight180();
                        Thread.Sleep(1000);

                    }


                    if (k == 255)
                    {

                        findRight180();
                        Thread.Sleep(1000);

                    }
                    iDistance = sensorDistance.ReadDistance();
                    k = iDistance;
                    Thread.Sleep(1000);

                    if (k == 255)
                    {

                        findLeft90();
                        Thread.Sleep(1000);
                    }
                }
                iDistance = sensorDistance.ReadDistance();
                k = iDistance;
                Thread.Sleep(50);
                lblSensorResult2.Text = "Closet object is " + iDistance + " cm";
             
            }
        }

        private void btnRecColour_Click(object sender, EventArgs e)
        {
            //enable the colour sensor
            sensorType = "LIGHT";
            sensorType = "DIST";
            timer1.Enabled = true;
            enableSensors(false);

            int midPoint;
            int value;
            int iDistance;

            int white = 58, black = 32;

            midPoint = (white + black) / 2;

            iDistance = sensorDistance.ReadDistance();
            value = sensorLight.ReadLightLevel();

            while (value != 1) // while infinity loop to running always the mode
            {
                brick.MotorA.On(20);
                brick.MotorC.On(20);

                Thread.Sleep(50);
                value = sensorLight.ReadLightLevel();
                if (value < midPoint )       // if statments to give the access on robot 
                {                           // to goes from any way in and out
                    brick.MotorC.On(-5);
                    brick.MotorA.On(20);

                    value = sensorLight.ReadLightLevel();
                    iDistance = sensorDistance.ReadDistance();
                    
                    //if statment when it's find an object to make 180 degree turn
                    if (iDistance < 15)
                    {

                        brick.PlayTone(500, 250);
                        Thread.Sleep(250);
                        brick.PlayTone(1000, 500);
                        Thread.Sleep(50);
                        brick.MotorA.Off();
                        brick.MotorC.Off();
                        Thread.Sleep(1000);
                        lineObjectRight180();
                        Thread.Sleep(1000);
                    }
                }

                else if (value >= midPoint + 3)  // if statments to give the access on robot 
                {                               //to goes from any way in and out

                    brick.MotorA.Off();
                    brick.MotorC.On(24);

                    value = sensorLight.ReadLightLevel();
                    iDistance = sensorDistance.ReadDistance();
                    
                    if (iDistance < 15)
                    {
                        brick.PlayTone(500, 250);
                        Thread.Sleep(250);
                        brick.PlayTone(1000, 500);
                        Thread.Sleep(50);
                        brick.MotorA.Off();
                        brick.MotorC.Off();
                        Thread.Sleep(1000);
                        lineObjectRight180();
                        Thread.Sleep(1000);
                    }
                }

                value = sensorLight.ReadLightLevel();
                Thread.Sleep(50);
                lblSensorResult2.Text = "Colour of object is " + iDistance;
                lblSensorResult.Text = "Colour light is " + value;
            }


            value = sensorLight.ReadLightLevel();
            iDistance = sensorDistance.ReadDistance();
            Thread.Sleep(50);
            lblSensorResult2.Text = "Closet object is " + iDistance + " cm";
            lblSensorResult.Text = "Colour light is " + value;
        }


        // method to move the robot with keyboard keys
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W )
            {
                btnForward_Click(null, null);
            }
            if (e.KeyCode == Keys.S)
            {
                btnBackward_Click(null, null);
            }
            if (e.KeyCode == Keys.A)
            {
                btnLeft_Click(null, null);
            }
            if (e.KeyCode == Keys.D)
            {
                btnRight_Click(null, null);
            }
            if (e.KeyCode == Keys.Space)
            {
                btnBrake_Click(null, null);
            }
          
        }

        // method to move the robot with keyboard keys
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                btnBrake_Click(null, null);
            }
            if (e.KeyCode == Keys.S)
            {
                btnBrake_Click(null, null);
            }
            if (e.KeyCode == Keys.A)
            {
                btnBrake_Click(null, null);
            }
            if (e.KeyCode == Keys.D)
            {
                btnBrake_Click(null, null);
            }
            if (e.KeyCode == Keys.Space)
            {
                btnBrake_Click(null, null);
            }
        }
    }
    
}
