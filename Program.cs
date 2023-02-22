using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ps10func;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Owis_rot_stage_with_Pilatus_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // OWIS rotation stage section
            // ask for COM port of OWIS rotation stage
            Console.WriteLine($"Insert COM port of OWIS rotation stage: {args[0]}.");
            String nComPort_str = args[0];
            // ask for axis of OWIS rotation stage
            Console.WriteLine($"Insert axis of OWIS rotation stage: {args[1]}");
            String nAxis_str = args[1];
            // print positioning velicity in Hz
            Console.WriteLine("Positioining velocity of OWIS rotation stage in Hz is: 50000");
            // ask for initial position
            Console.WriteLine($"Insert initial position in deg: {args[2]}");
            String dDistanceInitial_str = args[2];
            // ask for final position
            Console.WriteLine($"Insert final position in deg: {args[3]}");
            String dDistanceFinal_str = args[3];
            // ask for step
            Console.WriteLine($"Insert step in deg: {args[4]}");
            String dDistanceStep_str = args[4];

            // Pilatus detector section
            // ask for IP address of Pilatus detector
            Console.WriteLine($"Insert IP address of Pilatus detector: {args[5]}");
            string server_Pilatus = args[5];
            // ask for port of Pilatus detector
            Console.WriteLine($"Insert port number of Pilatus detector (e.g. 41234): {args[6]}");
            string port_Pilatus_str = args[6];
            Int32 port_Pilatus = Int32.Parse(port_Pilatus_str);
            // set number of images
            Console.WriteLine($"Set number of images: {args[7]}");
            string ni_str = args[7];
            int ni = int.Parse(ni_str);
            // set exposure time
            Console.WriteLine($"Set exposure time in seconds: {args[8]}");
            string expt_str = args[8];
            float expt = float.Parse(expt_str);
            // set exposure period
            Console.WriteLine($"Set exposure period in seconds: {args[9]}");
            string expp_str = args[9];
            float expp = float.Parse(expp_str);
            // set image name
            Console.WriteLine($"Set image name: {args[10]}");
            string image_name = args[10];


            // open communication with PS10 OWIS controller
            CPS10Win PS10 = new CPS10Win();
            Int32 nComPort = Int32.Parse(nComPort_str);
            Int32 nAxis = Int32.Parse(nAxis_str);
            // positioning velocity in Hz
            Int32 nPosF = 50000;
            // convert all distane values
            Double dDistanceInitial = Double.Parse(dDistanceInitial_str);
            Double dDistanceFinal = Double.Parse(dDistanceFinal_str);
            Double dDistanceStep = Double.Parse(dDistanceStep_str);

            // Connect to PS10 OWIS controller
            if (nComPort == 0)
            {
                PS10.SimpleConnect(1, "");
            }
            else if (nComPort == -1)
            {
                PS10.SimpleConnect(1, "net");
            }
            else
            {
                PS10.Connect(1, 0, nComPort, 9600, 0, 0, 0, 0);
            }

            // initialize rotation stage
            PS10.MotorInit(nAxis, 0);
            // set target mode to aboslute mode
            PS10.SetTargetMode(nAxis, 1, 0);
            // set velocity
            if (nPosF > 0)
            {
                PS10.SetPosF(nAxis, nPosF, 0);
            }

            // go to reference position, zero position
            PS10.GoRef(nAxis, 4, 0);
            Console.WriteLine($"Axis is moving to reference position.");
            while (PS10.GetMoveState(nAxis, 0) != 0)
            {
                ;
            }
            Console.WriteLine("Axis is in position.");

            // move to initial position
            PS10.MoveEx(nAxis, dDistanceInitial, true, 0);
            Console.WriteLine($"Axis is moving to {dDistanceInitial}");
            while (PS10.GetMoveState(nAxis, 0) != 0)
            {
                ;
            }
            Console.WriteLine("Axis is in position.");
            // take first exposition with Pilatus detector
            string image_name_number = "0";
            image_name_number = image_name_number.PadLeft(5, '0');
            string image_name_total = image_name + "_" + image_name_number;
            Pilatus_exposition(server_Pilatus, port_Pilatus, ni, expt, expp, image_name_total);

            // main while loop
            // initialize image counter
            int counter = 1;
            Double dDistance = dDistanceInitial + dDistanceStep;
            while (dDistance <= dDistanceFinal)
            {
                // set target mode to relative mode
                PS10.SetTargetMode(nAxis, 0, 0);
                // move relativelly
                PS10.MoveEx(nAxis, dDistanceStep, true, 0);
                Console.WriteLine($"Axis is moving to {dDistance}.");
                while (PS10.GetMoveState(nAxis, 0) != 0)
                {
                    ;
                }
                Console.WriteLine("Axis is in position.");
                // take exposition with Pilatus detector
                image_name_number = Convert.ToString(counter);
                image_name_number = image_name_number.PadLeft(5, '0');
                image_name_total = image_name + "_" + image_name_number;
                Pilatus_exposition(server_Pilatus, port_Pilatus, ni, expt, expp, image_name_total);
                // icrement distance and image counter
                dDistance = dDistance + dDistanceStep;
                counter += 1;
            }
            PS10.Disconnect();
        }

        static void Pilatus_exposition(string server_Pilatus, int port_Pilatus, int ni, float expt, float expp, string image_name)
        {
            // create new session with Pilatus detector
            TcpClient session_Pilatus = new TcpClient(server_Pilatus, port_Pilatus);

            // initialize stream
            NetworkStream stream = session_Pilatus.GetStream();

            // set number of images
            string ni_str = Convert.ToString(ni);
            string niString = "ni " + ni_str + "\n";
            Console.WriteLine(niString);
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(niString);
            stream.Write(data, 0, data.Length);
            // Buffer to store the response bytes.
            data = new Byte[256];
            // String to store the response ASCII representation.
            string responseData_ni = String.Empty;
            // Read Pilatus's response
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData_ni = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            // set exposure time
            string expt_str = Convert.ToString(expt);
            string exptString = "expt " + expt_str + "\n";
            Console.WriteLine(exptString);
            data = System.Text.Encoding.ASCII.GetBytes(exptString);
            stream.Write(data, 0, data.Length);
            // Read Pilatus's response
            data = new Byte[256];
            // String to store the response ASCII representation.
            string responseData_expt = String.Empty;
            bytes = stream.Read(data, 0, data.Length);
            responseData_expt = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            // set exposure period
            string expp_str = Convert.ToString(expp);
            string exppString = "expp " + expp_str + "\n";
            Console.WriteLine(exppString);
            data = System.Text.Encoding.ASCII.GetBytes(exppString);
            stream.Write(data, 0, data.Length);
            // Read Pilatus's response
            data = new Byte[256];
            // String to store the response ASCII representation.
            string responseData_expp = String.Empty;
            // Read Pilatus's response
            bytes = stream.Read(data, 0, data.Length);
            responseData_expp = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            // take image, do exposure
            string expoString = "expo " + image_name + ".tif" + "\n";
            Console.WriteLine(expoString);
            data = System.Text.Encoding.ASCII.GetBytes(expoString);
            stream.Write(data, 0, data.Length);
            // Read Pilatus's response
            data = new Byte[256];
            // String to store the response ASCII representation.
            string responseData_expo = String.Empty;
            // Read Pilatus's response
            bytes = stream.Read(data, 0, data.Length);
            responseData_expo = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            data = null;
            Thread.Sleep(250);

            // print all responses
            Console.WriteLine(responseData_ni);
            Console.WriteLine(responseData_expt);
            Console.WriteLine(responseData_expp);
            Console.WriteLine(responseData_expo);

            float ni_float = Convert.ToSingle(ni);
            float wait_in_ms_float = ni_float * expp * 1000 + 100;
            int wait_in_ms = Convert.ToInt32(wait_in_ms_float);
            Thread.Sleep(wait_in_ms);

            // Close everything
            stream.Flush();
            stream.Close();
            session_Pilatus.Close();
        }
    }
}
