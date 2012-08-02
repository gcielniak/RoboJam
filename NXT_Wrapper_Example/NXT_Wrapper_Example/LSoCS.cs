using System;
namespace LSoCS
{
    namespace NXT
    {
        using System.IO.Ports;
        using System.Threading;

        public enum SonarRegister : byte
        {
            MeasurementUnits = 0x14,
            PollInterval = 0x40,
            Mode = 0x41,
            MeasurementByte0 = 0x42,
            MeasurementByte1 = 0x43,
            MeasurementByte2 = 0x44,
            MeasurementByte3 = 0x45,
            MeasurementByte4 = 0x46,
            MeasurementByte5 = 0x47,
            MeasurementByte6 = 0x48
        }

        public enum DirectCommand : byte
        {
            StartProgram = 0x00,
            StopProgram = 0x01,
            PlaySoundFile = 0x02,
            PlayTone = 0x03,
            SetOutputState = 0x04,
            SetInputMode = 0x05,
            GetOutputState = 0x06,
            GetInputValues = 0x07,
            ResetInputScaledValue = 0x08,
            MessageWrite = 0x09,
            ResetMotorPosition = 0x0A,
            GetBatteryLevel = 0x0B,
            StopSoundPlayback = 0x0C,
            KeepAlive = 0x0D,
            LSGetStatus = 0x0E,
            LSWrite = 0x0F,
            LSRead = 0x10,
            GetCurrentProgramName = 0x11,
            MessageRead = 0x13,
            SetBrickName = 0x98
        }

        public enum Mode : byte
        {
            MotorOn = 0x01,     // Used to turn on specifid motor
            Break = 0x07,       // Use run/break instead of run/float in PWN
            Regulated = 0x04    // Turns on regulatoion
        }

        public enum RegulationMode : byte
        {
            Motor_Idle = 0x00,    // No regulation will be enabled
            Motor_On = 0x01,     // Power control will be enabled on specified output
            Motor_Sync = 0x02   // Sychronization will be enabled (Needs enabled on two outputs)
        }

        public enum RunState : byte
        {
            Idle = 0x00,    // Output will be idle
            RampUp = 0x10,  // Output will be ramp-up
            Running = 0x20, // Output will be running
            RampDown = 0x40 // Output will be ramp-down
        }

        public enum MotorPort : byte
        {
            MotorA = 0x00,
            MotorB = 0x01,
            MotorC = 0x02,
            MotorAll = 0xFF
        }

        public enum Command : byte
        {
            SetBrickName = 0x98,
            GetDeviceInfo = 0x9B
        }

        public enum SensorType : byte
        {
            NoSensor = 0x00,
            Switch = 0x01,
            Temperature = 0x02,
            Reflection = 0x03,
            Angle = 0x04,
            LightActive = 0x05,
            LightInactive = 0x06,
            SoundDB = 0x07,
            SoundDBA = 0x08,
            Custom = 0x09,
            LowSpeed = 0x0A,
            LowSpeed9V = 0x0B,
            Sonar = 0x0C,
            NoOfSensorTypes = 0x0D
        }

        public enum SensorMode : byte
        {
            RawMode = 0x00,
            BooleanMode = 0x20,
            TransitionCntMode = 0x40,
            PeriodCounterMode = 0x60,
            PctFullScaleMode = 0x80,
            CelsiusMode = 0xA0,
            FahrenheitMode = 0xC0,
            AngleStepsMode = 0xE0,
            SlopeMask = 0x1F,
            ModeMask = 0xE0
        }

        public enum SonarCommands : byte
        {
            Version = 0x00,
            ProductID = 0x08,
            SensorType = 0x10,
            FactoryZero = 0x11,
            FactoryScaleFactor = 0x12,
            FactoryScaleDivisor = 0x13,
            MeasurementUnits = 0x14,
            MeasurementInterval = 0x40,
            CommandState = 0x41,
            MeasurementByte0 = 0x42,
            MeasurementByte1 = 0x43,
            MeasurementByte2 = 0x44,
            MeasurementByte3 = 0x45,
            MeasurementByte4 = 0x46,
            MeasurementByte5 = 0x47,
            MeasurementByte6 = 0x48,
            ScaleFactor = 0x51,
            ScaleDivisor = 0x52
        }


