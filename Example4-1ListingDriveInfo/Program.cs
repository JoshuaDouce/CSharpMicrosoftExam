using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example4_1ListingDriveInfo
{
    class Program
    {
        private static DriveInfo[] drivesInfo = DriveInfo.GetDrives();

        static void Main(string[] args)
        {
            foreach (DriveInfo driveInfo in drivesInfo)
            {
                Console.WriteLine("Drive {0}", driveInfo.Name);
                Console.WriteLine("  Filter type: {0}", driveInfo.DriveType);

                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", driveInfo.VolumeLabel);
                    Console.WriteLine("  FileSystem: {0}", driveInfo.DriveFormat);
                    Console.WriteLine("  Available space to user: {0, 15} bytes", driveInfo.AvailableFreeSpace);
                    Console.WriteLine("  Total Available space: {0, 15} bytes", driveInfo.TotalFreeSpace);
                    Console.WriteLine("  Total drive size: {0, 15} bytes", driveInfo.TotalSize);
                }
            }
        }
    }
}
