using System;
using System.Management;

namespace HardLock
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = ""; // your hardware id
            string result = ""; // hardware id for program lock

            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection manageObjectCollection = managementObjectSearcher.Get();
            foreach (ManagementObject managementObject in manageObjectCollection)
            {
                result = managementObject["ProcessorId"].ToString();
                break;
            }

            if(result != id)
            {
                return;
            }

            Console.WriteLine("Login !");
            Console.WriteLine("ID: {0}", result);
        }
    }
}
