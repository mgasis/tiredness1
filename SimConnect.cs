using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorInterface
{
    /*
     * A class to connect the SimCreator simulation using the txt files.
     * The SimCreator writing txt file with a constant format (key:value) and the method of the
     * SimConnect class can read it. Additionally, the class writes to a txt file that the SimCreator
     * component reads from.
     * Using this class you can easily connect your GUI to SimCreator simulation on real time.
     */
    public class SimConnect
    {
        // Params for the connection
        // Real paths - the path on the host computer which been use for the connection 
        private string fromSim = @"\\operatorstation\c$\databases\BGU\Scripts\Evyatar\InterfaceData.txt";
        private string toSim = @"\\operatorstation\c$\databases\BGU\Scripts\Evyatar\ToSimulator.txt";

        // Test paths - paths on your local machine in order to debug your program
        private string fromSimLocal = @"C:\Users\Vadim\Desktop\personal\mediator\SimulatorInterface-master\fromSim.txt";
        private string toSimLocal = @"C:\Users\Vadim\Desktop\personal\mediator\SimulatorInterface-master\toSim.txt";

        // Variable to indicate if to use your local paths or using simulator paths
        private bool localMode = true;


        // Title of the SimCreator txt files (the keys in the file)
        private string accelTitle = "Acceleration";
        private string velocityTitle = "Velocity";
        private string steerTitle = "Steer";
        private string userTitle = "User";


        public SimConnect()
        {
            // Empty constructor
        }

        public double getAcceleration()
        {
            // Determine the path
            string path = localMode == true ? fromSimLocal : fromSim;

            return getValue(getSimData(path), accelTitle);
        }

        public double getVelocity()
        {
            // Determine the path
            string path = localMode == true ? fromSimLocal : fromSim;

            return getValue(getSimData(path), velocityTitle);
        }

        public double getSteer()
        {
            // Determine the path
            string path = localMode == true ? fromSimLocal : fromSim;

            return getValue(getSimData(path), steerTitle);
        }

        public double getUser(int i)
        {
            // The method returns the data from 'User_i' in the data the SimCreator creates.
            // Currently, we got user between 1 to 5.

            // Determine the path
            string path = localMode == true ? fromSimLocal : fromSim;

            return getValue(getSimData(path), userTitle + i.ToString());
        }

        private string[] getSimData(string path)
        {
            ///<summary>
            /// The function get the output text the model created during running.
            /// Then return the text of the output splitted by the '/n'
            ///</summary>
            string[] text;
            while (true)
            {
                try
                {
                    text = System.IO.File.ReadAllText(path).Split('\n');
                    return text;
                }
                catch
                {
                    Console.WriteLine("Got an exception while trying to read the text file");
                }
            }
        }

        private double getValue(string[] data, string title)
        {
            // The method returns the value of a given title from a given data
            // Find the relevant key and grab the data
            foreach (string v in data)
            {
                if (v.Contains(title))
                {
                    int valueIndex = v.IndexOf(':');
                    return Double.Parse(v.Substring(valueIndex + 1));
                }
            }

            return -999;
        }

        public void setSimData(int value)
        {
            // Determine the path
            string path = localMode == true ? toSimLocal : toSim;

            while (true)
            {
                try
                {
                    System.IO.File.WriteAllText(path, value.ToString());
                    return;
                }
                catch
                {
                    Console.WriteLine("Got exception while trying to write the txt toSim file");                
                }
            }
        }
    }
}
