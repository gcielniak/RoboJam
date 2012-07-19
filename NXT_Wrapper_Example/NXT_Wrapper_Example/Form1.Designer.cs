namespace Lego_Colour_Detection
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.txt_PortName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SetName = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Battery = new System.Windows.Forms.TextBox();
            this.txt_Flash = new System.Windows.Forms.TextBox();
            this.txt_Signal = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Protocol = new System.Windows.Forms.TextBox();
            this.txt_Firmware = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_StopProg = new System.Windows.Forms.Button();
            this.btn_StartProgram = new System.Windows.Forms.Button();
            this.txt_ProgName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_RunState = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.num_Turn = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_RegMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Mode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num_Speed = new System.Windows.Forms.NumericUpDown();
            this.btn_MotorSet = new System.Windows.Forms.Button();
            this.btn_MotorGet = new System.Windows.Forms.Button();
            this.btn_MotorReset = new System.Windows.Forms.Button();
            this.cmb_Motor = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chb_Loop = new System.Windows.Forms.CheckBox();
            this.btn_StartSound = new System.Windows.Forms.Button();
            this.txt_SoundName = new System.Windows.Forms.TextBox();
            this.btn_StopSound = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.num_Duration = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.num_Freq = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_StartTone = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Speed)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Freq)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(177, 22);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(116, 23);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Enabled = false;
            this.btn_Disconnect.Location = new System.Drawing.Point(299, 23);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(116, 22);
            this.btn_Disconnect.TabIndex = 1;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // txt_PortName
            // 
            this.txt_PortName.Location = new System.Drawing.Point(114, 22);
            this.txt_PortName.Name = "txt_PortName";
            this.txt_PortName.Size = new System.Drawing.Size(57, 20);
            this.txt_PortName.TabIndex = 2;
            this.txt_PortName.Text = "COM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_PortName);
            this.groupBox1.Controls.Add(this.btn_Disconnect);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "COM Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SetName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Battery);
            this.groupBox2.Controls.Add(this.txt_Flash);
            this.groupBox2.Controls.Add(this.txt_Signal);
            this.groupBox2.Controls.Add(this.txt_Address);
            this.groupBox2.Controls.Add(this.txt_Name);
            this.groupBox2.Controls.Add(this.txt_Protocol);
            this.groupBox2.Controls.Add(this.txt_Firmware);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 210);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Info";
            // 
            // btn_SetName
            // 
            this.btn_SetName.Enabled = false;
            this.btn_SetName.Location = new System.Drawing.Point(177, 79);
            this.btn_SetName.Name = "btn_SetName";
            this.btn_SetName.Size = new System.Drawing.Size(34, 20);
            this.btn_SetName.TabIndex = 14;
            this.btn_SetName.Text = "Set";
            this.btn_SetName.UseVisualStyleBackColor = true;
            this.btn_SetName.Click += new System.EventHandler(this.btn_SetName_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Battery";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Flash (KB)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Signal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Protocol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Firmware";
            // 
            // txt_Battery
            // 
            this.txt_Battery.Enabled = false;
            this.txt_Battery.Location = new System.Drawing.Point(77, 183);
            this.txt_Battery.Name = "txt_Battery";
            this.txt_Battery.Size = new System.Drawing.Size(137, 20);
            this.txt_Battery.TabIndex = 6;
            // 
            // txt_Flash
            // 
            this.txt_Flash.Enabled = false;
            this.txt_Flash.Location = new System.Drawing.Point(77, 157);
            this.txt_Flash.Name = "txt_Flash";
            this.txt_Flash.Size = new System.Drawing.Size(137, 20);
            this.txt_Flash.TabIndex = 5;
            // 
            // txt_Signal
            // 
            this.txt_Signal.Enabled = false;
            this.txt_Signal.Location = new System.Drawing.Point(77, 131);
            this.txt_Signal.Name = "txt_Signal";
            this.txt_Signal.Size = new System.Drawing.Size(137, 20);
            this.txt_Signal.TabIndex = 4;
            // 
            // txt_Address
            // 
            this.txt_Address.Enabled = false;
            this.txt_Address.Location = new System.Drawing.Point(77, 105);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(137, 20);
            this.txt_Address.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(77, 79);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(94, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Protocol
            // 
            this.txt_Protocol.Enabled = false;
            this.txt_Protocol.Location = new System.Drawing.Point(77, 53);
            this.txt_Protocol.Name = "txt_Protocol";
            this.txt_Protocol.Size = new System.Drawing.Size(137, 20);
            this.txt_Protocol.TabIndex = 1;
            // 
            // txt_Firmware
            // 
            this.txt_Firmware.Enabled = false;
            this.txt_Firmware.Location = new System.Drawing.Point(77, 27);
            this.txt_Firmware.Name = "txt_Firmware";
            this.txt_Firmware.Size = new System.Drawing.Size(137, 20);
            this.txt_Firmware.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_StopProg);
            this.groupBox3.Controls.Add(this.btn_StartProgram);
            this.groupBox3.Controls.Add(this.txt_ProgName);
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Programs";
            // 
            // btn_StopProg
            // 
            this.btn_StopProg.Enabled = false;
            this.btn_StopProg.Location = new System.Drawing.Point(7, 52);
            this.btn_StopProg.Name = "btn_StopProg";
            this.btn_StopProg.Size = new System.Drawing.Size(204, 20);
            this.btn_StopProg.TabIndex = 2;
            this.btn_StopProg.Text = "Stop";
            this.btn_StopProg.UseVisualStyleBackColor = true;
            this.btn_StopProg.Click += new System.EventHandler(this.btn_StopProg_Click);
            // 
            // btn_StartProgram
            // 
            this.btn_StartProgram.Enabled = false;
            this.btn_StartProgram.Location = new System.Drawing.Point(112, 26);
            this.btn_StartProgram.Name = "btn_StartProgram";
            this.btn_StartProgram.Size = new System.Drawing.Size(99, 20);
            this.btn_StartProgram.TabIndex = 1;
            this.btn_StartProgram.Text = "Run";
            this.btn_StartProgram.UseVisualStyleBackColor = true;
            this.btn_StartProgram.Click += new System.EventHandler(this.btn_StartProgram_Click);
            // 
            // txt_ProgName
            // 
            this.txt_ProgName.Location = new System.Drawing.Point(6, 26);
            this.txt_ProgName.MaxLength = 12;
            this.txt_ProgName.Name = "txt_ProgName";
            this.txt_ProgName.Size = new System.Drawing.Size(100, 20);
            this.txt_ProgName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cmb_RunState);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.num_Turn);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cmb_RegMode);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cmb_Mode);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.num_Speed);
            this.groupBox4.Controls.Add(this.btn_MotorSet);
            this.groupBox4.Controls.Add(this.btn_MotorGet);
            this.groupBox4.Controls.Add(this.btn_MotorReset);
            this.groupBox4.Controls.Add(this.cmb_Motor);
            this.groupBox4.Location = new System.Drawing.Point(251, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 293);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motor Control";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Run State";
            // 
            // cmb_RunState
            // 
            this.cmb_RunState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RunState.FormattingEnabled = true;
            this.cmb_RunState.Location = new System.Drawing.Point(82, 165);
            this.cmb_RunState.Name = "cmb_RunState";
            this.cmb_RunState.Size = new System.Drawing.Size(91, 21);
            this.cmb_RunState.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(116, 260);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(116, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(116, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Rotation Count";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Block Tacho Count";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tacho Count";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Turn Ratio";
            // 
            // num_Turn
            // 
            this.num_Turn.Location = new System.Drawing.Point(119, 137);
            this.num_Turn.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Turn.Name = "num_Turn";
            this.num_Turn.Size = new System.Drawing.Size(90, 20);
            this.num_Turn.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Regulator Mode";
            // 
            // cmb_RegMode
            // 
            this.cmb_RegMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RegMode.FormattingEnabled = true;
            this.cmb_RegMode.Items.AddRange(new object[] {
            "Break",
            "On",
            "Regulation"});
            this.cmb_RegMode.Location = new System.Drawing.Point(6, 136);
            this.cmb_RegMode.Name = "cmb_RegMode";
            this.cmb_RegMode.Size = new System.Drawing.Size(90, 21);
            this.cmb_RegMode.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Mode";
            // 
            // cmb_Mode
            // 
            this.cmb_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mode.FormattingEnabled = true;
            this.cmb_Mode.Items.AddRange(new object[] {
            "Break",
            "On",
            "Regulation"});
            this.cmb_Mode.Location = new System.Drawing.Point(6, 93);
            this.cmb_Mode.Name = "cmb_Mode";
            this.cmb_Mode.Size = new System.Drawing.Size(90, 21);
            this.cmb_Mode.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Speed";
            // 
            // num_Speed
            // 
            this.num_Speed.Location = new System.Drawing.Point(120, 93);
            this.num_Speed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Speed.Name = "num_Speed";
            this.num_Speed.Size = new System.Drawing.Size(90, 20);
            this.num_Speed.TabIndex = 4;
            this.num_Speed.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // btn_MotorSet
            // 
            this.btn_MotorSet.Enabled = false;
            this.btn_MotorSet.Location = new System.Drawing.Point(119, 48);
            this.btn_MotorSet.Name = "btn_MotorSet";
            this.btn_MotorSet.Size = new System.Drawing.Size(90, 23);
            this.btn_MotorSet.TabIndex = 3;
            this.btn_MotorSet.Text = "Set State";
            this.btn_MotorSet.UseVisualStyleBackColor = true;
            this.btn_MotorSet.Click += new System.EventHandler(this.btn_MotorSet_Click);
            // 
            // btn_MotorGet
            // 
            this.btn_MotorGet.Enabled = false;
            this.btn_MotorGet.Location = new System.Drawing.Point(6, 46);
            this.btn_MotorGet.Name = "btn_MotorGet";
            this.btn_MotorGet.Size = new System.Drawing.Size(90, 23);
            this.btn_MotorGet.TabIndex = 2;
            this.btn_MotorGet.Text = "Get State";
            this.btn_MotorGet.UseVisualStyleBackColor = true;
            this.btn_MotorGet.Click += new System.EventHandler(this.btn_MotorGet_Click);
            // 
            // btn_MotorReset
            // 
            this.btn_MotorReset.Enabled = false;
            this.btn_MotorReset.Location = new System.Drawing.Point(119, 19);
            this.btn_MotorReset.Name = "btn_MotorReset";
            this.btn_MotorReset.Size = new System.Drawing.Size(90, 23);
            this.btn_MotorReset.TabIndex = 1;
            this.btn_MotorReset.Text = "Reset";
            this.btn_MotorReset.UseVisualStyleBackColor = true;
            this.btn_MotorReset.Click += new System.EventHandler(this.btn_MotorReset_Click);
            // 
            // cmb_Motor
            // 
            this.cmb_Motor.DisplayMember = "--Select--";
            this.cmb_Motor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Motor.FormattingEnabled = true;
            this.cmb_Motor.Items.AddRange(new object[] {
            "Motor A",
            "Motor B",
            "Motor C",
            "All"});
            this.cmb_Motor.Location = new System.Drawing.Point(6, 19);
            this.cmb_Motor.Name = "cmb_Motor";
            this.cmb_Motor.Size = new System.Drawing.Size(90, 21);
            this.cmb_Motor.TabIndex = 0;
            this.cmb_Motor.TabStop = false;
            this.cmb_Motor.ValueMember = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chb_Loop);
            this.groupBox5.Controls.Add(this.btn_StartSound);
            this.groupBox5.Controls.Add(this.txt_SoundName);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 77);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Files";
            // 
            // chb_Loop
            // 
            this.chb_Loop.AutoSize = true;
            this.chb_Loop.Location = new System.Drawing.Point(121, 26);
            this.chb_Loop.Name = "chb_Loop";
            this.chb_Loop.Size = new System.Drawing.Size(50, 17);
            this.chb_Loop.TabIndex = 3;
            this.chb_Loop.Text = "Loop";
            this.chb_Loop.UseVisualStyleBackColor = true;
            // 
            // btn_StartSound
            // 
            this.btn_StartSound.Enabled = false;
            this.btn_StartSound.Location = new System.Drawing.Point(6, 51);
            this.btn_StartSound.Name = "btn_StartSound";
            this.btn_StartSound.Size = new System.Drawing.Size(193, 20);
            this.btn_StartSound.TabIndex = 1;
            this.btn_StartSound.Text = "Run";
            this.btn_StartSound.UseVisualStyleBackColor = true;
            this.btn_StartSound.Click += new System.EventHandler(this.btn_StartSound_Click);
            // 
            // txt_SoundName
            // 
            this.txt_SoundName.Location = new System.Drawing.Point(6, 26);
            this.txt_SoundName.MaxLength = 12;
            this.txt_SoundName.Name = "txt_SoundName";
            this.txt_SoundName.Size = new System.Drawing.Size(100, 20);
            this.txt_SoundName.TabIndex = 0;
            // 
            // btn_StopSound
            // 
            this.btn_StopSound.Enabled = false;
            this.btn_StopSound.Location = new System.Drawing.Point(12, 205);
            this.btn_StopSound.Name = "btn_StopSound";
            this.btn_StopSound.Size = new System.Drawing.Size(193, 20);
            this.btn_StopSound.TabIndex = 2;
            this.btn_StopSound.Text = "Stop";
            this.btn_StopSound.UseVisualStyleBackColor = true;
            this.btn_StopSound.Click += new System.EventHandler(this.btn_StopSound_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.num_Duration);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.num_Freq);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.btn_StartTone);
            this.groupBox6.Location = new System.Drawing.Point(6, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 101);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tones";
            // 
            // num_Duration
            // 
            this.num_Duration.Location = new System.Drawing.Point(87, 44);
            this.num_Duration.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.num_Duration.Name = "num_Duration";
            this.num_Duration.Size = new System.Drawing.Size(94, 20);
            this.num_Duration.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Duration (ms)";
            // 
            // num_Freq
            // 
            this.num_Freq.Location = new System.Drawing.Point(87, 18);
            this.num_Freq.Maximum = new decimal(new int[] {
            14000,
            0,
            0,
            0});
            this.num_Freq.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_Freq.Name = "num_Freq";
            this.num_Freq.Size = new System.Drawing.Size(94, 20);
            this.num_Freq.TabIndex = 19;
            this.num_Freq.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Frequency";
            // 
            // btn_StartTone
            // 
            this.btn_StartTone.Enabled = false;
            this.btn_StartTone.Location = new System.Drawing.Point(6, 75);
            this.btn_StartTone.Name = "btn_StartTone";
            this.btn_StartTone.Size = new System.Drawing.Size(193, 20);
            this.btn_StartTone.TabIndex = 1;
            this.btn_StartTone.Text = "Run";
            this.btn_StartTone.UseVisualStyleBackColor = true;
            this.btn_StartTone.Click += new System.EventHandler(this.btn_StartTone_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Controls.Add(this.btn_StopSound);
            this.groupBox7.Location = new System.Drawing.Point(473, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(220, 231);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sounds";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 375);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NXT Control Centre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Speed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Freq)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox txt_PortName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Battery;
        private System.Windows.Forms.TextBox txt_Flash;
        private System.Windows.Forms.TextBox txt_Signal;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Protocol;
        private System.Windows.Forms.TextBox txt_Firmware;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_ProgName;
        private System.Windows.Forms.Button btn_StartProgram;
        private System.Windows.Forms.Button btn_StopProg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmb_Motor;
        private System.Windows.Forms.Button btn_MotorSet;
        private System.Windows.Forms.Button btn_MotorGet;
        private System.Windows.Forms.Button btn_MotorReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_Speed;
        private System.Windows.Forms.ComboBox cmb_Mode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_RegMode;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown num_Turn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_RunState;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_StopSound;
        private System.Windows.Forms.Button btn_StartSound;
        private System.Windows.Forms.TextBox txt_SoundName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_StartTone;
        private System.Windows.Forms.CheckBox chb_Loop;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown num_Freq;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown num_Duration;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_SetName;
    }
}