        public class CSerialPort : SerialPort
        {
            public bool Connect(string port_name)
            {
                if (IsOpen)
                    Disconnect();

                PortName = port_name;
                BaudRate = 115200 / 4;
                DataBits = 8;
                Parity = Parity.None;
                StopBits = StopBits.One;
                ReadTimeout = 500;
                WriteTimeout = 500;
                Handshake = Handshake.None;

                try { Open(); }
                catch { return false; }

                DiscardInBuffer();
                DiscardOutBuffer();

                return IsOpen;
            }

            public bool Disconnect()
            {
                try { Close(); }
                catch { return false; }
                Thread.Sleep(100);
                return true;
            }

            public bool Send(Command command, ref byte[] reply)
            {
                byte[] data = new byte[2];
                data[0] = 0x01;
                data[1] = (byte)command;
                return Send(data, ref reply);
            }

            public bool Send(DirectCommand command)
            {
                byte[] data = new byte[2];
                data[0] = 0x00;
                data[1] = (byte)command;
                return Send(data);
            }

            public bool Send(byte[] command)
            {
                byte[] reply = null;
                return Send(command, ref reply);
            }

            public bool Send(byte[] command, ref byte[] reply)
            {
                if (!this.IsOpen)
                    return false;

                int length = command.Length;
                if (length == 0)
                    return true;

                byte[] data = new byte[command.Length + 2];
                data[0] = (byte)length;
                data[1] = (byte)(length >> 8);
                command.CopyTo(data, 2);

                try { this.Write(data, 0, data.Length); }
                catch (Exception) { return false; }

                if (command[0] < 0x80)
                {
                    int lsb, msb;

                    try { lsb = this.ReadByte(); }
                    catch (Exception) { return false; }

                    try { msb = this.ReadByte(); }
                    catch (Exception) { return false; }

                    int size = (msb << 8) + lsb;

                    Array.Resize(ref reply, size);

                    try { this.Read(reply, 0, size); }
                    catch (Exception) { return false; }


                    if ((reply.Length < 3) || (reply[2] != 0))
                        return false;
                }

                return true;
            }
        }

        public class CDeviceInfo : Error_Checking
        {
            byte[] device_info;

            CSerialPort serial_port;
            byte[] reply;

            public CDeviceInfo(CSerialPort serial_port)
            {
                device_info = new byte[30];
                this.serial_port = serial_port;
            }

            public bool Update()
            {
                byte[] reply = null;

                if (!serial_port.Send(Command.GetDeviceInfo, ref reply))
                    return false;

                if (reply == null)
                    return false;
                if (reply.Length != 33)
                    return false;

                Array.Copy(reply, 3, device_info, 0, 30);

                return true;
            }

            public string Name
            {
                get
                {
                    Update();
                    return System.Text.Encoding.ASCII.GetString(device_info, 0, 15);
                }
                set
                {
                    if (value.Length > 14)
                        value = value.Substring(0, 14);
                    byte[] message = new byte[18];
                    message[0] = 0x01;
                    message[1] = (byte)Command.SetBrickName;
                    System.Text.Encoding.ASCII.GetBytes(value).CopyTo(message, 2);

                    serial_port.Send(message);
                }
            }

            public string BTAddress
            {
                get
                {
                    Update();
                    return String.Format("{0:x2}:{1:x2}:{2:x2}:{3:x2}:{4:x2}:{5:x2}", device_info[15], device_info[16], device_info[17], device_info[18], device_info[19], device_info[20]);
                }
            }

            public uint BTSignalStrength
            {
                get
                {
                    Update();
                    return (uint)(device_info[22] + (device_info[23] << 8) + (device_info[24] << 16) + (device_info[25] << 24));
                }
            }

            public uint FreeUserFlash
            {
                get
                {
                    Update();
                    return (uint)(device_info[26] | (device_info[27] << 8) | (device_info[28]) | (device_info[29]));
                }
            }

            public string FirmwareVersion
            {
                get
                {
                    string Firmware = "";

                    byte[] message = new byte[2];

                    message[0] = 0x01;
                    message[1] = 0x88;

                    serial_port.Send(message, ref reply);

                    if (CheckResponce(ref reply[2]) != "Success")
                        return CheckResponce(ref message[2]);

                    Firmware = reply[6] + "." + reply[5];
                    return Firmware;
                }
            }

