using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LSoCS.NXT;

namespace Lego_Colour_Detection
{
    public partial class Form1 : Form
    {

        LSoCS.NXT.Robot NXT_Brick;
        string response = "";

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {

            // connect to the brick
            NXT_Brick = new Robot(txt_PortName.Text);
            if (NXT_Brick.connected)
            {
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;
                btn_MotorGet.Enabled = true;
                btn_MotorReset.Enabled = true;
                btn_MotorSet.Enabled = true;
                btn_SetName.Enabled = true;
                btn_StartProgram.Enabled = true;
                btn_StartSound.Enabled = true;
                btn_StartTone.Enabled = true;
                btn_StopProg.Enabled = true;
                btn_StopSound.Enabled = true;


                // load in device info
                txt_Name.Text = NXT_Brick.DeviceInfo.Name;
                txt_Address.Text = NXT_Brick.DeviceInfo.BTAddress;
                txt_Signal.Text = NXT_Brick.DeviceInfo.BTSignalStrength.ToString(); // doesn't seem to be working right now
                txt_Flash.Text = NXT_Brick.DeviceInfo.FreeUserFlash.ToString();
                txt_Firmware.Text = NXT_Brick.DeviceInfo.FirmwareVersion;
                txt_Protocol.Text = NXT_Brick.DeviceInfo.ProtocolVersion;
                txt_Battery.Text = NXT_Brick.DirectCommands.GetBatteryLevel();

               
                timer1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NXT_Brick = null;

            cmb_Motor.Items.Clear();
            cmb_Motor.Items.AddRange(Enum.GetNames(typeof(LSoCS.NXT.MotorPort)));
            cmb_Motor.SelectedIndex = 0;

            cmb_Mode.Items.Clear();
            cmb_Mode.Items.AddRange(Enum.GetNames(typeof(LSoCS.NXT.Mode)));
            cmb_Mode.SelectedIndex = 0;

            cmb_RegMode.Items.Clear();
            cmb_RegMode.Items.AddRange(Enum.GetNames(typeof(LSoCS.NXT.RegulationMode)));
            cmb_RegMode.SelectedIndex = 0;

            cmb_RunState.Items.Clear();
            cmb_RunState.Items.AddRange(Enum.GetNames(typeof(LSoCS.NXT.RunState)));
            cmb_RunState.SelectedIndex = 0;
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            NXT_Brick.Disconnect();
            btn_Disconnect.Enabled = false;
            btn_Connect.Enabled = true;
            timer1.Enabled = false;
            btn_MotorGet.Enabled = false;
            btn_MotorReset.Enabled = false;
            btn_MotorSet.Enabled = false;
            btn_SetName.Enabled = false;
            btn_StartProgram.Enabled = false;
            btn_StartSound.Enabled = false;
            btn_StartTone.Enabled = false;
            btn_StopProg.Enabled = false;
            btn_StopSound.Enabled = false;


            txt_Name.Text = "";
            txt_Address.Text = "";
            txt_Signal.Text = "";
            txt_Flash.Text = "";
            txt_Firmware.Text = "";
            txt_Protocol.Text = "";
            txt_Battery.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NXT_Brick.DirectCommands.CurrentProgram());
        }

        private void btn_StartProgram_Click(object sender, EventArgs e)
        {
            response = NXT_Brick.DirectCommands.StartProgram(txt_ProgName.Text);

            if (response != "Success")
            {
                MessageBox.Show(response);
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //NXT_Brick.Disconnect();
        }

        private void btn_StopProg_Click(object sender, EventArgs e)
        {
            NXT_Brick.DirectCommands.StopProgram();
        }

        private void btn_MotorGet_Click(object sender, EventArgs e)
        {

            

            //MessageBox.Show(temp);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_MotorSet_Click(object sender, EventArgs e)
        {
            IDictionary<string, OutPort> selectedPort = new Dictionary<string, OutPort>
            {
                {"MotorA", NXT_Brick.OutPortA},
                {"MotorB", NXT_Brick.OutPortB},
                {"MotorC", NXT_Brick.OutPortC}
            };

            string key = cmb_Motor.SelectedItem.ToString();
            if (selectedPort.ContainsKey(key))
            {
                selectedPort[key].SetOutputState((int)num_Speed.Value,
                                               (LSoCS.NXT.Mode)Enum.Parse(typeof(LSoCS.NXT.Mode), cmb_Mode.SelectedItem.ToString()),
                                               (LSoCS.NXT.RegulationMode)Enum.Parse(typeof(LSoCS.NXT.RegulationMode), cmb_RegMode.SelectedItem.ToString()),
                                               (int)num_Turn.Value,
                                               (LSoCS.NXT.RunState)Enum.Parse(typeof(LSoCS.NXT.RunState), cmb_RunState.SelectedItem.ToString()));
            }

        }

        private void btn_StartSound_Click(object sender, EventArgs e)
        {
            NXT_Brick.DirectCommands.PlaySoundFile(txt_SoundName.Text, chb_Loop.Checked);
        }

        private void btn_StartTone_Click(object sender, EventArgs e)
        {
            NXT_Brick.DirectCommands.PlayTone((int)num_Freq.Value, (int)num_Duration.Value);
        }

        private void btn_StopSound_Click(object sender, EventArgs e)
        {
            NXT_Brick.DirectCommands.StopSoundPlayback();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_Battery.Text = NXT_Brick.DirectCommands.GetBatteryLevel();
            //txt_Protocol.Text = NXT_Brick.DirectCommands.KeepAlive(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_MotorReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NXT_Brick.OutPortA.ResetMotorPosition(true));

        }

        private void btn_SetName_Click(object sender, EventArgs e)
        {
            NXT_Brick.DirectCommands.SetBrickName(txt_Name.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            NXT_Brick.GoBackwards(100);
        }
    }
}
