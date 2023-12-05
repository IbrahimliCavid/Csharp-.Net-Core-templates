namespace Task_3
{
    internal class Program
    {
        const string FolderDirectory = "C:\\Test qovluq";
        static void Main(string[] args)
        {
            Console.WriteLine(FilesAndFoldersCount());
        }

        static int FilesAndFoldersCount()
        {
            


            string directoryName = FolderDirectory;

                var folderInfo = new DirectoryInfo(directoryName);
                var files = folderInfo.GetFiles("*", SearchOption.AllDirectories);
                var folders = folderInfo.GetDirectories("*", SearchOption.AllDirectories);
          
               return files.Length + folders.Length;
            

           
        }
    }
}