            public string ProtocolVersion
            {
                get
                {
                    string Protocol = "";
                    byte[] message = new byte[2];

                    message[0] = 0x01;
                    message[1] = 0x88;

                    serial_port.Send(message, ref reply);

                    if (CheckResponce(ref reply[2]) != "Success")
                        return CheckResponce(ref message[2]);

                    Protocol = reply[4] + "." + reply[3];
                    return Protocol;
                }

            }
        }

        public class InPort
        {
            CSerialPort serial_port;
            byte port;
            byte[] state;
            SensorMode mode;
            SensorType type;

            public InPort(CSerialPort serial_port, byte port)
            {
                this.serial_port = serial_port;
                this.port = port;
                state = new byte[8];
            }

            public bool Set(SensorType type, SensorMode mode)
            {
                this.type = type;
                this.mode = mode;

                if (type == SensorType.Sonar)
                    type = SensorType.LowSpeed9V;

                byte[] command = new byte[5];
                command[0] = 0x00;
                command[1] = (byte)DirectCommand.SetInputMode;
                command[2] = port;
                command[3] = (byte)type;
                command[4] = (byte)mode;
                return serial_port.Send(command);
            }

            public bool Update()
            {
                if (type == SensorType.Sonar)
                    return UpdateSonar();

                byte[] message = new byte[3];
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.GetInputValues;
                message[2] = port;
                byte[] reply = null;
                if (!serial_port.Send(message, ref reply))
                    return false;
                if (reply == null)
                    return false;
                if (reply.Length != 16)
                    return false;
                Array.Copy(reply, 8, state, 0, 8);
                return true;
            }

            bool UpdateSonar()
            {
                byte[] reply = { 0 };
                if (!Commands.Read(serial_port, port, SonarCommands.MeasurementByte0, ref reply))
                    return false;
                if (reply.Length != 1)
                    return false;
                int value = (int)reply[0] * 10;
                state[1] = (byte)(value >> 8);
                state[0] = (byte)value;
                state[2] = state[0];
                state[3] = state[1];
                state[4] = state[0];
                state[5] = state[1];
                state[6] = state[0];
                state[7] = state[1];
                return true;
            }

            public ushort RawADValue
            {
                get
                {
                    return (ushort)((state[1] << 8) + state[0]);
                }
            }

            public ushort ScaledADValue
            {
                get
                {
                    return (ushort)((state[3] << 8) + state[2]);
                }
            }

            public short ScaledValue
            {
                get
                {
                    return (short)((state[5] << 8) + state[4]);
                }
            }

            public short CalibratedValue
            {
                get
                {
                    return (short)((state[7] << 8) + state[6]);
                }
            }

        }

        public class OutPort : Error_Checking
        {
            CSerialPort serial_port;
            MotorPort motor_port;
            string returnMessage = "";
            byte[] reply; 
            
            public OutPort(CSerialPort serial_port, MotorPort motor_port)
            {
                this.serial_port = serial_port;
                this.motor_port = motor_port;
            }

            public string SetOutputState(int speed, Mode mode, RegulationMode regMode, int turnRatio, RunState runState)
            {

                byte[] message = new byte[13];  // message to be sent          

                // Populate message
                message[0] = 0x00;                  // Feedback required
                message[1] = (byte)DirectCommand.SetOutputState;
                message[2] = (byte)motor_port;           // output port
                message[3] = (byte)speed;           // power set point 
                message[4] = (byte)mode;            // mode byte
                message[5] = (byte)regMode;         // reg mode
                message[6] = (byte)turnRatio;       //turn ratio 
                message[7] = (byte)runState;        //run state

                //figure something out with this - make programmerable 
                message[8] = 0x00;                      //tacho limit
                message[9] = 0x00;
                message[10] = 0x00;
                message[11] = 0x00;
                message[12] = 0x00;



                // Send message
                serial_port.Send(message, ref reply);
                returnMessage = CheckResponce(ref reply[2]);
                return returnMessage;

            }

            public string GetOutputState()
            {
                byte[] message = new byte[3];

                message[0] = 0x00;
                message[1] = (byte)DirectCommand.GetOutputState;
                message[2] = (byte)motor_port;

                serial_port.Send(message, ref reply);

                returnMessage = "";
                if (reply == null)
                    return "";

                for (int i = 0; i < 25; i++)
                {
                    returnMessage += Convert.ToUInt32(reply[i]) + " : ";
                }


                returnMessage += ";";


                return returnMessage;
            }

