namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetDriveInfo();
        }

        static void GetDriveInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {

                if (drive.IsReady)
                {
                    var totalSize = ByteToMb(drive.TotalSize);
                    var availableSize = ByteToMb(drive.AvailableFreeSpace);
                    var usedSize = totalSize - availableSize;
                    Console.WriteLine( $"{drive.Name} \n" +
                        $"Total size: {totalSize} GB \n" +
                        $"Avilabe size: {availableSize} Gb \n" +
                        $"Used size: {usedSize} GB");
                }
                else
                {
                    Console.WriteLine(drive.Name + "is not ready.");
                }
              
            }
        }

        static long ByteToMb(long bytes)
        {
            return  bytes / (1024 * 1024 * 1024);
        }
    }
}