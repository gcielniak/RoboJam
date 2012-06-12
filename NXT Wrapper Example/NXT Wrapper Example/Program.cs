using System;
using System.Threading;

namespace NXT_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            NXT.Robot nxt = new NXT.Robot("COM9");

            nxt.InPort1.Set(NXT.SensorType.Sonar, NXT.SensorMode.RawMode);
            Console.WriteLine("Waiting for commands...");
            for (; ; )
            {
                nxt.InPort1.Update();
                nxt.InPort1.Print();



                if (Console.KeyAvailable)
                {

                    string bob = Console.ReadKey(true).Key.ToString();
                    if (bob == "V")
                    {
                        Console.WriteLine("Running command....");
                        //nxt.StartMotor(100, 1);
                        //nxt.StartProgram("Untitled12.rpg");
                        nxt.StopProgram();
                        //nxt.PlaySoundFile("Untitled.rbt", false);

                    }

                    // Motor A
                    if (bob == "I")
                    {
                        Console.WriteLine("Running command....");
                        nxt.StartMotorA(100);
                    }
                    if (bob == "O")
                    {
                        Console.WriteLine("Running command....");
                        nxt.StopMotorA();
                    }

                    // Motor B
                    if (bob == "K")
                    {
                        Console.WriteLine("Running command....");
                        nxt.StartMotorB(100);
                    }
                    if (bob == "J")
                    {
                        Console.WriteLine("Running command....");
                        nxt.StartMotorB(-70);
                    }
                    if (bob == "L")
                    {
                        Console.WriteLine("Running command....");
                        nxt.StopMotorB();
                    }

                    // Motor C
                    if (bob == "N")
                    {
                        Console.WriteLine("Running command....");
                        nxt.StartMotorC(100);
                    }
                    if (bob == "M")
                    {
                        Console.WriteLine("Running command....");
                        nxt.StopMotorC();
                    }
                    if (bob == "Q")
                        nxt.CurrentProgram();



                }
            }

            //Console.WriteLine("Done!");
        }
    }
}