            public string ResetMotorPosition(bool AbsolutePosition)
            {
                byte[] message = new byte[4];

                message[0] = 0x00;
                message[1] = 0x0A;
                message[2] = (byte)motor_port;
                message[3] = 0;

                serial_port.Send(message, ref reply);


                returnMessage = CheckResponce(ref reply[2]);

                return returnMessage;
            }
        }

        public class Commands
        {

            static public byte LSGetStatus(CSerialPort serial_port, byte port)
            {
                byte[] message = new byte[3];
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.LSGetStatus;
                message[2] = port;
                byte[] reply = new byte[4];
                if (!serial_port.Send(message, ref reply))
                    return 0;
                if (reply.Length != 4)
                    return 0;
                return reply[3];
            }

            static public bool LSRead(CSerialPort serial_port, byte port, ref byte[] rx_data)
            {
                byte[] message = new byte[3];
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.LSRead;
                message[2] = port;
                byte[] reply = new byte[20];
                if (!serial_port.Send(message, ref reply))
                    return false;
                if (reply.Length != 20)
                    return false;
                Array.Resize(ref rx_data, reply[3]);
                Array.Copy(reply, 4, rx_data, 0, reply[3]);
                return true;
            }

            static public bool LSWrite(CSerialPort serial_port, byte port, byte[] tx_data, byte rx_data_length)
            {
                byte[] message = new byte[tx_data.Length + 5];
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.LSWrite;
                message[2] = port;
                message[3] = (byte)tx_data.Length;
                message[4] = rx_data_length;
                tx_data.CopyTo(message, 5);
                return serial_port.Send(message);
            }

            static public bool Read(CSerialPort serial_port, byte port, SonarCommands command, ref byte[] reply)
            {
                if (!Read(serial_port, port, command))
                    return false;

                return LSRead(serial_port, port, ref reply);
            }

            static public bool Read(CSerialPort serial_port, byte port, SonarCommands command)
            {
                byte[] data = { 0x02, (byte)command };

                switch (command)
                {
                    case SonarCommands.Version:
                    case SonarCommands.ProductID:
                    case SonarCommands.SensorType:
                        return LSWrite(serial_port, port, data, 8);
                    case SonarCommands.MeasurementUnits:
                        return LSWrite(serial_port, port, data, 7);
                    default:
                        return LSWrite(serial_port, port, data, 1);
                }
            }

            static public bool I2CSetByte(CSerialPort serial_port, byte port, byte address, byte data)
            {
                byte[] message = { 0x02, address, data };
                return LSWrite(serial_port, port, message, 0);
            }

            static public bool I2CGetByte(CSerialPort serial_port, byte port, byte address, ref byte data)
            {
                byte[] message = { 0x02, address };
                if (!LSWrite(serial_port, port, message, 1))
                    return false;

                byte[] reply = { 0 };

                LSRead(serial_port, port, ref reply);

                foreach (byte value in reply)
                    Console.Write("{0:x2} ", value);
                Console.WriteLine("");
                return true;
            }


        }

        public class Error_Checking
        {
            protected string CheckResponce(ref byte StatusByte)
            {
                string error = "";
                switch (StatusByte)
                {
                    case 0x00:
                        error = "Success";
                        break;
                    case 0x20:
                        error = "Pending communication trasaction in progress";
                        break;
                    case 0x40:
                        error = "Specified mailbox queue is empty";
                        break;
                    case 0xBD:
                        error = "Request failed (i.e. specified file not found)";
                        break;
                    case 0xBE:
                        error = "Unknown command opcode";
                        break;
                    case 0xBF:
                        error = "Insane packet";
                        break;
                    case 0xC0:
                        error = "Data contains out-of-range values";
                        break;
                    case 0xDD:
                        error = "Communication bus error";
                        break;
                    case 0xDE:
                        error = "No free memory in communication buffer";
                        break;
                    case 0xDF:
                        error = "Specified channel/connection is not valid";
                        break;
                    case 0xE0:
                        error = "Specified channel/connection not configured or busy";
                        break;
                    case 0xEC:
                        error = "No active program";
                        break;
                    case 0xED:
                        error = "Illegal size specified";
                        break;
                    case 0xEE:
                        error = "Illegal mailbox queue ID specified";
                        break;
                    case 0xEF:
                        error = "Attempted to access invalid field of a structure";
                        break;
                    case 0xF0:
                        error = "Bad input or output specified";
                        break;
                    case 0xFB:
                        error = "Insufficient memory available";
                        break;
                    case 0xFF:
                        error = "Bad arguments";
                        break;
                }

                return error;
            }
        }

        public class Details : Error_Checking
        {
            CSerialPort serial_port;
            byte[] reply = new byte[23];

            public Details(CSerialPort serial_port)
            {
                this.serial_port = serial_port;
            }
        }

        public class Direct_Commands : Error_Checking
        {
            CSerialPort serial_port;
            byte[] reply = new byte[23];

            string returnMessage = "";

            public Direct_Commands(CSerialPort serial_port)
            {
                this.serial_port = serial_port;
            }

            public string StartProgram(string name)
            {

                name += ".rxe";
                byte[] temp = new byte[name.Length];
                byte[] message = new byte[16];  // Set message size

                message[0] = 0x00;
                message[1] = (byte)DirectCommand.StartProgram; //  The type of command to send

                for (int i = 0; i < name.Length; i++)
                {
                    temp[i] = (byte)name[i];
                    message[2 + i] = temp[i];
                }


                serial_port.Send(message, ref reply);
                returnMessage = CheckResponce(ref reply[2]);
                return returnMessage;

            }

            public string StopProgram()
            {
                ////////////////////////////////////////
                // Function Description
                // This will stop the current running program 
                // on the NXT.


                byte[] message = new byte[23];  // Set message size
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.StopProgram;   // Message type

                serial_port.Send(message, ref reply);
                returnMessage = CheckResponce(ref reply[2]);
                return returnMessage;
            }

            public string PlaySoundFile(string name, bool loop)
            {
                /////////////////////////////
                // Function Description
                // This will play a sound file on the NXT either 
                // in a loop or only once.

                name += ".rso";
                if (name.Length > 14)   // Ensure that the file name isnt to big
                    name = name.Substring(0, 14);
                byte[] message = new byte[23];  // Set message size
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.PlaySoundFile; //  The type of command to send

                if (loop)
                    message[2] = 0x01;  // Loop sound
                else
                    message[2] = 0x00;  // Play once

                System.Text.Encoding.ASCII.GetBytes(name).CopyTo(message, 3);   // Load file name into message

                // Send message to NXT
                serial_port.Send(message, ref reply);
                returnMessage = CheckResponce(ref reply[2]);
                return returnMessage;
            }

            public string PlayTone(int frequency, int duration)
            {
                ////////////////////////////////////////
                // Function Description
                // This will play a tone

                byte[] FrequencyInBytes;  // Store byte version of frequency
                byte[] DurationInBytes;  // Store byte version of duration

                // Make sure the frequency is between 200 - 14000
                frequency %= 14001;
                if (frequency < 200)
                { frequency += 200; }

                // Convert to bytes
                FrequencyInBytes = BitConverter.GetBytes(frequency);
                DurationInBytes = BitConverter.GetBytes(duration);

                // Populate message
                byte[] message = new byte[23];  // Set message size
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.PlayTone;
                message[2] = FrequencyInBytes[0];
                message[3] = FrequencyInBytes[1];
                message[4] = DurationInBytes[0];
                message[5] = DurationInBytes[1];


                serial_port.Send(message, ref reply);
                returnMessage = CheckResponce(ref reply[2]);
                return returnMessage;


            }

            public string GetBatteryLevel()
            {
                byte[] message = new byte[2];

                message[0] = 0x00;
                message[1] = (byte)DirectCommand.GetBatteryLevel;


                serial_port.Send(message, ref reply);
                double temp = reply[3] + (reply[4] << 8);

                returnMessage = (temp / 1000.0).ToString();

                return returnMessage;
            }

            public string StopSoundPlayback()
            {
                byte[] message = new byte[2];
                message[0] = 0x80;
                message[1] = (byte)DirectCommand.StopSoundPlayback;

                serial_port.Send(message, ref reply);

                return CheckResponce(ref reply[2]);
            }

            public string KeepAlive()
            {
                byte[] message = new byte[2];

                message[0] = 0x00;
                message[1] = (byte)DirectCommand.KeepAlive;

                serial_port.Send(message, ref reply);

                returnMessage = CheckResponce(ref reply[2]);

                return returnMessage;
            }

            public string CurrentProgram()
            {
                byte[] message = new byte[2];
                string progName = "";
                message[0] = 0x00;
                message[1] = (byte)DirectCommand.GetCurrentProgramName;

                serial_port.Send(message, ref reply);

                for (int i = 3; i < reply.Length; i++)
                    progName += Convert.ToChar(reply[i]);


                CheckResponce(ref reply[2]);
                return (progName);
            }

            public string SetBrickName(string NewName)
            {
                byte[] message = new byte[18];
                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                byte[] newName = encoding.GetBytes(NewName);

                message[0] = 0x01;
                message[1] = (byte)Command.SetBrickName;

                newName.CopyTo(message, 2);

                serial_port.Send(message, ref reply);

                returnMessage = CheckResponce(ref reply[2]);

                return returnMessage;
            }
        }

        public class Robot
        {
            private string comPort;
            CSerialPort serial_port;
            public CDeviceInfo DeviceInfo;
            
            // All inports of the NXT 1-4
            public InPort InPort1,
                          InPort2,
                          InPort3,
                          InPort4;

            // All outports for the NXT A, B, C
            public OutPort  OutPortA,
                            OutPortB,
                            OutPortC;

            
            
            //flag for connectivity 
            public bool connected { get; protected set; }
            

            public Details Info;
            public Direct_Commands DirectCommands;

            public Robot(string ComPort)
            {
                connected = false;
                Connect(ComPort);
            }

            ~Robot()
            {
                // only do if we have connected 
                if (connected)
                    serial_port.Disconnect();
            }
            /// <summary>
            /// Will try and connect to a specific ComPort
            /// </summary>
            /// <param name="port_name"></param>
            /// <returns></returns>
            public bool Connect(string port_name)
            {
                serial_port = new CSerialPort();

                DeviceInfo = new CDeviceInfo(serial_port);

                InPort1 = new InPort(serial_port, 0);
                InPort2 = new InPort(serial_port, 1);
                InPort3 = new InPort(serial_port, 2);
                InPort4 = new InPort(serial_port, 3);


                comPort = port_name;

                Info = new Details(serial_port);
                DirectCommands = new Direct_Commands(serial_port);

                if (!serial_port.Connect(port_name))
                    return false;

                if (!serial_port.Send(DirectCommand.KeepAlive))
                {
                    Disconnect();
                    return false;
                }

                connected = true;
                return true;
            }

            /// <summary>
            /// Will try and Automatical find the correct ComPort to connect to
            /// </summary>
            /// <returns></returns>
            public bool AutoConnect()
            {
                foreach (string port_name in SerialPort.GetPortNames())
                    if (Connect(port_name))
                        return true;

                //another loop to fix problems with port names in the .NET library
                foreach (string port_name in SerialPort.GetPortNames())
                    if (Connect(port_name.Substring(0, port_name.Length - 1)))
                        return true;

                return false;
            }

            /// <summary>
            /// Disconnect from ComPort
            /// </summary>
            public void Disconnect()
            {

                serial_port.Disconnect();
                connected = false;
            }

            /// <summary>
            /// Move forward using ports B, C
            /// </summary>
            /// <param name="speed"></param>
            public void GoForward(uint speed)
            {
                speed = (speed > 100) ?100:speed;

                OutPortB.SetOutputState((int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running);
                OutPortC.SetOutputState((int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running);    
            }

            /// <summary>
            /// Move backwards using ports B, C
            /// </summary>
            /// <param name="speed"></param>
            public void GoBackwards(uint speed)
            {
                OutPortB.SetOutputState(-(int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running);
                OutPortC.SetOutputState(-(int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running); 
            }

            /// <summary>
            /// Turn right using ports B, C
            /// </summary>
            /// <param name="degrees"></param>
            /// <param name="speed"></param>
            public void TurnRight(int degrees, uint speed)
            {
                OutPortB.SetOutputState((int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running);
                OutPortC.SetOutputState(-(int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running); 
            }

            /// <summary>
            /// Turn left using ports B, C
            /// </summary>
            /// <param name="degrees"></param>
            /// <param name="speed"></param>
            public void TurnLeft(int degrees, uint speed)
            {
                OutPortB.SetOutputState(-(int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running);
                OutPortC.SetOutputState((int)speed, Mode.MotorOn, RegulationMode.Motor_Idle, (int)0, RunState.Running);
            }
        }
    }
}